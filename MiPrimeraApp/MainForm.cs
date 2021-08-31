using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraApp
{
    public partial class MainForm : Form
    {
        Report rp;

        public MainForm()
        {
            InitializeComponent();
            rtbox_result.Clear();

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            btnReport.Hide();
            rtbox_result.Text += txtName.Text + " - " + rtbox_description.Text+"\n";  


        }

        private void CustomEvent(object sender, EventArgs e)
        {
            
            MessageBox.Show("" + ((MouseEventArgs)e).Location);
        }

        private void rtbox_result_TextChanged(object sender, EventArgs e)
        {
            if(rtbox_result.Lines.Length >= 5)
            {
                if (rp == null || rp.IsDisposed)
                {
                    rp = new Report();
                }

                rp.Show();
                rp.ShowReportInformation(rtbox_result.Text);

            }


        }
    }
}
