﻿namespace SunManage.AllCheck
{
    partial class DiffusionFlowCheckPrinter
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiffusionFlowCheckPrinter));
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSetCoords";
            reportDataSource2.Value = null;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "SunManage.AllCheck.ReportReportViewer.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowZoomControl = false;
            this.reportViewer.Size = new System.Drawing.Size(752, 516);
            this.reportViewer.TabIndex = 2;
            // 
            // DiffusionFlowCheckPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiffusionFlowCheckPrinter";
            this.Text = "扩散流报表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiffusionFlowCheckPrinter_FormClosed);
            this.Load += new System.EventHandler(this.DiffusionFlowCheckPrinter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}