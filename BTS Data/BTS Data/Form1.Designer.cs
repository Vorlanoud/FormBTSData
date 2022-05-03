
namespace BTS_Data
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btband = new System.Windows.Forms.Button();
            this.btmember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(271, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to BTS Word";
            // 
            // btband
            // 
            this.btband.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btband.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btband.BackgroundImage")));
            this.btband.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btband.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btband.ForeColor = System.Drawing.Color.Pink;
            this.btband.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btband.Location = new System.Drawing.Point(235, 400);
            this.btband.Name = "btband";
            this.btband.Size = new System.Drawing.Size(161, 148);
            this.btband.TabIndex = 2;
            this.btband.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btband.UseVisualStyleBackColor = false;
            this.btband.Click += new System.EventHandler(this.btband_Click);
            // 
            // btmember
            // 
            this.btmember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btmember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmember.BackgroundImage")));
            this.btmember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btmember.ForeColor = System.Drawing.Color.Pink;
            this.btmember.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmember.Location = new System.Drawing.Point(486, 400);
            this.btmember.Name = "btmember";
            this.btmember.Size = new System.Drawing.Size(161, 148);
            this.btmember.TabIndex = 3;
            this.btmember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmember.UseVisualStyleBackColor = false;
            this.btmember.Click += new System.EventHandler(this.btmember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(271, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Band";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(515, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Member";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmember);
            this.Controls.Add(this.btband);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "BTS WORD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btband;
        private System.Windows.Forms.Button btmember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

