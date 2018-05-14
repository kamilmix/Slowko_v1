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
    public partial class Nauka : UserControl
    {
        public OleDbConnection connection = new OleDbConnection();
        string slowko;
        string id;
        int liczbaProb=0;
        int liczbaDobrze = 0;
        public Nauka()
        {
            InitializeComponent();
           
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kamil\Documents\slowka2.mdb;
                                                Persist Security Info = False; ";
            try
            {
                connection.Open();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


            listBox1.SelectedIndex = 0;
            connection.Close();
            losuj();
            connection.Close();

        }

        private int ileSlowekJest()
        {
            connection.Open();
            OleDbCommand komenda = new OleDbCommand();
            komenda.Connection = connection;
            komenda.CommandText = "select count(id) from " + listBox1.SelectedItem.ToString();
            string ile = komenda.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(ile);
        }
        private int ileSlowekPozostalo()
        {
            connection.Open();
            OleDbCommand komenda = new OleDbCommand();
            komenda.Connection = connection;
            komenda.CommandText = "select count(id) from " + listBox1.SelectedItem.ToString() + " where czy_umie=false";
            string ile = komenda.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(ile);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void buttonSprawdz_Click(object sender, EventArgs e)
        {

            
            if (textBox1.Text == slowko && textBox1.Text!="")
            {
                 
                label3.Visible = true;
                label3.Text = "DOBRZE";
                label3.ForeColor = Color.Green;
                oznaczJakoUmie(id);

                labelPodpowiedz.Visible = false;
                losuj();
                liczbaProb++;
                liczbaDobrze++;
            }
            else if (textBox1.Text == "")
            {
                
                labelPodpowiedz.Visible = false;
                label3.Visible = false;      
                losuj();
                liczbaProb++;
            }
            else
            {
               
                label3.Visible = true;
                label3.Text = "ŹLE";
                label3.ForeColor = Color.Red;
                labelPodpowiedz.Visible = true;
                labelPodpowiedz.Text = slowko;
                textBox1.Enabled = false;
            }
            textBox1.Clear();
            labelLiczbaProb.Text = "Liczba prób: " + liczbaDobrze + " / " + liczbaProb;



        }

        private void oznaczJakoUmie(string id)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "update " + listBox1.SelectedItem.ToString() + " set czy_umie=true where id=" + id;

            command.ExecuteNonQuery();
            connection.Close();
        }

        private void losuj()
        {
            textBox1.Enabled = true;
            textBox1.Focus();
            int x = ileSlowekPozostalo();

            if (x!=0)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from "+listBox1.SelectedItem.ToString()+" where czy_umie=false order by rnd(INT(NOW*id)-NOW*id)";

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                //MessageBox.Show(reader["tlumaczenie"].ToString());
                label2.Text = reader["tlumaczenie"].ToString();
                slowko = reader["slowko"].ToString();
                id = reader["id"].ToString();
               //  MessageBox.Show(id);
                connection.Close();
            }
            else
            {
                label2.Text = "";
                label3.Text = "Gratulacje!";
            }
            labelPozostalo.Text = "Pozostało: " + x + "/" + ileSlowekJest();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSprawdz.PerformClick();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox1.Clear();
            losuj();   

        }
    }
}
