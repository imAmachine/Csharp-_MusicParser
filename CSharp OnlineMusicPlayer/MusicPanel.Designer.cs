namespace CSharp_OnlineMusicPlayer
{
    partial class MusicPanel
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Compositor = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(70, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "label1";
            this.lbl_Title.MouseEnter += new System.EventHandler(this.MusicPanel_MouseEnter);
            this.lbl_Title.MouseLeave += new System.EventHandler(this.MusicPanel_MouseLeave);
            // 
            // lbl_Compositor
            // 
            this.lbl_Compositor.AutoSize = true;
            this.lbl_Compositor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Compositor.Location = new System.Drawing.Point(4, 25);
            this.lbl_Compositor.Name = "lbl_Compositor";
            this.lbl_Compositor.Size = new System.Drawing.Size(51, 20);
            this.lbl_Compositor.TabIndex = 1;
            this.lbl_Compositor.Text = "label2";
            this.lbl_Compositor.MouseEnter += new System.EventHandler(this.MusicPanel_MouseEnter);
            this.lbl_Compositor.MouseLeave += new System.EventHandler(this.MusicPanel_MouseLeave);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(6, 45);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(35, 13);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "label3";
            this.lbl_Time.MouseEnter += new System.EventHandler(this.MusicPanel_MouseEnter);
            this.lbl_Time.MouseLeave += new System.EventHandler(this.MusicPanel_MouseLeave);
            // 
            // MusicPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Compositor);
            this.Controls.Add(this.lbl_Title);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MusicPanel";
            this.Size = new System.Drawing.Size(429, 83);
            this.Load += new System.EventHandler(this.MusicPanel_Load);
            this.MouseEnter += new System.EventHandler(this.MusicPanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MusicPanel_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Compositor;
        private System.Windows.Forms.Label lbl_Time;
    }
}
