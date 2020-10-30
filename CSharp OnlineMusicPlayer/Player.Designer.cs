namespace CSharp_OnlineMusicPlayer
{
    partial class Player
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Volume = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Compositor = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(0, 0);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(41, 31);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(188, 1);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(37, 31);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(104, 0);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(78, 31);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Prev);
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.btn_Play);
            this.panel1.Location = new System.Drawing.Point(241, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 37);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_Volume
            // 
            this.tb_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Volume.AutoSize = false;
            this.tb_Volume.Location = new System.Drawing.Point(472, 6);
            this.tb_Volume.Maximum = 100;
            this.tb_Volume.Name = "tb_Volume";
            this.tb_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_Volume.Size = new System.Drawing.Size(24, 77);
            this.tb_Volume.TabIndex = 5;
            this.tb_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_Volume.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.lbl_Time);
            this.panel3.Controls.Add(this.lbl_Compositor);
            this.panel3.Controls.Add(this.lbl_Title);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 74);
            this.panel3.TabIndex = 7;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(3, 48);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(130, 26);
            this.lbl_Time.TabIndex = 3;
            this.lbl_Time.Text = "00:00 / 00:00";
            // 
            // lbl_Compositor
            // 
            this.lbl_Compositor.AutoSize = true;
            this.lbl_Compositor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Compositor.Location = new System.Drawing.Point(4, 26);
            this.lbl_Compositor.Name = "lbl_Compositor";
            this.lbl_Compositor.Size = new System.Drawing.Size(55, 20);
            this.lbl_Compositor.TabIndex = 1;
            this.lbl_Compositor.Text = "author";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(3, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(140, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Change track";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(241, 46);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 34);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(6, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 394);
            this.panel2.TabIndex = 9;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tb_Volume);
            this.Controls.Add(this.panel1);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(499, 480);
            this.Load += new System.EventHandler(this.Player_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tb_Volume;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Compositor;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button button1;
    }
}
