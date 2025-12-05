namespace CinemaFlix_Apps.Main_Page
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showtimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showtimesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeShowtimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genresToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.cinemasToolStripMenuItem,
            this.studiosToolStripMenuItem,
            this.showtimesToolStripMenuItem,
            this.showtimesToolStripMenuItem1,
            this.changeShowtimesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // cinemasToolStripMenuItem
            // 
            this.cinemasToolStripMenuItem.Name = "cinemasToolStripMenuItem";
            this.cinemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cinemasToolStripMenuItem.Text = "Cinemas";
            this.cinemasToolStripMenuItem.Click += new System.EventHandler(this.cinemasToolStripMenuItem_Click);
            // 
            // studiosToolStripMenuItem
            // 
            this.studiosToolStripMenuItem.Name = "studiosToolStripMenuItem";
            this.studiosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.studiosToolStripMenuItem.Text = "Studios";
            this.studiosToolStripMenuItem.Click += new System.EventHandler(this.studiosToolStripMenuItem_Click);
            // 
            // showtimesToolStripMenuItem
            // 
            this.showtimesToolStripMenuItem.Name = "showtimesToolStripMenuItem";
            this.showtimesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.showtimesToolStripMenuItem.Text = "Promo Codes";
            this.showtimesToolStripMenuItem.Click += new System.EventHandler(this.showtimesToolStripMenuItem_Click);
            // 
            // showtimesToolStripMenuItem1
            // 
            this.showtimesToolStripMenuItem1.Name = "showtimesToolStripMenuItem1";
            this.showtimesToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.showtimesToolStripMenuItem1.Text = "Showtimes";
            this.showtimesToolStripMenuItem1.Click += new System.EventHandler(this.showtimesToolStripMenuItem1_Click);
            // 
            // changeShowtimesToolStripMenuItem
            // 
            this.changeShowtimesToolStripMenuItem.Name = "changeShowtimesToolStripMenuItem";
            this.changeShowtimesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.changeShowtimesToolStripMenuItem.Text = "Change Showtimes";
            this.changeShowtimesToolStripMenuItem.Click += new System.EventHandler(this.changeShowtimesToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showtimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showtimesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeShowtimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}