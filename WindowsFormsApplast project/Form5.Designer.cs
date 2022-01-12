namespace WindowsFormsApplast_project
{
    partial class Form5
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
            this.NEXT_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NEXT_1
            // 
            this.NEXT_1.AllowDrop = true;
            this.NEXT_1.BackColor = System.Drawing.Color.Aquamarine;
            this.NEXT_1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEXT_1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NEXT_1.Location = new System.Drawing.Point(439, 383);
            this.NEXT_1.Name = "NEXT_1";
            this.NEXT_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NEXT_1.Size = new System.Drawing.Size(120, 45);
            this.NEXT_1.TabIndex = 12;
            this.NEXT_1.Text = "NEXT";
            this.NEXT_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NEXT_1.UseVisualStyleBackColor = false;
            this.NEXT_1.Click += new System.EventHandler(this.NEXT_1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(191, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "SUBMITT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(124, 344);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(524, 20);
            this.first.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "TRY 01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Which color looks brightest to you in this picture????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplast_project.Properties.Resources._6835971e_8806_40f8_903e_2c7b088182ac;
            this.pictureBox1.Location = new System.Drawing.Point(114, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NEXT_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NEXT_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}