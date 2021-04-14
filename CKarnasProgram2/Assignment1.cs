using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Click event for Area calculation

        private void btnArea_Click(object sender, EventArgs e)
        {
            Cone aCone = new Cone();

            lblResult.Text = aCone.CalculateArea(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString("N2");
        }

        // Click event for Volume calculation

        private void btnVolume_click(object sender, EventArgs e)
        {
            Cone aCone = new Cone();

            lblResult.Text = aCone.CalculateVolume(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString("N2");
        }

        // Click event to Exit form

        private void btnExit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
