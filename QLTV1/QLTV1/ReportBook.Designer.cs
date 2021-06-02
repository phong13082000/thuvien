
namespace QLTV1
{
    partial class ReportBook
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLTV1DataSet = new QLTV1.QLTV1DataSet();
            this.TableBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableBookTableAdapter = new QLTV1.QLTV1DataSetTableAdapters.TableBookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLTV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.TableBookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTV1.ReportBook.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1482, 740);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLTV1DataSet
            // 
            this.QLTV1DataSet.DataSetName = "QLTV1DataSet";
            this.QLTV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TableBookBindingSource
            // 
            this.TableBookBindingSource.DataMember = "TableBook";
            this.TableBookBindingSource.DataSource = this.QLTV1DataSet;
            // 
            // TableBookTableAdapter
            // 
            this.TableBookTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 764);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportBook";
            this.Load += new System.EventHandler(this.ReportBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLTV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TableBookBindingSource;
        private QLTV1DataSet QLTV1DataSet;
        private QLTV1DataSetTableAdapters.TableBookTableAdapter TableBookTableAdapter;
    }
}