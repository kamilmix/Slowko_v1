namespace Slowko_v1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelWskazujacy = new System.Windows.Forms.Panel();
            this.buttonPomoc = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonNauka = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonZamknijProgram = new System.Windows.Forms.Button();
            this.controlZarzadzaj1 = new Slowko_v1.ControlZarzadzaj();
            this.oknoNauki = new Slowko_v1.Nauka();
            this.oknoPomocy = new Slowko_v1.pomoc();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panelWskazujacy);
            this.panel1.Controls.Add(this.buttonPomoc);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Controls.Add(this.buttonNauka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 494);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Słówko";
            // 
            // panelWskazujacy
            // 
            this.panelWskazujacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelWskazujacy.Location = new System.Drawing.Point(0, 126);
            this.panelWskazujacy.Name = "panelWskazujacy";
            this.panelWskazujacy.Size = new System.Drawing.Size(8, 43);
            this.panelWskazujacy.TabIndex = 2;
            // 
            // buttonPomoc
            // 
            this.buttonPomoc.FlatAppearance.BorderSize = 0;
            this.buttonPomoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPomoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPomoc.Location = new System.Drawing.Point(0, 224);
            this.buttonPomoc.Name = "buttonPomoc";
            this.buttonPomoc.Size = new System.Drawing.Size(154, 43);
            this.buttonPomoc.TabIndex = 4;
            this.buttonPomoc.Text = "Pomoc";
            this.buttonPomoc.UseVisualStyleBackColor = true;
            this.buttonPomoc.Click += new System.EventHandler(this.buttonPomoc_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.FlatAppearance.BorderSize = 0;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(0, 175);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(154, 43);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Zarządzaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonNauka
            // 
            this.buttonNauka.FlatAppearance.BorderSize = 0;
            this.buttonNauka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNauka.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNauka.Location = new System.Drawing.Point(0, 126);
            this.buttonNauka.Name = "buttonNauka";
            this.buttonNauka.Size = new System.Drawing.Size(154, 43);
            this.buttonNauka.TabIndex = 2;
            this.buttonNauka.Text = "Nauka";
            this.buttonNauka.UseVisualStyleBackColor = true;
            this.buttonNauka.Click += new System.EventHandler(this.button2_Click);
            this.buttonNauka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonNauka_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonZamknijProgram);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 19);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(631, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "--";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonZamknijProgram
            // 
            this.buttonZamknijProgram.FlatAppearance.BorderSize = 0;
            this.buttonZamknijProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamknijProgram.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknijProgram.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonZamknijProgram.Location = new System.Drawing.Point(655, -3);
            this.buttonZamknijProgram.Name = "buttonZamknijProgram";
            this.buttonZamknijProgram.Size = new System.Drawing.Size(20, 27);
            this.buttonZamknijProgram.TabIndex = 2;
            this.buttonZamknijProgram.Text = "X";
            this.buttonZamknijProgram.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonZamknijProgram.UseVisualStyleBackColor = true;
            this.buttonZamknijProgram.Click += new System.EventHandler(this.buttonZamknijProgram_Click);
            // 
            // controlZarzadzaj1
            // 
            this.controlZarzadzaj1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlZarzadzaj1.ForeColor = System.Drawing.Color.Black;
            this.controlZarzadzaj1.Location = new System.Drawing.Point(153, 19);
            this.controlZarzadzaj1.Name = "controlZarzadzaj1";
            this.controlZarzadzaj1.Size = new System.Drawing.Size(676, 475);
            this.controlZarzadzaj1.TabIndex = 4;
            this.controlZarzadzaj1.Load += new System.EventHandler(this.controlZarzadzaj1_Load);
            // 
            // oknoNauki
            // 
            this.oknoNauki.ForeColor = System.Drawing.Color.Black;
            this.oknoNauki.Location = new System.Drawing.Point(154, 25);
            this.oknoNauki.Name = "oknoNauki";
            this.oknoNauki.Size = new System.Drawing.Size(675, 469);
            this.oknoNauki.TabIndex = 3;
            this.oknoNauki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.oknoNauki_KeyDown);
            // 
            // oknoPomocy
            // 
            this.oknoPomocy.ForeColor = System.Drawing.Color.Black;
            this.oknoPomocy.Location = new System.Drawing.Point(154, 25);
            this.oknoPomocy.Name = "oknoPomocy";
            this.oknoPomocy.Size = new System.Drawing.Size(675, 469);
            this.oknoPomocy.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 494);
            this.Controls.Add(this.controlZarzadzaj1);
            this.Controls.Add(this.oknoNauki);
            this.Controls.Add(this.oknoPomocy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonZamknijProgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNauka;
        private System.Windows.Forms.Button buttonPomoc;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Panel panelWskazujacy;
        private pomoc oknoPomocy;
        private Nauka oknoNauki;
        private System.Windows.Forms.Label label4;
        private ControlZarzadzaj controlZarzadzaj1;
    }
}

