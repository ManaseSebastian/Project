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
using System.Collections;
namespace Client
{
    public partial class priceForm : Form
    {
        Client.ServiceReference1.WebServiceSoapClient service = new Client.ServiceReference1.WebServiceSoapClient();
        private static priceForm instance;

        private priceForm()
        {
            InitializeComponent();
            InitializeDataGrid();

        }

        public static priceForm getInstance() {
            if (instance == null) {
                instance = new priceForm();
            }
            return instance;
        }

        private void InitializeDataGrid() {
            List<string> list = service.getDataPrice();
            for (int i = 0; i < list.Count; i+=3) {
                string[] columns = new string[3];
                columns[0] = list[i];
                columns[1] = list[i + 1];
                columns[2] = list[i + 2];
                priceDataGridView.Rows.Add(columns);
            }
        }

        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            crudPanel.Show();
        }

        private void deleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            crudPanel.Hide();
        }

        private void updateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            crudPanel.Show();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
           
            if (addRadioButton.Checked)
            {
                service.addPrice(nameTextBox.Text, typeTextBox.Text.ToUpper(), Convert.ToDouble(priceTextBox.Text));
                string[] row = { nameTextBox.Text, typeTextBox.Text.ToUpper(), priceTextBox.Text };
                priceDataGridView.Rows.Add(row);
                nameTextBox.Text = "";
                typeTextBox.Text = "";
                priceTextBox.Text = "";
            }
            else {
                try
                {
                    if (updateRadioButton.Checked)
                    {
                        service.updatePrice(priceDataGridView.SelectedCells[0].Value.ToString(), nameTextBox.Text, typeTextBox.Text.ToUpper(), Convert.ToDouble(priceTextBox.Text));
                        string[] row = { nameTextBox.Text, typeTextBox.Text.ToUpper(), priceTextBox.Text };
                        priceDataGridView.SelectedRows[0].SetValues(row);
                    }
                    else
                    {
                        if (deleteRadioButton.Checked)
                        {
                            service.deletePrice(priceDataGridView.SelectedCells[0].Value.ToString());
                            priceDataGridView.Rows.Remove(priceDataGridView.SelectedRows[0]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Selectati intreaga linie!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
