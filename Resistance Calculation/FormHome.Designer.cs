namespace Resistance_Calculation
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlSMD = new System.Windows.Forms.Panel();
            this.picSMD = new System.Windows.Forms.PictureBox();
            this.lblSMD = new System.Windows.Forms.Label();
            this.pnl3Precious = new System.Windows.Forms.Panel();
            this.pic3Precious = new System.Windows.Forms.PictureBox();
            this.lbl3Precious = new System.Windows.Forms.Label();
            this.pnl4Precious = new System.Windows.Forms.Panel();
            this.pic4Precious = new System.Windows.Forms.PictureBox();
            this.lbl4Precious = new System.Windows.Forms.Label();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pnl6Precious = new System.Windows.Forms.Panel();
            this.pic6Precious = new System.Windows.Forms.PictureBox();
            this.lbl6Precious = new System.Windows.Forms.Label();
            this.pnl5Precious = new System.Windows.Forms.Panel();
            this.pic5Precious = new System.Windows.Forms.PictureBox();
            this.lbl5Precious = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSMD)).BeginInit();
            this.pnl3Precious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3Precious)).BeginInit();
            this.pnl4Precious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4Precious)).BeginInit();
            this.pnlHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.pnl6Precious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic6Precious)).BeginInit();
            this.pnl5Precious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5Precious)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblMinimize);
            this.pnlHeader.Controls.Add(this.lblExit);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(360, 35);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(32, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Resistance_Calculation.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(309, 1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 24);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(335, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 24);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pnlSMD
            // 
            this.pnlSMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnlSMD.Controls.Add(this.picSMD);
            this.pnlSMD.Controls.Add(this.lblSMD);
            this.pnlSMD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSMD.Location = new System.Drawing.Point(12, 46);
            this.pnlSMD.Name = "pnlSMD";
            this.pnlSMD.Size = new System.Drawing.Size(106, 100);
            this.pnlSMD.TabIndex = 2;
            this.pnlSMD.Click += new System.EventHandler(this.pnlSMD_Click);
            // 
            // picSMD
            // 
            this.picSMD.Image = global::Resistance_Calculation.Properties.Resources.smd;
            this.picSMD.Location = new System.Drawing.Point(3, 12);
            this.picSMD.Name = "picSMD";
            this.picSMD.Size = new System.Drawing.Size(100, 50);
            this.picSMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSMD.TabIndex = 1;
            this.picSMD.TabStop = false;
            this.picSMD.Click += new System.EventHandler(this.pnlSMD_Click);
            // 
            // lblSMD
            // 
            this.lblSMD.AutoSize = true;
            this.lblSMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSMD.ForeColor = System.Drawing.Color.White;
            this.lblSMD.Location = new System.Drawing.Point(36, 72);
            this.lblSMD.Name = "lblSMD";
            this.lblSMD.Size = new System.Drawing.Size(38, 16);
            this.lblSMD.TabIndex = 0;
            this.lblSMD.Text = "SMD";
            this.lblSMD.Click += new System.EventHandler(this.pnlSMD_Click);
            // 
            // pnl3Precious
            // 
            this.pnl3Precious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnl3Precious.Controls.Add(this.pic3Precious);
            this.pnl3Precious.Controls.Add(this.lbl3Precious);
            this.pnl3Precious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl3Precious.Location = new System.Drawing.Point(127, 46);
            this.pnl3Precious.Name = "pnl3Precious";
            this.pnl3Precious.Size = new System.Drawing.Size(106, 100);
            this.pnl3Precious.TabIndex = 3;
            this.pnl3Precious.Click += new System.EventHandler(this.pnl3Precious_Click);
            // 
            // pic3Precious
            // 
            this.pic3Precious.Image = global::Resistance_Calculation.Properties.Resources.smd;
            this.pic3Precious.Location = new System.Drawing.Point(3, 12);
            this.pic3Precious.Name = "pic3Precious";
            this.pic3Precious.Size = new System.Drawing.Size(100, 50);
            this.pic3Precious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3Precious.TabIndex = 1;
            this.pic3Precious.TabStop = false;
            this.pic3Precious.Click += new System.EventHandler(this.pnl3Precious_Click);
            // 
            // lbl3Precious
            // 
            this.lbl3Precious.AutoSize = true;
            this.lbl3Precious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3Precious.ForeColor = System.Drawing.Color.White;
            this.lbl3Precious.Location = new System.Drawing.Point(17, 72);
            this.lbl3Precious.Name = "lbl3Precious";
            this.lbl3Precious.Size = new System.Drawing.Size(75, 16);
            this.lbl3Precious.TabIndex = 0;
            this.lbl3Precious.Text = "Precious_3";
            this.lbl3Precious.Click += new System.EventHandler(this.pnl3Precious_Click);
            // 
            // pnl4Precious
            // 
            this.pnl4Precious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnl4Precious.Controls.Add(this.pic4Precious);
            this.pnl4Precious.Controls.Add(this.lbl4Precious);
            this.pnl4Precious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl4Precious.Location = new System.Drawing.Point(242, 46);
            this.pnl4Precious.Name = "pnl4Precious";
            this.pnl4Precious.Size = new System.Drawing.Size(106, 100);
            this.pnl4Precious.TabIndex = 3;
            this.pnl4Precious.Click += new System.EventHandler(this.pn4Precious_Click);
            // 
            // pic4Precious
            // 
            this.pic4Precious.Image = global::Resistance_Calculation.Properties.Resources.smd;
            this.pic4Precious.Location = new System.Drawing.Point(3, 12);
            this.pic4Precious.Name = "pic4Precious";
            this.pic4Precious.Size = new System.Drawing.Size(100, 50);
            this.pic4Precious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4Precious.TabIndex = 1;
            this.pic4Precious.TabStop = false;
            this.pic4Precious.Click += new System.EventHandler(this.pn4Precious_Click);
            // 
            // lbl4Precious
            // 
            this.lbl4Precious.AutoSize = true;
            this.lbl4Precious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4Precious.ForeColor = System.Drawing.Color.White;
            this.lbl4Precious.Location = new System.Drawing.Point(18, 72);
            this.lbl4Precious.Name = "lbl4Precious";
            this.lbl4Precious.Size = new System.Drawing.Size(75, 16);
            this.lbl4Precious.TabIndex = 0;
            this.lbl4Precious.Text = "Precious_4";
            this.lbl4Precious.Click += new System.EventHandler(this.pn4Precious_Click);
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnlHelp.Controls.Add(this.picHelp);
            this.pnlHelp.Controls.Add(this.lblHelp);
            this.pnlHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHelp.Location = new System.Drawing.Point(242, 155);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(106, 100);
            this.pnlHelp.TabIndex = 6;
            this.pnlHelp.Click += new System.EventHandler(this.pnlInfo_Click);
            // 
            // picHelp
            // 
            this.picHelp.Image = global::Resistance_Calculation.Properties.Resources.info;
            this.picHelp.Location = new System.Drawing.Point(3, 13);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(100, 50);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 1;
            this.picHelp.TabStop = false;
            this.picHelp.Click += new System.EventHandler(this.pnlInfo_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(34, 73);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(37, 16);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.pnlInfo_Click);
            // 
            // pnl6Precious
            // 
            this.pnl6Precious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnl6Precious.Controls.Add(this.pic6Precious);
            this.pnl6Precious.Controls.Add(this.lbl6Precious);
            this.pnl6Precious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl6Precious.Location = new System.Drawing.Point(127, 155);
            this.pnl6Precious.Name = "pnl6Precious";
            this.pnl6Precious.Size = new System.Drawing.Size(106, 100);
            this.pnl6Precious.TabIndex = 5;
            this.pnl6Precious.Click += new System.EventHandler(this.pnl6Precious_Click);
            // 
            // pic6Precious
            // 
            this.pic6Precious.Image = global::Resistance_Calculation.Properties.Resources.smd;
            this.pic6Precious.Location = new System.Drawing.Point(3, 13);
            this.pic6Precious.Name = "pic6Precious";
            this.pic6Precious.Size = new System.Drawing.Size(100, 50);
            this.pic6Precious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6Precious.TabIndex = 1;
            this.pic6Precious.TabStop = false;
            this.pic6Precious.Click += new System.EventHandler(this.pnl6Precious_Click);
            // 
            // lbl6Precious
            // 
            this.lbl6Precious.AutoSize = true;
            this.lbl6Precious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6Precious.ForeColor = System.Drawing.Color.White;
            this.lbl6Precious.Location = new System.Drawing.Point(17, 73);
            this.lbl6Precious.Name = "lbl6Precious";
            this.lbl6Precious.Size = new System.Drawing.Size(75, 16);
            this.lbl6Precious.TabIndex = 0;
            this.lbl6Precious.Text = "Precious_6";
            this.lbl6Precious.Click += new System.EventHandler(this.pnl6Precious_Click);
            // 
            // pnl5Precious
            // 
            this.pnl5Precious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.pnl5Precious.Controls.Add(this.pic5Precious);
            this.pnl5Precious.Controls.Add(this.lbl5Precious);
            this.pnl5Precious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl5Precious.Location = new System.Drawing.Point(12, 155);
            this.pnl5Precious.Name = "pnl5Precious";
            this.pnl5Precious.Size = new System.Drawing.Size(106, 100);
            this.pnl5Precious.TabIndex = 4;
            this.pnl5Precious.Click += new System.EventHandler(this.pnl5Precious_Click);
            // 
            // pic5Precious
            // 
            this.pic5Precious.Image = global::Resistance_Calculation.Properties.Resources.smd;
            this.pic5Precious.Location = new System.Drawing.Point(3, 13);
            this.pic5Precious.Name = "pic5Precious";
            this.pic5Precious.Size = new System.Drawing.Size(100, 50);
            this.pic5Precious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5Precious.TabIndex = 1;
            this.pic5Precious.TabStop = false;
            this.pic5Precious.Click += new System.EventHandler(this.pnl5Precious_Click);
            // 
            // lbl5Precious
            // 
            this.lbl5Precious.AutoSize = true;
            this.lbl5Precious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5Precious.ForeColor = System.Drawing.Color.White;
            this.lbl5Precious.Location = new System.Drawing.Point(17, 73);
            this.lbl5Precious.Name = "lbl5Precious";
            this.lbl5Precious.Size = new System.Drawing.Size(75, 16);
            this.lbl5Precious.TabIndex = 0;
            this.lbl5Precious.Text = "Precious_5";
            this.lbl5Precious.Click += new System.EventHandler(this.pnl5Precious_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(360, 274);
            this.Controls.Add(this.pnlHelp);
            this.Controls.Add(this.pnl4Precious);
            this.Controls.Add(this.pnl6Precious);
            this.Controls.Add(this.pnl5Precious);
            this.Controls.Add(this.pnl3Precious);
            this.Controls.Add(this.pnlSMD);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resistance Calculation";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSMD.ResumeLayout(false);
            this.pnlSMD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSMD)).EndInit();
            this.pnl3Precious.ResumeLayout(false);
            this.pnl3Precious.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3Precious)).EndInit();
            this.pnl4Precious.ResumeLayout(false);
            this.pnl4Precious.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4Precious)).EndInit();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.pnl6Precious.ResumeLayout(false);
            this.pnl6Precious.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic6Precious)).EndInit();
            this.pnl5Precious.ResumeLayout(false);
            this.pnl5Precious.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic5Precious)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSMD;
        private System.Windows.Forms.Label lblSMD;
        private System.Windows.Forms.PictureBox picSMD;
        private System.Windows.Forms.Panel pnl3Precious;
        private System.Windows.Forms.PictureBox pic3Precious;
        private System.Windows.Forms.Label lbl3Precious;
        private System.Windows.Forms.Panel pnl4Precious;
        private System.Windows.Forms.PictureBox pic4Precious;
        private System.Windows.Forms.Label lbl4Precious;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Panel pnl6Precious;
        private System.Windows.Forms.PictureBox pic6Precious;
        private System.Windows.Forms.Label lbl6Precious;
        private System.Windows.Forms.Panel pnl5Precious;
        private System.Windows.Forms.PictureBox pic5Precious;
        private System.Windows.Forms.Label lbl5Precious;
    }
}

