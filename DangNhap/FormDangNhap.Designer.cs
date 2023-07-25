
namespace DangNhap
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picOpen = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTentk
            // 
            this.txtTentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentk.Location = new System.Drawing.Point(196, 431);
            this.txtTentk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentk.Multiline = true;
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(290, 45);
            this.txtTentk.TabIndex = 2;
            this.txtTentk.TextChanged += new System.EventHandler(this.txtTentk_TextChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(196, 498);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(290, 45);
            this.txtMatkhau.TabIndex = 3;
            // 
            // btDangnhap
            // 
            this.btDangnhap.BackColor = System.Drawing.Color.Orange;
            this.btDangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btDangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangnhap.Location = new System.Drawing.Point(240, 597);
            this.btDangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(155, 65);
            this.btDangnhap.TabIndex = 4;
            this.btDangnhap.Text = "Đăng nhập";
            this.btDangnhap.UseVisualStyleBackColor = false;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picHide.Image = global::DangNhap.Properties.Resources.visibility__1_;
            this.picHide.Location = new System.Drawing.Point(443, 506);
            this.picHide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(32, 28);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHide.TabIndex = 10;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            // 
            // picOpen
            // 
            this.picOpen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picOpen.Image = global::DangNhap.Properties.Resources.visibility;
            this.picOpen.Location = new System.Drawing.Point(443, 506);
            this.picOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picOpen.Name = "picOpen";
            this.picOpen.Size = new System.Drawing.Size(32, 28);
            this.picOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpen.TabIndex = 9;
            this.picOpen.TabStop = false;
            this.picOpen.Click += new System.EventHandler(this.picOpen_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DangNhap.Properties.Resources.confirm_password;
            this.pictureBox3.Location = new System.Drawing.Point(125, 498);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(125, 431);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 734);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.picOpen);
            this.Controls.Add(this.btDangnhap);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangNhap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.PictureBox picOpen;
        private System.Windows.Forms.PictureBox picHide;
    }
}

