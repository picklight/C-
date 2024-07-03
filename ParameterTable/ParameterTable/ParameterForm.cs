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


namespace ParameterTable
{
    public partial class ParameterForm : Form
    {
        private UserControl[] userControls = new UserControl[2];
        private int selectedIndex = 0;
        public ParameterForm()
        {
            InitializeComponent();
            

        }

     
        private void ParameterForm_Load(object sender, EventArgs e)
        {
            userControls[0] = paramPage1;
            userControls[1] = paramPage2;

        }
        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            selectedIndex--;
            if (selectedIndex < 0) selectedIndex = userControls.Length - 1; // 如果小于零则循环回到最后一个标签页索引位置
            UpdateParamPage(selectedIndex);
        }
        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            selectedIndex++;
            if (selectedIndex >= userControls.Length) selectedIndex = 0; // 如果大于等于最大索引则循环回到第一个标签页索引位置
            UpdateParamPage(selectedIndex);

        }

 
        private  void UpdateParamPage(int page)
        {
            for (int i = 0; i < userControls.Length; i++)
            {
                if (i == page)
                {
                    userControls[i].Visible = true;
                }
                else
                {
                    userControls[i].Visible = false;
                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            bool allIsNullEmpty = Param.Parameter.AllPropertiesIsNullEmpty();
            if (allIsNullEmpty)
            {
                Param.SaveDataAsJson();
            }
            else
            {
                MessageBox.Show("有参数没有填写，请填写完整！");
            }
        }

       
    }
}
