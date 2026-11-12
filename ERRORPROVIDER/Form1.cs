using System;
using System.Windows.Forms;

namespace ERRORPROVIDER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các lỗi hiện tại trước khi kiểm tra lại
            epCheck.Clear();
            bool isValid = true;

            // 1. Kiểm tra Tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            // 2. Kiểm tra Mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống!");
                isValid = false;
            }

            // 3. Kiểm tra Xác nhận mật khẩu
            if (txtPassword.Text != txtConfirmPassword.Text || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                epCheck.SetError(txtConfirmPassword, "Mật khẩu xác nhận không khớp!");
                isValid = false;
            }

            // 4. Kiểm tra Độ tuổi (>= 18)
            DateTime birthDate = dtpBirthDate.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            // Trừ đi 1 tuổi nếu chưa đến ngày sinh nhật trong năm nay
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            if (age < 18)
            {
                epCheck.SetError(dtpBirthDate, "Bạn phải đủ 18 tuổi trở lên!");
                isValid = false;
            }

            // 5. Kiểm tra Điều khoản dịch vụ
            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Bạn phải đồng ý với điều khoản dịch vụ!");
                isValid = false;
            }

            // Nếu tất cả đều hợp lệ
            if (isValid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Làm mới các ô nhập liệu
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            dtpBirthDate.Value = DateTime.Now;
            chkTerms.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}