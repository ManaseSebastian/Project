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
    public partial class programmeForm : Form
    {
        private static programmeForm instance;
        Client.ServiceReference1.WebServiceSoapClient service = new Client.ServiceReference1.WebServiceSoapClient();

        private programmeForm()
        {
            InitializeComponent();
            InitializeTreeView();
            InitializePatientComboBox();
            InitializeTreatmentComboBox();
            dateTimePicker.MinDate = DateTime.Today;
            dateTimePicker.MaxDate = new DateTime(2024, 1, 1);
        }

        public static programmeForm getInstance() {
            if (instance == null) {
                instance = new programmeForm();
            }
            return instance;
        }

        private void InitializeTreeView()
        {   
            try
            {
                List<string> listData = service.getDataProgramme();
                List<string> listName = service.getNameProgramme();
                List<string> listPrice = service.getPriceProgramme();
                List<string> list = new List<string>();

                for (int i = 0; i < listData.Count; i++)
                {
                    string[] subset = listData[i].Split(' ');
                    list.Add(subset[0] + " " + listName[i] + " " + subset[1] + " " + listPrice[i]);
                }
                list.Sort();

                listData.Sort();
                programmeTreeView.BeginUpdate();
                string element1 = "";
                for (int i = 0; i < listData.Count; i++)
                {
                    string[] subset = listData[i].Split(' ');
                    if (subset[0] != element1)
                    {
                        programmeTreeView.Nodes.Add(subset[0]);
                    }
                    element1 = subset[0];
                }

                for (int i = 0; i < list.Count; i++)
                {
                    string[] subset1 = list[i].Split(' ');
                    foreach (TreeNode element in programmeTreeView.Nodes)
                    {
                        string[] subset2 = element.ToString().Split(' ');
                        if (subset2[1] == subset1[0])
                        {
                            int index = programmeTreeView.Nodes.IndexOf(element);
                            string s = "";
                            for (int j = 1; j < subset1.Length; j++)
                            {
                                s = s + subset1[j] + " ";
                            }
                            programmeTreeView.Nodes[index].Nodes.Add(s);
                        }
                    }
                }

                programmeTreeView.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void InitializePatientComboBox()
        {
            List<string> list = service.getDataPatient();
            for (int i = 0; i < list.Count; i+=3) {
                patientComboBox.Items.Add(list[i] + " " + list[i+1]);
            }
        }

        private void InitializeTreatmentComboBox()
        {
            List<string> list = service.getDataPrice();
            for (int i = 0; i < list.Count; i += 3)
            {
                treatmentComboBox.Items.Add(list[i]);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clickButton_Click_1(object sender, EventArgs e)
        {
            if (addRadioButton.Checked)
            {
                string[] names = patientComboBox.Text.Split(' ');

                service.addProgramme(treatmentComboBox.Text, names[0], names[1], dateTimePicker.Value);
                string[] dateTime = dateTimePicker.Value.ToString().Split(' ');
                string s = names[0] + " " + names[1] + " " + dateTime[1] + " " + treatmentComboBox.Text;
                int index = -1;
                programmeTreeView.BeginUpdate();
                foreach (TreeNode element in programmeTreeView.Nodes)
                {
                    string[] subset2 = element.ToString().Split(' ');
                    if (subset2[1] == dateTime[0])
                    {
                        index = programmeTreeView.Nodes.IndexOf(element);
                        programmeTreeView.Nodes[index].Nodes.Add(s);
                        break;
                    }
                }

                if (index < 0)
                {
                    TreeNode node = new TreeNode(dateTime[0]);
                    node.Nodes.Add(s);
                    programmeTreeView.Nodes.Add(node);
                    programmeTreeView.Sort();
                }
                programmeTreeView.EndUpdate();
            }
            else
            {
                if (deleteRadioButton.Checked)
                {
                    try
                    {
                        string s = programmeTreeView.SelectedNode.ToString();
                        string[] subset = s.Split(' ');
                        service.deleteProgramme(subset[1], subset[2]);
                        programmeTreeView.Nodes.Remove(programmeTreeView.SelectedNode);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Selectati ora programarii pentru stergere");
                    }
                }
            }
        }

        private void addRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            crudPanel.Show();
        }

        private void deleteRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            crudPanel.Hide();
        }

        private void patientComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void treatmentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
