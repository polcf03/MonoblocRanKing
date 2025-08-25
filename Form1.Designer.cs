namespace Monobloc_RanKing
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RankingGroup = new System.Windows.Forms.Panel();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.climbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RankingGroupBox = new System.Windows.Forms.GroupBox();
            this.ChartGroupBox = new System.Windows.Forms.GroupBox();
            this.ClimbersManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RankingGroup
            // 
            this.RankingGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RankingGroup.AutoSize = true;
            this.RankingGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RankingGroup.Location = new System.Drawing.Point(119, 83);
            this.RankingGroup.Name = "RankingGroup";
            this.RankingGroup.Size = new System.Drawing.Size(0, 0);
            this.RankingGroup.TabIndex = 2;
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.rankingToolStripMenuItem.Text = "Ranking";
            this.rankingToolStripMenuItem.Click += new System.EventHandler(this.rankingToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // climbersToolStripMenuItem
            // 
            this.climbersToolStripMenuItem.Name = "climbersToolStripMenuItem";
            this.climbersToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.climbersToolStripMenuItem.Text = "Climbers";
            this.climbersToolStripMenuItem.Click += new System.EventHandler(this.climbersToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.climbersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RankingGroupBox
            // 
            this.RankingGroupBox.AutoSize = true;
            this.RankingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingGroupBox.Location = new System.Drawing.Point(0, 28);
            this.RankingGroupBox.Name = "RankingGroupBox";
            this.RankingGroupBox.Size = new System.Drawing.Size(760, 464);
            this.RankingGroupBox.TabIndex = 3;
            this.RankingGroupBox.TabStop = false;
            this.RankingGroupBox.Text = "Monobloc Ranking";
            // 
            // ChartGroupBox
            // 
            this.ChartGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartGroupBox.Location = new System.Drawing.Point(0, 28);
            this.ChartGroupBox.Name = "ChartGroupBox";
            this.ChartGroupBox.Size = new System.Drawing.Size(760, 464);
            this.ChartGroupBox.TabIndex = 0;
            this.ChartGroupBox.TabStop = false;
            this.ChartGroupBox.Text = "Chart";
            // 
            // ClimbersManagerGroupBox
            // 
            this.ClimbersManagerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClimbersManagerGroupBox.Location = new System.Drawing.Point(0, 28);
            this.ClimbersManagerGroupBox.Name = "ClimbersManagerGroupBox";
            this.ClimbersManagerGroupBox.Size = new System.Drawing.Size(760, 464);
            this.ClimbersManagerGroupBox.TabIndex = 0;
            this.ClimbersManagerGroupBox.TabStop = false;
            this.ClimbersManagerGroupBox.Text = "Climbers Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 492);
            this.Controls.Add(this.ClimbersManagerGroupBox);
            this.Controls.Add(this.ChartGroupBox);
            this.Controls.Add(this.RankingGroupBox);
            this.Controls.Add(this.RankingGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monobloc RanKING";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel RankingGroup;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem climbersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox RankingGroupBox;
        private System.Windows.Forms.GroupBox ChartGroupBox;
        private System.Windows.Forms.GroupBox ClimbersManagerGroupBox;
    }
}

