namespace CinemaFlix_Apps.Main_Page.Pages
{
    partial class MasterCinema
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cinemaNameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label totalStudiosLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aksi1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aksi2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cinemaNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.totalStudiosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cinemaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStudiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            cinemaNameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            totalStudiosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalStudiosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinemaNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.totalStudiosDataGridViewTextBoxColumn,
            this.aksi1,
            this.aksi2});
            this.dataGridView1.DataSource = this.cinemasBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 431);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aksi1
            // 
            this.aksi1.HeaderText = "Action 1";
            this.aksi1.Name = "aksi1";
            this.aksi1.ReadOnly = true;
            // 
            // aksi2
            // 
            this.aksi2.HeaderText = "Action 2";
            this.aksi2.Name = "aksi2";
            this.aksi2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(addressLabel);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(cinemaNameLabel);
            this.panel2.Controls.Add(this.cinemaNameTextBox);
            this.panel2.Controls.Add(cityLabel);
            this.panel2.Controls.Add(this.cityTextBox);
            this.panel2.Controls.Add(phoneNumberLabel);
            this.panel2.Controls.Add(this.phoneNumberTextBox);
            this.panel2.Controls.Add(totalStudiosLabel);
            this.panel2.Controls.Add(this.totalStudiosNumericUpDown);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 524);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(777, 205);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(777, 73);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Cinemas Will Be Displayed Here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(560, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema Management";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(363, 30);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinemasBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(450, 27);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(202, 65);
            this.addressTextBox.TabIndex = 9;
            // 
            // cinemaNameLabel
            // 
            cinemaNameLabel.AutoSize = true;
            cinemaNameLabel.Location = new System.Drawing.Point(3, 30);
            cinemaNameLabel.Name = "cinemaNameLabel";
            cinemaNameLabel.Size = new System.Drawing.Size(76, 13);
            cinemaNameLabel.TabIndex = 10;
            cinemaNameLabel.Text = "Cinema Name:";
            // 
            // cinemaNameTextBox
            // 
            this.cinemaNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinemasBindingSource, "CinemaName", true));
            this.cinemaNameTextBox.Location = new System.Drawing.Point(90, 27);
            this.cinemaNameTextBox.Name = "cinemaNameTextBox";
            this.cinemaNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.cinemaNameTextBox.TabIndex = 11;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(3, 56);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 12;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinemasBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(90, 53);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(203, 20);
            this.cityTextBox.TabIndex = 13;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(3, 82);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 14;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cinemasBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(90, 79);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(203, 20);
            this.phoneNumberTextBox.TabIndex = 15;
            // 
            // totalStudiosLabel
            // 
            totalStudiosLabel.AutoSize = true;
            totalStudiosLabel.Location = new System.Drawing.Point(3, 105);
            totalStudiosLabel.Name = "totalStudiosLabel";
            totalStudiosLabel.Size = new System.Drawing.Size(72, 13);
            totalStudiosLabel.TabIndex = 16;
            totalStudiosLabel.Text = "Total Studios:";
            // 
            // totalStudiosNumericUpDown
            // 
            this.totalStudiosNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cinemasBindingSource, "TotalStudios", true));
            this.totalStudiosNumericUpDown.Location = new System.Drawing.Point(90, 105);
            this.totalStudiosNumericUpDown.Name = "totalStudiosNumericUpDown";
            this.totalStudiosNumericUpDown.Size = new System.Drawing.Size(203, 20);
            this.totalStudiosNumericUpDown.TabIndex = 17;
            // 
            // cinemaNameDataGridViewTextBoxColumn
            // 
            this.cinemaNameDataGridViewTextBoxColumn.DataPropertyName = "CinemaName";
            this.cinemaNameDataGridViewTextBoxColumn.HeaderText = "CinemaName";
            this.cinemaNameDataGridViewTextBoxColumn.Name = "cinemaNameDataGridViewTextBoxColumn";
            this.cinemaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalStudiosDataGridViewTextBoxColumn
            // 
            this.totalStudiosDataGridViewTextBoxColumn.DataPropertyName = "TotalStudios";
            this.totalStudiosDataGridViewTextBoxColumn.HeaderText = "TotalStudios";
            this.totalStudiosDataGridViewTextBoxColumn.Name = "totalStudiosDataGridViewTextBoxColumn";
            this.totalStudiosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinemasBindingSource1
            // 
            this.cinemasBindingSource1.DataSource = typeof(CinemaFlix_Apps.Cinemas);
            // 
            // cinemasBindingSource
            // 
            this.cinemasBindingSource.DataSource = typeof(CinemaFlix_Apps.Cinemas);
            // 
            // MasterCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MasterCinema";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "MasterCinema";
            this.Load += new System.EventHandler(this.MasterCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalStudiosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinemaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalStudiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn aksi1;
        private System.Windows.Forms.DataGridViewButtonColumn aksi2;
        private System.Windows.Forms.BindingSource cinemasBindingSource;
        private System.Windows.Forms.BindingSource cinemasBindingSource1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cinemaNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.NumericUpDown totalStudiosNumericUpDown;
    }
}