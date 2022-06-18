
namespace UCAPP
{
    partial class Accueil
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
            this.Hotelspanel = new System.Windows.Forms.Panel();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.Brand_Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brand_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Hotelspanel
            // 
            this.Hotelspanel.AutoScroll = true;
            this.Hotelspanel.Location = new System.Drawing.Point(673, 9);
            this.Hotelspanel.Name = "Hotelspanel";
            this.Hotelspanel.Size = new System.Drawing.Size(449, 565);
            this.Hotelspanel.TabIndex = 1;
            this.Hotelspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Hotelspanel_Paint);
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.AutoScroll = true;
            this.RoomsPanel.Location = new System.Drawing.Point(239, 9);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(403, 562);
            this.RoomsPanel.TabIndex = 0;
            this.RoomsPanel.Visible = false;
            // 
            // Brand_Panel
            // 
            this.Brand_Panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.Brand_Panel.BackgroundImage = global::UCAPP.Properties.Resources.icon;
            this.Brand_Panel.Controls.Add(this.pictureBox2);
            this.Brand_Panel.Controls.Add(this.label1);
            this.Brand_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Brand_Panel.Location = new System.Drawing.Point(0, 0);
            this.Brand_Panel.Name = "Brand_Panel";
            this.Brand_Panel.Size = new System.Drawing.Size(223, 586);
            this.Brand_Panel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UCAPP.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotels Agency";
            // 
            // Accueil
            // 
            this.ClientSize = new System.Drawing.Size(1147, 586);
            this.Controls.Add(this.RoomsPanel);
            this.Controls.Add(this.Brand_Panel);
            this.Controls.Add(this.Hotelspanel);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.Brand_Panel.ResumeLayout(false);
            this.Brand_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Accueilpanel;
        private System.Windows.Forms.Label Accueillabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private  System.Windows.Forms.Panel Hotelspanel;
        private System.Windows.Forms.Panel Brand_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private  System.Windows.Forms.Panel RoomsPanel;
    }
}