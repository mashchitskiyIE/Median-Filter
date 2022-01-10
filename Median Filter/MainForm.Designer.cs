namespace MedianFilter
{
    partial class MainForm
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
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.TimerTB = new System.Windows.Forms.TextBox();
            this.edgeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pNCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxIn, 2);
            this.pictureBoxIn.Location = new System.Drawing.Point(317, 3);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(236, 191);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIn.TabIndex = 0;
            this.pictureBoxIn.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(456, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.75F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxOut, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxIn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimerTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.edgeCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pNCB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.04F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.04F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.04F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 742);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBoxOut
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxOut, 2);
            this.pictureBoxOut.Location = new System.Drawing.Point(559, 3);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(236, 191);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOut.TabIndex = 2;
            this.pictureBoxOut.TabStop = false;
            // 
            // TimerTB
            // 
            this.TimerTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerTB.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.TimerTB, 2);
            this.TimerTB.Location = new System.Drawing.Point(456, 719);
            this.TimerTB.Name = "TimerTB";
            this.TimerTB.ReadOnly = true;
            this.TimerTB.Size = new System.Drawing.Size(200, 20);
            this.TimerTB.TabIndex = 5;
            this.TimerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edgeCB
            // 
            this.edgeCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edgeCB.FormattingEnabled = true;
            this.edgeCB.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9"});
            this.edgeCB.Location = new System.Drawing.Point(483, 655);
            this.edgeCB.Name = "edgeCB";
            this.edgeCB.Size = new System.Drawing.Size(43, 21);
            this.edgeCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 636);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Window Edge";
            // 
            // pNCB
            // 
            this.pNCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pNCB.FormattingEnabled = true;
            this.pNCB.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.pNCB.Location = new System.Drawing.Point(586, 655);
            this.pNCB.Name = "pNCB";
            this.pNCB.Size = new System.Drawing.Size(43, 21);
            this.pNCB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 636);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Processing Units";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 742);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Median Filter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.ComboBox pNCB;
        private System.Windows.Forms.ComboBox edgeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimerTB;
    }
}

