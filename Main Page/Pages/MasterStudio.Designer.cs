namespace CinemaFlix_Apps.Main_Page.Pages
{
    partial class MasterStudio
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
            System.Windows.Forms.Label cinemaIDLabel;
            System.Windows.Forms.Label seatsPerRowLabel;
            System.Windows.Forms.Label studioNumberLabel;
            System.Windows.Forms.Label studioTypeLabel;
            System.Windows.Forms.Label totalRowsLabel;
            System.Windows.Forms.Label totalSeatsLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cinemasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRowsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsPerRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aksi2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studiosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cinemaNameComboBox = new System.Windows.Forms.ComboBox();
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatsPerRowTextBox = new System.Windows.Forms.TextBox();
            this.studioNumberTextBox = new System.Windows.Forms.TextBox();
            this.studioTypeComboBox = new System.Windows.Forms.ComboBox();
            this.totalRowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalSeatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cinemaIDLabel = new System.Windows.Forms.Label();
            seatsPerRowLabel = new System.Windows.Forms.Label();
            studioNumberLabel = new System.Windows.Forms.Label();
            studioTypeLabel = new System.Windows.Forms.Label();
            totalRowsLabel = new System.Windows.Forms.Label();
            totalSeatsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalRowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSeatsNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cinemaIDLabel
            // 
            cinemaIDLabel.AutoSize = true;
            cinemaIDLabel.Location = new System.Drawing.Point(327, 52);
            cinemaIDLabel.Name = "cinemaIDLabel";
            cinemaIDLabel.Size = new System.Drawing.Size(45, 13);
            cinemaIDLabel.TabIndex = 20;
            cinemaIDLabel.Text = "Cinema:";
            // 
            // seatsPerRowLabel
            // 
            seatsPerRowLabel.AutoSize = true;
            seatsPerRowLabel.Location = new System.Drawing.Point(3, 26);
            seatsPerRowLabel.Name = "seatsPerRowLabel";
            seatsPerRowLabel.Size = new System.Drawing.Size(81, 13);
            seatsPerRowLabel.TabIndex = 22;
            seatsPerRowLabel.Text = "Seats Per Row:";
            // 
            // studioNumberLabel
            // 
            studioNumberLabel.AutoSize = true;
            studioNumberLabel.Location = new System.Drawing.Point(3, 52);
            studioNumberLabel.Name = "studioNumberLabel";
            studioNumberLabel.Size = new System.Drawing.Size(80, 13);
            studioNumberLabel.TabIndex = 24;
            studioNumberLabel.Text = "Studio Number:";
            // 
            // studioTypeLabel
            // 
            studioTypeLabel.AutoSize = true;
            studioTypeLabel.Location = new System.Drawing.Point(3, 78);
            studioTypeLabel.Name = "studioTypeLabel";
            studioTypeLabel.Size = new System.Drawing.Size(67, 13);
            studioTypeLabel.TabIndex = 26;
            studioTypeLabel.Text = "Studio Type:";
            // 
            // totalRowsLabel
            // 
            totalRowsLabel.AutoSize = true;
            totalRowsLabel.Location = new System.Drawing.Point(3, 102);
            totalRowsLabel.Name = "totalRowsLabel";
            totalRowsLabel.Size = new System.Drawing.Size(64, 13);
            totalRowsLabel.TabIndex = 28;
            totalRowsLabel.Text = "Total Rows:";
            // 
            // totalSeatsLabel
            // 
            totalSeatsLabel.AutoSize = true;
            totalSeatsLabel.Location = new System.Drawing.Point(327, 26);
            totalSeatsLabel.Name = "totalSeatsLabel";
            totalSeatsLabel.Size = new System.Drawing.Size(64, 13);
            totalSeatsLabel.TabIndex = 30;
            totalSeatsLabel.Text = "Total Seats:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinemasDataGridViewTextBoxColumn,
            this.studioNumberDataGridViewTextBoxColumn,
            this.studioTypeDataGridViewTextBoxColumn,
            this.totalSeatsDataGridViewTextBoxColumn,
            this.totalRowsDataGridViewTextBoxColumn,
            this.seatsPerRowDataGridViewTextBoxColumn,
            this.aksi1,
            this.aksi2});
            this.dataGridView1.DataSource = this.studiosBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(828, 482);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // cinemasDataGridViewTextBoxColumn
            // 
            this.cinemasDataGridViewTextBoxColumn.DataPropertyName = "Cinemas";
            this.cinemasDataGridViewTextBoxColumn.HeaderText = "Cinema";
            this.cinemasDataGridViewTextBoxColumn.Name = "cinemasDataGridViewTextBoxColumn";
            this.cinemasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studioNumberDataGridViewTextBoxColumn
            // 
            this.studioNumberDataGridViewTextBoxColumn.DataPropertyName = "StudioNumber";
            this.studioNumberDataGridViewTextBoxColumn.HeaderText = "StudioNumber";
            this.studioNumberDataGridViewTextBoxColumn.Name = "studioNumberDataGridViewTextBoxColumn";
            this.studioNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studioTypeDataGridViewTextBoxColumn
            // 
            this.studioTypeDataGridViewTextBoxColumn.DataPropertyName = "StudioType";
            this.studioTypeDataGridViewTextBoxColumn.HeaderText = "StudioType";
            this.studioTypeDataGridViewTextBoxColumn.Name = "studioTypeDataGridViewTextBoxColumn";
            this.studioTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSeatsDataGridViewTextBoxColumn
            // 
            this.totalSeatsDataGridViewTextBoxColumn.DataPropertyName = "TotalSeats";
            this.totalSeatsDataGridViewTextBoxColumn.HeaderText = "TotalSeats";
            this.totalSeatsDataGridViewTextBoxColumn.Name = "totalSeatsDataGridViewTextBoxColumn";
            this.totalSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalRowsDataGridViewTextBoxColumn
            // 
            this.totalRowsDataGridViewTextBoxColumn.DataPropertyName = "TotalRows";
            this.totalRowsDataGridViewTextBoxColumn.HeaderText = "TotalRows";
            this.totalRowsDataGridViewTextBoxColumn.Name = "totalRowsDataGridViewTextBoxColumn";
            this.totalRowsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatsPerRowDataGridViewTextBoxColumn
            // 
            this.seatsPerRowDataGridViewTextBoxColumn.DataPropertyName = "SeatsPerRow";
            this.seatsPerRowDataGridViewTextBoxColumn.HeaderText = "SeatsPerRow";
            this.seatsPerRowDataGridViewTextBoxColumn.Name = "seatsPerRowDataGridViewTextBoxColumn";
            this.seatsPerRowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aksi1
            // 
            this.aksi1.HeaderText = "Action 1";
            this.aksi1.Name = "aksi1";
            this.aksi1.ReadOnly = true;
            this.aksi1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aksi1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // aksi2
            // 
            this.aksi2.HeaderText = "Action 2";
            this.aksi2.Name = "aksi2";
            this.aksi2.ReadOnly = true;
            // 
            // studiosBindingSource1
            // 
            this.studiosBindingSource1.DataSource = typeof(CinemaFlix_Apps.Studios);
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataSource = typeof(CinemaFlix_Apps.Studios);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cinemaNameComboBox);
            this.panel2.Controls.Add(cinemaIDLabel);
            this.panel2.Controls.Add(seatsPerRowLabel);
            this.panel2.Controls.Add(this.seatsPerRowTextBox);
            this.panel2.Controls.Add(studioNumberLabel);
            this.panel2.Controls.Add(this.studioNumberTextBox);
            this.panel2.Controls.Add(studioTypeLabel);
            this.panel2.Controls.Add(this.studioTypeComboBox);
            this.panel2.Controls.Add(totalRowsLabel);
            this.panel2.Controls.Add(this.totalRowsNumericUpDown);
            this.panel2.Controls.Add(totalSeatsLabel);
            this.panel2.Controls.Add(this.totalSeatsNumericUpDown);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 154);
            this.panel2.TabIndex = 4;
            // 
            // cinemaNameComboBox
            // 
            this.cinemaNameComboBox.DataSource = this.cinemasBindingSource;
            this.cinemaNameComboBox.DisplayMember = "CinemaName";
            this.cinemaNameComboBox.FormattingEnabled = true;
            this.cinemaNameComboBox.Location = new System.Drawing.Point(414, 49);
            this.cinemaNameComboBox.Name = "cinemaNameComboBox";
            this.cinemaNameComboBox.Size = new System.Drawing.Size(202, 21);
            this.cinemaNameComboBox.TabIndex = 32;
            this.cinemaNameComboBox.ValueMember = "CinemaID";
            // 
            // cinemasBindingSource
            // 
            this.cinemasBindingSource.DataSource = typeof(CinemaFlix_Apps.Cinemas);
            // 
            // seatsPerRowTextBox
            // 
            this.seatsPerRowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "SeatsPerRow", true));
            this.seatsPerRowTextBox.Location = new System.Drawing.Point(90, 23);
            this.seatsPerRowTextBox.Name = "seatsPerRowTextBox";
            this.seatsPerRowTextBox.Size = new System.Drawing.Size(202, 20);
            this.seatsPerRowTextBox.TabIndex = 23;
            // 
            // studioNumberTextBox
            // 
            this.studioNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "StudioNumber", true));
            this.studioNumberTextBox.Location = new System.Drawing.Point(90, 49);
            this.studioNumberTextBox.Name = "studioNumberTextBox";
            this.studioNumberTextBox.Size = new System.Drawing.Size(202, 20);
            this.studioNumberTextBox.TabIndex = 25;
            // 
            // studioTypeComboBox
            // 
            this.studioTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studiosBindingSource, "StudioType", true));
            this.studioTypeComboBox.FormattingEnabled = true;
            this.studioTypeComboBox.Items.AddRange(new object[] {
            "Regular",
            "Deluxe",
            "IMAX",
            "Premiere",
            "4DX"});
            this.studioTypeComboBox.Location = new System.Drawing.Point(90, 75);
            this.studioTypeComboBox.Name = "studioTypeComboBox";
            this.studioTypeComboBox.Size = new System.Drawing.Size(202, 21);
            this.studioTypeComboBox.TabIndex = 27;
            // 
            // totalRowsNumericUpDown
            // 
            this.totalRowsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studiosBindingSource, "TotalRows", true));
            this.totalRowsNumericUpDown.Location = new System.Drawing.Point(90, 102);
            this.totalRowsNumericUpDown.Name = "totalRowsNumericUpDown";
            this.totalRowsNumericUpDown.Size = new System.Drawing.Size(202, 20);
            this.totalRowsNumericUpDown.TabIndex = 29;
            // 
            // totalSeatsNumericUpDown
            // 
            this.totalSeatsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studiosBindingSource, "TotalSeats", true));
            this.totalSeatsNumericUpDown.Location = new System.Drawing.Point(414, 23);
            this.totalSeatsNumericUpDown.Name = "totalSeatsNumericUpDown";
            this.totalSeatsNumericUpDown.Size = new System.Drawing.Size(202, 20);
            this.totalSeatsNumericUpDown.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 73);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "All Studios Will Be Displayed Here";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(560, 31);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(200, 20);
            this.textBox9.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-4, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Studio Management";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataSource = typeof(CinemaFlix_Apps.Genres);
            // 
            // MasterStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(868, 749);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MasterStudio";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "MasterStudio";
            this.Load += new System.EventHandler(this.MasterStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalRowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSeatsNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinemasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRowsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsPerRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn aksi1;
        private System.Windows.Forms.DataGridViewButtonColumn aksi2;
        private System.Windows.Forms.BindingSource cinemasBindingSource;
        private System.Windows.Forms.BindingSource studiosBindingSource1;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private System.Windows.Forms.TextBox seatsPerRowTextBox;
        private System.Windows.Forms.TextBox studioNumberTextBox;
        private System.Windows.Forms.ComboBox studioTypeComboBox;
        private System.Windows.Forms.NumericUpDown totalRowsNumericUpDown;
        private System.Windows.Forms.NumericUpDown totalSeatsNumericUpDown;
        private System.Windows.Forms.ComboBox cinemaNameComboBox;
    }
}