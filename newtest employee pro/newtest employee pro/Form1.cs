using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

    
namespace newtest_employee_pro
{
    public partial class frm : Form
    {
        // هنا جملة الاتصال والمتطلبات لكي نربط بين السيكوال سيرفر والسي شارب
        // وايضا تعاريف مهمة من البيانات والجدول 
        SqlConnection conn = new SqlConnection("Server=DESKTOP-U9D8BHS\\YASIR;Database=Emp;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable Dt = new DataTable("Employee");
        DataSet ds = new DataSet();
        SqlCommandBuilder cmdb;
        CurrencyManager cm;
        public frm()
        {
            // متطلبات الربط من جملة وجدول وملئ الداتا كرد فيو
            InitializeComponent();
            adapter = new SqlDataAdapter("select * from Employee", conn);
            adapter.Fill(Dt);
            dgv.DataSource = Dt;

            // هنا كي نحمل المعلومات ونربطها بين التصميم التكستبوكس والجدول مع الداتاكردفيو
            txtEmpID.DataBindings.Add("text", Dt, "EmployeeID");
            txtEmpName.DataBindings.Add("text", Dt, "EmployeeName");
            txtEmpSalary.DataBindings.Add("text", Dt, "EmployeeSalary");
            txtAddress.DataBindings.Add("text", Dt, "Address");
            // هذا الايعاز في الاسفل مهم يسهل علينا كتابة العمليات الاربعة من اضافة وحذف ... الخ
            cm = (CurrencyManager)this.BindingContext[Dt];
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // زر الاضافة
            cm.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(adapter);
            adapter.Update(Dt);
            MessageBox.Show("Add Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // زر تفريغ الخانات وعمل حقل جديد فارغ
           cm.AddNew();
           txtEmpID.Focus();
        }

        private void txtEmpSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // زر التعديل 
            cm.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(adapter);
            adapter.Update(Dt);
            cm.Refresh();
            MessageBox.Show("Update Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // زرالحذف 
            // هنا رسالة قبل الحذف حيث يستفسر هل نريد فعلا الحذف او التراجع عن الحذف ؟
            DialogResult del = MessageBox.Show("Are you sure to delete file", "worring", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                cm.RemoveAt(cm.Position);
                cm.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(adapter);
                adapter.Update(Dt);
                MessageBox.Show("Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
            else
            {
                MessageBox.Show("Do Not Delete!", "Worring", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            // لغرض برمجة البحث عن طريق الاسم والعنوان 
            DataView dv = new DataView(Dt);
            string Expr= " like'%" + txtsearch.Text + "%'";

                  
                if (rdName.Checked) Expr = "EmployeeName" + Expr;

                else if (rdAddress.Checked) Expr = "Address" + Expr;

                dv.RowFilter = Expr;
                dgv.DataSource = dv;
            }
           
        

        private void btnExpoData_Click(object sender, EventArgs e)
        {
            // في هذا الزر نقوم بحفظ البيانات على شكل فايل اكي ام ال حتى نستفاد منها عند حصول خطا او تلف قاعدة البيانات
             if(sfd.ShowDialog()==DialogResult.OK)
            {
                Dt.WriteXml(sfd.FileName);
                MessageBox.Show("File Saved");
            }
        }
    }
}
