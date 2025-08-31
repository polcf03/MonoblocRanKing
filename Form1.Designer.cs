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
            this.components = new System.ComponentModel.Container();
            this.RankingGroup = new System.Windows.Forms.Panel();
            this.RankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClimbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RankingGroupBox = new System.Windows.Forms.GroupBox();
            this.RankingListView = new System.Windows.Forms.ListView();
            this.ChartGroupBox = new System.Windows.Forms.GroupBox();
            this.ClimbersManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.climbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.RankingGroupBox.SuspendLayout();
            this.ClimbersManagerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.climbersBindingSource)).BeginInit();
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
            // RankingToolStripMenuItem
            // 
            this.RankingToolStripMenuItem.Name = "RankingToolStripMenuItem";
            this.RankingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.RankingToolStripMenuItem.Text = "Ranking";
            this.RankingToolStripMenuItem.Click += new System.EventHandler(this.RankingToolStripMenuItem_Click);
            // 
            // ChartToolStripMenuItem
            // 
            this.ChartToolStripMenuItem.Name = "ChartToolStripMenuItem";
            this.ChartToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.ChartToolStripMenuItem.Text = "Chart";
            this.ChartToolStripMenuItem.Click += new System.EventHandler(this.ChartToolStripMenuItem_Click);
            // 
            // ClimbersToolStripMenuItem
            // 
            this.ClimbersToolStripMenuItem.Name = "ClimbersToolStripMenuItem";
            this.ClimbersToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ClimbersToolStripMenuItem.Text = "Climbers";
            this.ClimbersToolStripMenuItem.Click += new System.EventHandler(this.ClimbersToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RankingToolStripMenuItem,
            this.ChartToolStripMenuItem,
            this.ClimbersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1707, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RankingGroupBox
            // 
            this.RankingGroupBox.AutoSize = true;
            this.RankingGroupBox.Controls.Add(this.RankingListView);
            this.RankingGroupBox.Location = new System.Drawing.Point(32, 86);
            this.RankingGroupBox.Name = "RankingGroupBox";
            this.RankingGroupBox.Size = new System.Drawing.Size(436, 536);
            this.RankingGroupBox.TabIndex = 3;
            this.RankingGroupBox.TabStop = false;
            this.RankingGroupBox.Text = "Monobloc Ranking";
            // 
            // RankingListView
            // 
            this.RankingListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingListView.HideSelection = false;
            this.RankingListView.Location = new System.Drawing.Point(3, 18);
            this.RankingListView.Name = "RankingListView";
            this.RankingListView.Size = new System.Drawing.Size(430, 515);
            this.RankingListView.TabIndex = 0;
            this.RankingListView.UseCompatibleStateImageBehavior = false;
            // 
            // ChartGroupBox
            // 
            this.ChartGroupBox.Location = new System.Drawing.Point(1064, 104);
            this.ChartGroupBox.Name = "ChartGroupBox";
            this.ChartGroupBox.Size = new System.Drawing.Size(760, 519);
            this.ChartGroupBox.TabIndex = 0;
            this.ChartGroupBox.TabStop = false;
            this.ChartGroupBox.Text = "Chart";
            // 
            // ClimbersManagerGroupBox
            // 
            this.ClimbersManagerGroupBox.Controls.Add(this.label1);
            this.ClimbersManagerGroupBox.Controls.Add(this.button1);
            this.ClimbersManagerGroupBox.Location = new System.Drawing.Point(486, 100);
            this.ClimbersManagerGroupBox.Name = "ClimbersManagerGroupBox";
            this.ClimbersManagerGroupBox.Size = new System.Drawing.Size(561, 519);
            this.ClimbersManagerGroupBox.TabIndex = 0;
            this.ClimbersManagerGroupBox.TabStop = false;
            this.ClimbersManagerGroupBox.Text = "Climbers Manager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 856);
            this.Controls.Add(this.RankingGroupBox);
            this.Controls.Add(this.ChartGroupBox);
            this.Controls.Add(this.ClimbersManagerGroupBox);
            this.Controls.Add(this.RankingGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Monobloc RanKING";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RankingGroupBox.ResumeLayout(false);
            this.ClimbersManagerGroupBox.ResumeLayout(false);
            this.ClimbersManagerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.climbersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel RankingGroup;
        private System.Windows.Forms.ToolStripMenuItem RankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClimbersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox RankingGroupBox;
        private System.Windows.Forms.GroupBox ChartGroupBox;
        private System.Windows.Forms.GroupBox ClimbersManagerGroupBox;
        private System.Windows.Forms.ListView RankingListView;
        private System.Windows.Forms.BindingSource climbersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

