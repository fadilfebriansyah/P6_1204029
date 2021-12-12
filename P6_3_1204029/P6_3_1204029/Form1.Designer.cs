namespace P6_3_1204029
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kalender = new System.Windows.Forms.MonthCalendar();
            this.ll = new System.Windows.Forms.RadioButton();
            this.pr = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbnpm = new P6_3_1204029.NumericTextB();
            this.tbnama = new P6_3_1204029.CharTextB();
            this.label8 = new System.Windows.Forms.Label();
            this.tbno = new P6_3_1204029.NumericTextB();
            this.epWar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "No. Telepon";
            // 
            // kalender
            // 
            this.kalender.Location = new System.Drawing.Point(188, 123);
            this.kalender.Name = "kalender";
            this.kalender.TabIndex = 7;
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(188, 311);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(68, 17);
            this.ll.TabIndex = 8;
            this.ll.TabStop = true;
            this.ll.Text = "Laki-Laki";
            this.ll.UseVisualStyleBackColor = true;
            // 
            // pr
            // 
            this.pr.AutoSize = true;
            this.pr.Location = new System.Drawing.Point(330, 309);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(79, 17);
            this.pr.TabIndex = 9;
            this.pr.TabStop = true;
            this.pr.Text = "Perempuan";
            this.pr.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 432);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbalamat
            // 
            this.tbalamat.Location = new System.Drawing.Point(188, 340);
            this.tbalamat.Multiline = true;
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(227, 42);
            this.tbalamat.TabIndex = 13;
            this.tbalamat.Leave += new System.EventHandler(this.tbalamat_Leave);
            // 
            // tbnpm
            // 
            this.tbnpm.Location = new System.Drawing.Point(188, 59);
            this.tbnpm.Name = "tbnpm";
            this.tbnpm.Size = new System.Drawing.Size(107, 20);
            this.tbnpm.TabIndex = 14;
            this.tbnpm.Leave += new System.EventHandler(this.tbnpm_Leave);
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(188, 92);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(107, 20);
            this.tbnama.TabIndex = 15;
            this.tbnama.Leave += new System.EventHandler(this.tbnama_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Program Studi";
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(188, 394);
            this.tbno.Name = "tbno";
            this.tbno.Size = new System.Drawing.Size(107, 20);
            this.tbno.TabIndex = 17;
            this.tbno.Leave += new System.EventHandler(this.tbno_Leave);
            // 
            // epWar
            // 
            this.epWar.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 504);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.tbnpm);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.kalender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Master Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.epWar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar kalender;
        private System.Windows.Forms.RadioButton ll;
        private System.Windows.Forms.RadioButton pr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbalamat;
        private NumericTextB tbnpm;
        private CharTextB tbnama;
        private System.Windows.Forms.Label label8;
        private NumericTextB tbno;
        private System.Windows.Forms.ErrorProvider epWar;
    }
}

