
namespace Mouse_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MouseDoubleClick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MouseDoubleClick)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseDoubleClick
            // 
            this.MouseDoubleClick.Image = ((System.Drawing.Image)(resources.GetObject("MouseDoubleClick.Image")));
            this.MouseDoubleClick.Location = new System.Drawing.Point(67, 62);
            this.MouseDoubleClick.Name = "MouseDoubleClick";
            this.MouseDoubleClick.Size = new System.Drawing.Size(260, 260);
            this.MouseDoubleClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MouseDoubleClick.TabIndex = 0;
            this.MouseDoubleClick.TabStop = false;
           // this.MouseDoubleClick.Click += new System.EventHandler(this.MouseDoubleClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MouseDoubleClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.MouseDoubleClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MouseDoubleClick;
    }
}

