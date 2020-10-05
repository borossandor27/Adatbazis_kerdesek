namespace Adatbazis_kerdesek
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Osztaly = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Kerdes = new System.Windows.Forms.Label();
            this.textBox_Valasz = new System.Windows.Forms.TextBox();
            this.label_Elteltido = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_adatbazis = new System.Windows.Forms.Label();
            this.checkBox_Orszagok = new System.Windows.Forms.CheckBox();
            this.checkBox_Tagdij = new System.Windows.Forms.CheckBox();
            this.checkBox_Pizza = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "osztály:";
            // 
            // comboBox_Osztaly
            // 
            this.comboBox_Osztaly.FormattingEnabled = true;
            this.comboBox_Osztaly.Items.AddRange(new object[] {
            "13T",
            "14S",
            "14SL"});
            this.comboBox_Osztaly.Location = new System.Drawing.Point(128, 10);
            this.comboBox_Osztaly.Name = "comboBox_Osztaly";
            this.comboBox_Osztaly.Size = new System.Drawing.Size(197, 33);
            this.comboBox_Osztaly.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "név:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(495, 13);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(387, 31);
            this.textBox_Nev.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Kerdes
            // 
            this.label_Kerdes.AutoSize = true;
            this.label_Kerdes.ForeColor = System.Drawing.Color.Maroon;
            this.label_Kerdes.Location = new System.Drawing.Point(12, 190);
            this.label_Kerdes.Name = "label_Kerdes";
            this.label_Kerdes.Size = new System.Drawing.Size(80, 25);
            this.label_Kerdes.TabIndex = 5;
            this.label_Kerdes.Text = "Kerdes";
            // 
            // textBox_Valasz
            // 
            this.textBox_Valasz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_Valasz.Location = new System.Drawing.Point(0, 269);
            this.textBox_Valasz.Multiline = true;
            this.textBox_Valasz.Name = "textBox_Valasz";
            this.textBox_Valasz.Size = new System.Drawing.Size(1184, 298);
            this.textBox_Valasz.TabIndex = 6;
            // 
            // label_Elteltido
            // 
            this.label_Elteltido.AutoSize = true;
            this.label_Elteltido.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Elteltido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_Elteltido.Location = new System.Drawing.Point(400, 99);
            this.label_Elteltido.Name = "label_Elteltido";
            this.label_Elteltido.Size = new System.Drawing.Size(152, 55);
            this.label_Elteltido.TabIndex = 7;
            this.label_Elteltido.Text = "label3";
            // 
            // button_Stop
            // 
            this.button_Stop.Image = global::Adatbazis_kerdesek.Properties.Resources.Stop_red_icon;
            this.button_Stop.Location = new System.Drawing.Point(627, 99);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(255, 45);
            this.button_Stop.TabIndex = 8;
            this.button_Stop.Text = "Kérdés vége";
            this.button_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Image = global::Adatbazis_kerdesek.Properties.Resources.Start_icon;
            this.button_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Start.Location = new System.Drawing.Point(70, 99);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(255, 45);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Kérem a kérdést!";
            this.button_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_adatbazis
            // 
            this.label_adatbazis.AutoSize = true;
            this.label_adatbazis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_adatbazis.Location = new System.Drawing.Point(13, 156);
            this.label_adatbazis.Name = "label_adatbazis";
            this.label_adatbazis.Size = new System.Drawing.Size(105, 25);
            this.label_adatbazis.TabIndex = 9;
            this.label_adatbazis.Text = "adatbazis";
            // 
            // checkBox_Orszagok
            // 
            this.checkBox_Orszagok.AutoSize = true;
            this.checkBox_Orszagok.Checked = true;
            this.checkBox_Orszagok.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Orszagok.Location = new System.Drawing.Point(254, 58);
            this.checkBox_Orszagok.Name = "checkBox_Orszagok";
            this.checkBox_Orszagok.Size = new System.Drawing.Size(119, 29);
            this.checkBox_Orszagok.TabIndex = 10;
            this.checkBox_Orszagok.Text = "orszagok";
            this.checkBox_Orszagok.UseVisualStyleBackColor = true;
            // 
            // checkBox_Tagdij
            // 
            this.checkBox_Tagdij.AutoSize = true;
            this.checkBox_Tagdij.Checked = true;
            this.checkBox_Tagdij.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Tagdij.Location = new System.Drawing.Point(427, 58);
            this.checkBox_Tagdij.Name = "checkBox_Tagdij";
            this.checkBox_Tagdij.Size = new System.Drawing.Size(83, 29);
            this.checkBox_Tagdij.TabIndex = 11;
            this.checkBox_Tagdij.Text = "tagdij";
            this.checkBox_Tagdij.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pizza
            // 
            this.checkBox_Pizza.AutoSize = true;
            this.checkBox_Pizza.Checked = true;
            this.checkBox_Pizza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Pizza.Location = new System.Drawing.Point(564, 58);
            this.checkBox_Pizza.Name = "checkBox_Pizza";
            this.checkBox_Pizza.Size = new System.Drawing.Size(82, 29);
            this.checkBox_Pizza.TabIndex = 12;
            this.checkBox_Pizza.Text = "pizza";
            this.checkBox_Pizza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 567);
            this.Controls.Add(this.checkBox_Pizza);
            this.Controls.Add(this.checkBox_Tagdij);
            this.Controls.Add(this.checkBox_Orszagok);
            this.Controls.Add(this.label_adatbazis);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.label_Elteltido);
            this.Controls.Add(this.textBox_Valasz);
            this.Controls.Add(this.label_Kerdes);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Osztaly);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "SQL teszt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Osztaly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Kerdes;
        private System.Windows.Forms.TextBox textBox_Valasz;
        private System.Windows.Forms.Label label_Elteltido;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label_adatbazis;
        private System.Windows.Forms.CheckBox checkBox_Orszagok;
        private System.Windows.Forms.CheckBox checkBox_Tagdij;
        private System.Windows.Forms.CheckBox checkBox_Pizza;
    }
}

