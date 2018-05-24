using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slowko_v1
{
    public partial class Form1 : Form
    {
        public OleDbConnection connection = new OleDbConnection();
        public Form1()
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


            oknoNauki.BringToFront();
            panelWskazujacy.Top = buttonNauka.Top;
            panelWskazujacy.Height = buttonNauka.Height;
        }

        int mouseX = 0, mouseY=0;
        int mouseinX = 0, mouseinY = 0;
        bool mouseDown;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
           
               

                if (mouseDown)
                {
                    mouseX = MousePosition.X - mouseinX;
                    mouseY = MousePosition.Y - mouseinY;

                    this.SetDesktopLocation(mouseX, mouseY);
                }

            
        }

        private void buttonZamknijProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oknoNauki.BringToFront();
            panelWskazujacy.Top = buttonNauka.Top;
            panelWskazujacy.Height = buttonNauka.Height;
        }

        private void buttonPomoc_Click(object sender, EventArgs e)
        {
            oknoPomocy.BringToFront();
            panelWskazujacy.Top = buttonPomoc.Top;
            panelWskazujacy.Height = buttonPomoc.Height;
        }

        private void buttonNauka_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void oknoNauki_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            controlZarzadzaj1.BringToFront();
            panelWskazujacy.Top = buttonDodaj.Top;
            panelWskazujacy.Height = buttonDodaj.Height;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

    }
}
