namespace Csharp_giaiphuongtrinhbat2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.akbb = new System.Windows.Forms.TrackBar();
            this.akba = new System.Windows.Forms.TrackBar();
            this.akbc = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblkq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.akbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(329, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "giải phương trình";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(56, 130);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(78, 25);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "nhập a";
            this.lbla.Click += new System.EventHandler(this.label1_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(151, 127);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(139, 45);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(151, 178);
            this.txtb.Multiline = true;
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(139, 40);
            this.txtb.TabIndex = 4;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(56, 181);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(81, 25);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "Nhập b";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(151, 224);
            this.txtc.Multiline = true;
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(139, 45);
            this.txtc.TabIndex = 6;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(57, 233);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(80, 25);
            this.lblc.TabIndex = 5;
            this.lblc.Text = "Nhập c";
            // 
            // akbb
            // 
            this.akbb.Location = new System.Drawing.Point(320, 178);
            this.akbb.Maximum = 100;
            this.akbb.Minimum = -100;
            this.akbb.Name = "akbb";
            this.akbb.Size = new System.Drawing.Size(527, 45);
            this.akbb.TabIndex = 8;
            this.akbb.Scroll += new System.EventHandler(this.akbb_Scroll);
            // 
            // akba
            // 
            this.akba.Location = new System.Drawing.Point(329, 127);
            this.akba.Maximum = 100;
            this.akba.Minimum = -100;
            this.akba.Name = "akba";
            this.akba.Size = new System.Drawing.Size(518, 45);
            this.akba.TabIndex = 9;
            this.akba.Value = 100;
            this.akba.Scroll += new System.EventHandler(this.akba_Scroll);
            // 
            // akbc
            // 
            this.akbc.Location = new System.Drawing.Point(320, 229);
            this.akbc.Maximum = 100;
            this.akbc.Minimum = -100;
            this.akbc.Name = "akbc";
            this.akbc.Size = new System.Drawing.Size(527, 45);
            this.akbc.TabIndex = 10;
            this.akbc.Scroll += new System.EventHandler(this.akbc_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "ỨNG DỤNG GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(362, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "ax2+bx+c=0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblkq);
            this.groupBox1.Location = new System.Drawing.Point(99, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkq.Location = new System.Drawing.Point(49, 67);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(0, 24);
            this.lblkq.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(899, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.akbc);
            this.Controls.Add(this.akba);
            this.Controls.Add(this.akbb);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.akbb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akbc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TrackBar akbb;
        private System.Windows.Forms.TrackBar akba;
        private System.Windows.Forms.TrackBar akbc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblkq;
    }
}

