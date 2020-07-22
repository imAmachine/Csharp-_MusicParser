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
            this.listbox = new System.Windows.Forms.ListBox();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Volume = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(3, 46);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(391, 433);
            this.listbox.TabIndex = 0;
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(3, 3);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(54, 31);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "Prev";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(123, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(54, 31);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(63, 3);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(54, 31);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Prev);
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.btn_Play);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 37);
            this.panel1.TabIndex = 4;
            // 
            // tb_Volume
            // 
            this.tb_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Volume.AutoSize = false;
            this.tb_Volume.Location = new System.Drawing.Point(186, 16);
            this.tb_Volume.Maximum = 100;
            this.tb_Volume.Name = "tb_Volume";
            this.tb_Volume.Size = new System.Drawing.Size(207, 24);
            this.tb_Volume.TabIndex = 5;
            this.tb_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_Volume.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Volume);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listbox);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(397, 480);
            this.Load += new System.EventHandler(this.Player_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tb_Volume;
    }
}
