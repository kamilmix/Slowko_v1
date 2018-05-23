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
            listBox1.SelectedIndex = 0;
            pokazDane();

           

        }

        private void pokazDane()
        {
            try
            {
                connection.Open();
                OleDbCommand komenda = new OleDbCommand();
                komenda.Connection = connection;
                komenda.CommandText = "select slowko, tlumaczenie, czy_umie from " + listBox1.SelectedItem.ToString();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokazDane();
        }

        private void buttonResetuj_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "update " + listBox1.SelectedItem.ToString() + " set czy_umie=false ";

            command.ExecuteNonQuery();
            connection.Close();

            pokazDane();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView1.SelectedRows.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;



            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                string wiersz = richTextBox1.Lines[i];
                string[] tab = wiersz.Split(':');

             //   label1.Text = tab[0];

                string slowko1 = tab[0];
                string slowko2 = tab[1];

                  command.CommandText = "insert into " 
                      + listBox1.SelectedItem.ToString() + " (slowko, tlumaczenie) values ('" + slowko1+"', '"+slowko2+"') ";

                command.ExecuteNonQuery();
            }
                connection.Close();
            

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if(1==0) { }
        }
    }
}
