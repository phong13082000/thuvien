
namespace QLTV1
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TableBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTV1DataSet1 = new QLTV1.QLTV1DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txbReport = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.TableBorrowTableAdapter = new QLTV1.QLTV1DataSet1TableAdapters.TableBorrowTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBorrowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTV1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableBorrowBindingSource
            // 
            this.TableBorrowBindingSource.DataMember = "TableBorrow";
            this.TableBorrowBindingSource.DataSource = this.QLTV1DataSet1;
            // 
            // QLTV1DataSet1
            // 
            this.QLTV1DataSet1.DataSetName = "QLTV1DataSet1";
            this.QLTV1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TableBorrowBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTV1.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(878, 588);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txbReport
            // 
            this.txbReport.Location = new System.Drawing.Point(184, 17);
            this.txbReport.Name = "txbReport";
            this.txbReport.Size = new System.Drawing.Size(121, 22);
            this.txbReport.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Black;
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(311, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 33);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Chọn";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // TableBorrowTableAdapter
            // 
            this.TableBorrowTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn mã độc giả";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txbReport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBorrowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTV1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableBorrowBindingSource;
        private QLTV1DataSet1 QLTV1DataSet1;
        private QLTV1DataSet1TableAdapters.TableBorrowTableAdapter TableBorrowTableAdapter;
        private System.Windows.Forms.TextBox txbReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource TableBookBindingSource;
    }
}