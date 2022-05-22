using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pricesButton_Click(object sender, EventArgs e)
        {
            priceForm.getInstance().Show();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            patientForm.getInstance().Show();
        }

        private void programmeButton_Click(object sender, EventArgs e)
        {
            programmeForm.getInstance().Show();
        }
    }
}
