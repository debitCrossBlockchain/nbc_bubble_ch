using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//引用创建Access数据库的库
using System.Data.OleDb;
using System.IO;
using System.Collections;
namespace SunManage.communication
{
    public partial class Export : Form
    {

        private OleDbConnection mConnection;
        string sAccessConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\DataBase\\TestHistoryData.mdb";
       
        //private DataSet ds1 = new DataSet();//数据库操作
        Main mTreeName = new Main();
        public Export()
        {
            InitializeComponent();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            query();
        }
        private void query()
        {
            DataSet ds = new DataSet();//数据库操作
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select TestHisData as 序号, Htest_type as 测试模态,Test_Psernum as 生产批号 ,HA_STime as 测试时间,Test_Name as 测试名称,Test_Fsernum as 滤器序号,Test_filt as 滤材种类,Test_LIQU as 测试液体,Test_Filt_Hight as 滤芯高度,Test_Filt_Num as 滤芯数量,Test_Result as 结果,Test_startp as 起测压力,Test_SetBp as 最小泡点,Test_Up_Volm as 上游体积,Test_Dif_max as 最大扩散流,Htest_DifValue as 测试值1,Htest_Value as 测试值2,Test_Filter_Area as 过滤面积,Test_Meme_Aper as 孔径,Test_Filter_type as 过滤器种类,Htest_DiffePress as 压力衰减,Test_CDifValue as 最大扩散流值,Test_testimes as 采样次数,Test_Sampling_Frequency as 采样点的频率,Htest_DifStart as 扩散流的起始位置,Htest_Name as 测试人员名,Htest_Press_Line as 压力的曲线值,Htest_Dif_Line as 扩散流的曲线值  From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(mQuery, mConnection);
            //DataGridView dz = new DataGridView();
            //dz.DataSource = ds.Tables[0].DefaultView;
            //如果需要再次查询，需清空dataset里面的数据  
            try
            {
               
                mConnection.Open();
                

                dataAdapter.Fill(ds);
                dataGridViewExportInfo.DataSource = ds.Tables[0].DefaultView;
                dataGridViewExportInfo.AllowUserToAddRows = false;
                
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());

            }

            finally
            {
                mConnection.Close();
            }
        }

        private void buttonExportRefresh_Click(object sender, EventArgs e)
        {
            query();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewExportInfo.Rows.Count > 0)
                {

                    saveFileDialogExport.InitialDirectory = @"..\..\Export";
                    saveFileDialogExport.Filter = "txt文件|*.*";
                    saveFileDialogExport.FilterIndex = 2;
                    //saveFileDialog1.RestoreDirectory =false ;
                    saveFileDialogExport.ShowHelp = true;
                    saveFileDialogExport.Title = "保存txt";
                    saveFileDialogExport.FileName = DateTime.Now.ToString("yyyy-MM-dd ");
                    saveFileDialogExport.RestoreDirectory = true;
                    if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
                    {
                        string saveName = saveFileDialogExport.FileName.ToString();


                        string str = dataGridViewExportInfo.Rows.Count.ToString() + "\r\n";
                        for (int i = 0; i < dataGridViewExportInfo.Rows.Count; i++)
                        {
                            string Htest_type = "";
                            switch (dataGridViewExportInfo.Rows[i].Cells[1].Value.ToString())
                            {
                                case "手动泡点测试":
                                    {
                                        Htest_type = "M";
                                    }
                                    break;
                                case "基本泡点测试":
                                    {
                                        Htest_type = "B";
                                    }
                                    break;
                                case "增强泡点测试":
                                    {
                                        Htest_type = "A";
                                    }
                                    break;
                                case "保压测试":
                                    {
                                        Htest_type = "P";
                                    }
                                    break;
                                case "扩散流测试":
                                    {
                                        Htest_type = "D";
                                    }
                                    break;
                                case "超滤测试":
                                    {
                                        Htest_type = "d";
                                    }
                                    break;
                                case "水浸入测试":
                                    {
                                        Htest_type = "H";
                                    }
                                    break;
                                default: break;


                            }

                            str = str + (i + 1).ToString() + "," + Htest_type;
                            for (int j = 2; j < 26;j++)
                            {
                                str =str+ "," + dataGridViewExportInfo.Rows[i].Cells[j].Value.ToString();

                            }
                            string strPrcess = dataGridViewExportInfo.Rows[i].Cells[26].Value.ToString();
                            string strDif = dataGridViewExportInfo.Rows[i].Cells[27].Value.ToString();
                            str = str +","+strPrcess +","+","+","+  strDif + "," + "\r\n";
                        }

                        File.WriteAllText(saveName, str, System.Text.Encoding.GetEncoding("GB2312"));
                        MessageBox.Show("已导出文件！");
                  
                    }

                }
            }

            catch (Exception ex)
            {

                LogClass.WriteLogFile ("Exception:" + ex.ToString());

            }
        }
    }
}
