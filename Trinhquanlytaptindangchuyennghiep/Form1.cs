using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Trinhquanlytaptindangchuyennghiep
{
    public partial class Form1 : Form
    {
        
        public class Employee
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string StartDate { get; set; }
            public string DepartmentCode { get; set; } 
        }

        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TreeNode root = new TreeNode("Công ty TNHH ABC") { Name = "root" };

            TreeNode hr = new TreeNode("Phòng Nhân sự") { Name = "hr" };
            hr.Nodes.Add(new TreeNode("Nhóm Tuyển dụng") { Name = "hr_recruitment" });
            hr.Nodes.Add(new TreeNode("Nhóm C&B (Lương thưởng)") { Name = "hr_cb" });

            TreeNode it = new TreeNode("Phòng IT") { Name = "it" };
            it.Nodes.Add(new TreeNode("Nhóm Phần mềm") { Name = "it_dev" });
            it.Nodes.Add(new TreeNode("Nhóm Hệ thống") { Name = "it_sys" });

            root.Nodes.Add(hr);
            root.Nodes.Add(it);
            tvDepartments.Nodes.Add(root);
            tvDepartments.ExpandAll();

            
            lsvEmployees.Columns.Add("Mã NV", 80);
            lsvEmployees.Columns.Add("Họ Tên", 150);
            lsvEmployees.Columns.Add("Chức vụ", 150);
            lsvEmployees.Columns.Add("Ngày vào làm", 120);

            
            cboViewMode.Items.AddRange(new string[] { "Details", "LargeIcon", "SmallIcon", "List", "Tile" });
            cboViewMode.SelectedIndex = 0; // Mặc định là Details

            
            employees.Add(new Employee { Id = "NV01", Name = "Nguyễn Văn A", Position = "Trưởng phòng HR", StartDate = "01/01/2020", DepartmentCode = "hr" });
            employees.Add(new Employee { Id = "NV02", Name = "Trần Thị B", Position = "Chuyên viên Tuyển dụng", StartDate = "15/05/2021", DepartmentCode = "hr_recruitment" });
            employees.Add(new Employee { Id = "NV03", Name = "Lê Văn C", Position = "Chuyên viên C&B", StartDate = "10/08/2022", DepartmentCode = "hr_cb" });
            employees.Add(new Employee { Id = "NV04", Name = "Phạm Văn D", Position = "Trưởng phòng IT", StartDate = "02/02/2019", DepartmentCode = "it" });
            employees.Add(new Employee { Id = "NV05", Name = "Hoàng Thị E", Position = "Lập trình viên .NET", StartDate = "12/12/2023", DepartmentCode = "it_dev" });
            employees.Add(new Employee { Id = "NV06", Name = "Đinh Văn F", Position = "Quản trị mạng", StartDate = "20/11/2022", DepartmentCode = "it_sys" });
        }

        
        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsvEmployees.Items.Clear();
            string selectedCode = e.Node.Name;

            
            List<Employee> filteredList;
            if (selectedCode == "root")
            {
                filteredList = employees;
            }
            else
            {
                
                filteredList = employees.Where(emp => emp.DepartmentCode.StartsWith(selectedCode)).ToList();
            }

            
            foreach (var emp in filteredList)
            {
                ListViewItem item = new ListViewItem(emp.Id);
                item.SubItems.Add(emp.Name);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.StartDate);

                
                item.ImageIndex = 0;
                lsvEmployees.Items.Add(item);
            }
        }

        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedView = cboViewMode.SelectedItem.ToString();
            switch (selectedView)
            {
                case "Details": lsvEmployees.View = View.Details; break;
                case "LargeIcon": lsvEmployees.View = View.LargeIcon; break;
                case "SmallIcon": lsvEmployees.View = View.SmallIcon; break;
                case "List": lsvEmployees.View = View.List; break;
                case "Tile": lsvEmployees.View = View.Tile; break;
            }
        }
    }
}