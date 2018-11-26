namespace SoNguyenLon
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
            this.components = new System.ComponentModel.Container();
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ngẫuNhiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngẫuNhiênSốAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngẫuNhiênSốBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcTệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcTệpChoSốAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcTệpChoSốBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuKếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuKếtQuảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuLịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtLạiLịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtLạiTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnsNumA = new System.Windows.Forms.Button();
            this.AnsNumB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lưuPhépTínhHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuSốAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuSốBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(81, 43);
            this.txtNumA.Multiline = true;
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(374, 61);
            this.txtNumA.TabIndex = 1;
            this.txtNumA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumA_KeyPress);
            this.txtNumA.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumA_Validating);
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(81, 158);
            this.txtNumB.Multiline = true;
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(374, 61);
            this.txtNumB.TabIndex = 2;
            this.txtNumB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumB_KeyPress);
            this.txtNumB.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumB_Validating);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(80, 275);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(85, 33);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(81, 328);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(374, 61);
            this.txtKetQua.TabIndex = 99;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(180, 275);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(85, 33);
            this.btnTru.TabIndex = 4;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(279, 275);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(85, 33);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnChia
            // 
            this.btnChia.Enabled = false;
            this.btnChia.Location = new System.Drawing.Point(370, 275);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(85, 33);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Số B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Kết Quả";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(786, -120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cộng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngẫuNhiênToolStripMenuItem,
            this.đọcTệpToolStripMenuItem,
            this.lưuKếtQuảToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ngẫuNhiênToolStripMenuItem
            // 
            this.ngẫuNhiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngẫuNhiênSốAToolStripMenuItem,
            this.ngẫuNhiênSốBToolStripMenuItem});
            this.ngẫuNhiênToolStripMenuItem.Name = "ngẫuNhiênToolStripMenuItem";
            this.ngẫuNhiênToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ngẫuNhiênToolStripMenuItem.Text = "Ngẫu Nhiên";
            // 
            // ngẫuNhiênSốAToolStripMenuItem
            // 
            this.ngẫuNhiênSốAToolStripMenuItem.Name = "ngẫuNhiênSốAToolStripMenuItem";
            this.ngẫuNhiênSốAToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ngẫuNhiênSốAToolStripMenuItem.Text = "Ngẫu nhiên số A";
            this.ngẫuNhiênSốAToolStripMenuItem.Click += new System.EventHandler(this.ngẫuNhiênSốAToolStripMenuItem_Click);
            // 
            // ngẫuNhiênSốBToolStripMenuItem
            // 
            this.ngẫuNhiênSốBToolStripMenuItem.Name = "ngẫuNhiênSốBToolStripMenuItem";
            this.ngẫuNhiênSốBToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ngẫuNhiênSốBToolStripMenuItem.Text = "Ngẫu nhiên số B";
            this.ngẫuNhiênSốBToolStripMenuItem.Click += new System.EventHandler(this.ngẫuNhiênSốBToolStripMenuItem_Click);
            // 
            // đọcTệpToolStripMenuItem
            // 
            this.đọcTệpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đọcTệpChoSốAToolStripMenuItem,
            this.đọcTệpChoSốBToolStripMenuItem});
            this.đọcTệpToolStripMenuItem.Name = "đọcTệpToolStripMenuItem";
            this.đọcTệpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.đọcTệpToolStripMenuItem.Text = "Đọc Tệp";
            this.đọcTệpToolStripMenuItem.Click += new System.EventHandler(this.đọcTệpToolStripMenuItem_Click);
            // 
            // đọcTệpChoSốAToolStripMenuItem
            // 
            this.đọcTệpChoSốAToolStripMenuItem.Name = "đọcTệpChoSốAToolStripMenuItem";
            this.đọcTệpChoSốAToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.đọcTệpChoSốAToolStripMenuItem.Text = "Đọc tệp cho số A";
            this.đọcTệpChoSốAToolStripMenuItem.Click += new System.EventHandler(this.đọcTệpChoSốAToolStripMenuItem_Click);
            // 
            // đọcTệpChoSốBToolStripMenuItem
            // 
            this.đọcTệpChoSốBToolStripMenuItem.Name = "đọcTệpChoSốBToolStripMenuItem";
            this.đọcTệpChoSốBToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.đọcTệpChoSốBToolStripMenuItem.Text = "Đọc tệp cho số B";
            this.đọcTệpChoSốBToolStripMenuItem.Click += new System.EventHandler(this.đọcTệpChoSốBToolStripMenuItem_Click);
            // 
            // lưuKếtQuảToolStripMenuItem
            // 
            this.lưuKếtQuảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuSốAToolStripMenuItem,
            this.lưuSốBToolStripMenuItem,
            this.lưuKếtQuảToolStripMenuItem1,
            this.lưuLịchSửToolStripMenuItem,
            this.lưuPhépTínhHiệnTạiToolStripMenuItem});
            this.lưuKếtQuảToolStripMenuItem.Name = "lưuKếtQuảToolStripMenuItem";
            this.lưuKếtQuảToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.lưuKếtQuảToolStripMenuItem.Text = "Lưu";
            this.lưuKếtQuảToolStripMenuItem.Click += new System.EventHandler(this.lưuKếtQuảToolStripMenuItem_Click);
            // 
            // lưuKếtQuảToolStripMenuItem1
            // 
            this.lưuKếtQuảToolStripMenuItem1.Name = "lưuKếtQuảToolStripMenuItem1";
            this.lưuKếtQuảToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.lưuKếtQuảToolStripMenuItem1.Text = "Lưu kết quả";
            this.lưuKếtQuảToolStripMenuItem1.Click += new System.EventHandler(this.lưuKếtQuảToolStripMenuItem1_Click);
            // 
            // lưuLịchSửToolStripMenuItem
            // 
            this.lưuLịchSửToolStripMenuItem.Name = "lưuLịchSửToolStripMenuItem";
            this.lưuLịchSửToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lưuLịchSửToolStripMenuItem.Text = "Lưu lịch sử";
            this.lưuLịchSửToolStripMenuItem.Click += new System.EventHandler(this.lưuLịchSửToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtLạiToolStripMenuItem,
            this.đặtLạiLịchSửToolStripMenuItem,
            this.đặtLạiTấtCảToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.resetToolStripMenuItem.Text = "Đặt lại";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // đặtLạiToolStripMenuItem
            // 
            this.đặtLạiToolStripMenuItem.Name = "đặtLạiToolStripMenuItem";
            this.đặtLạiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.đặtLạiToolStripMenuItem.Text = "Đặt lại số phép tính";
            this.đặtLạiToolStripMenuItem.Click += new System.EventHandler(this.đặtLạiToolStripMenuItem_Click);
            // 
            // đặtLạiLịchSửToolStripMenuItem
            // 
            this.đặtLạiLịchSửToolStripMenuItem.Name = "đặtLạiLịchSửToolStripMenuItem";
            this.đặtLạiLịchSửToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.đặtLạiLịchSửToolStripMenuItem.Text = "Đặt lại lịch sử";
            this.đặtLạiLịchSửToolStripMenuItem.Click += new System.EventHandler(this.đặtLạiLịchSửToolStripMenuItem_Click);
            // 
            // đặtLạiTấtCảToolStripMenuItem
            // 
            this.đặtLạiTấtCảToolStripMenuItem.Name = "đặtLạiTấtCảToolStripMenuItem";
            this.đặtLạiTấtCảToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.đặtLạiTấtCảToolStripMenuItem.Text = "Đặt lại tất cả";
            this.đặtLạiTấtCảToolStripMenuItem.Click += new System.EventHandler(this.đặtLạiTấtCảToolStripMenuItem_Click);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // AnsNumA
            // 
            this.AnsNumA.Location = new System.Drawing.Point(396, 110);
            this.AnsNumA.Name = "AnsNumA";
            this.AnsNumA.Size = new System.Drawing.Size(59, 24);
            this.AnsNumA.TabIndex = 99;
            this.AnsNumA.Text = "Ans";
            this.AnsNumA.UseVisualStyleBackColor = true;
            this.AnsNumA.Click += new System.EventHandler(this.AnsNumA_Click);
            // 
            // AnsNumB
            // 
            this.AnsNumB.Location = new System.Drawing.Point(396, 225);
            this.AnsNumB.Name = "AnsNumB";
            this.AnsNumB.Size = new System.Drawing.Size(59, 24);
            this.AnsNumB.TabIndex = 99;
            this.AnsNumB.Text = "Ans";
            this.AnsNumB.UseVisualStyleBackColor = true;
            this.AnsNumB.Click += new System.EventHandler(this.AnsNumB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "Lịch Sử";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(484, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 312);
            this.listView1.TabIndex = 99;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lưuPhépTínhHiệnTạiToolStripMenuItem
            // 
            this.lưuPhépTínhHiệnTạiToolStripMenuItem.Name = "lưuPhépTínhHiệnTạiToolStripMenuItem";
            this.lưuPhépTínhHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lưuPhépTínhHiệnTạiToolStripMenuItem.Text = "Lưu phép tính hiện tại";
            this.lưuPhépTínhHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.lưuPhépTínhHiệnTạiToolStripMenuItem_Click);
            // 
            // lưuSốAToolStripMenuItem
            // 
            this.lưuSốAToolStripMenuItem.Name = "lưuSốAToolStripMenuItem";
            this.lưuSốAToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lưuSốAToolStripMenuItem.Text = "Lưu số A";
            this.lưuSốAToolStripMenuItem.Click += new System.EventHandler(this.lưuSốAToolStripMenuItem_Click);
            // 
            // lưuSốBToolStripMenuItem
            // 
            this.lưuSốBToolStripMenuItem.Name = "lưuSốBToolStripMenuItem";
            this.lưuSốBToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.lưuSốBToolStripMenuItem.Text = "Lưu số B";
            this.lưuSốBToolStripMenuItem.Click += new System.EventHandler(this.lưuSốBToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(759, 411);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AnsNumB);
            this.Controls.Add(this.AnsNumA);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Toán Số Nguyên Lớn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ngẫuNhiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đọcTệpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuKếtQuảToolStripMenuItem;
        private System.Windows.Forms.Button AnsNumA;
        private System.Windows.Forms.Button AnsNumB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolStripMenuItem lưuKếtQuảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lưuLịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngẫuNhiênSốAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngẫuNhiênSốBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đọcTệpChoSốAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đọcTệpChoSốBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtLạiLịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtLạiTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuPhépTínhHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuSốAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuSốBToolStripMenuItem;
    }
}

