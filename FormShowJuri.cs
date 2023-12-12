using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DBCon;

namespace WindowsFormsApp1
{
    public partial class FormShowJuri : Form
    {
        public FormShowJuri()
        {
            InitializeComponent();
        }

        private void FormShowJuri_Load(object sender, EventArgs e)
        {
            int number = 1;
            foreach (int i in MainForm.JuryList)
            {
                User user = DBConst.model.User.Find(i);
                UserControJuri userControJuri = new UserControJuri();
                userControJuri.Fill(user, number);
                flowLayoutPanel2.Controls.Add(userControJuri);
                number++;
            }

        }
    }
}
