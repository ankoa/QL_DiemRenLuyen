﻿using AuthService.Helper;
using ql_diemrenluyen.BUS;
using ql_diemrenluyen.DTO;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ql_diemrenluyen.GUI
{
    public partial class ResetPass : Form
    {
        private TextBox[] otpInputs;
        private bool isPasswordHidden = true;
        object user = null;
        private SinhVienDTO sinhvien;
        private GiangVienDTO giangvien;
        private readonly string accountType;
        private string id;

        public ResetPass(Object user, string accountType)
        {
            InitializeComponent();
            InitializeOTPInputs();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.Region = new Region(CreateRoundedRectanglePath(this.ClientRectangle, 30));
            this.user = user;
            this.accountType = accountType;
            loadUser();
            this.inputUser.Enabled = false;
        }

        // Khởi tạo các TextBox OTP trong FlowLayoutPanel
        private void InitializeOTPInputs()
        {
            int otpLength = 6; // Số ký tự OTP
            otpInputs = new TextBox[otpLength];

            for (int i = 0; i < otpLength; i++)
            {
                TextBox txt = new TextBox
                {
                    Width = 40,
                    MaxLength = 1,
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Arial", 16),
                    Margin = new Padding(10),
                    BackColor = Color.SkyBlue,
                    Enabled = false
                };

                txt.TextChanged += TextBox_TextChanged;
                txt.KeyDown += TextBox_KeyDown;
                otpInputs[i] = txt;
                flowLayoutPanel1.Controls.Add(txt); // Thêm vào FlowLayoutPanel
            }

            otpInputs[0].Focus(); // Đặt focus vào ô đầu tiên
            otpInputs[0].Enabled = true;
        }

        // Khi nhập xong 1 ký tự, tự chuyển sang ô tiếp theo
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            int index = Array.IndexOf(otpInputs, currentTextBox);

            if (!string.IsNullOrEmpty(currentTextBox.Text) && index < otpInputs.Length - 1)
            {
                otpInputs[index + 1].Enabled = true;
                otpInputs[index + 1].Focus();
            }
        }

        // Xử lý phím Backspace để quay lại ô trước đó
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            int index = Array.IndexOf(otpInputs, currentTextBox);

            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(currentTextBox.Text) && index > 0)
            {
                otpInputs[index - 1].Focus();
                otpInputs[index].Enabled = false;
                otpInputs[index - 1].SelectAll();
            }
        }

        // Hàm tạo GraphicsPath với góc bo tròn
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Góc trên-trái
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Góc trên-phải
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Góc dưới-phải
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            // Góc dưới-trái
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure(); // Đóng hình
            return path;
        }

        // DllImport để sử dụng API Windows
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void loadUser()
        {
            if (user != null)
            {
                // Gán giá trị cho biến user dựa trên kiểu tài khoản
                if (accountType == "Sinh viên")
                {
                    user = user as SinhVienDTO;
                }
                else if (accountType == "Giảng viên")
                {
                    user = user as GiangVienDTO;
                }

                if (user is SinhVienDTO sinhVien)
                {
                    this.sinhvien = sinhVien;
                    this.id = sinhvien.Id.ToString();
                    this.inputUser.Text = this.sinhvien.Email;
                }
                else if (user is GiangVienDTO giangVien)
                {
                    this.giangvien = giangVien;
                    this.inputUser.Text = this.giangvien.Email;
                    this.id = giangvien.Id.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string otp = string.Join("", otpInputs.Select(input => input.Text));
            if (otp.Length != 6)
            {
                MessageBox.Show("Vui lòng nhập đủ 6 ký tự OTP.");
                return;
            }
            string email = inputUser.Text;

            try
            {
                var passwordReset = PasswordResetBUS.VerifyToken(email, otp);

                if (passwordReset != null)
                {
                    if (PasswordResetBUS.MarkOTPAsUsed(passwordReset.Id))
                    {
                        this.Dispose();  // Ẩn form hiện tại
                                         // Chuyển sang OTPForm và truyền username
                        CreateNewPass otpForm = new CreateNewPass(id);
                        otpForm.Show();  // Hiển thị form mới
                    }

                    else
                        MessageBox.Show("Lỗi khi xác thực OTP");
                }
                else
                {
                    MessageBox.Show("OTP không hợp lệ hoặc đã hết hạn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;

            //if (isPasswordHidden)
            //{
            //    // Ẩn mật khẩu
            //    inputPass.PasswordChar = '●';
            //    pictureBox5.Image = Properties.Resources.hidden;
            //}
            //else
            //{
            //    // Hiện mật khẩu
            //    inputPass.PasswordChar = '\0';
            //    pictureBox5.Image = Properties.Resources.view;
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResetPass_Load(object sender, EventArgs e)
        {

        }

        private async void label6_Click(object sender, EventArgs e)
        {
            var username = inputUser.Text;
            var (account, accountType) = AccountBUS.findAccountByEmail(username);

            if (account == null)
            {
                MessageBox.Show("Không tìm thấy user");
            }
            else
            {
                //pictureBox4.Visible = true;
                try
                {
                    var codeReset = RNG.GenerateSixDigitNumber().ToString();
                    await SendMail.SendPasswordResetEmailAsync(username, codeReset);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
                finally
                {
                    //pictureBox4.Visible = false;
                    //this.Dispose();  // Ẩn form hiện tại
                    //                 // Chuyển sang OTPForm và truyền username
                    //ResetPass otpForm = new ResetPass(account, accountType);
                    //otpForm.Show();  // Hiển thị form mới

                }


            }
        }
    }
}
