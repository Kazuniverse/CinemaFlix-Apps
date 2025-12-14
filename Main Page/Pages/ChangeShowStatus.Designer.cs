namespace CinemaFlix_Apps.Main_Page.Pages
{
    partial class ChangeShowStatus
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.showtimeStatusChangesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studiosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showtimeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showtimeStatusChangesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmodif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.showtimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cinemasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showtimesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showtimeStatusChangesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(416, 60);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 97);
            this.textBox5.TabIndex = 13;
            this.textBox5.Visible = false;
            // 
            // showtimeStatusChangesBindingSource
            // 
            this.showtimeStatusChangesBindingSource.DataSource = typeof(CinemaFlix_Apps.ShowtimeStatusChanges);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Remark";
            this.label7.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Studio";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            this.label4.Visible = false;
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
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Showtimes Will Be Displayed Here";
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
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Showtime Status Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studiosDataGridViewTextBoxColumn,
            this.showtimeCodeDataGridViewTextBoxColumn,
            this.moviesDataGridViewTextBoxColumn,
            this.showDateDataGridViewTextBoxColumn,
            this.showTimeDataGridViewTextBoxColumn,
            this.showtimeStatusChangesDataGridViewTextBoxColumn,
            this.lastmodif,
            this.aksi1});
            this.dataGridView1.DataSource = this.showtimesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 232);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // studiosDataGridViewTextBoxColumn
            // 
            this.studiosDataGridViewTextBoxColumn.DataPropertyName = "Studios";
            this.studiosDataGridViewTextBoxColumn.HeaderText = "Studios";
            this.studiosDataGridViewTextBoxColumn.Name = "studiosDataGridViewTextBoxColumn";
            this.studiosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showtimeCodeDataGridViewTextBoxColumn
            // 
            this.showtimeCodeDataGridViewTextBoxColumn.DataPropertyName = "ShowtimeCode";
            this.showtimeCodeDataGridViewTextBoxColumn.HeaderText = "ShowtimeCode";
            this.showtimeCodeDataGridViewTextBoxColumn.Name = "showtimeCodeDataGridViewTextBoxColumn";
            this.showtimeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moviesDataGridViewTextBoxColumn
            // 
            this.moviesDataGridViewTextBoxColumn.DataPropertyName = "Movies";
            this.moviesDataGridViewTextBoxColumn.HeaderText = "Movies";
            this.moviesDataGridViewTextBoxColumn.Name = "moviesDataGridViewTextBoxColumn";
            this.moviesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showDateDataGridViewTextBoxColumn
            // 
            this.showDateDataGridViewTextBoxColumn.DataPropertyName = "ShowDate";
            this.showDateDataGridViewTextBoxColumn.HeaderText = "ShowDate";
            this.showDateDataGridViewTextBoxColumn.Name = "showDateDataGridViewTextBoxColumn";
            this.showDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showTimeDataGridViewTextBoxColumn
            // 
            this.showTimeDataGridViewTextBoxColumn.DataPropertyName = "ShowTime";
            this.showTimeDataGridViewTextBoxColumn.HeaderText = "ShowTime";
            this.showTimeDataGridViewTextBoxColumn.Name = "showTimeDataGridViewTextBoxColumn";
            this.showTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showtimeStatusChangesDataGridViewTextBoxColumn
            // 
            this.showtimeStatusChangesDataGridViewTextBoxColumn.DataPropertyName = "ShowtimeStatusChanges";
            this.showtimeStatusChangesDataGridViewTextBoxColumn.HeaderText = "ShowtimeStatusChanges";
            this.showtimeStatusChangesDataGridViewTextBoxColumn.Name = "showtimeStatusChangesDataGridViewTextBoxColumn";
            this.showtimeStatusChangesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastmodif
            // 
            this.lastmodif.HeaderText = "LastModified";
            this.lastmodif.Name = "lastmodif";
            this.lastmodif.ReadOnly = true;
            // 
            // aksi1
            // 
            this.aksi1.HeaderText = "Action 1";
            this.aksi1.Name = "aksi1";
            this.aksi1.ReadOnly = true;
            // 
            // showtimesBindingSource
            // 
            this.showtimesBindingSource.DataSource = typeof(CinemaFlix_Apps.Showtimes);
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
            this.panel1.Size = new System.Drawing.Size(760, 73);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 325);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(760, 205);
            this.panel2.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cinemasBindingSource;
            this.comboBox2.DisplayMember = "CinemaName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(416, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "CinemaID";
            this.comboBox2.Visible = false;
            // 
            // cinemasBindingSource
            // 
            this.cinemasBindingSource.DataSource = typeof(CinemaFlix_Apps.Cinemas);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "On Schedule",
            "Cancelled",
            "Full",
            "Studio Changed"});
            this.comboBox1.Location = new System.Drawing.Point(68, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studiosBindingSource
            // 
            this.studiosBindingSource.DataSource = typeof(CinemaFlix_Apps.Studios);
            // 
            // showtimesBindingSource1
            // 
            this.showtimesBindingSource1.DataSource = typeof(CinemaFlix_Apps.Showtimes);
            // 
            // ChangeShowStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ChangeShowStatus";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ChangeShowStatus";
            this.Load += new System.EventHandler(this.ChangeShowStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showtimeStatusChangesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cinemasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource showtimesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studiosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showtimeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showtimeStatusChangesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodif;
        private System.Windows.Forms.DataGridViewButtonColumn aksi1;
        private System.Windows.Forms.BindingSource showtimeStatusChangesBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource studiosBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource showtimesBindingSource1;
        private System.Windows.Forms.BindingSource cinemasBindingSource;
    }
}