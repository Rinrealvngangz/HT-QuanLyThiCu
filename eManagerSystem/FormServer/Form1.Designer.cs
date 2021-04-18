namespace FormServer
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTimeleft = new System.Windows.Forms.Label();
            this.cmdNhapVungIP = new System.Windows.Forms.Button();
            this.cmdKichHoatAllClient = new System.Windows.Forms.Button();
            this.cmdBatDauLamBai = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbCbonMonThi = new System.Windows.Forms.ComboBox();
            this.cmdChapNhan = new System.Windows.Forms.Button();
            this.txtThoiGianLamBai = new System.Windows.Forms.TextBox();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdChonClientPath = new System.Windows.Forms.Button();
            this.cmdChon = new System.Windows.Forms.Button();
            this.tbSErverPath = new System.Windows.Forms.TextBox();
            this.txtClientPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lstDeThi = new System.Windows.Forms.ListBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShutDown);
            this.groupBox4.Controls.Add(this.btnLogOut);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.cmdNhapVungIP);
            this.groupBox4.Controls.Add(this.cmdKichHoatAllClient);
            this.groupBox4.Controls.Add(this.cmdBatDauLamBai);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(4, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 560);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTimeleft);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 493);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(142, 62);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Time exam";
            // 
            // lblTimeleft
            // 
            this.lblTimeleft.AutoSize = true;
            this.lblTimeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeleft.Location = new System.Drawing.Point(45, 28);
            this.lblTimeleft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeleft.Name = "lblTimeleft";
            this.lblTimeleft.Size = new System.Drawing.Size(0, 20);
            this.lblTimeleft.TabIndex = 0;
            // 
            // cmdNhapVungIP
            // 
            this.cmdNhapVungIP.Location = new System.Drawing.Point(7, 21);
            this.cmdNhapVungIP.Name = "cmdNhapVungIP";
            this.cmdNhapVungIP.Size = new System.Drawing.Size(148, 30);
            this.cmdNhapVungIP.TabIndex = 46;
            this.cmdNhapVungIP.Text = "Nhập Vùng  IP";
            this.cmdNhapVungIP.UseVisualStyleBackColor = true;
            this.cmdNhapVungIP.Click += new System.EventHandler(this.cmdNhapVungIP_Click);
            // 
            // cmdKichHoatAllClient
            // 
            this.cmdKichHoatAllClient.Location = new System.Drawing.Point(7, 288);
            this.cmdKichHoatAllClient.Name = "cmdKichHoatAllClient";
            this.cmdKichHoatAllClient.Size = new System.Drawing.Size(148, 39);
            this.cmdKichHoatAllClient.TabIndex = 45;
            this.cmdKichHoatAllClient.Text = "Kích Hoạt Tất Cả Client";
            this.cmdKichHoatAllClient.UseVisualStyleBackColor = true;
            this.cmdKichHoatAllClient.Click += new System.EventHandler(this.cmdKichHoatAllClient_Click);
            // 
            // cmdBatDauLamBai
            // 
            this.cmdBatDauLamBai.Location = new System.Drawing.Point(7, 456);
            this.cmdBatDauLamBai.Name = "cmdBatDauLamBai";
            this.cmdBatDauLamBai.Size = new System.Drawing.Size(148, 32);
            this.cmdBatDauLamBai.TabIndex = 44;
            this.cmdBatDauLamBai.Text = "Bắt Đầu Làm Bài";
            this.cmdBatDauLamBai.UseVisualStyleBackColor = true;
            this.cmdBatDauLamBai.Click += new System.EventHandler(this.cmdBatDauLamBai_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 40);
            this.button6.TabIndex = 40;
            this.button6.Text = "Send Message To All";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 238);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(148, 43);
            this.button11.TabIndex = 40;
            this.button11.Text = "Disable Tất Cả Các Máy Trống";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(7, 189);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 43);
            this.button10.TabIndex = 40;
            this.button10.Text = "Lấy Danh Sách Thi Từ CSDL";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 139);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 43);
            this.button9.TabIndex = 40;
            this.button9.Text = "Lấy Danh Sách Thi Từ File";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 30);
            this.button4.TabIndex = 40;
            this.button4.Text = "Disconnect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbCbonMonThi);
            this.groupBox5.Controls.Add(this.cmdChapNhan);
            this.groupBox5.Controls.Add(this.txtThoiGianLamBai);
            this.groupBox5.Location = new System.Drawing.Point(664, 576);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 150);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn Môn Thi và Thời Gian Làm Bài";
            // 
            // cbCbonMonThi
            // 
            this.cbCbonMonThi.FormattingEnabled = true;
            this.cbCbonMonThi.Location = new System.Drawing.Point(11, 25);
            this.cbCbonMonThi.Name = "cbCbonMonThi";
            this.cbCbonMonThi.Size = new System.Drawing.Size(203, 21);
            this.cbCbonMonThi.TabIndex = 30;
            this.cbCbonMonThi.Click += new System.EventHandler(this.cbCbonMonThi_Click);
            // 
            // cmdChapNhan
            // 
            this.cmdChapNhan.Location = new System.Drawing.Point(65, 104);
            this.cmdChapNhan.Name = "cmdChapNhan";
            this.cmdChapNhan.Size = new System.Drawing.Size(103, 23);
            this.cmdChapNhan.TabIndex = 29;
            this.cmdChapNhan.Text = "Chấp Nhận";
            this.cmdChapNhan.UseVisualStyleBackColor = true;
            this.cmdChapNhan.Click += new System.EventHandler(this.cmdChapNhan_Click);
            // 
            // txtThoiGianLamBai
            // 
            this.txtThoiGianLamBai.Location = new System.Drawing.Point(11, 60);
            this.txtThoiGianLamBai.Name = "txtThoiGianLamBai";
            this.txtThoiGianLamBai.Size = new System.Drawing.Size(203, 20);
            this.txtThoiGianLamBai.TabIndex = 28;
            this.txtThoiGianLamBai.Text = "120";
            this.txtThoiGianLamBai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.flowLayoutContainer);
            this.MainGroupBox.Location = new System.Drawing.Point(184, 10);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(866, 473);
            this.MainGroupBox.TabIndex = 51;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Danh Sách Các Máy Tính Trong Phòng Máy";
            // 
            // flowLayoutContainer
            // 
            this.flowLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutContainer.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutContainer.Name = "flowLayoutContainer";
            this.flowLayoutContainer.Size = new System.Drawing.Size(860, 454);
            this.flowLayoutContainer.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdChonClientPath);
            this.groupBox3.Controls.Add(this.cmdChon);
            this.groupBox3.Controls.Add(this.tbSErverPath);
            this.groupBox3.Controls.Add(this.txtClientPath);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(4, 576);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 146);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn Đường Dẫn";
            // 
            // cmdChonClientPath
            // 
            this.cmdChonClientPath.Location = new System.Drawing.Point(139, 80);
            this.cmdChonClientPath.Name = "cmdChonClientPath";
            this.cmdChonClientPath.Size = new System.Drawing.Size(62, 23);
            this.cmdChonClientPath.TabIndex = 36;
            this.cmdChonClientPath.Text = "Chọn";
            this.cmdChonClientPath.UseVisualStyleBackColor = true;
            this.cmdChonClientPath.Click += new System.EventHandler(this.cmdChonClientPath_Click);
            // 
            // cmdChon
            // 
            this.cmdChon.Location = new System.Drawing.Point(139, 36);
            this.cmdChon.Name = "cmdChon";
            this.cmdChon.Size = new System.Drawing.Size(62, 24);
            this.cmdChon.TabIndex = 35;
            this.cmdChon.Text = "Chọn";
            this.cmdChon.UseVisualStyleBackColor = true;
            this.cmdChon.Click += new System.EventHandler(this.cmdChon_Click);
            // 
            // tbSErverPath
            // 
            this.tbSErverPath.Location = new System.Drawing.Point(12, 36);
            this.tbSErverPath.Name = "tbSErverPath";
            this.tbSErverPath.Size = new System.Drawing.Size(120, 20);
            this.tbSErverPath.TabIndex = 34;
            // 
            // txtClientPath
            // 
            this.txtClientPath.Location = new System.Drawing.Point(12, 82);
            this.txtClientPath.Name = "txtClientPath";
            this.txtClientPath.Size = new System.Drawing.Size(120, 20);
            this.txtClientPath.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Client Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Server Path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(918, 576);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 150);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Noi Lưu Bài Thi";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài thi được lưu ở";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.lstDeThi);
            this.groupBox1.Location = new System.Drawing.Point(273, 576);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 153);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Đề Thi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 29);
            this.button3.TabIndex = 31;
            this.button3.Text = "Thêm Đề Thi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstDeThi
            // 
            this.lstDeThi.FormattingEnabled = true;
            this.lstDeThi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstDeThi.Location = new System.Drawing.Point(6, 19);
            this.lstDeThi.Name = "lstDeThi";
            this.lstDeThi.Size = new System.Drawing.Size(241, 108);
            this.lstDeThi.TabIndex = 30;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(6, 333);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 34);
            this.btnLogOut.TabIndex = 48;
            this.btnLogOut.Text = "LogOutUser";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.Location = new System.Drawing.Point(6, 392);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(149, 34);
            this.btnShutDown.TabIndex = 49;
            this.btnShutDown.Text = "ShutDown";
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 741);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.MainGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdNhapVungIP;
        private System.Windows.Forms.Button cmdKichHoatAllClient;
        private System.Windows.Forms.Button cmdBatDauLamBai;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdChapNhan;
        private System.Windows.Forms.TextBox txtThoiGianLamBai;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdChonClientPath;
        private System.Windows.Forms.Button cmdChon;
        private System.Windows.Forms.TextBox txtClientPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstDeThi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutContainer;
        public System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.TextBox tbSErverPath;
        private System.Windows.Forms.ComboBox cbCbonMonThi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTimeleft;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShutDown;
    }
}

