using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelPhoneApp {
    public partial class MainForm : Form {
        People pList = new People();
        public MainForm() {
            InitializeComponent();
        }
        private void UpdateDisplay(People lt) {
            lbDisplay.Items.Clear();
            for (int i = 0; i < lt.Count; ++i)
                lbDisplay.Items.Add(lt[i].ToString());
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            if (txtName.Text != "" && txtPhone.Text != "") {
                Person per = new Person(txtName.Text, txtPhone.Text);
                pList.Add(per);

                txtName.Text = "";
                txtPhone.Text = "";
                txtName.Focus();
                UpdateDisplay(pList);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e) {
            string name = txtSearch.Text;
            if (name == "")
                return;

            txtSearch.Text = "";
            txtSearch.Focus();

            People tlist = new People();
            for(int i = 0; i < pList.Count; ++i)
                if(pList[i].Name == name) {
                    tlist.Add(pList[i]);
                }
            UpdateDisplay(tlist);
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            string phone = txtRemove.Text;
            if (phone == "")
                return;

            txtRemove.Text = "";
            txtRemove.Focus();
                        
            for (int i = 0; i < pList.Count; ++i)
                if (pList[i].Phone == phone) {
                    pList.Remove(i);
                }
            UpdateDisplay(pList);
        }
        private void btnPrint_Click(object sender, EventArgs e) {
            UpdateDisplay(pList);
        }
    }
}
