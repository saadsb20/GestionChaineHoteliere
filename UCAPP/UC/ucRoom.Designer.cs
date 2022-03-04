namespace UCAPP.UC
{
    partial class ucRoom
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
            this.components = new System.ComponentModel.Container();
            this.lbNum = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.réserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nettoyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.ForeColor = System.Drawing.Color.Blue;
            this.lbNum.Location = new System.Drawing.Point(5, 2);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(36, 38);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "1";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réserverToolStripMenuItem,
            this.libérerToolStripMenuItem,
            this.nettoyerToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(271, 150);
            // 
            // réserverToolStripMenuItem
            // 
            this.réserverToolStripMenuItem.Name = "réserverToolStripMenuItem";
            this.réserverToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.réserverToolStripMenuItem.Text = "Réserver";
            this.réserverToolStripMenuItem.Click += new System.EventHandler(this.réserverToolStripMenuItem_Click);
            // 
            // libérerToolStripMenuItem
            // 
            this.libérerToolStripMenuItem.Name = "libérerToolStripMenuItem";
            this.libérerToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.libérerToolStripMenuItem.Text = "Libérer";
            this.libérerToolStripMenuItem.Click += new System.EventHandler(this.libérerToolStripMenuItem_Click);
            // 
            // nettoyerToolStripMenuItem
            // 
            this.nettoyerToolStripMenuItem.Name = "nettoyerToolStripMenuItem";
            this.nettoyerToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.nettoyerToolStripMenuItem.Text = "Info";
            this.nettoyerToolStripMenuItem.Click += new System.EventHandler(this.nettoyerToolStripMenuItem_Click);
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.lbNum);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(247, 88);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem réserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nettoyerToolStripMenuItem;
    }
}
