namespace Adci
{
    partial class EditSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.cpSetting = new System.Windows.Forms.ComboBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.brSetting = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.brSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM Port";
            // 
            // cpSetting
            // 
            this.cpSetting.FormattingEnabled = true;
            this.cpSetting.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.cpSetting.Location = new System.Drawing.Point(79, 6);
            this.cpSetting.Name = "cpSetting";
            this.cpSetting.Size = new System.Drawing.Size(140, 21);
            this.cpSetting.TabIndex = 3;
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(15, 58);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(204, 23);
            this.saveSettings.TabIndex = 4;
            this.saveSettings.Text = "Save Settings";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // brSetting
            // 
            this.brSetting.Location = new System.Drawing.Point(79, 33);
            this.brSetting.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.brSetting.Name = "brSetting";
            this.brSetting.Size = new System.Drawing.Size(140, 20);
            this.brSetting.TabIndex = 5;
            // 
            // EditSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 88);
            this.Controls.Add(this.brSetting);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.cpSetting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.EditSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cpSetting;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.NumericUpDown brSetting;
    }
}