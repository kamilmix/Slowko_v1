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
                komenda.CommandText = "select id, slowko, tlumaczenie, czy_umie from " + listBox1.SelectedItem.ToString();
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

            dataGridView1.CurrentCell = null;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].FillWeight = 50;
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

                if (tab.Count() > 1)
                {
                    string slowko1 = tab[0];
                    string slowko2 = tab[1];


                    command.CommandText = "insert into "
                        + listBox1.SelectedItem.ToString() + " (slowko, tlumaczenie) values ('" + slowko1 + "', '" + slowko2 + "') ";

                    command.ExecuteNonQuery();
                }
            }
                connection.Close();
            pokazDane();
            

        }


        private void buttonUsun_Click(object sender, EventArgs e)
        {
          

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow delrow = dataGridView1.Rows[i];
                    if (delrow.Selected == true)
                    {
                    string id = delrow.Cells[0].Value.ToString();
                   
                        dataGridView1.Rows.RemoveAt(i);
                        try
                        {
                            command.CommandText = "delete * from " + listBox1.SelectedItem.ToString() + " where id=" + id;
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

        }
            connection.Close();
            pokazDane();

        }

        private void buttonUsunWszystkie_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewny czy usunąć wszystkie słówka?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }

                try
                {
                    command.CommandText = "delete * from " + listBox1.SelectedItem.ToString();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                connection.Close();
                pokazDane();
            }       
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }
    }
}
