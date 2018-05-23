namespace Slowko_v1
{
    partial class Nauka
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelPozostalo = new System.Windows.Forms.Label();
            this.labelPodpowiedz = new System.Windows.Forms.Label();
            this.labelLiczbaProb = new System.Windows.Forms.Label();
            this.Statystyki = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Statystyki.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(32, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(449, 304);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 3;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "zielony";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(338, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DOBRZE";
            this.label3.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "kolory",
            "dom",
            "napoje",
            "zestaw1",
            "zestaw2"});
            this.listBox1.Location = new System.Drawing.Point(3, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 105);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelPozostalo
            // 
            this.labelPozostalo.AutoSize = true;
            this.labelPozostalo.BackColor = System.Drawing.Color.Transparent;
            this.labelPozostalo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPozostalo.Location = new System.Drawing.Point(15, 26);
            this.labelPozostalo.Name = "labelPozostalo";
            this.labelPozostalo.Size = new System.Drawing.Size(80, 17);
            this.labelPozostalo.TabIndex = 8;
            this.labelPozostalo.Text = "Pozostało: ";
            // 
            // labelPodpowiedz
            // 
            this.labelPodpowiedz.AutoSize = true;
            this.labelPodpowiedz.BackColor = System.Drawing.Color.Transparent;
            this.labelPodpowiedz.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPodpowiedz.Location = new System.Drawing.Point(47, 345);
            this.labelPodpowiedz.Name = "labelPodpowiedz";
            this.labelPodpowiedz.Size = new System.Drawing.Size(71, 24);
            this.labelPodpowiedz.TabIndex = 9;
            this.labelPodpowiedz.Text = "green";
            this.labelPodpowiedz.Visible = false;
            // 
            // labelLiczbaProb
            // 
            this.labelLiczbaProb.AutoSize = true;
            this.labelLiczbaProb.BackColor = System.Drawing.Color.Transparent;
            this.labelLiczbaProb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaProb.Location = new System.Drawing.Point(15, 47);
            this.labelLiczbaProb.Name = "labelLiczbaProb";
            this.labelLiczbaProb.Size = new System.Drawing.Size(88, 17);
            this.labelLiczbaProb.TabIndex = 10;
            this.labelLiczbaProb.Text = "Liczba prób:";
            // 
            // Statystyki
            // 
            this.Statystyki.Controls.Add(this.labelPozostalo);
            this.Statystyki.Controls.Add(this.labelLiczbaProb);
            this.Statystyki.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Statystyki.Location = new System.Drawing.Point(193, 19);
            this.Statystyki.Name = "Statystyki";
            this.Statystyki.Size = new System.Drawing.Size(151, 99);
            this.Statystyki.TabIndex = 11;
            this.Statystyki.TabStop = false;
            this.Statystyki.Text = "Statystyki";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(32, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zestaw słówek";
            // 
            // Nauka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Statystyki);
            this.Controls.Add(this.labelPodpowiedz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSprawdz);
            this.Controls.Add(this.textBox1);
            this.Name = "Nauka";
            this.Size = new System.Drawing.Size(675, 469);
            this.Statystyki.ResumeLayout(false);
            this.Statystyki.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelPozostalo;
        private System.Windows.Forms.Label labelPodpowiedz;
        private System.Windows.Forms.Label labelLiczbaProb;
        private System.Windows.Forms.GroupBox Statystyki;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
