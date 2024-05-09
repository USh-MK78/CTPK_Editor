using CTPK_Library;
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

namespace CTPK_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open_CTPK = new OpenFileDialog()
            {
                Title = "Open CTPK (3DS)",
                InitialDirectory = @"C:\Users\User\Desktop",
                Filter = "ctpk file|*.ctpk"
            };

            if (Open_CTPK.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(Open_CTPK.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                CTPK cTPK = new CTPK();
                cTPK.Read_CTPK(br);

                foreach (var item in cTPK.Root_CTPKDataList)
                {
                    CTPKData_ListBox.Items.Add(item.Name);
                }

                foreach (var item in cTPK.CTPKDataList)
                {
                    CTPKData_ListBox.Items.Add(item.Name);
                }

            }

        }
    }
}
