using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Formquanlydssptrongbonho
{
    public partial class Form1 : Form
    {
        // 1. Định nghĩa Lớp Product
        public class Product
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; }
        }

        // Khởi tạo danh sách và BindingSource
        private List<Product> productList = new List<Product>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập dữ liệu nguồn cho DataGridView
            bindingSource.DataSource = productList;
            dgvProducts.DataSource = bindingSource;

            // Tùy chỉnh hiển thị cột trên DataGridView (Tùy chọn)
            dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
            dgvProducts.Columns["ProductName"].HeaderText = "Tên SP";
            dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn giá";
            dgvProducts.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProducts.Columns["Category"].HeaderText = "Danh mục";
        }

        // 2. Nút Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã SP đã tồn tại chưa
                if (productList.Any(p => p.ProductId == txtId.Text))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Product newProduct = new Product
                {
                    ProductId = txtId.Text,
                    ProductName = txtName.Text,
                    UnitPrice = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Category = txtCategory.Text
                };

                productList.Add(newProduct);
                bindingSource.ResetBindings(false); // Làm mới DataGridView
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Đơn giá và Số lượng!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Đẩy ngược dữ liệu khi Click vào DataGridView
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productList.Count)
            {
                // Lấy đối tượng Product tương ứng với dòng được chọn
                Product selectedProduct = (Product)bindingSource[e.RowIndex];

                txtId.Text = selectedProduct.ProductId;
                txtName.Text = selectedProduct.ProductName;
                txtPrice.Text = selectedProduct.UnitPrice.ToString();
                txtQuantity.Text = selectedProduct.Quantity.ToString();
                txtCategory.Text = selectedProduct.Category;

                // Không cho phép sửa Mã SP
                txtId.Enabled = false;
            }
        }

        // Nút Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                try
                {
                    Product selectedProduct = (Product)bindingSource.Current;

                    // Cập nhật thông tin (trừ ID)
                    selectedProduct.ProductName = txtName.Text;
                    selectedProduct.UnitPrice = decimal.Parse(txtPrice.Text);
                    selectedProduct.Quantity = int.Parse(txtQuantity.Text);
                    selectedProduct.Category = txtCategory.Text;

                    bindingSource.ResetBindings(false);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. Nút Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Product selectedProduct = (Product)bindingSource.Current;
                    productList.Remove(selectedProduct);
                    bindingSource.ResetBindings(false);
                    ClearInputs();
                }
            }
        }

        // Nút Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                // Nếu ô tìm kiếm trống, hiển thị lại toàn bộ
                bindingSource.DataSource = productList;
            }
            else
            {
                // Lọc danh sách theo tên SP
                var filteredList = productList.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                bindingSource.DataSource = filteredList;
            }
            bindingSource.ResetBindings(false);
        }

        // Hàm hỗ trợ làm mới ô nhập liệu
        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtCategory.Clear();
            txtId.Enabled = true;
            txtId.Focus();
        }

        // Nút Hủy / Làm mới (Tùy chọn)
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}