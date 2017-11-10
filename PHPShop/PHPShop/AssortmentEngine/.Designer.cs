namespace PHPShop
{
    partial class Assortment
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
            this.ShopNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AssortmentBox1 = new System.Windows.Forms.GroupBox();
            this.AssortmentBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameLabel.Location = new System.Drawing.Point(122, 9);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(141, 25);
            this.ShopNameLabel.TabIndex = 0;
            this.ShopNameLabel.Text = "Button Shop";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Собери клавиатуру! Просто жмякни на любую";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 211);
            this.panel1.TabIndex = 9;
            // 
            // AssortmentBox1
            // 
            this.AssortmentBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssortmentBox1.Controls.Add(this.panel1);
            this.AssortmentBox1.Location = new System.Drawing.Point(12, 37);
            this.AssortmentBox1.Name = "AssortmentBox1";
            this.AssortmentBox1.Size = new System.Drawing.Size(360, 236);
            this.AssortmentBox1.TabIndex = 0;
            this.AssortmentBox1.TabStop = false;
            this.AssortmentBox1.Text = "Ассортимент";
            // 
            // Assortment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.AssortmentBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShopNameLabel);
            this.Name = "Assortment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ассортимент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Assortment_FormClosed);
            this.Load += new System.EventHandler(this.Assortment_Load);
            this.AssortmentBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox AssortmentBox1;
    }
}

