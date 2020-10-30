namespace CSharp_OnlineMusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаСайтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitmomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.player1 = new CSharp_OnlineMusicPlayer.Player();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(462, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаСайтаToolStripMenuItem});
            this.опцииToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // сменаСайтаToolStripMenuItem
            // 
            this.сменаСайтаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hitmomeToolStripMenuItem});
            this.сменаСайтаToolStripMenuItem.Name = "сменаСайтаToolStripMenuItem";
            this.сменаСайтаToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.сменаСайтаToolStripMenuItem.Text = "Смена сайта...";
            // 
            // hitmomeToolStripMenuItem
            // 
            this.hitmomeToolStripMenuItem.Checked = true;
            this.hitmomeToolStripMenuItem.CheckOnClick = true;
            this.hitmomeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hitmomeToolStripMenuItem.Name = "hitmomeToolStripMenuItem";
            this.hitmomeToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.hitmomeToolStripMenuItem.Tag = "https://ruq.hotmo.org/";
            this.hitmomeToolStripMenuItem.Text = "hotmo.org";
            this.hitmomeToolStripMenuItem.Click += new System.EventHandler(this.hitmomeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 45);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(334, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Search.Location = new System.Drawing.Point(12, 5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(316, 31);
            this.tb_Search.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(376, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 31);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // player1
            // 
            this.player1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1.Location = new System.Drawing.Point(3, 71);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(456, 480);
            this.player1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(442, 381);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.player1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Player player1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаСайтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitmomeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}

