namespace SPTBackgroundManager
{
    partial class BackgroundManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundManager));
            this.btn_setLauncher = new System.Windows.Forms.Button();
            this.btn_setServer = new System.Windows.Forms.Button();
            this.btn_revert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_setLauncher
            // 
            this.btn_setLauncher.Location = new System.Drawing.Point(12, 12);
            this.btn_setLauncher.Name = "btn_setLauncher";
            this.btn_setLauncher.Size = new System.Drawing.Size(105, 36);
            this.btn_setLauncher.TabIndex = 0;
            this.btn_setLauncher.Text = "Set Launcher BG";
            this.btn_setLauncher.UseVisualStyleBackColor = true;
            this.btn_setLauncher.Click += new System.EventHandler(this.btn_setLauncher_Click);
            // 
            // btn_setServer
            // 
            this.btn_setServer.Location = new System.Drawing.Point(123, 12);
            this.btn_setServer.Name = "btn_setServer";
            this.btn_setServer.Size = new System.Drawing.Size(105, 36);
            this.btn_setServer.TabIndex = 1;
            this.btn_setServer.Text = "Set Server BG";
            this.btn_setServer.UseVisualStyleBackColor = true;
            this.btn_setServer.Click += new System.EventHandler(this.btn_setServer_Click);
            // 
            // btn_revert
            // 
            this.btn_revert.Location = new System.Drawing.Point(234, 12);
            this.btn_revert.Name = "btn_revert";
            this.btn_revert.Size = new System.Drawing.Size(105, 36);
            this.btn_revert.TabIndex = 2;
            this.btn_revert.Text = "Revert to Defaults";
            this.btn_revert.UseVisualStyleBackColor = true;
            this.btn_revert.Click += new System.EventHandler(this.btn_revert_Click);
            // 
            // BackgroundManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 63);
            this.Controls.Add(this.btn_revert);
            this.Controls.Add(this.btn_setServer);
            this.Controls.Add(this.btn_setLauncher);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "BackgroundManager";
            this.Text = "SPT Background Manager";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_setLauncher;
        private System.Windows.Forms.Button btn_setServer;
        private System.Windows.Forms.Button btn_revert;

        #endregion
    }
}