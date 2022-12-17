namespace DSAKnap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ItemWeight_TB = new System.Windows.Forms.TextBox();
            this.ItemValue_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Calculate_Btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Listbox1 = new System.Windows.Forms.ListBox();
            this.Result_GV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowCart_Btn = new System.Windows.Forms.Button();
            this.ItemName_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.KnapsackWeght_Lbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.HowToUse_Lbl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Result_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemWeight_TB
            // 
            this.ItemWeight_TB.Location = new System.Drawing.Point(146, 83);
            this.ItemWeight_TB.Name = "ItemWeight_TB";
            this.ItemWeight_TB.Size = new System.Drawing.Size(201, 20);
            this.ItemWeight_TB.TabIndex = 1;
            // 
            // ItemValue_TB
            // 
            this.ItemValue_TB.Location = new System.Drawing.Point(146, 128);
            this.ItemValue_TB.Name = "ItemValue_TB";
            this.ItemValue_TB.Size = new System.Drawing.Size(201, 20);
            this.ItemValue_TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Knapsack Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // Calculate_Btn
            // 
            this.Calculate_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Btn.Location = new System.Drawing.Point(180, 320);
            this.Calculate_Btn.Name = "Calculate_Btn";
            this.Calculate_Btn.Size = new System.Drawing.Size(105, 37);
            this.Calculate_Btn.TabIndex = 4;
            this.Calculate_Btn.Text = "Calculate";
            this.Calculate_Btn.UseVisualStyleBackColor = true;
            this.Calculate_Btn.Click += new System.EventHandler(this.Calculate_Btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "0";
            // 
            // Listbox1
            // 
            this.Listbox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.Listbox1.FormattingEnabled = true;
            this.Listbox1.ItemHeight = 18;
            this.Listbox1.Items.AddRange(new object[] {
            "Selected Items"});
            this.Listbox1.Location = new System.Drawing.Point(427, 38);
            this.Listbox1.Name = "Listbox1";
            this.Listbox1.Size = new System.Drawing.Size(94, 256);
            this.Listbox1.TabIndex = 11;
            // 
            // Result_GV
            // 
            this.Result_GV.AllowUserToAddRows = false;
            this.Result_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_GV.Location = new System.Drawing.Point(12, 370);
            this.Result_GV.Name = "Result_GV";
            this.Result_GV.ReadOnly = true;
            this.Result_GV.Size = new System.Drawing.Size(832, 226);
            this.Result_GV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(349, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "KG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(349, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "RS.";
            // 
            // ShowCart_Btn
            // 
            this.ShowCart_Btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ShowCart_Btn.Location = new System.Drawing.Point(427, 320);
            this.ShowCart_Btn.Name = "ShowCart_Btn";
            this.ShowCart_Btn.Size = new System.Drawing.Size(94, 37);
            this.ShowCart_Btn.TabIndex = 15;
            this.ShowCart_Btn.Text = "Show Chart";
            this.ShowCart_Btn.UseVisualStyleBackColor = true;
            this.ShowCart_Btn.Visible = false;
            this.ShowCart_Btn.Click += new System.EventHandler(this.ShowCart_Btn_Click);
            // 
            // ItemName_TB
            // 
            this.ItemName_TB.Location = new System.Drawing.Point(146, 38);
            this.ItemName_TB.Multiline = true;
            this.ItemName_TB.Name = "ItemName_TB";
            this.ItemName_TB.Size = new System.Drawing.Size(201, 20);
            this.ItemName_TB.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Item Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Benifit";
            // 
            // KnapsackWeght_Lbl
            // 
            this.KnapsackWeght_Lbl.AutoSize = true;
            this.KnapsackWeght_Lbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnapsackWeght_Lbl.Location = new System.Drawing.Point(179, 179);
            this.KnapsackWeght_Lbl.Name = "KnapsackWeght_Lbl";
            this.KnapsackWeght_Lbl.Size = new System.Drawing.Size(0, 17);
            this.KnapsackWeght_Lbl.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(213, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "RS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(214, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "KG";
            // 
            // HowToUse_Lbl
            // 
            this.HowToUse_Lbl.AutoSize = true;
            this.HowToUse_Lbl.Location = new System.Drawing.Point(3, 3);
            this.HowToUse_Lbl.Name = "HowToUse_Lbl";
            this.HowToUse_Lbl.Size = new System.Drawing.Size(63, 13);
            this.HowToUse_Lbl.TabIndex = 25;
            this.HowToUse_Lbl.TabStop = true;
            this.HowToUse_Lbl.Text = "How to Use";
            this.HowToUse_Lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HowToUse_Lbl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSAKnap.Properties.Resources.Knapsack;
            this.pictureBox1.Location = new System.Drawing.Point(580, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(856, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HowToUse_Lbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.KnapsackWeght_Lbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ItemName_TB);
            this.Controls.Add(this.ShowCart_Btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Result_GV);
            this.Controls.Add(this.Listbox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Calculate_Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemValue_TB);
            this.Controls.Add(this.ItemWeight_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-50, 60);
            this.Name = "MainForm";
            this.Text = "Fractional knapsack";
            ((System.ComponentModel.ISupportInitialize)(this.Result_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemWeight_TB;
        private System.Windows.Forms.TextBox ItemValue_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Calculate_Btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Listbox1;
        private System.Windows.Forms.DataGridView Result_GV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowCart_Btn;
        private System.Windows.Forms.TextBox ItemName_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label KnapsackWeght_Lbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel HowToUse_Lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

