using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Client
{
    public partial class patientForm : Form
    {
        private static patientForm instance;
        Client.ServiceReference1.WebServiceSoapClient service = new Client.ServiceReference1.WebServiceSoapClient();

        private patientForm()
        {
            InitializeComponent();
            InitializeListBox();
        }

        public static patientForm getInstance() {
            if (instance == null) {
                instance = new patientForm();
            }
            return instance;
        }

        private void InitializeListBox() {
            List<string> list = service.getDataPatient();
            for (int i = 0; i < list.Count; i+=3) {
                patientsListBox.Items.Add(list[i] + " " + list[i+1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void patientsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = patientsListBox.SelectedIndex;
            phonePatientTextBox.Text = service.getDataPatient()[index * 3 + 2];
        }

        private void programmeButton_Click(object sender, EventArgs e)
        {
            if (addRadioButton.Checked)
            {
                service.addPatient(nameTextBox.Text, firstNameTextBox.Text, phoneTextBox.Text);
                patientsListBox.Items.Add(nameTextBox.Text + " " + firstNameTextBox.Text);
                phonePatientTextBox.Text = phoneTextBox.Text;
                nameTextBox.Text = "";
                firstNameTextBox.Text = "";
                phoneTextBox.Text = ""; 
            }
            else {
                if (updateRadioButton.Checked) {
                   service.updatePatient(patientsListBox.SelectedIndex, nameTextBox.Text, firstNameTextBox.Text, phoneTextBox.Text);
                   patientsListBox.Items[patientsListBox.SelectedIndex] = nameTextBox.Text + " " + firstNameTextBox.Text;
                   phonePatientTextBox.Text = phoneTextBox.Text;
                   nameTextBox.Text = "";
                   firstNameTextBox.Text = "";
                   phoneTextBox.Text = "";
                }
            }
        }
    }
}
