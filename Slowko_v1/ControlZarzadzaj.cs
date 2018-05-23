using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Slowko_v1
{
    public partial class ControlZarzadzaj : UserControl
    {
        public OleDbConnection connection = new OleDbConnection();
        public ControlZarzadzaj()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kamil\Documents\slowka2.mdb;
                                                Persist Security Info = False; ";
            try
            {
                connection.Open();
                OleDbCommand komenda = new OleDbCommand();
                komenda.Connection = connection;
                komenda.CommandText = "select slowko, tlumaczenie, czy_umie from kolory";
                OleDbDataAdapter da = new OleDbDataAdapter(komenda);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }


    }
}
