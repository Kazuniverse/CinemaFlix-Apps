namespace CinemaFlix_Apps.Main_Page.Pages
{
    partial class MasterPromoCode
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.promoCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validUntilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.aksi2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.promoCodesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.promoCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoCodesBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promoCodesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.promoCodeDataGridViewTextBoxColumn,
            this.discountPercentageDataGridViewTextBoxColumn,
            this.maxDiscountDataGridViewTextBoxColumn,
            this.validFromDataGridViewTextBoxColumn,
            this.validUntilDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.aksi1,
            this.aksi2});
            this.dataGridView1.DataSource = this.promoCodesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 229);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // promoCodeDataGridViewTextBoxColumn
            // 
            this.promoCodeDataGridViewTextBoxColumn.DataPropertyName = "PromoCode";
            this.promoCodeDataGridViewTextBoxColumn.FillWeight = 102.7146F;
            this.promoCodeDataGridViewTextBoxColumn.HeaderText = "PromoCode";
            this.promoCodeDataGridViewTextBoxColumn.Name = "promoCodeDataGridViewTextBoxColumn";
            this.promoCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountPercentageDataGridViewTextBoxColumn
            // 
            this.discountPercentageDataGridViewTextBoxColumn.DataPropertyName = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.FillWeight = 100.1692F;
            this.discountPercentageDataGridViewTextBoxColumn.HeaderText = "DiscountPercentage";
            this.discountPercentageDataGridViewTextBoxColumn.Name = "discountPercentageDataGridViewTextBoxColumn";
            this.discountPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDiscountDataGridViewTextBoxColumn
            // 
            this.maxDiscountDataGridViewTextBoxColumn.DataPropertyName = "MaxDiscount";
            this.maxDiscountDataGridViewTextBoxColumn.FillWeight = 100.388F;
            this.maxDiscountDataGridViewTextBoxColumn.HeaderText = "MaxDiscount";
            this.maxDiscountDataGridViewTextBoxColumn.Name = "maxDiscountDataGridViewTextBoxColumn";
            this.maxDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validFromDataGridViewTextBoxColumn
            // 
            this.validFromDataGridViewTextBoxColumn.DataPropertyName = "ValidFrom";
            this.validFromDataGridViewTextBoxColumn.FillWeight = 99.82896F;
            this.validFromDataGridViewTextBoxColumn.HeaderText = "ValidFrom";
            this.validFromDataGridViewTextBoxColumn.Name = "validFromDataGridViewTextBoxColumn";
            this.validFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validUntilDataGridViewTextBoxColumn
            // 
            this.validUntilDataGridViewTextBoxColumn.DataPropertyName = "ValidUntil";
            this.validUntilDataGridViewTextBoxColumn.FillWeight = 98.33749F;
            this.validUntilDataGridViewTextBoxColumn.HeaderText = "ValidUntil";
            this.validUntilDataGridViewTextBoxColumn.Name = "validUntilDataGridViewTextBoxColumn";
            this.validUntilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 99.51284F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aksi1
            // 
            this.aksi1.FillWeight = 98.63063F;
            this.aksi1.HeaderText = "Action 1";
            this.aksi1.Name = "aksi1";
            this.aksi1.ReadOnly = true;
            // 
            // aksi2
            // 
            this.aksi2.FillWeight = 100.4184F;
            this.aksi2.HeaderText = "Action 2";
            this.aksi2.Name = "aksi2";
            this.aksi2.ReadOnly = true;
            // 
            // promoCodesBindingSource1
            // 
            this.promoCodesBindingSource1.DataSource = typeof(CinemaFlix_Apps.PromoCodes);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 73);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "All Promo Codes Will Be Displayed Here";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(560, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Promo Code Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Discount Percentage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 53;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 54;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Max Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Promo Code";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.promoCodesBindingSource, "PromoCode", true));
            this.textBox4.Location = new System.Drawing.Point(116, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 56;
            // 
            // promoCodesBindingSource
            // 
            this.promoCodesBindingSource.DataSource = typeof(CinemaFlix_Apps.PromoCodes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Valid From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Valid Until";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Description";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.promoCodesBindingSource, "Description", true));
            this.textBox8.Location = new System.Drawing.Point(442, 23);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 86);
            this.textBox8.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 208);
            this.panel2.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.promoCodesBindingSource, "ValidUntil", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 69;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.promoCodesBindingSource, "ValidFrom", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.promoCodesBindingSource, "MaxDiscount", true));
            this.numericUpDown2.Location = new System.Drawing.Point(116, 57);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown2.TabIndex = 67;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.promoCodesBindingSource, "DiscountPercentage", true));
            this.numericUpDown1.Location = new System.Drawing.Point(116, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 66;
            // 
            // MasterPromoCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MasterPromoCode";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "MasterPromoCode";
            this.Load += new System.EventHandler(this.MasterPromoCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promoCodesBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promoCodesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn promoCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validUntilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn aksi1;
        private System.Windows.Forms.DataGridViewButtonColumn aksi2;
        private System.Windows.Forms.BindingSource promoCodesBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource promoCodesBindingSource1;
    }
}