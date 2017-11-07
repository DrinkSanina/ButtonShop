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
            this.label1 = new System.Windows.Forms.Label();
            this.LetterA = new System.Windows.Forms.PictureBox();
            this.LetterB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegB = new System.Windows.Forms.Button();
            this.LoginTBox = new System.Windows.Forms.TextBox();
            this.PasswordTBox = new System.Windows.Forms.TextBox();
            this.BalanceTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LetterA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LetterB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Магазин господина 32";
            // 
            // LetterA
            // 
            this.LetterA.Image = global::PHPShop.Properties.Resources.A;
            this.LetterA.Location = new System.Drawing.Point(17, 52);
            this.LetterA.Name = "LetterA";
            this.LetterA.Size = new System.Drawing.Size(90, 94);
            this.LetterA.TabIndex = 1;
            this.LetterA.TabStop = false;
            this.LetterA.Click += new System.EventHandler(this.LetterA_Click);
            // 
            // LetterB
            // 
            this.LetterB.Image = global::PHPShop.Properties.Resources.B;
            this.LetterB.Location = new System.Drawing.Point(192, 52);
            this.LetterB.Name = "LetterB";
            this.LetterB.Size = new System.Drawing.Size(76, 94);
            this.LetterB.TabIndex = 2;
            this.LetterB.TabStop = false;
            this.LetterB.Click += new System.EventHandler(this.LetterB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Буква А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Буква B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Собери клавиатуру! Просто жмякни на любую";
            // 
            // RegB
            // 
            this.RegB.Location = new System.Drawing.Point(103, 206);
            this.RegB.Name = "RegB";
            this.RegB.Size = new System.Drawing.Size(75, 23);
            this.RegB.TabIndex = 6;
            this.RegB.Text = "button1";
            this.RegB.UseVisualStyleBackColor = true;
            this.RegB.Click += new System.EventHandler(this.RegB_Click);
            // 
            // LoginTBox
            // 
            this.LoginTBox.Location = new System.Drawing.Point(17, 180);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTBox.TabIndex = 7;
            this.LoginTBox.Text = "Login";
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.Location = new System.Drawing.Point(168, 180);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.PasswordChar = '*';
            this.PasswordTBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTBox.TabIndex = 7;
            this.PasswordTBox.Text = "r";
            // 
            // BalanceTBox
            // 
            this.BalanceTBox.Location = new System.Drawing.Point(92, 154);
            this.BalanceTBox.Name = "BalanceTBox";
            this.BalanceTBox.Size = new System.Drawing.Size(100, 20);
            this.BalanceTBox.TabIndex = 8;
            // 
            // Assortment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 267);
            this.Controls.Add(this.BalanceTBox);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.LoginTBox);
            this.Controls.Add(this.RegB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LetterB);
            this.Controls.Add(this.LetterA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Assortment";
            this.Text = "Ассортимент";
            ((System.ComponentModel.ISupportInitialize)(this.LetterA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LetterB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LetterA;
        private System.Windows.Forms.PictureBox LetterB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegB;
        private System.Windows.Forms.TextBox LoginTBox;
        private System.Windows.Forms.TextBox PasswordTBox;
        private System.Windows.Forms.TextBox BalanceTBox;
    }
}

