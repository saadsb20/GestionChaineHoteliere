
namespace UCAPP
{
    partial class Reserver
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
            this.BrandPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReservationPanel = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.PaysLabel = new System.Windows.Forms.Label();
            this.CodePostalLabel = new System.Windows.Forms.Label();
            this.VilleLabel = new System.Windows.Forms.Label();
            this.AdresseLabel = new System.Windows.Forms.Label();
            this.PrenomLabel = new System.Windows.Forms.Label();
            this.PrenomtextBox = new System.Windows.Forms.TextBox();
            this.AdressetextBox = new System.Windows.Forms.TextBox();
            this.Code_postaltextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.TelephonetextBox = new System.Windows.Forms.TextBox();
            this.PaystextBox = new System.Windows.Forms.TextBox();
            this.VilletextBox = new System.Windows.Forms.TextBox();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.NomLabel = new System.Windows.Forms.Label();
            this.BrandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ReservationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrandPanel
            // 
            this.BrandPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.BrandPanel.BackgroundImage = global::UCAPP.Properties.Resources.icon;
            this.BrandPanel.Controls.Add(this.pictureBox1);
            this.BrandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrandPanel.Location = new System.Drawing.Point(0, 0);
            this.BrandPanel.Name = "BrandPanel";
            this.BrandPanel.Size = new System.Drawing.Size(502, 100);
            this.BrandPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UCAPP.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReservationPanel
            // 
            this.ReservationPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ReservationPanel.Controls.Add(this.btnSubmit);
            this.ReservationPanel.Controls.Add(this.EmailLabel);
            this.ReservationPanel.Controls.Add(this.TelephoneLabel);
            this.ReservationPanel.Controls.Add(this.PaysLabel);
            this.ReservationPanel.Controls.Add(this.CodePostalLabel);
            this.ReservationPanel.Controls.Add(this.VilleLabel);
            this.ReservationPanel.Controls.Add(this.AdresseLabel);
            this.ReservationPanel.Controls.Add(this.PrenomLabel);
            this.ReservationPanel.Controls.Add(this.PrenomtextBox);
            this.ReservationPanel.Controls.Add(this.AdressetextBox);
            this.ReservationPanel.Controls.Add(this.Code_postaltextBox);
            this.ReservationPanel.Controls.Add(this.EmailtextBox);
            this.ReservationPanel.Controls.Add(this.TelephonetextBox);
            this.ReservationPanel.Controls.Add(this.PaystextBox);
            this.ReservationPanel.Controls.Add(this.VilletextBox);
            this.ReservationPanel.Controls.Add(this.NomTextBox);
            this.ReservationPanel.Controls.Add(this.NomLabel);
            this.ReservationPanel.Location = new System.Drawing.Point(25, 106);
            this.ReservationPanel.Name = "ReservationPanel";
            this.ReservationPanel.Size = new System.Drawing.Size(449, 510);
            this.ReservationPanel.TabIndex = 1;
            this.ReservationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReservationPanel_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(157, 459);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 42);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Réserver";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(23, 367);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 23);
            this.EmailLabel.TabIndex = 32;
            this.EmailLabel.Text = "Email";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneLabel.Location = new System.Drawing.Point(237, 267);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(109, 23);
            this.TelephoneLabel.TabIndex = 31;
            this.TelephoneLabel.Text = "Telephone";
            // 
            // PaysLabel
            // 
            this.PaysLabel.AutoSize = true;
            this.PaysLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaysLabel.Location = new System.Drawing.Point(23, 267);
            this.PaysLabel.Name = "PaysLabel";
            this.PaysLabel.Size = new System.Drawing.Size(54, 23);
            this.PaysLabel.TabIndex = 30;
            this.PaysLabel.Text = "Pays";
            // 
            // CodePostalLabel
            // 
            this.CodePostalLabel.AutoSize = true;
            this.CodePostalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodePostalLabel.Location = new System.Drawing.Point(237, 185);
            this.CodePostalLabel.Name = "CodePostalLabel";
            this.CodePostalLabel.Size = new System.Drawing.Size(131, 23);
            this.CodePostalLabel.TabIndex = 29;
            this.CodePostalLabel.Text = "Code postal";
            // 
            // VilleLabel
            // 
            this.VilleLabel.AutoSize = true;
            this.VilleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VilleLabel.Location = new System.Drawing.Point(23, 185);
            this.VilleLabel.Name = "VilleLabel";
            this.VilleLabel.Size = new System.Drawing.Size(65, 23);
            this.VilleLabel.TabIndex = 28;
            this.VilleLabel.Text = "Ville";
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseLabel.Location = new System.Drawing.Point(23, 100);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(87, 23);
            this.AdresseLabel.TabIndex = 27;
            this.AdresseLabel.Text = "Adresse";
            // 
            // PrenomLabel
            // 
            this.PrenomLabel.AutoSize = true;
            this.PrenomLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomLabel.Location = new System.Drawing.Point(237, 9);
            this.PrenomLabel.Name = "PrenomLabel";
            this.PrenomLabel.Size = new System.Drawing.Size(76, 23);
            this.PrenomLabel.TabIndex = 26;
            this.PrenomLabel.Text = "Prénom";
            // 
            // PrenomtextBox
            // 
            this.PrenomtextBox.Location = new System.Drawing.Point(241, 35);
            this.PrenomtextBox.Name = "PrenomtextBox";
            this.PrenomtextBox.Size = new System.Drawing.Size(184, 22);
            this.PrenomtextBox.TabIndex = 25;
            // 
            // AdressetextBox
            // 
            this.AdressetextBox.Location = new System.Drawing.Point(27, 126);
            this.AdressetextBox.Name = "AdressetextBox";
            this.AdressetextBox.Size = new System.Drawing.Size(398, 22);
            this.AdressetextBox.TabIndex = 24;
            // 
            // Code_postaltextBox
            // 
            this.Code_postaltextBox.Location = new System.Drawing.Point(241, 211);
            this.Code_postaltextBox.Name = "Code_postaltextBox";
            this.Code_postaltextBox.Size = new System.Drawing.Size(184, 22);
            this.Code_postaltextBox.TabIndex = 23;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(27, 404);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(398, 22);
            this.EmailtextBox.TabIndex = 22;
            // 
            // TelephonetextBox
            // 
            this.TelephonetextBox.Location = new System.Drawing.Point(241, 302);
            this.TelephonetextBox.Name = "TelephonetextBox";
            this.TelephonetextBox.Size = new System.Drawing.Size(184, 22);
            this.TelephonetextBox.TabIndex = 21;
            // 
            // PaystextBox
            // 
            this.PaystextBox.Location = new System.Drawing.Point(27, 302);
            this.PaystextBox.Name = "PaystextBox";
            this.PaystextBox.Size = new System.Drawing.Size(174, 22);
            this.PaystextBox.TabIndex = 20;
            // 
            // VilletextBox
            // 
            this.VilletextBox.Location = new System.Drawing.Point(27, 211);
            this.VilletextBox.Name = "VilletextBox";
            this.VilletextBox.Size = new System.Drawing.Size(174, 22);
            this.VilletextBox.TabIndex = 19;
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(27, 35);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(174, 22);
            this.NomTextBox.TabIndex = 18;
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLabel.Location = new System.Drawing.Point(23, 9);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(43, 23);
            this.NomLabel.TabIndex = 17;
            this.NomLabel.Text = "Nom";
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 628);
            this.Controls.Add(this.ReservationPanel);
            this.Controls.Add(this.BrandPanel);
            this.Name = "Reserver";
            this.Text = "Reserver";
            this.Load += new System.EventHandler(this.Reserver_Load);
            this.BrandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ReservationPanel.ResumeLayout(false);
            this.ReservationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BrandPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ReservationPanel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label PaysLabel;
        private System.Windows.Forms.Label CodePostalLabel;
        private System.Windows.Forms.Label VilleLabel;
        private System.Windows.Forms.Label AdresseLabel;
        private System.Windows.Forms.Label PrenomLabel;
        private System.Windows.Forms.TextBox PrenomtextBox;
        private System.Windows.Forms.TextBox AdressetextBox;
        private System.Windows.Forms.TextBox Code_postaltextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox TelephonetextBox;
        private System.Windows.Forms.TextBox PaystextBox;
        private System.Windows.Forms.TextBox VilletextBox;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Label NomLabel;
    }
}