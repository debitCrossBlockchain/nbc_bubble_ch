using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SunManage.AllCheck
{
    public partial class Test_Liquid : Form
    {
        bool formMove = false;//窗体是否移动
        Point formPoint;//记录窗体的位置
        public static string mTest_Liquid = "";
        public Test_Liquid()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 水
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWater_Click(object sender, EventArgs e)
        {
           
            try
            {

                mTest_Liquid = "水";
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
        /// <summary>
        /// 酒精
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAlcohol_Click(object sender, EventArgs e)
        {
            try
            {

                mTest_Liquid = "乙醇";
                Concentration mConcentrationW = new Concentration();
                this.Close();
                this.Dispose();
                mConcentrationW.Show();
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }

           
        }
        /// <summary>
        /// 异丙醇
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelIsopropanol_Click(object sender, EventArgs e)
        {
            try
            {

                mTest_Liquid = "异丙醇";
                Concentration mConcentrationW = new Concentration();
                this.Close();
                this.Dispose();
                mConcentrationW.Show();
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
        /// <summary>
        /// 其它
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelOther_Click(object sender, EventArgs e)
        {
            try
            {

                mTest_Liquid = "其它";
                Fluid mFluidW = new Fluid();
                this.Close();
                this.Dispose();
                mFluidW.Show();
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }

        private void Test_Liquid_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                formPoint = new Point();
                int xOffset;
                int yOffset;
                if (e.Button == MouseButtons.Left)
                {
                    xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                    yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                    formPoint = new Point(xOffset, yOffset);
                    formMove = true;//开始移动
                }
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }

        private void Test_Liquid_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (formMove == true)
                {
                    Point mousePos = Control.MousePosition;
                    mousePos.Offset(formPoint.X, formPoint.Y);
                    Location = mousePos;
                }
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }

      

        private void labelCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }

        private void Test_Liquid_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)//按下的是鼠标左键
                {
                    formMove = false;//停止移动
                }
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
    }
}
