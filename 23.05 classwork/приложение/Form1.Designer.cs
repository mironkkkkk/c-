namespace WindowsFormsApp1
{
    partial class Form1
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
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLoginStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoginPass = new System.Windows.Forms.TextBox();
            this.textBoxLoginLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRegisterMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLoginMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(66, 229);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 2;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(248, 229);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 3;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pass";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(155, 339);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(193, 178);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(28, 13);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "error";
            this.labelError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Register";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "error";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonLoginStart
            // 
            this.buttonLoginStart.Location = new System.Drawing.Point(536, 339);
            this.buttonLoginStart.Name = "buttonLoginStart";
            this.buttonLoginStart.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginStart.TabIndex = 12;
            this.buttonLoginStart.Text = "start";
            this.buttonLoginStart.UseVisualStyleBackColor = true;
            this.buttonLoginStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pass";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxLoginPass
            // 
            this.textBoxLoginPass.Location = new System.Drawing.Point(617, 229);
            this.textBoxLoginPass.Name = "textBoxLoginPass";
            this.textBoxLoginPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginPass.TabIndex = 10;
            this.textBoxLoginPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLoginLogin
            // 
            this.textBoxLoginLogin.Location = new System.Drawing.Point(435, 229);
            this.textBoxLoginLogin.Name = "textBoxLoginLogin";
            this.textBoxLoginLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginLogin.TabIndex = 9;
            this.textBoxLoginLogin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Login";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxRegisterMail
            // 
            this.textBoxRegisterMail.Location = new System.Drawing.Point(150, 295);
            this.textBoxRegisterMail.Name = "textBoxRegisterMail";
            this.textBoxRegisterMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegisterMail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mail";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxLoginMail
            // 
            this.textBoxLoginMail.Location = new System.Drawing.Point(526, 295);
            this.textBoxLoginMail.Name = "textBoxLoginMail";
            this.textBoxLoginMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginMail.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxLoginMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRegisterMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLoginStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLoginPass);
            this.Controls.Add(this.textBoxLoginLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLoginStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoginPass;
        private System.Windows.Forms.TextBox textBoxLoginLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRegisterMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLoginMail;
        private System.Windows.Forms.Label label9;
    }
}

