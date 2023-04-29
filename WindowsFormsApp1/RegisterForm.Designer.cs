namespace WindowsFormsApp1
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.close_form1 = new System.Windows.Forms.Button();
            this.autorise_buttom = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirm_pass = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_form1
            // 
            this.close_form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_form1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_form1.Location = new System.Drawing.Point(503, 12);
            this.close_form1.Name = "close_form1";
            this.close_form1.Size = new System.Drawing.Size(66, 51);
            this.close_form1.TabIndex = 13;
            this.close_form1.Text = "X";
            this.close_form1.UseVisualStyleBackColor = true;
            this.close_form1.Click += new System.EventHandler(this.close_form1_Click);
            // 
            // autorise_buttom
            // 
            this.autorise_buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorise_buttom.Location = new System.Drawing.Point(189, 423);
            this.autorise_buttom.Name = "autorise_buttom";
            this.autorise_buttom.Size = new System.Drawing.Size(213, 60);
            this.autorise_buttom.TabIndex = 12;
            this.autorise_buttom.Text = "register";
            this.autorise_buttom.UseVisualStyleBackColor = true;
            this.autorise_buttom.Click += new System.EventHandler(this.autorise_buttom_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(201, 264);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(185, 69);
            this.password.TabIndex = 11;
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.qweqwe;
            this.pictureBox2.Location = new System.Drawing.Point(90, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(211, 114);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(175, 70);
            this.username.TabIndex = 16;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.MouseEnter += new System.EventHandler(this.username_MouseEnter);
            this.username.MouseLeave += new System.EventHandler(this.username_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "registration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Profile_User_free_icons_designed_by_Freepik;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(90, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // confirm_pass
            // 
            this.confirm_pass.Location = new System.Drawing.Point(201, 339);
            this.confirm_pass.Multiline = true;
            this.confirm_pass.Name = "confirm_pass";
            this.confirm_pass.PasswordChar = '*';
            this.confirm_pass.Size = new System.Drawing.Size(185, 69);
            this.confirm_pass.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.qweqwe;
            this.pictureBox3.Location = new System.Drawing.Point(90, 339);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(194, 496);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(194, 29);
            this.login_label.TabIndex = 17;
            this.login_label.Text = "already got an account";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 549);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.confirm_pass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.close_form1);
            this.Controls.Add(this.autorise_buttom);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_form1;
        private System.Windows.Forms.Button autorise_buttom;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox confirm_pass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}