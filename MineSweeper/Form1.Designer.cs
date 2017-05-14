namespace MineSweeper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.级别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_control = new System.Windows.Forms.Button();
            this.label_ClickNums = new System.Windows.Forms.Label();
            this.label_MineNums = new System.Windows.Forms.Label();
            this.panel_contain = new System.Windows.Forms.Panel();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_contain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.级别ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            this.游戏ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.游戏ToolStripMenuItem.Text = "游戏";
            // 
            // 级别ToolStripMenuItem
            // 
            this.级别ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.初级ToolStripMenuItem,
            this.中级ToolStripMenuItem,
            this.高级ToolStripMenuItem});
            this.级别ToolStripMenuItem.Name = "级别ToolStripMenuItem";
            this.级别ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.级别ToolStripMenuItem.Text = "级别";
            // 
            // 初级ToolStripMenuItem
            // 
            this.初级ToolStripMenuItem.Name = "初级ToolStripMenuItem";
            this.初级ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.初级ToolStripMenuItem.Text = "初级";
            this.初级ToolStripMenuItem.Click += new System.EventHandler(this.初级ToolStripMenuItem_Click);
            // 
            // 中级ToolStripMenuItem
            // 
            this.中级ToolStripMenuItem.Name = "中级ToolStripMenuItem";
            this.中级ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.中级ToolStripMenuItem.Text = "中级";
            this.中级ToolStripMenuItem.Click += new System.EventHandler(this.中级ToolStripMenuItem_Click);
            // 
            // 高级ToolStripMenuItem
            // 
            this.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem";
            this.高级ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.高级ToolStripMenuItem.Text = "高级";
            this.高级ToolStripMenuItem.Click += new System.EventHandler(this.高级ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_control);
            this.panel1.Controls.Add(this.label_ClickNums);
            this.panel1.Controls.Add(this.label_MineNums);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.panel1.Size = new System.Drawing.Size(382, 55);
            this.panel1.TabIndex = 1;
            // 
            // button_control
            // 
            this.button_control.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_control.BackColor = System.Drawing.SystemColors.Control;
            this.button_control.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_control.BackgroundImage")));
            this.button_control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_control.Location = new System.Drawing.Point(163, 6);
            this.button_control.Margin = new System.Windows.Forms.Padding(0);
            this.button_control.Name = "button_control";
            this.button_control.Size = new System.Drawing.Size(50, 40);
            this.button_control.TabIndex = 0;
            this.button_control.UseVisualStyleBackColor = false;
            this.button_control.Click += new System.EventHandler(this.button_control_Click);
            // 
            // label_ClickNums
            // 
            this.label_ClickNums.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ClickNums.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_ClickNums.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label_ClickNums.ForeColor = System.Drawing.Color.Red;
            this.label_ClickNums.Location = new System.Drawing.Point(267, 10);
            this.label_ClickNums.Name = "label_ClickNums";
            this.label_ClickNums.Size = new System.Drawing.Size(65, 35);
            this.label_ClickNums.TabIndex = 2;
            this.label_ClickNums.Text = "099";
            this.label_ClickNums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MineNums
            // 
            this.label_MineNums.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_MineNums.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_MineNums.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.label_MineNums.ForeColor = System.Drawing.Color.Red;
            this.label_MineNums.Location = new System.Drawing.Point(50, 10);
            this.label_MineNums.Margin = new System.Windows.Forms.Padding(0);
            this.label_MineNums.Name = "label_MineNums";
            this.label_MineNums.Size = new System.Drawing.Size(65, 35);
            this.label_MineNums.TabIndex = 1;
            this.label_MineNums.Text = "099";
            this.label_MineNums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_contain
            // 
            this.panel_contain.Controls.Add(this.panel_btn);
            this.panel_contain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contain.Location = new System.Drawing.Point(0, 83);
            this.panel_contain.Name = "panel_contain";
            this.panel_contain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.panel_contain.Size = new System.Drawing.Size(382, 270);
            this.panel_contain.TabIndex = 2;
            // 
            // panel_btn
            // 
            this.panel_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btn.Location = new System.Drawing.Point(10, 0);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(362, 265);
            this.panel_btn.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.panel_contain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫雷游戏";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_contain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 级别ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 初级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_control;
        private System.Windows.Forms.Label label_ClickNums;
        private System.Windows.Forms.Label label_MineNums;
        private System.Windows.Forms.Panel panel_contain;
        private System.Windows.Forms.Panel panel_btn;
    }
}

