namespace Adci
{
    partial class Calibration
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
            this.phControl = new System.Windows.Forms.NumericUpDown();
            this.saveCalibration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phElectrode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.phControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phElectrode)).BeginInit();
            this.SuspendLayout();
            // 
            // phControl
            // 
            this.phControl.Location = new System.Drawing.Point(118, 18);
            this.phControl.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.phControl.Name = "phControl";
            this.phControl.Size = new System.Drawing.Size(101, 20);
            this.phControl.TabIndex = 10;
            // 
            // saveCalibration
            // 
            this.saveCalibration.Location = new System.Drawing.Point(12, 70);
            this.saveCalibration.Name = "saveCalibration";
            this.saveCalibration.Size = new System.Drawing.Size(204, 23);
            this.saveCalibration.TabIndex = 9;
            this.saveCalibration.Text = "Save Settings";
            this.saveCalibration.UseVisualStyleBackColor = true;
            this.saveCalibration.Click += new System.EventHandler(this.saveCalibration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Control PH Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Electrode PH Value";
            // 
            // phElectrode
            // 
            this.phElectrode.Enabled = false;
            this.phElectrode.Location = new System.Drawing.Point(118, 44);
            this.phElectrode.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.phElectrode.Name = "phElectrode";
            this.phElectrode.Size = new System.Drawing.Size(101, 20);
            this.phElectrode.TabIndex = 11;
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 101);
            this.Controls.Add(this.phElectrode);
            this.Controls.Add(this.phControl);
            this.Controls.Add(this.saveCalibration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calibration";
            ((System.ComponentModel.ISupportInitialize)(this.phControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phElectrode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown phControl;
        private System.Windows.Forms.Button saveCalibration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown phElectrode;
    }
}