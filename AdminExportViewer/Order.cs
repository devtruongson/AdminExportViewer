﻿using System;
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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_manage_rent_bikeDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this._manage_rent_bikeDataSet.Orders);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
