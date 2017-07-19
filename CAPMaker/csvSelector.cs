using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPMaker
{
    

    public partial class csvSelector : Form
    {
        public string Field_areadesc { get; set; }
        public string Field_areatype { get; set; }


        public csvSelector()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;

        }

        public void setColumns(string[] headers)
        {
            cbAreaType.DataSource = headers.Clone();

            cbAREADESC.DataSource = headers.Clone();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(cbAREADESC.SelectedIndex==cbAreaType.SelectedIndex)
            {
                MessageBox.Show("請選擇不同的欄位，以方便程式進行匯入工作", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Field_areadesc = cbAREADESC.SelectedItem.ToString();

            Field_areatype = cbAreaType.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
