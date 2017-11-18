namespace CheckerWithRedpen
{
    partial class SettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRedpenBat = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonJavaHome = new System.Windows.Forms.Button();
            this.textBoxJavaHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRedpenBat = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pass of \"redpen.bat\"";
            // 
            // textBoxRedpenBat
            // 
            this.textBoxRedpenBat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRedpenBat.Location = new System.Drawing.Point(128, 11);
            this.textBoxRedpenBat.Name = "textBoxRedpenBat";
            this.textBoxRedpenBat.Size = new System.Drawing.Size(347, 19);
            this.textBoxRedpenBat.TabIndex = 1;
            this.textBoxRedpenBat.Text = "D:\\java\\redpen-distribution-1.10.0\\bin\\redpen.bat";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1426F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.85741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.buttonJavaHome, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxJavaHome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRedpenBat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRedpenBat, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 83);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonJavaHome
            // 
            this.buttonJavaHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonJavaHome.Location = new System.Drawing.Point(481, 50);
            this.buttonJavaHome.Name = "buttonJavaHome";
            this.buttonJavaHome.Size = new System.Drawing.Size(69, 23);
            this.buttonJavaHome.TabIndex = 5;
            this.buttonJavaHome.Text = "Browse";
            this.buttonJavaHome.UseVisualStyleBackColor = true;
            // 
            // textBoxJavaHome
            // 
            this.textBoxJavaHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxJavaHome.Location = new System.Drawing.Point(128, 52);
            this.textBoxJavaHome.Name = "textBoxJavaHome";
            this.textBoxJavaHome.Size = new System.Drawing.Size(347, 19);
            this.textBoxJavaHome.TabIndex = 4;
            this.textBoxJavaHome.Text = "D:\\Program Files\\Java\\jre1.8.0_151";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pass of JAVA_HOME";
            // 
            // buttonRedpenBat
            // 
            this.buttonRedpenBat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRedpenBat.Location = new System.Drawing.Point(481, 9);
            this.buttonRedpenBat.Name = "buttonRedpenBat";
            this.buttonRedpenBat.Size = new System.Drawing.Size(69, 23);
            this.buttonRedpenBat.TabIndex = 2;
            this.buttonRedpenBat.Text = "Browse";
            this.buttonRedpenBat.UseVisualStyleBackColor = true;
            this.buttonRedpenBat.Click += new System.EventHandler(this.buttonRedpenBat_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(491, 101);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 136);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "パス設定";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRedpenBat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonJavaHome;
        private System.Windows.Forms.TextBox textBoxJavaHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRedpenBat;
        private System.Windows.Forms.Button buttonSave;
    }
}