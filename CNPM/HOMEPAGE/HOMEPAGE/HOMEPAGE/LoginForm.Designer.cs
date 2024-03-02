namespace HOMEPAGE
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            gradientPanel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            rememberMe = new CheckBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            CB_ShowPass = new CheckBox();
            LB_ShowPass = new Label();
            LB_LoginForm = new Label();
            TB_UserName = new TextBox();
            TB_Password = new TextBox();
            BT_ForgotPass = new Button();
            BT_Login = new Button();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = SystemColors.ActiveCaption;
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(rememberMe);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(CB_ShowPass);
            gradientPanel1.Controls.Add(LB_ShowPass);
            gradientPanel1.Controls.Add(LB_LoginForm);
            gradientPanel1.Controls.Add(TB_UserName);
            gradientPanel1.Controls.Add(TB_Password);
            gradientPanel1.Controls.Add(BT_ForgotPass);
            gradientPanel1.Controls.Add(BT_Login);
            gradientPanel1.Location = new Point(93, 64);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(694, 401);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.Enter += gradientPanel1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 206);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 21;
            label5.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 249);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 20;
            label4.Text = "Remember me";
            label4.Click += label4_Click;
            // 
            // rememberMe
            // 
            rememberMe.AutoSize = true;
            rememberMe.BackColor = Color.Transparent;
            rememberMe.Location = new Point(377, 249);
            rememberMe.Name = "rememberMe";
            rememberMe.Size = new Size(18, 17);
            rememberMe.TabIndex = 19;
            rememberMe.UseVisualStyleBackColor = false;
            rememberMe.CheckedChanged += rememberMe_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 158);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 17;
            label2.Text = "Tên người dùng";
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(377, 281);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 15;
            button1.Text = "ĐĂNG KÍ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(175, 281);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 14;
            label1.Text = "Bạn chưa có tài khoản ?";
            // 
            // CB_ShowPass
            // 
            CB_ShowPass.AutoSize = true;
            CB_ShowPass.BackColor = Color.Transparent;
            CB_ShowPass.Location = new Point(175, 249);
            CB_ShowPass.Name = "CB_ShowPass";
            CB_ShowPass.Size = new Size(18, 17);
            CB_ShowPass.TabIndex = 7;
            CB_ShowPass.UseVisualStyleBackColor = false;
            CB_ShowPass.CheckedChanged += CB_ShowPass_CheckedChanged;
            // 
            // LB_ShowPass
            // 
            LB_ShowPass.AutoSize = true;
            LB_ShowPass.BackColor = Color.Transparent;
            LB_ShowPass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_ShowPass.Location = new Point(207, 249);
            LB_ShowPass.Name = "LB_ShowPass";
            LB_ShowPass.Size = new Size(133, 23);
            LB_ShowPass.TabIndex = 9;
            LB_ShowPass.Text = "Hiện mật khẩu";
            // 
            // LB_LoginForm
            // 
            LB_LoginForm.AutoSize = true;
            LB_LoginForm.BackColor = Color.Transparent;
            LB_LoginForm.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            LB_LoginForm.ForeColor = Color.Red;
            LB_LoginForm.Location = new Point(190, 58);
            LB_LoginForm.Name = "LB_LoginForm";
            LB_LoginForm.Size = new Size(313, 57);
            LB_LoginForm.TabIndex = 8;
            LB_LoginForm.Text = "ĐĂNG NHẬP";
            // 
            // TB_UserName
            // 
            TB_UserName.Location = new Point(175, 154);
            TB_UserName.Name = "TB_UserName";
            TB_UserName.Size = new Size(337, 27);
            TB_UserName.TabIndex = 11;
            TB_UserName.Text = "Tên đăng nhập";
            TB_UserName.TextChanged += TB_UserName_TextChanged;
            TB_UserName.Enter += TB_UserName_Enter;
            TB_UserName.Leave += TB_UserName_Leave;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(175, 206);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(337, 27);
            TB_Password.TabIndex = 10;
            TB_Password.Text = "Mật khẩu";
            TB_Password.Enter += TB_Password_Enter;
            TB_Password.Leave += TB_Password_Leave;
            // 
            // BT_ForgotPass
            // 
            BT_ForgotPass.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_ForgotPass.Location = new Point(377, 316);
            BT_ForgotPass.Name = "BT_ForgotPass";
            BT_ForgotPass.Size = new Size(167, 42);
            BT_ForgotPass.TabIndex = 13;
            BT_ForgotPass.Text = "Quên mật khẩu";
            BT_ForgotPass.UseVisualStyleBackColor = true;
            // 
            // BT_Login
            // 
            BT_Login.AutoSize = true;
            BT_Login.BackColor = Color.LightCoral;
            BT_Login.BackgroundImageLayout = ImageLayout.Center;
            BT_Login.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_Login.Location = new Point(147, 316);
            BT_Login.Name = "BT_Login";
            BT_Login.Size = new Size(182, 42);
            BT_Login.TabIndex = 12;
            BT_Login.Text = "Đăng nhập";
            BT_Login.UseVisualStyleBackColor = false;
            BT_Login.Click += BT_Login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(849, 510);
            Controls.Add(gradientPanel1);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "Đăng Nhập";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gradientPanel1;
        private Button button1;
        private Label label1;
        private CheckBox CB_ShowPass;
        private Label LB_ShowPass;
        private Label LB_LoginForm;
        private TextBox TB_UserName;
        private TextBox TB_Password;
        private Button BT_ForgotPass;
        private Button BT_Login;
        private Label label2;
        private Label label5;
        private Label label4;
        private CheckBox rememberMe;
    }
}