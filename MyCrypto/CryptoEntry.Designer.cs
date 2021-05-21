
namespace MyCrypto
{
    partial class CryptoEntry
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
            this.ImgCrypto = new System.Windows.Forms.PictureBox();
            this.LabelCrypto = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ImgGraph = new System.Windows.Forms.PictureBox();
            this.LabelMarketCap = new System.Windows.Forms.Label();
            this.LabelAcronym = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCrypto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgCrypto
            // 
            this.ImgCrypto.Location = new System.Drawing.Point(6, 20);
            this.ImgCrypto.Name = "ImgCrypto";
            this.ImgCrypto.Size = new System.Drawing.Size(32, 32);
            this.ImgCrypto.TabIndex = 1;
            this.ImgCrypto.TabStop = false;
            // 
            // LabelCrypto
            // 
            this.LabelCrypto.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCrypto.Location = new System.Drawing.Point(44, 12);
            this.LabelCrypto.Name = "LabelCrypto";
            this.LabelCrypto.Size = new System.Drawing.Size(120, 23);
            this.LabelCrypto.TabIndex = 2;
            this.LabelCrypto.Text = "name";
            this.LabelCrypto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPrice
            // 
            this.LabelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPrice.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(331, 12);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPrice.Size = new System.Drawing.Size(142, 20);
            this.LabelPrice.TabIndex = 3;
            this.LabelPrice.Text = "price";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImgGraph
            // 
            this.ImgGraph.Location = new System.Drawing.Point(165, 12);
            this.ImgGraph.Name = "ImgGraph";
            this.ImgGraph.Size = new System.Drawing.Size(164, 48);
            this.ImgGraph.TabIndex = 4;
            this.ImgGraph.TabStop = false;
            // 
            // LabelMarketCap
            // 
            this.LabelMarketCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMarketCap.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMarketCap.Location = new System.Drawing.Point(331, 40);
            this.LabelMarketCap.Name = "LabelMarketCap";
            this.LabelMarketCap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelMarketCap.Size = new System.Drawing.Size(142, 20);
            this.LabelMarketCap.TabIndex = 5;
            this.LabelMarketCap.Text = "market cap";
            this.LabelMarketCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAcronym
            // 
            this.LabelAcronym.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAcronym.Location = new System.Drawing.Point(44, 37);
            this.LabelAcronym.Name = "LabelAcronym";
            this.LabelAcronym.Size = new System.Drawing.Size(120, 23);
            this.LabelAcronym.TabIndex = 6;
            this.LabelAcronym.Text = "acronym";
            this.LabelAcronym.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CryptoEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LabelAcronym);
            this.Controls.Add(this.LabelMarketCap);
            this.Controls.Add(this.ImgGraph);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelCrypto);
            this.Controls.Add(this.ImgCrypto);
            this.Name = "CryptoEntry";
            this.Size = new System.Drawing.Size(483, 73);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCrypto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ImgCrypto;
        private System.Windows.Forms.Label LabelCrypto;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.PictureBox ImgGraph;
        private System.Windows.Forms.Label LabelMarketCap;
        private System.Windows.Forms.Label LabelAcronym;
    }
}
