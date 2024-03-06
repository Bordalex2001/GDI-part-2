namespace Homework
{
    partial class Form1
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
            this.hourHandPictureBox = new System.Windows.Forms.PictureBox();
            this.minuteHandPictureBox = new System.Windows.Forms.PictureBox();
            this.secondHandPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteHandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondHandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hourHandPictureBox
            // 
            this.hourHandPictureBox.Location = new System.Drawing.Point(288, 75);
            this.hourHandPictureBox.Name = "hourHandPictureBox";
            this.hourHandPictureBox.Size = new System.Drawing.Size(90, 67);
            this.hourHandPictureBox.TabIndex = 0;
            this.hourHandPictureBox.TabStop = false;
            // 
            // minuteHandPictureBox
            // 
            this.minuteHandPictureBox.Location = new System.Drawing.Point(501, 191);
            this.minuteHandPictureBox.Name = "minuteHandPictureBox";
            this.minuteHandPictureBox.Size = new System.Drawing.Size(100, 50);
            this.minuteHandPictureBox.TabIndex = 1;
            this.minuteHandPictureBox.TabStop = false;
            // 
            // secondHandPictureBox
            // 
            this.secondHandPictureBox.Location = new System.Drawing.Point(278, 267);
            this.secondHandPictureBox.Name = "secondHandPictureBox";
            this.secondHandPictureBox.Size = new System.Drawing.Size(100, 50);
            this.secondHandPictureBox.TabIndex = 2;
            this.secondHandPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondHandPictureBox);
            this.Controls.Add(this.minuteHandPictureBox);
            this.Controls.Add(this.hourHandPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteHandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondHandPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hourHandPictureBox;
        private System.Windows.Forms.PictureBox minuteHandPictureBox;
        private System.Windows.Forms.PictureBox secondHandPictureBox;
    }
}

