namespace WinSolitaireTrain
{
    partial class WinTrain
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.ListBox();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBeginTraining = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(928, 570);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(199, 29);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Næste";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.FormattingEnabled = true;
            this.lbType.ItemHeight = 16;
            this.lbType.Items.AddRange(new object[] {
            "Spar Es",
            "Spar 2",
            "Spar 3",
            "Spar 4",
            "Spar 5",
            "Spar 6",
            "Spar 7",
            "Spar 8",
            "Spar 9",
            "Spar 10",
            "Spar Knægt",
            "Spar Dame",
            "Spar Konge",
            "Ruder Es",
            "Ruder 2",
            "Ruder 3",
            "Ruder 4",
            "Ruder 5",
            "Ruder 6",
            "Ruder 7",
            "Ruder 8",
            "Ruder 9",
            "Ruder 10",
            "Ruder Knægt",
            "Ruder Dame",
            "Ruder Konge",
            "Hjerter Es",
            "Hjerter 2",
            "Hjerter 3",
            "Hjerter 4",
            "Hjerter 5",
            "Hjerter 6",
            "Hjerter 7",
            "Hjerter 8",
            "Hjerter 9",
            "Hjerter 10",
            "Hjerter Knægt",
            "Hjerter Dame",
            "Hjerter Konge",
            "Klør Es",
            "Klør 2",
            "Klør 3",
            "Klør 4",
            "Klør 5",
            "Klør 6",
            "Klør 7",
            "Klør 8",
            "Klør 9",
            "Klør 10",
            "Klør Knægt",
            "Klør Dame",
            "Klør Konge"});
            this.lbType.Location = new System.Drawing.Point(928, 144);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(201, 324);
            this.lbType.TabIndex = 1;
            // 
            // pbCard
            // 
            this.pbCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCard.Location = new System.Drawing.Point(12, 31);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(910, 568);
            this.pbCard.TabIndex = 2;
            this.pbCard.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.testToolStripMenuItem.Text = "Åbn Billeder";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // btnBeginTraining
            // 
            this.btnBeginTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeginTraining.Location = new System.Drawing.Point(928, 512);
            this.btnBeginTraining.Name = "btnBeginTraining";
            this.btnBeginTraining.Size = new System.Drawing.Size(199, 23);
            this.btnBeginTraining.TabIndex = 4;
            this.btnBeginTraining.Text = "Begynd Træning";
            this.btnBeginTraining.UseVisualStyleBackColor = true;
            this.btnBeginTraining.Click += new System.EventHandler(this.btnBeginTraining_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(928, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(928, 480);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: Venter";
            // 
            // WinTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 611);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBeginTraining);
            this.Controls.Add(this.pbCard);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinTrain";
            this.Text = "Solitaire Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lbType;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button btnBeginTraining;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
    }
}

