namespace Client
{
    partial class programmeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programmeForm));
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.treatmentComboBox = new System.Windows.Forms.ComboBox();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.clickButton = new System.Windows.Forms.Button();
            this.programmeTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.closePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.crudPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.closePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closePanel.Location = new System.Drawing.Point(0, 0);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(409, 31);
            this.closePanel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(369, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 22);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.crudPanel);
            this.panel1.Controls.Add(this.deleteRadioButton);
            this.panel1.Controls.Add(this.addRadioButton);
            this.panel1.Controls.Add(this.clickButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 213);
            this.panel1.TabIndex = 6;
            // 
            // crudPanel
            // 
            this.crudPanel.BackColor = System.Drawing.Color.Transparent;
            this.crudPanel.Controls.Add(this.label2);
            this.crudPanel.Controls.Add(this.dateTimePicker);
            this.crudPanel.Controls.Add(this.label1);
            this.crudPanel.Controls.Add(this.label4);
            this.crudPanel.Controls.Add(this.treatmentComboBox);
            this.crudPanel.Controls.Add(this.patientComboBox);
            this.crudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudPanel.Location = new System.Drawing.Point(0, 0);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(409, 123);
            this.crudPanel.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(92, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tratament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pacient";
            // 
            // treatmentComboBox
            // 
            this.treatmentComboBox.FormattingEnabled = true;
            this.treatmentComboBox.Location = new System.Drawing.Point(92, 44);
            this.treatmentComboBox.Name = "treatmentComboBox";
            this.treatmentComboBox.Size = new System.Drawing.Size(230, 24);
            this.treatmentComboBox.TabIndex = 10;
            this.treatmentComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treatmentComboBox_KeyPress);
            // 
            // patientComboBox
            // 
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(88, 9);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(174, 24);
            this.patientComboBox.TabIndex = 9;
            this.patientComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patientComboBox_KeyPress);
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRadioButton.Location = new System.Drawing.Point(110, 129);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(71, 21);
            this.deleteRadioButton.TabIndex = 7;
            this.deleteRadioButton.Text = "Sterge";
            this.deleteRadioButton.UseVisualStyleBackColor = false;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.deleteRadioButton_CheckedChanged_1);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.addRadioButton.Checked = true;
            this.addRadioButton.Location = new System.Drawing.Point(12, 129);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(78, 21);
            this.addRadioButton.TabIndex = 6;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Adauga";
            this.addRadioButton.UseVisualStyleBackColor = false;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged_1);
            // 
            // clickButton
            // 
            this.clickButton.BackColor = System.Drawing.Color.SkyBlue;
            this.clickButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clickButton.BackgroundImage")));
            this.clickButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clickButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clickButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clickButton.FlatAppearance.BorderSize = 0;
            this.clickButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clickButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clickButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clickButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clickButton.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.clickButton.Location = new System.Drawing.Point(0, 161);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(409, 52);
            this.clickButton.TabIndex = 5;
            this.clickButton.Text = "Click";
            this.clickButton.UseVisualStyleBackColor = false;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click_1);
            // 
            // programmeTreeView
            // 
            this.programmeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programmeTreeView.Location = new System.Drawing.Point(0, 244);
            this.programmeTreeView.Name = "programmeTreeView";
            this.programmeTreeView.Size = new System.Drawing.Size(409, 210);
            this.programmeTreeView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data/Ora";
            // 
            // programmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 454);
            this.Controls.Add(this.programmeTreeView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "programmeForm";
            this.Text = "Form4";
            this.closePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView programmeTreeView;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.ComboBox treatmentComboBox;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}