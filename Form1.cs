using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SoNguyenLon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumA.Tag = txtNumA.Text;
            txtNumB.Tag = txtNumB.Text;
            txtKetQua.Tag = txtKetQua.Text;
        }

        Random random = new Random();
        public static string SoLuong = string.Empty; // biến lưu trữ số lượng từ formsoluong gửi về
        Stopwatch stopwatch = new Stopwatch();
        string Ans = "";
        string Mark = "";
        //Remove "0" characters
        public void RemoveZeros (ref string a, ref string b)
        {
            while (a[0] - '0' == 0 && a.Length > 1)
                a = a.Remove(0,1);
            while (b[0] - '0' == 0 && b.Length > 1)
                b = b.Remove(0,1);
        }
        //hàm so sánh xem số nào lớn hơn
        public bool Compare(string a, string b)
        {
            int numA = a.Length;
            int numB = b.Length;
            if (numA > numB)
                return true;
            else if(numA == numB)
            {
                int i = 0;
                while (i < numA-1 && a[i] == b[i])
                    i++;
                if (a[i]>=b[i])
                    return true;
                else
                    return false;
            }
            else
                return false;                           
        }
        //hàm đảo ngược
        public string Reverse(string a)
        {
            string reserse = "";
            int length = a.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                reserse += a.Substring(i, 1);
            }
            return reserse;
        }
        //Hàm Cộng
        public void Add(string a, string b)
        {
            RemoveZeros(ref a, ref b);
            string result = "";
            int length = 0;
            string addThis = "";
            int max = 0;
            // Thêm lại số 0 vào chuỗi ngắn hơn
            if (Compare(a, b))
            {
                length = a.Length - b.Length;
                max = a.Length;
                for (int i = 0; i < length; i++)
                {
                    addThis += "0";
                }
                b = addThis + b;
            }
            else
            {
                length = b.Length - a.Length;
                max = b.Length;
                for (int i = 0; i < length; i++)
                {
                    addThis += "0";
                }
                a = addThis + a;
            }// kết thúc thêm số 0
            // bắt đầu cộng
            int nho = 0;
            for (int i = max - 1; i >= 0; i--)
            {
                char numA = char.Parse(a.Substring(i, 1));
                char numB = char.Parse(b.Substring(i, 1));
                result += (numA - '0' + numB - '0' + nho) % 10;
                nho = (numA - '0' + numB - '0' + nho) / 10;
                //result += (a[i] - '0' + b[i] - '0' + nho) % 10;
                //nho = (a[i] - '0' + b[i] - '0' + nho) / 10;
            }
            if (nho > 0)
            {
                result = result + 1;
            }
            result = Reverse(result);
            Ans = result;
            //thêm kết quả vào listview
            listView1.Items.Add(listView1.Items.Count + 1 + ".  " + result);
            txtKetQua.Text = result;
        }
        //Cộng
        private void btnCong_Click(object sender, EventArgs e)
        {
            Mark = " + ";
            if (string.IsNullOrEmpty(txtNumA.Text))
            {
                txtNumA.Focus();
                errorProvider1.SetError(txtNumA, "Không được để trống");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNumB.Text))
                {
                    txtNumB.Focus();
                    errorProvider1.SetError(txtNumB, "Không được để trống");
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    stopWatchStart();
                    Add(txtNumA.Text, txtNumB.Text);
                    stopWatchStop();
                    Cursor = Cursors.Default;
                }                
            }
        }
        // Hàm Trừ
        public void Sub(string num1, string num2)
        {
            RemoveZeros(ref num1, ref num2);
            //Các biến dùng cho tính toán
            txtKetQua.Text = "";
            int muon = 0;
            int min = num1.Length < num2.Length ? num1.Length : num2.Length;
            int max = num1.Length < num2.Length ? num2.Length : num1.Length;
            string kq = "";
            string kqcuoi = "";
            int i = 0; ;
            string tam="";
            int solech = max - min;
            String addThis = "";
            // thêm số 0 vào chuỗi ngắn hơn
            if (num1.Length < num2.Length)
            {
                for (i = 0; i < solech; i++)
                {
                    addThis += "0";
                }
                num1 = addThis + num1;
            }
            else
            {
                for (i = 0; i < solech; i++)
                {
                    addThis += "0";
                }
                num2 = addThis + num2;
            }
            // đổi giá trị của hai số nếu số thứ nhất nhỏ hơn số thứ hai
            if (!Compare(num1, num2))
            {
                txtKetQua.Text = "-";
                tam = num1;
                num1 = num2;
                num2 = tam;
            }
            // bắt đầu trừ
            for (i = 0; i < max; i++)
            {
                if (num1[num1.Length - 1 - i] - muon >= num2[num2.Length - 1 - i])
                {
                    kq += ((num1[num1.Length - 1 - i] - num2[num2.Length - 1 - i] - muon) % 10).ToString();
                    muon = 0;
                }
                else
                {
                    kq += ((10 + num1[num1.Length - 1 - i] - num2[num2.Length - 1 - i] - muon) % 10).ToString();
                    muon = 1;
                }
            }
            if (kq == "0")
            {
                txtKetQua.Text = "0";
                Ans = txtKetQua.Text;
                // them kq vao listview
                listView1.Items.Add(listView1.Items.Count + 1 + ".   " + txtKetQua.Text);
            }
            else
            {             
                // chuyển ngược lại chuỗi kq để được kq cuối cùng
                kqcuoi = Reverse(kq);
                
                // xóa số 0 thừa
                //while (kqcuoi[0] - '0' == 0)
                //{
                //    kqcuoi = kqcuoi.Remove(0, 1);
                //}
                txtKetQua.Text += kqcuoi;
                Ans = txtKetQua.Text;
                // them kq vao listview
                listView1.Items.Add(listView1.Items.Count + 1 + ".   " + txtKetQua.Text);
            }            
        }
        //stop watch
        public void stopWatchStart()
        {
            stopwatch.Start();
        }

        public void stopWatchStop()
        {
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            MessageBox.Show("Thời gian thự hiện: " + elapsedTime);
            stopwatch.Reset();
        }       
        //Trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            Mark = " - ";
            if (string.IsNullOrEmpty(txtNumA.Text))
            {
                txtNumA.Focus();
                errorProvider1.SetError(txtNumA, "Không được để trống");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNumB.Text))
                {
                    txtNumB.Focus();
                    errorProvider1.SetError(txtNumB, "Không được để trống");
                }
                else
                {
                    Cursor = Cursors.WaitCursor;                    
                    stopWatchStart();
                    Sub(txtNumA.Text, txtNumB.Text);
                    stopWatchStop();
                    Cursor = Cursors.Default;
                }
            }
        }
        // Hàm Random
        public string RdStringBuilder()
        {
            FormSoLuong frm = new FormSoLuong();
            frm.ShowDialog();
            StringBuilder stringBuilder = new StringBuilder();
            Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(SoLuong))
            {                
                // bắt đầu random
                int loops = int.Parse(SoLuong);
                stopWatchStart();
                for (int i = 0; i < loops; i++)
                {
                    stringBuilder.Append(random.Next(0, 9));
                }
            }
            else
            {
                MessageBox.Show("Đã hủy");

            }
            return stringBuilder.ToString();            
        }
        //Hàm đọc từ tệp
        public string Reader()
        {
            string address = "";
            string content = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                content = File.ReadAllText(address);
            }
            return content;
        }
        //Hàm Nhân
        public void Multiplication(string a, string b)
        {
            RemoveZeros(ref a, ref b);
            int[] result = new int[a.Length+b.Length];
            string c = "";

            //Nhân lần lượt từng số và đặt vào đúng vị trí
            for (int i = a.Length - 1; i >= 0; i--)
            {
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    result[i+1+j] += (a[i] - '0') * (b[j] - '0');
                }
            }

            //Cộng dồn để lấy kết quả cuối cùng
            for (int i = a.Length + b.Length-1; i >= 0; i--)
            {
                if (result[i] > 9)
                {
                    result[i - 1] += result[i] / 10;
                    result[i] %= 10;
                }
            }

            //chuyển thành chuỗi -> in ra mh
            for (int i = 0; i <= a.Length + b.Length -1; i++)
            {
                c += result[i];
            }
            if (c[0] - '0' == 0)
            {
                c = c.Remove(0, 1);
            }

            txtKetQua.Text = c;
            Ans = c;
            listView1.Items.Add(listView1.Items.Count + 1 + ".   " + c);
        }
        // phím Nhân
        private void btnMul_Click(object sender, EventArgs e)
        {
            Mark = " * ";
            if (string.IsNullOrEmpty(txtNumA.Text))
            {
                txtNumA.Focus();
                errorProvider1.SetError(txtNumA, "Không được để trống");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNumB.Text))
                {
                    txtNumB.Focus();
                    errorProvider1.SetError(txtNumB, "Không được để trống");
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    stopWatchStart();
                    Multiplication(txtNumA.Text, txtNumB.Text);
                    stopWatchStop();
                    Cursor = Cursors.Default;
                }
            }
        }
        // Hàm chia
        public string Division(string number,string divisor)
        {
            RemoveZeros(ref number, ref divisor);
            string kq = "";
            int idx = 0;
            Int64 temp = number[idx] - '0';
            try
            {
                // nếu divisor là số 0
                if (Int64.Parse(divisor) == 0)
                {
                    return "Lỗi";
                }
                // nếu divisor lớn hơn number
                if (Int64.Parse(number) < Int64.Parse(divisor))
                {
                    return "0 dư " + number;
                }
                else
                {
                    while (temp < Int64.Parse(divisor))
                        temp = temp * 10 + (number[++idx] - '0');
                    while (number.Length > idx)
                    {
                        kq += (temp / Int64.Parse(divisor));
                        if (number.Length - 1 == idx)
                            //temp = (temp % divisor);
                            break;
                        temp = (temp % Int64.Parse(divisor)) * 10 + (number[++idx] - '0');
                    }
                    return kq;
                }
            }
            catch (Exception)
            {
                return "Error";
            }
        }
        // phím chia
        private void btnDiv_Click(object sender, EventArgs e)
        {
            Mark = " % ";
            if (string.IsNullOrEmpty(txtNumA.Text))
            {
                txtNumA.Focus();
                errorProvider1.SetError(txtNumA, "Không được để trống");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNumB.Text))
                {
                    txtNumB.Focus();
                    errorProvider1.SetError(txtNumB, "Không được để trống");
                }
                else
                {
                    Cursor = Cursors.WaitCursor;
                    stopWatchStart();
                    Division(txtNumA.Text, txtNumB.Text);
                    stopWatchStop();
                    Cursor = Cursors.Default;
                }
            }
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumA.Focus();
        }
        //Menu list
        private void đọcTệpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lưuKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AnsNumA_Click(object sender, EventArgs e)
        {
            if(Ans != "" && Ans.Substring(0,1) == "-")
            {
                txtNumA.Text = "0";
            } else
            {
                txtNumA.Text = Ans;
            }
            
        }

        private void AnsNumB_Click(object sender, EventArgs e)
        {
            if (Ans != "" && Ans.Substring(0, 1) == "-")
            {
                txtNumB.Text = "0";
            }
            else
            {
                txtNumB.Text = Ans;
            }
        }

        private void txtNumA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumA.Text))
            {
                e.Cancel = true;
                txtNumA.Focus();
                errorProvider1.SetError(txtNumA, "Không được để trống");
            }            
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNumA, null);
            }
        }

        private void txtNumB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumB.Text))
            {
                e.Cancel = true;
                txtNumB.Focus();
                errorProvider2.SetError(txtNumB, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtNumB, null);
            }
        }
        // hàm lưu kq
        private void Save(string txt)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txt);
            }
        }

        private void lưuKếtQuảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtKetQua.Text != "")
            {
                Save(txtKetQua.Text);
            }
            else
            {
                MessageBox.Show("Chưa có kết quả!");
            }
        }

        private void lưuLịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Chưa có lịch sử!");                
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        StringBuilder sb;
                        foreach (ListViewItem lvi in listView1.Items)
                        {
                            sb = new StringBuilder();
                            foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                            {
                                sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                            }
                            sw.WriteLine(sb.ToString());
                        }
                        sw.WriteLine();
                    }       
                }
            }
        }

        private void txtNumA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNumA, "Chỉ các ký tự số");
            }
        }

        private void txtNumB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtNumA, "Chỉ các ký tự số");
            }
        }

        private void ngẫuNhiênSốAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = RdStringBuilder();
            txtNumA.Text = result;
            Cursor = Cursors.Default;
            stopWatchStop();
        }

        private void ngẫuNhiênSốBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = RdStringBuilder();
            txtNumB.Text = result;
            Cursor = Cursors.Default;
            stopWatchStop();
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        } // kiểm tra từng ký tự trong numA,numB có phải là số không

        private void đọcTệpChoSốAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = Reader();
            txtNumA.Text = content;
            if (!IsNumber(txtNumA.Text))
            {
                errorProvider1.SetError(txtNumA, "Có ký tự không hợp lệ");
                txtNumA.Text = "";
                txtNumA.Focus();
            }
        }

        private void đọcTệpChoSốBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = Reader();
            txtNumB.Text = content;
            if (!IsNumber(txtNumB.Text))
            {
                errorProvider2.SetError(txtNumB, "Có ký tự không hợp lệ");
                txtNumB.Text = "";
                txtNumB.Focus();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đặtLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNumA.Text = txtNumA.Tag.ToString();
            txtNumA.Focus();
            txtNumB.Text = txtNumB.Tag.ToString();
            txtKetQua.Text = txtKetQua.Tag.ToString();
        }

        private void đặtLạiLịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void đặtLạiTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNumA.Text = txtNumA.Tag.ToString();
            txtNumA.Focus();
            txtNumB.Text = txtNumB.Tag.ToString();
            txtKetQua.Text = txtKetQua.Tag.ToString();
            listView1.Items.Clear();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lưuPhépTínhHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtKetQua.Text != "" && txtNumA.Text != "" && txtNumB.Text != "")
            {
                Save(txtNumA.Text + Mark + txtNumB.Text + " = " + txtKetQua.Text + "\n \n");
            }
            else
            {
                MessageBox.Show("Có số hạng rỗng!");
            }
        }

        private void lưuSốAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumA.Text != "")
            {
                Save(txtNumA.Text);
            }
            else
            {
                MessageBox.Show("Rỗng!");
            }
        }

        private void lưuSốBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNumB.Text != "")
            {
                Save(txtNumB.Text);
            }
            else
            {
                MessageBox.Show("Rỗng!");
            }
        }

    }
}
