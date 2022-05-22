namespace Client
{
    partial class priceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(priceForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.closePanel = new System.Windows.Forms.Panel();
            this.priceDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.crudPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Controls.Add(this.clickButton);
            this.mainPanel.Controls.Add(this.crudPanel);
            this.mainPanel.Controls.Add(this.updateRadioButton);
            this.mainPanel.Controls.Add(this.deleteRadioButton);
            this.mainPanel.Controls.Add(this.addRadioButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 182);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(482, 204);
            this.mainPanel.TabIndex = 2;
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.addRadioButton.Checked = true;
            this.addRadioButton.Location = new System.Drawing.Point(37, 33);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(78, 21);
            this.addRadioButton.TabIndex = 0;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Adauga";
            this.addRadioButton.UseVisualStyleBackColor = false;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.addRadioButton_CheckedChanged);
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRadioButton.Location = new System.Drawing.Point(37, 60);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(71, 21);
            this.deleteRadioButton.TabIndex = 1;
            this.deleteRadioButton.Text = "Sterge";
            this.deleteRadioButton.UseVisualStyleBackColor = false;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.deleteRadioButton_CheckedChanged);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.updateRadioButton.Location = new System.Drawing.Point(37, 87);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(81, 21);
            this.updateRadioButton.TabIndex = 2;
            this.updateRadioButton.Text = "Modifica";
            this.updateRadioButton.UseVisualStyleBackColor = false;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.updateRadioButton_CheckedChanged);
            // 
            // crudPanel
            // 
            this.crudPanel.BackColor = System.Drawing.Color.Transparent;
            this.crudPanel.Controls.Add(this.priceTextBox);
            this.crudPanel.Controls.Add(this.typeTextBox);
            this.crudPanel.Controls.Add(this.nameTextBox);
            this.crudPanel.Controls.Add(this.label3);
            this.crudPanel.Controls.Add(this.label2);
            this.crudPanel.Controls.Add(this.label1);
            this.crudPanel.Location = new System.Drawing.Point(198, 6);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(239, 136);
            this.crudPanel.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(84, 85);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(151, 22);
            this.priceTextBox.TabIndex = 14;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(84, 58);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(151, 22);
            this.typeTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 22);
            this.nameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Denumire";
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
            this.clickButton.Location = new System.Drawing.Point(0, 148);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(482, 56);
            this.clickButton.TabIndex = 10;
            this.clickButton.Text = "CLICK";
            this.clickButton.UseVisualStyleBackColor = false;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.closePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closePanel.Location = new System.Drawing.Point(0, 0);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(482, 31);
            this.closePanel.TabIndex = 3;
            // 
            // priceDataGridView
            // 
            this.priceDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.priceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.price});
            this.priceDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceDataGridView.Location = new System.Drawing.Point(0, 31);
            this.priceDataGridView.Name = "priceDataGridView";
            this.priceDataGridView.RowTemplate.Height = 24;
            this.priceDataGridView.Size = new System.Drawing.Size(482, 151);
            this.priceDataGridView.TabIndex = 4;
            // 
            // name
            // 
            this.name.HeaderText = "Denumire";
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.HeaderText = "Tip";
            this.type.Name = "type";
            // 
            // price
            // 
            this.price.HeaderText = "Pret";
            this.price.Name = "price";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(438, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 22);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 386);
            this.Controls.Add(this.priceDataGridView);
            this.Controls.Add(this.closePanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "priceForm";
            this.Text = "Tarife";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.closePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.DataGridView priceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button closeButton;
    }
}