namespace Interface___igra
{
    partial class MenuForm
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
            this.SecretCodeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exitButton3 = new System.Windows.Forms.Button();
            this.helpButton2 = new System.Windows.Forms.Button();
            this.playButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Abril Fatface", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(321, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puzzle Game";
            // 
            // SecretCodeButton
            // 
            this.SecretCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(187)))), ((int)(((byte)(115)))));
            this.SecretCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecretCodeButton.Location = new System.Drawing.Point(344, 415);
            this.SecretCodeButton.Name = "SecretCodeButton";
            this.SecretCodeButton.Size = new System.Drawing.Size(75, 23);
            this.SecretCodeButton.TabIndex = 4;
            this.SecretCodeButton.Text = "Код";
            this.SecretCodeButton.UseVisualStyleBackColor = false;
            this.SecretCodeButton.Click += new System.EventHandler(this.SecretCodeButton_Click);
            this.SecretCodeButton.MouseEnter += new System.EventHandler(this.SecretCodeButton_MouseEnter);
            this.SecretCodeButton.MouseLeave += new System.EventHandler(this.SecretCodeButton_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Interface___igra.Properties.Resources.arrow2;
            this.pictureBox2.Location = new System.Drawing.Point(189, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // exitButton3
            // 
            this.exitButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.exitButton3.BackgroundImage = global::Interface___igra.Properties.Resources.Exit;
            this.exitButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton3.Location = new System.Drawing.Point(344, 218);
            this.exitButton3.Name = "exitButton3";
            this.exitButton3.Size = new System.Drawing.Size(75, 35);
            this.exitButton3.TabIndex = 2;
            this.exitButton3.UseVisualStyleBackColor = false;
            this.exitButton3.Click += new System.EventHandler(this.exitButton3_Click);
            // 
            // helpButton2
            // 
            this.helpButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.helpButton2.BackgroundImage = global::Interface___igra.Properties.Resources.Help;
            this.helpButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.helpButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton2.Location = new System.Drawing.Point(344, 177);
            this.helpButton2.Name = "helpButton2";
            this.helpButton2.Size = new System.Drawing.Size(75, 35);
            this.helpButton2.TabIndex = 1;
            this.helpButton2.UseVisualStyleBackColor = false;
            this.helpButton2.Click += new System.EventHandler(this.helpButton2_Click);
            // 
            // playButton1
            // 
            this.playButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.playButton1.BackgroundImage = global::Interface___igra.Properties.Resources.GameController;
            this.playButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton1.Location = new System.Drawing.Point(344, 134);
            this.playButton1.Name = "playButton1";
            this.playButton1.Size = new System.Drawing.Size(75, 37);
            this.playButton1.TabIndex = 0;
            this.playButton1.UseVisualStyleBackColor = false;
            this.playButton1.Click += new System.EventHandler(this.playButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Interface___igra.Properties.Resources.Cat1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(452, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 172);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(35)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SecretCodeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton3);
            this.Controls.Add(this.helpButton2);
            this.Controls.Add(this.playButton1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton1;
        private System.Windows.Forms.Button helpButton2;
        private System.Windows.Forms.Button exitButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SecretCodeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

