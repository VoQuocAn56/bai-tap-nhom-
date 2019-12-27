using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh3Cau3
{
    public partial class Form2 : Form
    {
        List<string> ListEmployees = new List<string>();

        private string NameEmployee;
        private string Street;
        private string City;
        private double Salary;
        private double Commission;
        private double sales;
        private double wage;
        private int hour;
        private DateTime dateTime;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            CreateEmployee();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            dialogResult = MessageBox.Show("Bạn có muốn thêm nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult.Equals(DialogResult.Yes))
            {
                GetEmployeeInfo();
                InsertEmployee();
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                dialogResult = MessageBox.Show("Bạn có muốn nhập lại nhân viên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    CreateEmployee();
                }
            }
        }

        private void CreateEmployee() {
            this.txbTenDuong.Text = "";
            this.txbTenNhanVien.Text = "";
            this.txbTenThanhPho.Text = "";

            this.nmrudSoGioLam.Value = 0;
            this.nmrudSoLuongBan.Value = 0;
            this.nmrudSoTienCong.Value = 0;
            this.nmrudSoTienLuong.Value = 0;
            this.nmrudThuLoa.Value = 0;
            this.dtpkNgaySinh.Value = DateTime.Now;
        }
        
        private void GetEmployeeInfo() {
            NameEmployee = txbTenNhanVien.Text.ToString();
            Street = this.txbTenDuong.Text.ToString();
            City = txbTenThanhPho.Text.ToString();

            Salary = (double)nmrudSoTienLuong.Value;
            Commission = (double)nmrudThuLoa.Value;
            sales = (double)nmrudSoLuongBan.Value;
            wage = (double)nmrudSoTienCong.Value;
            hour = (int)nmrudSoGioLam.Value;

            dateTime = dtpkNgaySinh.Value;
        }

        private void InsertEmployee() {
            string _salariedEmployee = CreateSalariedEmployee().ToString();
            string _salesEmployee = CreateSalesEmployee().ToString();
            string _wagedEmployee = CreateWagedEmployee().ToString();

            string Mess = string.Format("Thông tin nhân viên {0} \n\nThông tin bán hàng {1} \n\nTiền công nhân viên {2}", new object[] { _salariedEmployee, _salesEmployee, _wagedEmployee });
            ListEmployees.Add(Mess);
        }
       
        private SalariedEmployee CreateSalariedEmployee() {
            SalariedEmployee salariedEmployee = new SalariedEmployee(NameEmployee, dateTime.Year, dateTime.Month, dateTime.Day, Salary);
            salariedEmployee.SetAddress(Street, City);
            return salariedEmployee;
        }

        private SalesEmployee CreateSalesEmployee()
        {
            SalesEmployee salesEmployee = new SalesEmployee(NameEmployee, dateTime.Year, dateTime.Month, dateTime.Day, Salary, Commission, sales);
            salesEmployee.SetAddress(Street, City);
            return salesEmployee;
        }

        private WagedEmployee CreateWagedEmployee()
        {
            WagedEmployee waged = new WagedEmployee(NameEmployee, dateTime.Year, dateTime.Month, dateTime.Day, wage, hour); ;
            waged.SetAddress(Street, City);
            return waged;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            foreach (var item in ListEmployees) {
                DialogResult dialogResult =  MessageBox.Show(item,"Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

                if (dialogResult != DialogResult.OK) {
                    break;
                }
            }
        }
    }
}
