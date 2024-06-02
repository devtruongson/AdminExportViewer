namespace AdminExportViewer
{
    partial class Booking
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
            this._manage_rent_bikeDataSet = new AdminExportViewer._manage_rent_bikeDataSet();
            this.bookingformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booking_formTableAdapter = new AdminExportViewer._manage_rent_bikeDataSetTableAdapters.booking_formTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._manage_rent_bikeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetBookingForm";
            reportDataSource1.Value = this.bookingformBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AdminExportViewer.ReportBooking.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // _manage_rent_bikeDataSet
            // 
            this._manage_rent_bikeDataSet.DataSetName = "_manage_rent_bikeDataSet";
            this._manage_rent_bikeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingformBindingSource
            // 
            this.bookingformBindingSource.DataMember = "booking_form";
            this.bookingformBindingSource.DataSource = this._manage_rent_bikeDataSet;
            // 
            // booking_formTableAdapter
            // 
            this.booking_formTableAdapter.ClearBeforeFill = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this._manage_rent_bikeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingformBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _manage_rent_bikeDataSet _manage_rent_bikeDataSet;
        private System.Windows.Forms.BindingSource bookingformBindingSource;
        private _manage_rent_bikeDataSetTableAdapters.booking_formTableAdapter booking_formTableAdapter;
    }
}