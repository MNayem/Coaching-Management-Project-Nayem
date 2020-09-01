namespace INSPIRON
{
    partial class Teacher_Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_institute = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_savePic = new System.Windows.Forms.Button();
            this.btn_showPic = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureTeacher = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(188, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(188, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Institute :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(188, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(188, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(299, 79);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(280, 28);
            this.txt_name.TabIndex = 5;
            // 
            // txt_institute
            // 
            this.txt_institute.Location = new System.Drawing.Point(299, 133);
            this.txt_institute.Multiline = true;
            this.txt_institute.Name = "txt_institute";
            this.txt_institute.Size = new System.Drawing.Size(280, 28);
            this.txt_institute.TabIndex = 6;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(299, 183);
            this.txt_subject.Multiline = true;
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(280, 28);
            this.txt_subject.TabIndex = 7;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(299, 233);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(184, 28);
            this.txt_contact.TabIndex = 8;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.Olive;
            this.btn_browse.Location = new System.Drawing.Point(628, 274);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(156, 29);
            this.btn_browse.TabIndex = 9;
            this.btn_browse.Text = "Browse picture";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_savePic
            // 
            this.btn_savePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_savePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savePic.ForeColor = System.Drawing.Color.Olive;
            this.btn_savePic.Location = new System.Drawing.Point(628, 304);
            this.btn_savePic.Name = "btn_savePic";
            this.btn_savePic.Size = new System.Drawing.Size(75, 32);
            this.btn_savePic.TabIndex = 10;
            this.btn_savePic.Text = "Save Pic";
            this.btn_savePic.UseVisualStyleBackColor = false;
            this.btn_savePic.Click += new System.EventHandler(this.btn_savePic_Click);
            // 
            // btn_showPic
            // 
            this.btn_showPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_showPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showPic.ForeColor = System.Drawing.Color.Olive;
            this.btn_showPic.Location = new System.Drawing.Point(709, 304);
            this.btn_showPic.Name = "btn_showPic";
            this.btn_showPic.Size = new System.Drawing.Size(75, 32);
            this.btn_showPic.TabIndex = 11;
            this.btn_showPic.Text = "Show Pic";
            this.btn_showPic.UseVisualStyleBackColor = false;
            this.btn_showPic.Click += new System.EventHandler(this.btn_showPic_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(332, 299);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 37);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(186, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Teacher\'s Profile and Basic Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INSPIRON.Properties.Resources.INSPIRON;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 427);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureTeacher
            // 
            this.pictureTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureTeacher.Location = new System.Drawing.Point(628, 79);
            this.pictureTeacher.Name = "pictureTeacher";
            this.pictureTeacher.Size = new System.Drawing.Size(156, 194);
            this.pictureTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTeacher.TabIndex = 4;
            this.pictureTeacher.TabStop = false;
            // 
            // Teacher_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(814, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_showPic);
            this.Controls.Add(this.btn_savePic);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_institute);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.pictureTeacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teacher_Profile";
            this.Text = "Teacher_Profile";
            this.Load += new System.EventHandler(this.Teacher_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureTeacher;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_institute;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_savePic;
        private System.Windows.Forms.Button btn_showPic;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}