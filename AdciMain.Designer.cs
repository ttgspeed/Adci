namespace Adci
{
    partial class AdciMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.beginTracking = new System.Windows.Forms.Button();
            this.dcGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ioBox = new System.Windows.Forms.ListView();
            this.columnDC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ioStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ioBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ldSettings = new System.Windows.Forms.Button();
            this.exportCSV = new System.Windows.Forms.Button();
            this.resetData = new System.Windows.Forms.Button();
            this.ldCalibrate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dcGraph)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // beginTracking
            // 
            this.beginTracking.Location = new System.Drawing.Point(12, 226);
            this.beginTracking.Name = "beginTracking";
            this.beginTracking.Size = new System.Drawing.Size(158, 23);
            this.beginTracking.TabIndex = 1;
            this.beginTracking.Text = "Begin Tracking";
            this.beginTracking.UseVisualStyleBackColor = true;
            this.beginTracking.Click += new System.EventHandler(this.beginTracking_Click);
            // 
            // dcGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.dcGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dcGraph.Legends.Add(legend1);
            this.dcGraph.Location = new System.Drawing.Point(176, 12);
            this.dcGraph.Name = "dcGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "PH";
            series1.YValuesPerPoint = 2;
            this.dcGraph.Series.Add(series1);
            this.dcGraph.Size = new System.Drawing.Size(650, 208);
            this.dcGraph.TabIndex = 2;
            this.dcGraph.Text = "chart1";
            // 
            // ioBox
            // 
            this.ioBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDC,
            this.columnPH});
            this.ioBox.Location = new System.Drawing.Point(12, 12);
            this.ioBox.Name = "ioBox";
            this.ioBox.Size = new System.Drawing.Size(158, 208);
            this.ioBox.TabIndex = 3;
            this.ioBox.UseCompatibleStateImageBehavior = false;
            this.ioBox.View = System.Windows.Forms.View.Details;
            // 
            // columnDC
            // 
            this.columnDC.Text = "Drop Count";
            // 
            // columnPH
            // 
            this.columnPH.Text = "PH";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ioStatus,
            this.ioBaudRate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ioStatus
            // 
            this.ioStatus.Name = "ioStatus";
            this.ioStatus.Size = new System.Drawing.Size(79, 17);
            this.ioStatus.Text = "Disconnected";
            // 
            // ioBaudRate
            // 
            this.ioBaudRate.Name = "ioBaudRate";
            this.ioBaudRate.Size = new System.Drawing.Size(0, 17);
            // 
            // ldSettings
            // 
            this.ldSettings.Location = new System.Drawing.Point(668, 227);
            this.ldSettings.Name = "ldSettings";
            this.ldSettings.Size = new System.Drawing.Size(158, 23);
            this.ldSettings.TabIndex = 5;
            this.ldSettings.Text = "Settings";
            this.ldSettings.UseVisualStyleBackColor = true;
            this.ldSettings.Click += new System.EventHandler(this.ldSettings_Click);
            // 
            // exportCSV
            // 
            this.exportCSV.Location = new System.Drawing.Point(340, 226);
            this.exportCSV.Name = "exportCSV";
            this.exportCSV.Size = new System.Drawing.Size(158, 23);
            this.exportCSV.TabIndex = 6;
            this.exportCSV.Text = "Export to CSV";
            this.exportCSV.UseVisualStyleBackColor = true;
            this.exportCSV.Click += new System.EventHandler(this.exportCSV_Click);
            // 
            // resetData
            // 
            this.resetData.Location = new System.Drawing.Point(504, 226);
            this.resetData.Name = "resetData";
            this.resetData.Size = new System.Drawing.Size(158, 23);
            this.resetData.TabIndex = 7;
            this.resetData.Text = "Reset Data";
            this.resetData.UseVisualStyleBackColor = true;
            this.resetData.Click += new System.EventHandler(this.resetData_Click);
            // 
            // ldCalibrate
            // 
            this.ldCalibrate.Location = new System.Drawing.Point(176, 227);
            this.ldCalibrate.Name = "ldCalibrate";
            this.ldCalibrate.Size = new System.Drawing.Size(158, 23);
            this.ldCalibrate.TabIndex = 8;
            this.ldCalibrate.Text = "Calibrate";
            this.ldCalibrate.UseVisualStyleBackColor = true;
            this.ldCalibrate.Click += new System.EventHandler(this.ldCalibrate_Click);
            // 
            // AdciMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 275);
            this.Controls.Add(this.ldCalibrate);
            this.Controls.Add(this.resetData);
            this.Controls.Add(this.exportCSV);
            this.Controls.Add(this.ldSettings);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ioBox);
            this.Controls.Add(this.dcGraph);
            this.Controls.Add(this.beginTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdciMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adci";
            this.Load += new System.EventHandler(this.Adci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dcGraph)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginTracking;
        private System.Windows.Forms.DataVisualization.Charting.Chart dcGraph;
        private System.Windows.Forms.ListView ioBox;
        private System.Windows.Forms.ColumnHeader columnDC;
        private System.Windows.Forms.ColumnHeader columnPH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ioStatus;
        private System.Windows.Forms.Button ldSettings;
        private System.Windows.Forms.ToolStripStatusLabel ioBaudRate;
        private System.Windows.Forms.Button exportCSV;
        private System.Windows.Forms.Button resetData;
        private System.Windows.Forms.Button ldCalibrate;
    }
}

