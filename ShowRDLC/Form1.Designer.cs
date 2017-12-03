namespace ShowRDLC
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetOrderDetails_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.tbShowReport = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbWait = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetOrderDetails_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetOrderDetails_ResultBindingSource
            // 
            this.GetOrderDetails_ResultBindingSource.DataSource = typeof(ShowRDLC.GetOrderDetails_Result);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(68, 6);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(100, 20);
            this.tbOrderID.TabIndex = 1;
            // 
            // tbShowReport
            // 
            this.tbShowReport.Location = new System.Drawing.Point(174, 4);
            this.tbShowReport.Name = "tbShowReport";
            this.tbShowReport.Size = new System.Drawing.Size(75, 23);
            this.tbShowReport.TabIndex = 2;
            this.tbShowReport.Text = "Show Order";
            this.tbShowReport.UseVisualStyleBackColor = true;
            this.tbShowReport.Click += new System.EventHandler(this.tbShowReport_Click);
            // 
            // reportViewer
            // 
            reportDataSource2.Name = "Orders";
            reportDataSource2.Value = this.GetOrderDetails_ResultBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ShowRDLC.OrdersReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(15, 33);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ShowToolBar = false;
            this.reportViewer.Size = new System.Drawing.Size(757, 516);
            this.reportViewer.TabIndex = 3;
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.ForeColor = System.Drawing.Color.Blue;
            this.lbWait.Location = new System.Drawing.Point(266, 9);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(126, 13);
            this.lbWait.TabIndex = 4;
            this.lbWait.Text = "<--- Please input Order ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbWait);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.tbShowReport);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetOrderDetails_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Button tbShowReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource GetOrderDetails_ResultBindingSource;
        private System.Windows.Forms.Label lbWait;
    }
}

