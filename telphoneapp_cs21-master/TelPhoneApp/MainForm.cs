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
        private void btnAdd_Click(object sender, EventArgs e) {
            if (txtName.Text != "" && txtPhone.Text != "") {
                Person per = new Person(txtName.Text, txtPhone.Text);
                pList.Add(per);

                txtName.Text = "";
                txtPhone.Text = "";
                txtName.Focus();
                UpdateDisplay();
            }
        }
        private void UpdateDisplay() {
            lbDisplay.Items.Clear();
            for (int i = 0; i < pList.Count; ++i)
                lbDisplay.Items.Add(pList[i].ToString());
        }
    }
}
