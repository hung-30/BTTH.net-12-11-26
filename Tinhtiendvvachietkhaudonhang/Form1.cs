using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tinhtiendvvachietkhaudonhang
{
    public partial class Form1 : Form
    {
        // Lớp phụ để lưu thông tin dịch vụ
        public class ServiceItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public override string ToString()
            {
                return $"{Name} - {Price:N0} VNĐ";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm các loại dịch vụ vào ComboBox
            cboCategory.Items.AddRange(new string[] { "Khám bệnh", "Xét nghiệm", "Chụp X-Quang", "Vắc-xin" });
            cboCategory.SelectedIndex = 0; // Chọn mặc định
            txtDiscount.Text = "0"; // Mặc định chiết khấu 0%
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            string selectedCategory = cboCategory.SelectedItem.ToString();

            // Load danh sách tương ứng
            if (selectedCategory == "Khám bệnh")
            {
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Khám nội tổng quát", Price = 150000 });
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Khám chuyên khoa", Price = 200000 });
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Khám răng hàm mặt", Price = 100000 });
            }
            else if (selectedCategory == "Xét nghiệm")
            {
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Xét nghiệm máu sinh hóa", Price = 350000 });
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Xét nghiệm nước tiểu", Price = 50000 });
            }
            else if (selectedCategory == "Chụp X-Quang")
            {
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Chụp X-Quang phổi", Price = 150000 });
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Siêu âm ổ bụng", Price = 250000 });
            }
            else if (selectedCategory == "Vắc-xin")
            {
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Tiêm vắc-xin cúm", Price = 300000 });
                lstAvailableServices.Items.Add(new ServiceItem { Name = "Tiêm vắc-xin HPV", Price = 1200000 });
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(lstAvailableServices, lstSelectedServices);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveSelectedItem(lstSelectedServices, lstAvailableServices);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CalculateTotal();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItem(lstAvailableServices, lstSelectedServices);
        }

        private void lstSelectedServices_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItem(lstSelectedServices, lstAvailableServices);
        }

        // Hàm di chuyển item dùng chung
        private void MoveSelectedItem(ListBox source, ListBox destination)
        {
            if (source.SelectedItem != null)
            {
                // Thêm vào đích
                destination.Items.Add(source.SelectedItem);
                // Xóa khỏi nguồn
                source.Items.Remove(source.SelectedItem);
                // Tính lại tiền
                CalculateTotal();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        // Hàm tính toán tiền
        private void CalculateTotal()
        {
            decimal totalBeforeDiscount = 0;

            // Tính tổng tiền các dịch vụ đã chọn
            foreach (ServiceItem item in lstSelectedServices.Items)
            {
                totalBeforeDiscount += item.Price;
            }

            txtTotal.Text = totalBeforeDiscount.ToString("N0");

            // Lấy tỷ lệ chiết khấu
            decimal discountRate = 0;
            if (decimal.TryParse(txtDiscount.Text, out decimal rate))
            {
                discountRate = rate;
            }

            // Tính thành tiền
            decimal discountAmount = totalBeforeDiscount * (discountRate / 100);
            decimal finalTotal = totalBeforeDiscount - discountAmount;

            txtFinalTotal.Text = finalTotal.ToString("N0");
        }
    }
}