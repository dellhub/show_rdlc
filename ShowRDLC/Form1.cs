using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRDLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrderID.Focus();
            //this.reportViewer.RefreshReport();
        }

        private void tbShowReport_Click(object sender, EventArgs e)
        {

            using (SellEntities db = new SellEntities())
            {
                GetOrderDetails_ResultBindingSource.DataSource = db.GetOrderDetails(int.Parse(tbOrderID.Text.ToString())).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParems = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("orderID",tbOrderID.Text.ToString())
                };
                reportViewer.LocalReport.SetParameters(rParems);
                this.reportViewer.RefreshReport();
            }

            lbWait.Text = "Complete!";
        }
    }
}
