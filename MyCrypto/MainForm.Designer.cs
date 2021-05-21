
namespace MyCrypto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CryptoList = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelLoading = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.CryptoWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // CryptoList
            // 
            this.CryptoList.AutoScroll = true;
            this.CryptoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryptoList.Location = new System.Drawing.Point(0, 0);
            this.CryptoList.Name = "CryptoList";
            this.CryptoList.Size = new System.Drawing.Size(1004, 561);
            this.CryptoList.TabIndex = 0;
            // 
            // PanelLoading
            // 
            this.PanelLoading.Controls.Add(this.progressBar1);
            this.PanelLoading.Controls.Add(this.label1);
            this.PanelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLoading.Location = new System.Drawing.Point(0, 0);
            this.PanelLoading.Name = "PanelLoading";
            this.PanelLoading.Size = new System.Drawing.Size(1004, 561);
            this.PanelLoading.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(343, 306);
            this.progressBar1.MarqueeAnimationSpeed = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(319, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading data. Please wait...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CryptoWorker
            // 
            this.CryptoWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CryptoWorker_DoWork);
            this.CryptoWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CryptoWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.PanelLoading);
            this.Controls.Add(this.CryptoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCrypto";
            this.PanelLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CryptoList;
        private System.Windows.Forms.Panel PanelLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker CryptoWorker;
    }
}

