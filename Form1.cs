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
    public partial class Form1 : Form
    {
        public static readonly string KeyspaceName =  ConfigurationManager.AppSettings["KeySpace"];
        public static readonly Server Server = new Server(ConfigurationManager.AppSettings["Server"]);

        public Form1()
        {
            InitializeComponent();
        }

        #region Setup

        private static void SetupKeyspace()
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

                // create super column family using API
                keyspace.TryCreateColumnFamily(new CassandraColumnFamilySchema
                {
                    FamilyName = "razgovor",
                    FamilyType = ColumnType.Super,
                    KeyValueType = CassandraType.AsciiType,
                    SuperColumnNameType = CassandraType.AsciiType,
                    ColumnNameType = CassandraType.UTF8Type,
                    DefaultColumnValueType = CassandraType.UTF8Type
                });

                db.ExecuteNonQuery(@"CREATE TABLE poraka(
    naslov text,
    sodrzina text,
    PRIMARY KEY(naslov)
);");
            }
        }

        #endregion

        #region Create Comments

        private static void CreateComments()
        {
            using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
            {
                var key = "lista_razgovori";

                // get the comments family
                var commentsFamily = db.GetSuperColumnFamily("razgovor");
                var postComments = commentsFamily.CreateRecord(key: key);

                // lets attach it to the database before we add the comments
                db.Attach(postComments);

                var comment = postComments.CreateSuperColumn();
                postComments["3"] = comment;
                comment["broj_a"] = "070441113";
                comment["broj_b"] = "078487693";
                comment["dolzina"] = "28";
                comment["vreme"] = "23.11.2013 10:44:32";

                db.SaveChanges();

                db.ExecuteNonQuery("INSERT INTO poraka(naslov, sodrzina) VALUES ('test 2 naslov','test 2 sodrzina')");
            }
        }

        #endregion

        #region Read Post

        private void ReadAllPosts()
        {
            using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
            {
                String kluc = "";
                String red = "";

                foreach (var row in db.ExecuteQuery("SELECT * FROM razgovor"))//dolzina='" + tbDolzina.Text + "'"))
                {
                    if (kluc == "") kluc = row.Columns[1].ToString();

                    if (kluc == row.Columns[1].ToString())
                    {
                        red += row.Columns[2].ColumnValue + ":" + row.Columns[3].ColumnValue + "; ";
                    }
                    else
                    {
                        listBox1.Items.Add(red);
                        kluc = row.Columns[1].ToString();
                        red = row.Columns[2].ColumnValue + " " + row.Columns[3].ColumnValue + "; ";
                    }
                }
                listBox1.Items.Add(red);

                foreach (var row2 in db.ExecuteQuery("SELECT * FROM poraka WHERE naslov='test 2 naslov'"))
                {
                    listBox1.Items.Add(row2.Columns[0].ColumnValue + "; " + row2.Columns[1].ColumnValue );
                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            CreateComments();
            listBox1.Items.Clear();
            ReadAllPosts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetupKeyspace();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ReadAllPosts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var db = new CassandraContext(keyspace: KeyspaceName, server: Server))
            {
                var commentsFamily = db.GetSuperColumnFamily("razgovor");
                commentsFamily.RemoveAllRows();
                listBox1.Items.Clear();
                ReadAllPosts();
            }
        }
    }
}
