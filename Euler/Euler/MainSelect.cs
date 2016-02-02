using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEulerProblem.Items.Add("1 - Multiples of 3 and 5");
            cmbEulerProblem.Items.Add("2 - Even Fibonacci numbers");
            cmbEulerProblem.Items.Add("3 - Largest Prime Factor");
            cmbEulerProblem.SelectedIndex = 0;

        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            String cmbString = cmbEulerProblem.Text.Substring(0, cmbEulerProblem.Text.Split('-').Length-1);
            int eulerNum = Int32.Parse(cmbString);
            Form EulerImpForm = new frEulerImplementation(eulerNum);
            EulerImpForm.Show();

        }
    }
}
