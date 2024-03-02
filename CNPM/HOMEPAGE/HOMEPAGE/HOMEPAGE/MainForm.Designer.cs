namespace HOMEPAGE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel_Left = new Panel();
            panel1 = new Panel();
            button4 = new Button();
            btnLienLac = new Button();
            btnBoPhan = new Button();
            btnLichSu = new Button();
            pictureBox1 = new PictureBox();
            panel_Top = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel_Body = new Panel();
            panel_Left.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Top.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = Color.FromArgb(192, 64, 0);
            panel_Left.Controls.Add(panel1);
            panel_Left.Dock = DockStyle.Left;
            panel_Left.Location = new Point(0, 0);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(177, 471);
            panel_Left.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnLienLac);
            panel1.Controls.Add(btnBoPhan);
            panel1.Controls.Add(btnLichSu);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 471);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.LightCoral;
            button4.Location = new Point(0, 324);
            button4.Name = "button4";
            button4.Size = new Size(177, 72);
            button4.TabIndex = 4;
            button4.Text = "Đăng Nhập";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnLienLac
            // 
            btnLienLac.BackColor = Color.Cyan;
            btnLienLac.Dock = DockStyle.Top;
            btnLienLac.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLienLac.ForeColor = Color.LightCoral;
            btnLienLac.Location = new Point(0, 252);
            btnLienLac.Name = "btnLienLac";
            btnLienLac.Size = new Size(177, 72);
            btnLienLac.TabIndex = 3;
            btnLienLac.Text = "Thông Tin Liên lạc";
            btnLienLac.UseVisualStyleBackColor = false;
            btnLienLac.Click += btnLienLac_Click;
            // 
            // btnBoPhan
            // 
            btnBoPhan.BackColor = SystemColors.GradientActiveCaption;
            btnBoPhan.Dock = DockStyle.Top;
            btnBoPhan.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBoPhan.ForeColor = Color.LightCoral;
            btnBoPhan.Location = new Point(0, 180);
            btnBoPhan.Name = "btnBoPhan";
            btnBoPhan.Size = new Size(177, 72);
            btnBoPhan.TabIndex = 2;
            btnBoPhan.Text = "Các Bộ Phận";
            btnBoPhan.UseVisualStyleBackColor = false;
            btnBoPhan.Click += btnBoPhan_Click;
            // 
            // btnLichSu
            // 
            btnLichSu.BackColor = SystemColors.Info;
            btnLichSu.Dock = DockStyle.Top;
            btnLichSu.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLichSu.ForeColor = Color.LightCoral;
            btnLichSu.Location = new Point(0, 108);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Size = new Size(177, 72);
            btnLichSu.TabIndex = 1;
            btnLichSu.Text = "Lịch Sử Phát Triển";
            btnLichSu.UseVisualStyleBackColor = false;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 108);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_Top
            // 
            panel_Top.BackColor = Color.FromArgb(192, 64, 0);
            panel_Top.Controls.Add(panel2);
            panel_Top.Dock = DockStyle.Top;
            panel_Top.Location = new Point(177, 0);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(729, 87);
            panel_Top.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 87);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(66, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 47);
            label1.TabIndex = 0;
            label1.Text = "TRANG CHỦ";
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.BurlyWood;
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(177, 87);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(729, 384);
            panel_Body.TabIndex = 0;
            panel_Body.Paint += panel_Body_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 471);
            Controls.Add(panel_Body);
            Controls.Add(panel_Top);
            Controls.Add(panel_Left);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel_Left.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Top.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Left;
        private Panel panel1;
        private Panel panel_Top;
        private Panel panel2;
        private Panel panel_Body;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLichSu;
        private Button btnLienLac;
        private Button btnBoPhan;
        private Button button4;
    }
}
