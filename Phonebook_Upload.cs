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
    public partial class Phonebook_Upload : Form
    {
        #region Variables
        public static readonly string KeyspaceName = ConfigurationManager.AppSettings["KeySpace"];
        public static readonly Server Server = new Server(ConfigurationManager.AppSettings["Server"]);
        #endregion

        #region Load
        public Phonebook_Upload()
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
                    // Open excel document and read all data
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(openFileDialog1.FileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    Excel.Range range = xlWorkSheet.UsedRange;
                    float odnos = (float)100 / range.Rows.Count;

                    for (int rCnt = 2; rCnt <= range.Rows.Count; rCnt++)
                    {
                    //Insert the excel rows into Cassandra database (table Phonebook)
                    String cql = @"INSERT INTO phonebook(kluc, name, surname, number, phone_type) 
                                   VALUES ('" + range.Cells[rCnt, 1].Value + range.Cells[rCnt, 2].Value + "','"
                                              + range.Cells[rCnt, 2].Value + "', '"
                                              + range.Cells[rCnt, 1].Value + "', '"
                                              + range.Cells[rCnt, 3].Value + "', '"
                                              + range.Cells[rCnt, 4].Value + "')";
                        db.ExecuteNonQuery(cql);

                        progressBarUpload.Value = Convert.ToInt32(Decimal.Multiply(Convert.ToDecimal(rCnt), Convert.ToDecimal(odnos)));
                    }

                    xlWorkBook.Close(true, null, null);
                    xlApp.Quit();
                }
                MessageBox.Show("Successfully imported!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("The records were not added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Handled Events
        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
                {
                    //Insert the manual rows into Cassandra database (table Phonebook)
                    String cql = @"INSERT INTO phonebook(kluc, name, surname, number, phone_type) 
                                   VALUES ('" + tbFirstName + tbLastName + "','" + tbFirstName.TextBox.Text + "','" 
                                             + tbLastName.TextBox.Text + "', '38943551" + tbPhoneNumber.TextBox.Text + "','" 
                                             + cbPhoneType.SelectedItem.ToString() + "')";
                    db.ExecuteNonQuery(cql);
                }

                MessageBox.Show("Successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("The record was not added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void gbInsertOne_Enter(object sender, EventArgs e)
        {

        }
        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            progressBarUpload.Visible = true;
            btnChoseFile.Enabled = false;
            btnUpload.Enabled = false;
            ImportFromExcel_Parser();
            btnChoseFile.Enabled = true;
            btnUpload.Enabled = true;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tbImportFile.TextBox.Text = openFileDialog1.FileName;
        }
        #endregion

    }

}
