namespace UCAPP
{
    partial class ucHotel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.AdresseLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.EtoilesPanel = new System.Windows.Forms.Panel();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(27, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 33);
            this.label.TabIndex = 0;
            this.label.Text = "HotelName";
            // 
            // AdresseLabel
            // 
            this.AdresseLabel.AutoSize = true;
            this.AdresseLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdresseLabel.Location = new System.Drawing.Point(26, 54);
            this.AdresseLabel.Name = "AdresseLabel";
            this.AdresseLabel.Size = new System.Drawing.Size(76, 23);
            this.AdresseLabel.TabIndex = 2;
            this.AdresseLabel.Text = "label1";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TelephoneLabel.Location = new System.Drawing.Point(29, 91);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(76, 23);
            this.TelephoneLabel.TabIndex = 3;
            this.TelephoneLabel.Text = "label1";
            // 
            // EtoilesPanel
            // 
            this.EtoilesPanel.Location = new System.Drawing.Point(247, 126);
            this.EtoilesPanel.Name = "EtoilesPanel";
            this.EtoilesPanel.Size = new System.Drawing.Size(280, 60);
            this.EtoilesPanel.TabIndex = 6;
            // 
            // btnConsulter
            // 
            this.btnConsulter.Location = new System.Drawing.Point(681, 53);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(130, 61);
            this.btnConsulter.TabIndex = 7;
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.UseVisualStyleBackColor = true;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.EtoilesPanel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.AdresseLabel);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(835, 199);
            this.Load += new System.EventHandler(this.ucHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label AdresseLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Panel EtoilesPanel;
        private System.Windows.Forms.Button btnConsulter;
    }
}
