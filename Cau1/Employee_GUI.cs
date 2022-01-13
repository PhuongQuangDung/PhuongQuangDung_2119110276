using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cau1.DTO;
using Cau1.BLL;

namespace Cau1
{
    public partial class Employee_GUI : Form
    {
        Employee_BLL nvBLL = new Employee_BLL();
        Department_BLL DpBLL = new Department_BLL();
        public Employee_GUI()
        {
            InitializeComponent();
        }

        private void Employee_GUI_Load(object sender, EventArgs e)
        {
            List<Employee_DTO> lstNv = nvBLL.ReadEmployee();
            foreach (Employee_DTO nv in lstNv)
            {
                dataGridView1.Rows.Add(nv.IdEmployee, nv.Name, nv.DateBirth, nv.Gender, nv.PlaceBirth, nv.DepamentName);
            }
            List<Department_DTO> lstDp = DpBLL.ReadDepartmentList();
            foreach (Department_DTO Department in lstDp)
            {
                cbDonVi.Items.Add(Department);
            }
            cbDonVi.DisplayMember = "Name";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Employee_DTO nv = new Employee_DTO();
            nv.IdEmployee = tbMa.Text;
            nv.Name = tbName.Text;
            nv.DateBirth = DateTime.Parse(dtNgaySinh.Text);
            nv.Gender = cbGioiTinh.Checked;
            nv.PlaceBirth = tbNoiSinhh.Text;
            nv.Department_MSSV = (Department_DTO)cbDonVi.SelectedItem;

            nvBLL.NewEmployee_MSSV(nv);

            dataGridView1.Rows.Add(nv.IdEmployee, nv.Name, nv.DateBirth, nv.Gender, nv.PlaceBirth, nv.Department_MSSV.Name);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Employee_DTO nv = new Employee_DTO();
            nv.IdEmployee = tbMa.Text;
            nv.Name = tbName.Text;
            nv.DateBirth = DateTime.Parse(dtNgaySinh.Text);
            nv.Gender = cbGioiTinh.Checked;
            nv.PlaceBirth = tbNoiSinhh.Text;
            nv.Department_MSSV = (Department_DTO)cbDonVi.SelectedItem;

            nvBLL.DeleteEmployee_MSSV(nv);

            int idx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(idx);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            Employee_DTO nv = new Employee_DTO();
            nv.IdEmployee = tbMa.Text;
            nv.Name = tbName.Text;
            nv.DateBirth = DateTime.Parse(dtNgaySinh.Text);
            nv.Gender = cbGioiTinh.Checked;
            nv.PlaceBirth = tbNoiSinhh.Text;
            nv.Department_MSSV = (Department_DTO)cbDonVi.SelectedItem;

            nvBLL.EditEmployee(nv);

            row.Cells[0].Value = nv.IdEmployee;
            row.Cells[1].Value = nv.Name;
            row.Cells[2].Value = nv.DateBirth;
            row.Cells[3].Value = nv.Gender;
            row.Cells[4].Value = nv.PlaceBirth;
            row.Cells[5].Value = nv.Department_MSSV.Name;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = (MessageBox.Show("Bạn có muốn đóng chương trình không?", "Chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongBao == DialogResult.Yes)
                Application.Exit();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[idx];
            tbMa.Text = row.Cells[0].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
            dtNgaySinh.Text = row.Cells[2].Value.ToString();
            cbGioiTinh.Checked = (bool)row.Cells[3].Value;
            tbNoiSinhh.Text = row.Cells[4].Value.ToString();
            cbDonVi.Text = row.Cells[5].Value.ToString();
        }
    }
}
