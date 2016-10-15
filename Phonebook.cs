using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using OutlookStyleControls;
using System.Data.OleDb;
using System.Configuration;
using FluentCassandra.Connections;
using FluentCassandra.Types;
using FluentCassandra.Linq;
using FluentCassandra;
using FluentCassandra.Operations;
using FastExcelExportingDemoCs;

namespace Telephone_Parser
{
    public partial class Phonebook : Form
    {
        
        #region Variables
        DataSet MyDs = new DataSet();

        // specifies the current data view (bound/unbound, dataset)
        private string View;

        // remember the column index that was last sorted on
        private int prevColIndex = -1;

        // remember the direction the rows were last sorted on (ascending/descending)
        private ListSortDirection prevSortDirection = ListSortDirection.Ascending;

        public static readonly string KeyspaceName = ConfigurationManager.AppSettings["KeySpace"];
        public static readonly Server Server = new Server(ConfigurationManager.AppSettings["Server"]);

        
        #endregion

        #region Grouping & Sorting
        private void outlookGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 && e.ColumnIndex >= 0)
            //{
            //    ListSortDirection direction = ListSortDirection.Ascending;
            //    if (e.ColumnIndex == prevColIndex) // reverse sort order
            //        direction = prevSortDirection == ListSortDirection.Descending ? ListSortDirection.Ascending : ListSortDirection.Descending;

            //    // remember the column that was clicked and in which direction is ordered
            //    prevColIndex = e.ColumnIndex;
            //    prevSortDirection = direction;

            //    outlookGrid1.Sort(new DataRowComparer(e.ColumnIndex, direction));
            //}
        }
        #endregion Grouping & Sorting
        
        #region Load
        public Phonebook()
        {
            InitializeComponent();
        }

        private void Phonebook_Load(object sender, EventArgs e)
        {
              
        }
        #endregion

        #region Functions
        private void ExecuteSearch()
        {
            PleaseWait frmPW = new PleaseWait();
            frmPW.Show();
            Application.DoEvents();

            MyDs.Tables.Clear();
            outlookGrid1.Rows.Clear();
            DataTable dt = new DataTable();

            lblNoRows.Text = "";
            lblSumAmount.Text = "";
            lblSumAmountVat.Text = "";

            dt.TableName = "Phonebook";
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Phone number");
            dt.Columns.Add("Phone type");

            String CQL = "SELECT name, surname, number, phone_type FROM phonebook";

            String WherePart = FillWherePart();
            CQL += WherePart;

            using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
            {
                foreach (var row2 in db.ExecuteQuery(CQL))
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = row2.Columns[0].ColumnValue;
                    dr[1] = row2.Columns[1].ColumnValue;
                    dr[2] = row2.Columns[2].ColumnValue;
                    dr[3] = row2.Columns[3].ColumnValue;
                    
                    dt.Rows.Add(dr);
                }
            }

            MyDs.Tables.Add(dt);

            if (MyDs.Tables[0].Rows.Count > 0)
            {
                outlookGrid1.BindData(MyDs, MyDs.Tables[0].TableName);
            
                outlookGrid1.AllowUserToResizeColumns = true;

                outlookGrid1.Columns[0].Width = 200;
                outlookGrid1.Columns[1].Width = 200;
                outlookGrid1.Columns[2].Width = 120;
                outlookGrid1.Columns[3].Width = 120;

                //Decimal amount = 0;
                //Decimal amount_vat = 0;

                //for (int i = 0; i < MyDs.Tables[0].Rows.Count; i++)
                //{
                //    amount += Convert.ToDecimal(MyDs.Tables[0].Rows[i][5].ToString());
                //    amount_vat += Convert.ToDecimal(MyDs.Tables[0].Rows[i][6].ToString());  
                //}

                //lblNoRows.Text = "Number of rows: " + MyDs.Tables[0].Rows.Count;
                //lblSumAmount.Text = "Sum of Amount: " + amount.ToString();
                //lblSumAmountVat.Text = "Sum of Amount with VAT: " + amount_vat.ToString();
            }
            frmPW.Close();
        }
        private string FillWherePart()
        {
            String WherePart = "";
            WherePart = VratiWherePart(tbFirstName, "name", WherePart);
            WherePart = VratiWherePart(tbLastName, "surname", WherePart);

            if (WherePart.Length > 0) WherePart = " WHERE " + WherePart;
            return WherePart;
        }
        private string VratiWherePart(TextBox Kontrola, String Kolona, String WherePart)
        {
            String WherePart1 = "";
            if (Kontrola.Text.Length > 0)
            {
                WherePart1 = " " + Kolona + " = '" + Kontrola.Text.ToString().Replace("'","''") + "' "; 

                if (WherePart.Length > 0)
                {
                    if (WherePart1.Length > 0)
                        WherePart += " AND (" + WherePart1 + ") ";
                }
                else
                {
                    if (WherePart1.Length > 0)
                        WherePart += " (" + WherePart1 + ") ";
                }
            }

            return WherePart;
        }
        private string VratiWherePartCombo(ComboBox Kontrola, String Kolona, String WherePart)
        {
            String WherePart1 = "";
            if (Kontrola.SelectedIndex != -1)
            {
                if (Kontrola.SelectedItem.ToString().Length > 0)
                {
                    WherePart1 += " " + Kolona + " = " + Kontrola.SelectedItem.ToString() + " ";

                    if (WherePart.Length > 0)
                    {
                        if (WherePart1.Length > 0)
                            WherePart += " AND (" + WherePart1 + ") ";
                    }
                    else
                    {
                        if (WherePart1.Length > 0)
                            WherePart += " (" + WherePart1 + ") ";
                    }
                }
            }

            return WherePart;
        }

        private void FillCombo(String pSQL, ComboBox Control, String DisplayMember)
        {
            DataTable dt = new DataTable();

            dt.TableName = DisplayMember;
            dt.Columns.Add(DisplayMember);

            try
            {
                using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
                {
                    foreach (var row in db.ExecuteQuery(pSQL))
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = row.Columns[0].ColumnValue;
                        
                        dt.Rows.Add(dr);
                    }
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

            DataSet MyDS = new DataSet();
            MyDS.Tables.Add(dt);
            Control.DataSource = MyDS.Tables[0].DefaultView;
            Control.DisplayMember = DisplayMember;
        }
       
        #endregion

        #region Handled Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
        private void Preview_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    ExecuteSearch();
                    break;
            }
        }
        private void outlookGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(outlookGrid1.Rows[e.RowIndex].Cells["ItemId"].Value) > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataGridViewRow dr = outlookGrid1.Rows[e.RowIndex];
                    //AddItem_Edit ai = new AddItem_Edit(dr);
                    //ai.Text = "Edit item";
                    //ai.ShowDialog();
                    ExecuteSearch();
                    Cursor.Current = Cursors.Default;
                }
            }
            catch { }
        }
        private void lblAssignedTo_Click(object sender, EventArgs e)
        {

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (MyDs.Tables.Count > 0)
            {
                if (MyDs.Tables[0].Rows.Count > 0)
                {
                    PleaseWait frmPW = new PleaseWait();
                    frmPW.Show();
                    Application.DoEvents();
                    FastExportingMethod.ExportToExcel(MyDs);//, sfd.FileName);
                    frmPW.Close();
                }
            }
        }
        private void tbCaller_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
#endregion

        private void btnInsertPhonebook_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Phonebook_Upload pb = new Phonebook_Upload();
            pb.Show();
            Cursor.Current = Cursors.Default;
        }

  }
}