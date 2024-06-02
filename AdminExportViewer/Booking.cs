using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminExportViewer
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_manage_rent_bikeDataSet.booking_form' table. You can move, or remove it, as needed.
            this.booking_formTableAdapter.Fill(this._manage_rent_bikeDataSet.booking_form);

            this.reportViewer1.RefreshReport();
        }
    }
}
