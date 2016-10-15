using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using FluentCassandra.Connections;
using FluentCassandra.Types;
using FluentCassandra.Linq;
using FluentCassandra;
using FluentCassandra.Operations;

namespace Telephone_Parser
{
    public partial class Default : Form
    {
        #region Variables
        public static readonly string KeyspaceName = ConfigurationManager.AppSettings["KeySpace"];
        public static readonly Server Server = new Server(ConfigurationManager.AppSettings["Server"]);
        #endregion
       
        #region Load
        public Default()
        {
            InitializeComponent();
        }
        private void Default_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["ShowDatabaseInit"] == "1")
                btnDatabaseInit.Visible = true;
            else
                btnDatabaseInit.Visible = false;
        }
        #endregion

        #region Handled Events
        private void imgPreview_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Preview pw = new Preview();
            pw.Show();
            Cursor.Current = Cursors.Default;
        }
        private void exiitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

        }
        private void imgAddItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UploadList ul = new UploadList();
            ul.Show();
            Cursor.Current = Cursors.Default;
        }
        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgAddItem_Click(null, null);
        }
        private void previewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgPreview_Click(null, null);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Phonebook pb = new Phonebook();
            pb.Show();
            Cursor.Current = Cursors.Default;
        }
        private void btnDatabaseInit_Click(object sender, EventArgs e)
        {
            using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
            {
                if (db.KeyspaceExists(KeyspaceName))
                    db.DropKeyspace(KeyspaceName);

                var keyspace = new CassandraKeyspace(new CassandraKeyspaceSchema
                {
                    Name = KeyspaceName,
                }, db);

                keyspace.TryCreateSelf();

                String CQL = @"CREATE TABLE razgovori(kluc text, direction text, caller ascii, called text, start text, duration text,
                                     amount float, amount_ddv float, godina int, mesec int, 
                                     PRIMARY KEY(godina,mesec,caller,start,called,direction)
                                );";

                db.ExecuteNonQuery(CQL);
                //CQL = "CREATE INDEX ON razgovori(godina);";
                //db.ExecuteNonQuery(CQL);

                CQL = @"CREATE TABLE phonebook(kluc text, name text, surname text, number text, phone_type text, 
                                     PRIMARY KEY(surname,name,number)
                                );";
                db.ExecuteNonQuery(CQL);
                CQL = "CREATE INDEX ON phonebook(name);";
                db.ExecuteNonQuery(CQL);
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion

    }
}
