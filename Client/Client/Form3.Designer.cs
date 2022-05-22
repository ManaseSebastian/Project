namespace Client
{
    partial class patientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientForm));
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.patientsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.phonePatientTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.programmeButton = new System.Windows.Forms.Button();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Controls.Add(this.button1);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.closePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closePanel.Location = new System.Drawing.Point(0, 0);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(413, 31);
            this.closePanel.TabIndex = 4;
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
            this.closeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(438, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 22);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // patientsListBox
            // 
            this.patientsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.patientsListBox.FormattingEnabled = true;
            this.patientsListBox.ItemHeight = 16;
            this.patientsListBox.Location = new System.Drawing.Point(0, 31);
            this.patientsListBox.Name = "patientsListBox";
            this.patientsListBox.Size = new System.Drawing.Size(151, 392);
            this.patientsListBox.TabIndex = 5;
            this.patientsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.patientsListBox_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.phonePatientTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(151, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 106);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefon Pacient";
            // 
            // phonePatientTextBox
            // 
            this.phonePatientTextBox.Enabled = false;
            this.phonePatientTextBox.Location = new System.Drawing.Point(42, 55);
            this.phonePatientTextBox.Name = "phonePatientTextBox";
            this.phonePatientTextBox.Size = new System.Drawing.Size(152, 22);
            this.phonePatientTextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.programmeButton);
            this.panel2.Controls.Add(this.updateRadioButton);
            this.panel2.Controls.Add(this.addRadioButton);
            this.panel2.Controls.Add(this.phoneTextBox);
            this.panel2.Controls.Add(this.firstNameTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(151, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 286);
            this.panel2.TabIndex = 7;
            // 
            // programmeButton
            // 
            this.programmeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.programmeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("programmeButton.BackgroundImage")));
            this.programmeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.programmeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.programmeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.programmeButton.FlatAppearance.BorderSize = 0;
            this.programmeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.programmeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.programmeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.programmeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.programmeButton.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.programmeButton.Location = new System.Drawing.Point(0, 233);
            this.programmeButton.Name = "programmeButton";
            this.programmeButton.Size = new System.Drawing.Size(262, 53);
            this.programmeButton.TabIndex = 24;
            this.programmeButton.Text = "CLICK";
            this.programmeButton.UseVisualStyleBackColor = false;
            this.programmeButton.Click += new System.EventHandler(this.programmeButton_Click);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.updateRadioButton.Location = new System.Drawing.Point(127, 185);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(81, 21);
            this.updateRadioButton.TabIndex = 23;
            this.updateRadioButton.Text = "Modifica";
            this.updateRadioButton.UseVisualStyleBackColor = false;
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.addRadioButton.Checked = true;
            this.addRadioButton.Location = new System.Drawing.Point(24, 185);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(78, 21);
            this.addRadioButton.TabIndex = 22;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Adauga";
            this.addRadioButton.UseVisualStyleBackColor = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(43, 142);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(151, 22);
            this.phoneTextBox.TabIndex = 20;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(43, 89);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 22);
            this.firstNameTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(43, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 22);
            this.nameTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nume";
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientsListBox);
            this.Controls.Add(this.closePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patientForm";
            this.Text = "Pacienti";
            this.closePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox patientsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox phonePatientTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.Button programmeButton;
    }
}