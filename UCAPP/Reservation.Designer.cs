
namespace UCAPP
{
    partial class Reservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.PeriodPicker = new System.Windows.Forms.DateTimePicker();
            this.SejourLabel = new System.Windows.Forms.Label();
            this.BrandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.BrandPanel.Size = new System.Drawing.Size(425, 100);
            this.BrandPanel.TabIndex = 0;
            this.BrandPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BrandPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UCAPP.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnConfirmer);
            this.panel1.Controls.Add(this.PeriodPicker);
            this.panel1.Controls.Add(this.SejourLabel);
            this.panel1.Location = new System.Drawing.Point(13, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 257);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirmer.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmer.Location = new System.Drawing.Point(134, 178);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(132, 51);
            this.btnConfirmer.TabIndex = 2;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // PeriodPicker
            // 
            this.PeriodPicker.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodPicker.Location = new System.Drawing.Point(38, 78);
            this.PeriodPicker.Name = "PeriodPicker";
            this.PeriodPicker.Size = new System.Drawing.Size(200, 22);
            this.PeriodPicker.TabIndex = 1;
            // 
            // SejourLabel
            // 
            this.SejourLabel.AutoSize = true;
            this.SejourLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SejourLabel.Location = new System.Drawing.Point(33, 31);
            this.SejourLabel.Name = "SejourLabel";
            this.SejourLabel.Size = new System.Drawing.Size(207, 28);
            this.SejourLabel.TabIndex = 0;
            this.SejourLabel.Text = "Début de séjour";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BrandPanel);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.BrandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BrandPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker PeriodPicker;
        private System.Windows.Forms.Label SejourLabel;
        private System.Windows.Forms.Button btnConfirmer;
    }
}