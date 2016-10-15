using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using FluentCassandra.Connections;
using FluentCassandra.Types;
using FluentCassandra.Linq;
using FluentCassandra;
using FluentCassandra.Operations;
using LumenWorks.Framework.IO.Csv;
using System.IO;

namespace Telephone_Parser
{
    public partial class UploadList : Form
    {

        #region Variables
        public static readonly string KeyspaceName = ConfigurationManager.AppSettings["KeySpace"];
        public static readonly Server Server = new Server(ConfigurationManager.AppSettings["Server"]);
        #endregion

        #region Load
        public UploadList()
        {
            InitializeComponent();
        }
        private void AddItem_Load(object sender, EventArgs e)
        {
            tbImportFile.TextBox.ReadOnly = true;
        }
        #endregion

        #region Functions

        private void ImportFromExcel_Parser()
        {
            try
            {
                progressBarUpload.Value = 0; 
                using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
                {
                    //Read all data from selected file
                    string[] allLines = File.ReadAllLines(openFileDialog1.FileName);
                    Boolean Citaj = false; //this one is flag when to stop
                    float odnos = (float)100 / allLines.Length; //this one needs for progress bar
                    int br_redovi_ostanato = allLines.Length;  //this one is for the remaining rows , again for progress bar

                    for (int i = 0; i < allLines.Length; i++)
                    {
                        br_redovi_ostanato--;
                        String zamenet = allLines[i].Replace(",\"", "$"); //parse the row data
                        zamenet = zamenet.Replace("\"", ""); //parse the row data
                        string[] red = zamenet.Split('$'); //return data into array

                        String pom = "";
                        try
                        {
                            pom = red[0];
                        }
                        catch { pom = ""; }

                        if (pom.StartsWith("Direction"))
                        {
                            Citaj = true;
                            i++;
                            br_redovi_ostanato--;
                        }

                        if (Citaj)
                        {
                            zamenet = allLines[i].Replace(",\"", "$");
                            zamenet = zamenet.Replace("\"", "");
                            red = zamenet.Split('$');
                            pom = red[0];

                            if (pom.Length > 0 && !pom.StartsWith("Total due"))
                            {
                                string[] pole = pom.Split(',');

                                //get data in separate variables, to be able to insert it after
                                String Datum = red[3];
                                String Godina = Datum.Substring(6, 4);
                                String Mesec = Datum.Substring(3, 2);
                                Datum = Datum.Substring(6, 4) + "-" + Datum.Substring(3, 2) + "-" + Datum.Substring(0, 2) + " " + Datum.Substring(11, 8);
                                
                                //Insert row into Cassandra database (table Razgovori)
                                String cql = @"INSERT INTO razgovori(kluc, direction, caller, called, start, duration, amount, amount_ddv, godina, mesec) 
                                                                                         VALUES ('" + red[1]+red[3] + "','" + red[0] + "','" + red[1] + "', '" + red[2] + @"' ,
                                                                                         '" + Datum + "', '" + red[4] + "', " + red[5].Replace(",", ".") + @", " + red[6].Replace(",", ".") + ", " + Godina + "," + Mesec + ")";
                                db.ExecuteNonQuery(cql);

                                progressBarUpload.Value = Convert.ToInt32(Decimal.Multiply(Convert.ToDecimal(i), Convert.ToDecimal(odnos)));
                            }
                        }
                    }
                }
                MessageBox.Show("Successfully imported!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("The records were not added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
        #endregion

        #region Handled Events

        private void btnEdit_Click(object sender, EventArgs e)
        {
            progressBarUpload.Visible = true;
            btnChoseFile.Enabled = false;
            btnUpload.Enabled = false;
            ImportFromExcel_Parser();
            btnChoseFile.Enabled = true;
            btnUpload.Enabled = true;
        }
        
        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tbImportFile.TextBox.Text = openFileDialog1.FileName;
        }

        #endregion
    }
}
