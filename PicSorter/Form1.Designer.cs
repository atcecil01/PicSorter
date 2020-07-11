namespace PicSorter
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
            this.btn_ChooseFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rdobtn_ByMonth = new System.Windows.Forms.RadioButton();
            this.rdobtn_ByDay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChooseFolder
            // 
            this.btn_ChooseFolder.Location = new System.Drawing.Point(305, 31);
            this.btn_ChooseFolder.Name = "btn_ChooseFolder";
            this.btn_ChooseFolder.Size = new System.Drawing.Size(126, 23);
            this.btn_ChooseFolder.TabIndex = 0;
            this.btn_ChooseFolder.Text = "Choose Folder";
            this.btn_ChooseFolder.UseVisualStyleBackColor = true;
            this.btn_ChooseFolder.Click += new System.EventHandler(this.btn_ChooseFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rdobtn_ByMonth
            // 
            this.rdobtn_ByMonth.AutoSize = true;
            this.rdobtn_ByMonth.Checked = true;
            this.rdobtn_ByMonth.Location = new System.Drawing.Point(15, 22);
            this.rdobtn_ByMonth.Name = "rdobtn_ByMonth";
            this.rdobtn_ByMonth.Size = new System.Drawing.Size(91, 17);
            this.rdobtn_ByMonth.TabIndex = 2;
            this.rdobtn_ByMonth.TabStop = true;
            this.rdobtn_ByMonth.Text = "Sort by Month";
            this.rdobtn_ByMonth.UseVisualStyleBackColor = true;
            this.rdobtn_ByMonth.CheckedChanged += new System.EventHandler(this.rdobtn_ByMonth_CheckedChanged);
            // 
            // rdobtn_ByDay
            // 
            this.rdobtn_ByDay.AutoSize = true;
            this.rdobtn_ByDay.Location = new System.Drawing.Point(15, 45);
            this.rdobtn_ByDay.Name = "rdobtn_ByDay";
            this.rdobtn_ByDay.Size = new System.Drawing.Size(80, 17);
            this.rdobtn_ByDay.TabIndex = 3;
            this.rdobtn_ByDay.Text = "Sort by Day";
            this.rdobtn_ByDay.UseVisualStyleBackColor = true;
            this.rdobtn_ByDay.CheckedChanged += new System.EventHandler(this.rdobtn_ByDay_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_ByDay);
            this.groupBox1.Controls.Add(this.rdobtn_ByMonth);
            this.groupBox1.Location = new System.Drawing.Point(61, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Selection";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(305, 84);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(126, 89);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "GO!";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 212);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ChooseFolder);
            this.Name = "Form1";
            this.Text = "PicSorter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChooseFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton rdobtn_ByMonth;
        private System.Windows.Forms.RadioButton rdobtn_ByDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Submit;
    }
}

