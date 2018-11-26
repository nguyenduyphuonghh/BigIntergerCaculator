namespace SoNguyenLon
{
    partial class FormSoLuong
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
            this.btnCancelKhoiTao = new System.Windows.Forms.Button();
            this.btnOkKhoiTao = new System.Windows.Forms.Button();
            this.txtSoLuongKhoiTao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelKhoiTao
            // 
            this.btnCancelKhoiTao.Location = new System.Drawing.Point(254, 81);
            this.btnCancelKhoiTao.Name = "btnCancelKhoiTao";
            this.btnCancelKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnCancelKhoiTao.TabIndex = 7;
            this.btnCancelKhoiTao.Text = "Hủy bỏ";
            this.btnCancelKhoiTao.UseVisualStyleBackColor = true;
            this.btnCancelKhoiTao.Click += new System.EventHandler(this.btnCancelKhoiTao_Click_1);
            // 
            // btnOkKhoiTao
            // 
            this.btnOkKhoiTao.Location = new System.Drawing.Point(173, 81);
            this.btnOkKhoiTao.Name = "btnOkKhoiTao";
            this.btnOkKhoiTao.Size = new System.Drawing.Size(75, 23);
            this.btnOkKhoiTao.TabIndex = 6;
            this.btnOkKhoiTao.Text = "Ok";
            this.btnOkKhoiTao.UseVisualStyleBackColor = true;
            this.btnOkKhoiTao.Click += new System.EventHandler(this.btnOkKhoiTao_Click_1);
            // 
            // txtSoLuongKhoiTao
            // 
            this.txtSoLuongKhoiTao.Location = new System.Drawing.Point(123, 13);
            this.txtSoLuongKhoiTao.Name = "txtSoLuongKhoiTao";
            this.txtSoLuongKhoiTao.Size = new System.Drawing.Size(192, 20);
            this.txtSoLuongKhoiTao.TabIndex = 5;
            this.txtSoLuongKhoiTao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongKhoiTao_KeyPress);
            this.txtSoLuongKhoiTao.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoLuongKhoiTao_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số lượng muốn khởi tạo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSoLuong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(335, 117);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelKhoiTao);
            this.Controls.Add(this.btnOkKhoiTao);
            this.Controls.Add(this.txtSoLuongKhoiTao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSoLuong";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelKhoiTao;
        private System.Windows.Forms.Button btnOkKhoiTao;
        private System.Windows.Forms.TextBox txtSoLuongKhoiTao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}