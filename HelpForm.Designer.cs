namespace Interface___igra
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.goback_button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "\t\t\tУправление:",
            "   Что бы поменять картинки местами - Сначала нажмите на ",
            "   картинку которую хотите поменять, затем на другую",
            "",
            "",
            "",
            "",
            "\t\t\t    Правила:",
            "   Игра считается пройденой, когда изображение слева и справа",
            "   будутполностью соответствовать друг-другу"});
            this.listBox1.Location = new System.Drawing.Point(124, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(537, 284);
            this.listBox1.TabIndex = 0;
            // 
            // goback_button1
            // 
            this.goback_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.goback_button1.BackgroundImage = global::Interface___igra.Properties.Resources.Return;
            this.goback_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goback_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_button1.Location = new System.Drawing.Point(363, 379);
            this.goback_button1.Name = "goback_button1";
            this.goback_button1.Size = new System.Drawing.Size(75, 28);
            this.goback_button1.TabIndex = 1;
            this.goback_button1.UseVisualStyleBackColor = false;
            this.goback_button1.Click += new System.EventHandler(this.goback_button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Interface___igra.Properties.Resources._10399826;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(657, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 302);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(35)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.goback_button1);
            this.Controls.Add(this.listBox1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button goback_button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}