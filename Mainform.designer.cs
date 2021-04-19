namespace EarlyDibetic
{
    partial class Mainform
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
            this.CNMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFullImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pg1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxtTH = new System.Windows.Forms.TextBox();
            this.TxtTL = new System.Windows.Forms.TextBox();
            this.BtnCannyEdgeDetect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSigma = new System.Windows.Forms.TextBox();
            this.TxtGMask = new System.Windows.Forms.TextBox();
            this.GaussianFilteredImage = new System.Windows.Forms.PictureBox();
            this.CannyEdges = new System.Windows.Forms.PictureBox();
            this.HystThreshImage = new System.Windows.Forms.PictureBox();
            this.IrisImage = new System.Windows.Forms.PictureBox();
            this.GNH = new System.Windows.Forms.PictureBox();
            this.GNL = new System.Windows.Forms.PictureBox();
            this.CNMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianFilteredImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyEdges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HystThreshImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IrisImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNL)).BeginInit();
            this.SuspendLayout();
            // 
            // CNMenuStrip
            // 
            this.CNMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFullImageToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.CNMenuStrip.Name = "CNMenuStrip";
            this.CNMenuStrip.Size = new System.Drawing.Size(164, 48);
            // 
            // selectFullImageToolStripMenuItem
            // 
            this.selectFullImageToolStripMenuItem.Name = "selectFullImageToolStripMenuItem";
            this.selectFullImageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectFullImageToolStripMenuItem.Text = "Select Full Image";
            this.selectFullImageToolStripMenuItem.Click += new System.EventHandler(this.selectFullImageToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pg1,
            this.toolStripStatusLabel3,
            this.time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1117, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status :";
            // 
            // pg1
            // 
            this.pg1.Name = "pg1";
            this.pg1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel3.Text = "Processing Time : ";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(77, 17);
            this.time.Text = "HH:MM:SSSS";
            // 
            // TxtTH
            // 
            this.TxtTH.Location = new System.Drawing.Point(156, 832);
            this.TxtTH.Name = "TxtTH";
            this.TxtTH.Size = new System.Drawing.Size(38, 20);
            this.TxtTH.TabIndex = 46;
            this.TxtTH.Text = "20";
            // 
            // TxtTL
            // 
            this.TxtTL.Location = new System.Drawing.Point(111, 832);
            this.TxtTL.Name = "TxtTL";
            this.TxtTL.Size = new System.Drawing.Size(41, 20);
            this.TxtTL.TabIndex = 47;
            this.TxtTL.Text = "10";
            this.TxtTL.Visible = false;
            // 
            // BtnCannyEdgeDetect
            // 
            this.BtnCannyEdgeDetect.Location = new System.Drawing.Point(458, 813);
            this.BtnCannyEdgeDetect.Name = "BtnCannyEdgeDetect";
            this.BtnCannyEdgeDetect.Size = new System.Drawing.Size(75, 36);
            this.BtnCannyEdgeDetect.TabIndex = 48;
            this.BtnCannyEdgeDetect.Text = "Canny";
            this.BtnCannyEdgeDetect.UseVisualStyleBackColor = true;
            this.BtnCannyEdgeDetect.Visible = false;
            this.BtnCannyEdgeDetect.Click += new System.EventHandler(this.BtnCannyEdgeDetect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 813);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "High Threshold TH";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 813);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Low Threshold TL";
            this.label2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 825);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Final Canny Edges";
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 813);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Sigma";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 813);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Gaussian Mask Size";
            this.label10.Visible = false;
            // 
            // TxtSigma
            // 
            this.TxtSigma.Location = new System.Drawing.Point(390, 832);
            this.TxtSigma.Name = "TxtSigma";
            this.TxtSigma.Size = new System.Drawing.Size(41, 20);
            this.TxtSigma.TabIndex = 59;
            this.TxtSigma.Text = "1";
            this.TxtSigma.Visible = false;
            // 
            // TxtGMask
            // 
            this.TxtGMask.Location = new System.Drawing.Point(285, 832);
            this.TxtGMask.Name = "TxtGMask";
            this.TxtGMask.Size = new System.Drawing.Size(38, 20);
            this.TxtGMask.TabIndex = 58;
            this.TxtGMask.Text = "5";
            this.TxtGMask.Visible = false;
            // 
            // GaussianFilteredImage
            // 
            this.GaussianFilteredImage.Location = new System.Drawing.Point(285, 28);
            this.GaussianFilteredImage.Name = "GaussianFilteredImage";
            this.GaussianFilteredImage.Size = new System.Drawing.Size(20, 16);
            this.GaussianFilteredImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GaussianFilteredImage.TabIndex = 56;
            this.GaussianFilteredImage.TabStop = false;
            this.GaussianFilteredImage.Visible = false;
            // 
            // CannyEdges
            // 
            this.CannyEdges.Location = new System.Drawing.Point(379, 385);
            this.CannyEdges.Name = "CannyEdges";
            this.CannyEdges.Size = new System.Drawing.Size(337, 308);
            this.CannyEdges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CannyEdges.TabIndex = 45;
            this.CannyEdges.TabStop = false;
            this.CannyEdges.Click += new System.EventHandler(this.CannyEdges_Click);
            // 
            // HystThreshImage
            // 
            this.HystThreshImage.Location = new System.Drawing.Point(362, 53);
            this.HystThreshImage.Name = "HystThreshImage";
            this.HystThreshImage.Size = new System.Drawing.Size(337, 308);
            this.HystThreshImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HystThreshImage.TabIndex = 42;
            this.HystThreshImage.TabStop = false;
            this.HystThreshImage.Click += new System.EventHandler(this.HystThreshImage_Click);
            // 
            // IrisImage
            // 
            this.IrisImage.ContextMenuStrip = this.CNMenuStrip;
            this.IrisImage.Location = new System.Drawing.Point(19, 53);
            this.IrisImage.Name = "IrisImage";
            this.IrisImage.Size = new System.Drawing.Size(337, 308);
            this.IrisImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IrisImage.TabIndex = 41;
            this.IrisImage.TabStop = false;
            this.IrisImage.Click += new System.EventHandler(this.IrisImage_Click);
            // 
            // GNH
            // 
            this.GNH.Location = new System.Drawing.Point(742, 53);
            this.GNH.Name = "GNH";
            this.GNH.Size = new System.Drawing.Size(337, 308);
            this.GNH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GNH.TabIndex = 44;
            this.GNH.TabStop = false;
            this.GNH.Visible = false;
            // 
            // GNL
            // 
            this.GNL.Location = new System.Drawing.Point(19, 385);
            this.GNL.Name = "GNL";
            this.GNL.Size = new System.Drawing.Size(337, 308);
            this.GNL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GNL.TabIndex = 43;
            this.GNL.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtSigma);
            this.Controls.Add(this.TxtGMask);
            this.Controls.Add(this.GaussianFilteredImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTL);
            this.Controls.Add(this.BtnCannyEdgeDetect);
            this.Controls.Add(this.TxtTH);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GNL);
            this.Controls.Add(this.HystThreshImage);
            this.Controls.Add(this.IrisImage);
            this.Controls.Add(this.GNH);
            this.Controls.Add(this.CannyEdges);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edge Detection";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.CNMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianFilteredImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyEdges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HystThreshImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IrisImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CNMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectFullImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pg1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.PictureBox IrisImage;
        private System.Windows.Forms.PictureBox HystThreshImage;
        private System.Windows.Forms.PictureBox GNL;
        private System.Windows.Forms.PictureBox GNH;
        private System.Windows.Forms.PictureBox CannyEdges;
        private System.Windows.Forms.TextBox TxtTH;
        private System.Windows.Forms.TextBox TxtTL;
        private System.Windows.Forms.Button BtnCannyEdgeDetect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox GaussianFilteredImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSigma;
        private System.Windows.Forms.TextBox TxtGMask;
    }
}

