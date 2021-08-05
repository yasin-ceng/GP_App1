namespace GP_App1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImgScl = new System.Windows.Forms.Button();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImgUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImgPos = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.btnRotateR = new System.Windows.Forms.Button();
            this.btnRotateL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(547, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnImgScl
            // 
            this.btnImgScl.Location = new System.Drawing.Point(28, 253);
            this.btnImgScl.Name = "btnImgScl";
            this.btnImgScl.Size = new System.Drawing.Size(178, 81);
            this.btnImgScl.TabIndex = 1;
            this.btnImgScl.Text = "Ölçeklendir";
            this.btnImgScl.UseVisualStyleBackColor = true;
            this.btnImgScl.Click += new System.EventHandler(this.btnImgScl_Click);
            // 
            // textBoxW
            // 
            this.textBoxW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxW.Location = new System.Drawing.Point(70, 92);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(100, 26);
            this.textBoxW.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "W Çarpan";
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxH.Location = new System.Drawing.Point(70, 162);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 26);
            this.textBoxH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "H Çarpan";
            // 
            // btnImgUp
            // 
            this.btnImgUp.Location = new System.Drawing.Point(593, 40);
            this.btnImgUp.Name = "btnImgUp";
            this.btnImgUp.Size = new System.Drawing.Size(178, 81);
            this.btnImgUp.TabIndex = 1;
            this.btnImgUp.Text = "Resim Yükle";
            this.btnImgUp.UseVisualStyleBackColor = true;
            this.btnImgUp.Click += new System.EventHandler(this.btnImgUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(286, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "X +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(286, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y +";
            // 
            // btnImgPos
            // 
            this.btnImgPos.Location = new System.Drawing.Point(212, 253);
            this.btnImgPos.Name = "btnImgPos";
            this.btnImgPos.Size = new System.Drawing.Size(178, 81);
            this.btnImgPos.TabIndex = 4;
            this.btnImgPos.Text = "Yer Değiştirme";
            this.btnImgPos.UseVisualStyleBackColor = true;
            this.btnImgPos.Click += new System.EventHandler(this.btnImgPos_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxY.Location = new System.Drawing.Point(250, 162);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 26);
            this.textBoxY.TabIndex = 5;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxX.Location = new System.Drawing.Point(250, 92);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 26);
            this.textBoxX.TabIndex = 6;
            // 
            // btnRotateR
            // 
            this.btnRotateR.Location = new System.Drawing.Point(28, 356);
            this.btnRotateR.Name = "btnRotateR";
            this.btnRotateR.Size = new System.Drawing.Size(178, 81);
            this.btnRotateR.TabIndex = 7;
            this.btnRotateR.Text = "Saat Yönünde(Sağa)";
            this.btnRotateR.UseVisualStyleBackColor = true;
            this.btnRotateR.Click += new System.EventHandler(this.btnRotateR_Click);
            // 
            // btnRotateL
            // 
            this.btnRotateL.Location = new System.Drawing.Point(212, 356);
            this.btnRotateL.Name = "btnRotateL";
            this.btnRotateL.Size = new System.Drawing.Size(178, 81);
            this.btnRotateL.TabIndex = 8;
            this.btnRotateL.Text = "Saat Yönü Tersi(Sola)";
            this.btnRotateL.UseVisualStyleBackColor = true;
            this.btnRotateL.Click += new System.EventHandler(this.btnRotateL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "201613172907";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yasin CAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 625);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRotateL);
            this.Controls.Add(this.btnRotateR);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.btnImgPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxW);
            this.Controls.Add(this.btnImgUp);
            this.Controls.Add(this.btnImgScl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImgScl;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImgUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImgPos;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button btnRotateR;
        private System.Windows.Forms.Button btnRotateL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

