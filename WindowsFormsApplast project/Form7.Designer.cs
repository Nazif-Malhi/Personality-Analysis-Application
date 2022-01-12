namespace WindowsFormsApplast_project
{
    partial class Form7
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
            this.NEXT_2 = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NEXT_2
            // 
            this.NEXT_2.AllowDrop = true;
            this.NEXT_2.BackColor = System.Drawing.Color.Aquamarine;
            this.NEXT_2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEXT_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NEXT_2.Location = new System.Drawing.Point(435, 376);
            this.NEXT_2.Name = "NEXT_2";
            this.NEXT_2.Size = new System.Drawing.Size(114, 45);
            this.NEXT_2.TabIndex = 15;
            this.NEXT_2.Text = "DONE";
            this.NEXT_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NEXT_2.UseVisualStyleBackColor = false;
            this.NEXT_2.Click += new System.EventHandler(this.NEXT_2_Click);
            // 
            // third
            // 
            this.third.BackColor = System.Drawing.Color.LightSteelBlue;
            this.third.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.third.Location = new System.Drawing.Point(232, 376);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(117, 45);
            this.third.TabIndex = 14;
            this.third.Text = "SUBMITT";
            this.third.UseVisualStyleBackColor = false;
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(128, 333);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(554, 20);
            this.last.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Which color looks brightest to you in this picture????";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "TRY 03";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplast_project.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(105, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NEXT_2);
            this.Controls.Add(this.third);
            this.Controls.Add(this.last);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NEXT_2;
        private System.Windows.Forms.Button third;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}