using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Xml;
using SunManage.communication;

namespace SunManage.AllCheck
{
    public partial class mSystemParameter : Form
    {
        public static int mProject = 0;
        private OleDbConnection mConnection;
        string sAccessConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\DataBase\\SystemParameter.mdb";


        Main mTreeName = new Main();
        public mSystemParameter()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询最大扩散流参数事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFilter_Difmax_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select PES_Dif_max, PVDF_Dif_max,PTFE_Dif_max,NYLON_Dif_max,OTHER_Dif_max,PTFE_flow_max From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tBPES_Dif_max.Text = reader[0].ToString();
                tBPVDF_Dif_max.Text = reader[1].ToString();
                tBPTFE_Dif_max.Text = reader[2].ToString();
                tBNYLON_Dif_max.Text = reader[3].ToString();
                tBOTHER_Dif_max.Text = reader[4].ToString();
                //tBPTFE_flow_max.Text = reader[5].ToString();
            }
            reader.Close();
            mConnection.Close();
            //    PES_Dif_max, PVDF_Dif_max,PTFE_Dif_max,NYLON_Dif_max,OTHER_Dif_max,PTFE_flow_max
        }
        /// <summary>
        /// 查询设备的基本参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDevice_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select  Inter_Volm,Exter_Volm,SourceP,AddP_extent,Print_Setup,Over_ModeSetup,Language_Setup,Default_Load,InitTestPara,Test_rate From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //tBInter_Volm.Text = reader[0].ToString();
                tBExter_Volm.Text = reader[1].ToString();
                tBSourceP.Text = reader[2].ToString();
                tBAddP_extent.Text = reader[3].ToString();
                string Print_Setup = reader[4].ToString();
                string Over_ModeSetup = reader[5].ToString();
                string Language_Setup = reader[6].ToString();
                string Default_Load = reader[7].ToString();
                string InitTestPara = reader[8].ToString();
                string Test_rate = reader[9].ToString();
                const Int32 a = 0;
                const Int32 b = 1;
                //打印设置
                switch (Convert.ToInt32(Print_Setup))
                {
                    case a:
                        radioButtonPrint_SetupAuto.Checked = true;
                        radioButtonPrint_SetupManual.Checked = false;
                        break;
                    case b:
                        radioButtonPrint_SetupAuto.Checked = false;
                        radioButtonPrint_SetupManual.Checked = true;
                        break;
                    default: break;
                }

                //结束还是询问

                switch (Convert.ToInt32(Over_ModeSetup))
                {
                    case a:
                        radioButtonOver_ModeSetupM.Checked = true;
                        radioButtonOver_ModeSetupA.Checked = false;
                        break;
                    case b:
                        radioButtonOver_ModeSetupM.Checked = false;
                        radioButtonOver_ModeSetupA.Checked = true;
                        break;
                    default: break;
                }
                //语言选择，中文还是英文


                switch (Convert.ToInt32(Language_Setup))
                {
                    case a:
                        radioButtonLanguage_SetupC.Checked = true;
                        radioButtonLanguage_SetupE.Checked = false;
                        break;
                    case b:
                        radioButtonLanguage_SetupC.Checked = false;
                        radioButtonLanguage_SetupE.Checked = true;
                        break;
                    default: break;
                }
                //是否加载缺省值

                switch (Convert.ToInt32(Default_Load))
                {
                    case a:
                        radioButtonDefault_LoadYes.Checked = true;
                        radioButtonDefault_LoadNo.Checked = false;
                        break;
                    case b:
                        radioButtonDefault_LoadYes.Checked = false;
                        radioButtonDefault_LoadNo.Checked = true;
                        break;
                    default: break;
                }
                //是否初始化测试参数

                switch (Convert.ToInt32(InitTestPara))
                {
                    case a:
                        radioButtonInitTestParaYes.Checked = true;
                        radioButtonInitTestParaNo.Checked = false;
                        break;
                    case b:
                        radioButtonInitTestParaYes.Checked = false;
                        radioButtonInitTestParaNo.Checked = true;
                        break;
                    default: break;
                }
                

            }
            reader.Close();
            mConnection.Close();
        }

        private void buttonSystem_Manage_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select  senson_adj_year,senson_adj_month,OutFaction_year,OutFaction_month,IF_Outfaction,Device_Serial,Using_CompanyName From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    comboBoxSenson_adj_year.Text = reader[0].ToString();
            //    comboBoxSenson_adj_month.Text = reader[1].ToString();
            //    comboBoxOutFaction_year.Text = reader[2].ToString();
            //    comboBoxOutFaction_month.Text = reader[3].ToString();
            //    textBoxIF_Outfaction.Text = reader[4].ToString();
            //    textBoxDevice_Serial.Text = reader[5].ToString();
            //    textBoxUsing_CompanyName.Text = reader[6].ToString();
            //}
            reader.Close();
            mConnection.Close();
        }

        private void buttonSensor_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select  Psense_Zero_0,Psense_Zero_1,Psense_Coeff_0,Psense_Coeff_1 From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    textBoxPsense_Zero_0.Text = reader[0].ToString();
            //    textBoxPsense_Zero_1.Text = reader[1].ToString();
            //    textBoxPsense_Coeff_0.Text = reader[2].ToString();
            //    textBoxPsense_Coeff_1.Text = reader[3].ToString();

            //}
            reader.Close();
            mConnection.Close();
        }

        private void buttonCommuniction_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select  Brate_Uart,Databits_Uart,Parity_Uart,Stopbit_Uart,IFAutoIP,Net_IP1,Net_IP2,Net_IP3,Net_IP4,Subnet_Mask1,Subnet_Mask2,Subnet_Mask3,Subnet_Mask4,Default_Gateway1,Default_Gateway2,Default_Gateway3,Default_Gateway4 From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    textBoxBrate_Uart.Text = reader[0].ToString();
            //    comboBoxDatabits_Uart.Text = reader[1].ToString();
            //    comboBoxParity_Uart.Text = reader[2].ToString();
            //    comboBoxStopbit_Uart.Text = reader[3].ToString();
            //    string IFAutoIP = reader[4].ToString();
            //    switch (Convert.ToInt32(IFAutoIP))
            //    { 
            //        case 0:
            //            radioButtonIFAutoIPYes.Checked = true;
            //            radioButtonIFAutoIPNo.Checked = false;
            //            break;
            //        case 1:
            //            radioButtonIFAutoIPYes.Checked = false;
            //            radioButtonIFAutoIPNo.Checked = true;
            //            break;
            //        default: break;
            //    }
            //    textBoxNet_IP.Text = reader[5].ToString() + "." + reader[6].ToString() + "." + reader[7].ToString() + "." + reader[8].ToString();
            //    textBoxSubnet_Mask.Text = reader[9].ToString() + "." + reader[10].ToString() + "." + reader[11].ToString() + "." + reader[12].ToString();
            //    textBoxDefault_Gateway.Text= reader[13].ToString() + "." + reader[14].ToString() + "." + reader[15].ToString() + "." + reader[16].ToString();
            //}
            reader.Close();
            mConnection.Close();
        }

        private void buttonPowerManage_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select  Power_Supply,BatterPower_light,ACPower_light,Backlight_time,BatterPower_ScreenSave,BattBacklight_time From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    textBoxPower_Supply.Text = reader[0].ToString();
            //    textBoxBatterPower_light.Text = reader[1].ToString();
            //    textBoxACPower_light.Text = reader[2].ToString();
            //    textBoxBacklight_time.Text = reader[3].ToString();
            //    textBoxBatterPower_ScreenSave.Text = reader[4].ToString();
            //    textBoxBattBacklight_time.Text = reader[5].ToString();

            //}
            reader.Close();
            mConnection.Close();
        }

        private void buttonTouchManage_Param_Click(object sender, EventArgs e)
        {
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select  CurrScreen_light,Touch_Sound From {0}";
            mQuery = string.Format(mQuery, mTreeView);
            mConnection = new OleDbConnection(sAccessConnection);
            mConnection.Open();
            OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    textBoxCurrScreen_light.Text = reader[0].ToString();
            //    textBoxTouch_Sound.Text = reader[1].ToString();


            //}
            reader.Close();
            mConnection.Close();
        }

        private void mSystemParameter_Load(object sender, EventArgs e)
        {

            string Print_Setup = "1";
            string Over_ModeSetup = "1";
            string Language_Setup = "1";
            string Default_Load ="1";
            string InitTestPara ="1";
       
              //实例化xml
            XmlDocument xml = new XmlDocument();
            //读取xml文件
            xml.Load(@"..\..\XmlIni\StartTheTestData.XML");  //xml地址

            //////////*******下面开始循环读取xml文件信息********/
            ///////////////
            foreach (XmlNode node in xml.ChildNodes)
            {
                if (node.Name == "Config")
                {
                    foreach (XmlNode node1 in node.ChildNodes)
                    {
                        if (node1.Name == "SystemParameter")
                        {
                            foreach (XmlNode node2 in node1.ChildNodes)
                            {
                                switch (node2.Name)
                                {
                                    //各种滤材的最大扩散流参数
                                    case "PES_Dif_max":
                                        tBPES_Dif_max.Text  = node2.InnerText;
                                        break;

                                    case "PVDF_Dif_max":
                                         tBPVDF_Dif_max.Text  = node2.InnerText;
                                        break;
                                    case "PTFE_Dif_max":
                                         tBPTFE_Dif_max.Text = node2.InnerText;
                                        break;
                                    case "NYLON_Dif_max":
                                         tBNYLON_Dif_max.Text = node2.InnerText;
                                        break;
                                    case "OTHER_Dif_max":
                                        tBOTHER_Dif_max.Text = node2.InnerText;
                                        break;
                                    ////设备的基本参数
                                    case "Exter_Volm":
                                         tBExter_Volm.Text = node2.InnerText;
                                        break;

                                    case "SourceP":
                                        tBSourceP.Text = node2.InnerText;
                                        break;
                                    case "AddP_extent":
                                        tBAddP_extent.Text = node2.InnerText;
                                        break;
                                    case "Print_Setup":
                                        Print_Setup = node2.InnerText;
                                        break;

                                    case "Over_ModeSetup":
                                        Over_ModeSetup = node2.InnerText;
                                        break;
                                    case "Language_Setup":
                                        Language_Setup = node2.InnerText;
                                        break;
                                    case "Default_Load":
                                        Default_Load = node2.InnerText;
                                        break;
                                    case "InitTestPara":
                                        InitTestPara = node2.InnerText;
                                        break;
                                    default:

                                        break;
                                }
                            }

                        }
                    }
                }
            
            
                const Int32 a = 0;
                const Int32 b = 1;
                //打印设置
                switch (Convert.ToInt32(Print_Setup))
                {
                    case a:
                         radioButtonPrint_SetupAuto.Checked = false;
                        radioButtonPrint_SetupManual.Checked = true;
                        break;
                       
                    case b:
                         radioButtonPrint_SetupAuto.Checked = true;
                        radioButtonPrint_SetupManual.Checked = false;
                        break;
                       
                    default: break;
                }

                //结束还是询问

                switch (Convert.ToInt32(Over_ModeSetup))
                {
                    case a:
                        radioButtonOver_ModeSetupM.Checked = false;
                        radioButtonOver_ModeSetupA.Checked = true;
                        break;
                       
                    case b:
                        
                         radioButtonOver_ModeSetupM.Checked = true;
                        radioButtonOver_ModeSetupA.Checked = false;
                        break;
                    default: break;
                }
                //语言选择，中文还是英文


                switch (Convert.ToInt32(Language_Setup))
                {
                    case a:
                        radioButtonLanguage_SetupC.Checked = false;
                        radioButtonLanguage_SetupE.Checked = true;
                        break;
                    case b:
                        radioButtonLanguage_SetupC.Checked = true;
                        radioButtonLanguage_SetupE.Checked = false;
                    
                        break;
                    default: break;
                }
                //是否加载缺省值

                switch (Convert.ToInt32(Default_Load))
                {
                    case a:
                        radioButtonDefault_LoadYes.Checked = false;
                        radioButtonDefault_LoadNo.Checked = true;
                        break;
                    case b:
                        radioButtonDefault_LoadYes.Checked = true;
                        radioButtonDefault_LoadNo.Checked = false;
                        
                        break;
                    default: break;
                }
                //是否初始化测试参数

                switch (Convert.ToInt32(InitTestPara))
                {
                    case a:
                        radioButtonInitTestParaYes.Checked = false;
                        radioButtonInitTestParaNo.Checked = true;
                        
                        break;
                    case b:
                        radioButtonInitTestParaYes.Checked = true;
                        radioButtonInitTestParaNo.Checked = false;
                       
                        break;
                    default: break;
                }
                


                
            }



        }
          /// <summary>
          /// 把记录存储到数据库
         /// </summary>
         /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            switch (comboBoxProject.SelectedIndex)
            {
                case 0:
                    mProject = 1;
                    break;
                case 1:
                    mProject = 2;
                    break;
                case 2:
                    mProject = 3;
                    break;
                case 3:
                    mProject = 4;
                    break;
                case 4:
                    mProject = 5;
                    break;
                case 5:
                    mProject = 6;
                    break;
                case 6:
                    mProject = 7;
                    break;
                case 7:
                    mProject = 8;
                    break;
                case 8:
                    mProject = 9;
                    break;
                case 9:
                    mProject = 10;
                    break;
                case 10:
                    mProject = 11;
                    break;
                case 11:
                    mProject = 12;
                    break;
                case 12:
                    mProject = 13;
                    break;
                case 13:
                    mProject = 14;
                    break;
                case 14:
                    mProject = 15;
                    break;
                case 15:
                    mProject = 16;
                    break;
                case 16:
                    mProject = 17;
                    break;
                case 17:
                    mProject = 18;
                    break;
                case 18:
                    mProject = 19;
                    break;
                case 19:
                    mProject = 20;
                    break;

                default: break;
            }
            string Print_Setup = "";
            string Over_ModeSetup = "";
            string Language_Setup = "";
            string Default_Load = "";
            string InitTestPara = "";
           
            //打印设置
           
            if ((radioButtonPrint_SetupAuto.Checked == false) && (radioButtonPrint_SetupManual.Checked == true))
            {
                Print_Setup = "0";
            }
            else if ((radioButtonPrint_SetupAuto.Checked == true) && (radioButtonPrint_SetupManual.Checked == false))
            {
                Print_Setup = "1";
            }
            //结束还是询问

           
            if ((radioButtonOver_ModeSetupM.Checked == false) && (radioButtonOver_ModeSetupA.Checked == true))
            {
                Over_ModeSetup = "0";
            }
            else if ((radioButtonOver_ModeSetupM.Checked == true) && (radioButtonOver_ModeSetupA.Checked == false))
            {
                Over_ModeSetup = "1";
            }
            //语言选择，中文还是英文

            if ((radioButtonLanguage_SetupC.Checked == false) && (radioButtonLanguage_SetupE.Checked == true))
            {
                Language_Setup = "0";
            }
            else if ((radioButtonLanguage_SetupC.Checked == true) && (radioButtonLanguage_SetupE.Checked == false))
            {
                Language_Setup = "1";
            }
            //是否加载缺省值

            if ((radioButtonDefault_LoadYes.Checked == false) && (radioButtonDefault_LoadNo.Checked == true))
            {
                Default_Load = "0";
            }
            else if ((radioButtonDefault_LoadYes.Checked == true) && (radioButtonDefault_LoadNo.Checked == false))
            {
                Default_Load = "1";
            }
            //是否初始化测试参数

            if ((radioButtonInitTestParaYes.Checked == false) && (radioButtonInitTestParaNo.Checked == true))
            {
                InitTestPara = "0";
            }
            else if ((radioButtonInitTestParaYes.Checked == true) && (radioButtonInitTestParaNo.Checked == false))
            {
                InitTestPara = "1";
            }
            

             DialogResult dr = MessageBox.Show("你确定要保存系统参数到数据库吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (DialogResult.Yes == dr)
             {
                 string mTreeView = Main.MTreeName.ToString();




                 string mQuery = String.Format("insert into {0}([SystemParameter],[PES_Dif_max],[PVDF_Dif_max],[PTFE_Dif_max],[NYLON_Dif_max],[OTHER_Dif_max],[Exter_Volm],[SourceP],[AddP_extent],[Print_Setup],[Over_ModeSetup],[Language_Setup],[Default_Load],[InitTestPara]) values ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", mTreeView, mProject, tBPES_Dif_max.Text.ToString(), tBPVDF_Dif_max.Text.ToString(), tBPTFE_Dif_max.Text.ToString(), tBNYLON_Dif_max.Text.ToString(), tBOTHER_Dif_max.Text.ToString(), tBExter_Volm.Text.ToString(), tBSourceP.Text.ToString(), tBAddP_extent.Text.ToString(), Print_Setup, Over_ModeSetup, Language_Setup, Default_Load, InitTestPara);

                 // mQuery = string.Format(mQuery, mTreeView);
                 mConnection = new OleDbConnection(sAccessConnection);

                 OleDbCommand da = new OleDbCommand(mQuery, mConnection);

                 //

                 try
                 {
                     mConnection.Open();
                     da.ExecuteNonQuery();

                     MessageBox.Show("增加成功！", "提示");



                 }

                 catch (Exception ex)
                 {

                     MessageBox.Show("异常：" + ex.ToString(), "方案名称必须唯一");

                 }

                 finally
                 {

                     mConnection.Close();

                 }
             }
            
        }
        /// <summary>
        /// 查询数据库中的方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxInquire_Click(object sender, EventArgs e)
        {
            switch (comboBoxProject.SelectedIndex)
            {
                case 0:
                    mProject = 1;
                    break;
                case 1:
                    mProject = 2;
                    break;
                case 2:
                    mProject = 3;
                    break;
                case 3:
                    mProject = 4;
                    break;
                case 4:
                    mProject = 5;
                    break;
                case 5:
                    mProject = 6;
                    break;
                case 6:
                    mProject = 7;
                    break;
                case 7:
                    mProject = 8;
                    break;
                case 8:
                    mProject = 9;
                    break;
                case 9:
                    mProject = 10;
                    break;
                case 10:
                    mProject = 11;
                    break;
                case 11:
                    mProject = 12;
                    break;
                case 12:
                    mProject = 13;
                    break;
                case 13:
                    mProject = 14;
                    break;
                case 14:
                    mProject = 15;
                    break;
                case 15:
                    mProject = 16;
                    break;
                case 16:
                    mProject = 17;
                    break;
                case 17:
                    mProject = 18;
                    break;
                case 18:
                    mProject = 19;
                    break;
                case 19:
                    mProject = 20;
                    break;

                default: break;
            }
            string mTreeView = Main.MTreeName.ToString();
            string mQuery = "Select * From {0} where [SystemParameter]={1}";
            mQuery = string.Format(mQuery, mTreeView, mProject);
            mConnection = new OleDbConnection(sAccessConnection);
           
            try
            {
                mConnection.Open();
                OleDbCommand cmd = new OleDbCommand(mQuery, mConnection);
                OleDbDataReader reader= cmd.ExecuteReader();
                if (reader.Read())
                {
                   
                    tBPES_Dif_max.Text=reader[1].ToString();
                    tBPVDF_Dif_max.Text=reader[2].ToString();
                    tBPTFE_Dif_max.Text=reader[3].ToString();
                    tBNYLON_Dif_max.Text=reader[4].ToString(); 
                    tBOTHER_Dif_max.Text=reader[5].ToString();
                    tBExter_Volm.Text=reader[6].ToString();
                    tBSourceP.Text=reader[7].ToString();
                    tBAddP_extent.Text = reader[8].ToString();
                    const Int32 a = 0;
                    const Int32 b = 1;
                    //打印设置
                    switch (Convert.ToInt32(reader[9]))
                    {
                        case a:
                            radioButtonPrint_SetupAuto.Checked = false;
                            radioButtonPrint_SetupManual.Checked = true;
                            break;

                        case b:
                            radioButtonPrint_SetupAuto.Checked = true;
                            radioButtonPrint_SetupManual.Checked = false;
                            break;

                        default: break;
                    }

                    //结束还是询问

                    switch (Convert.ToInt32(reader[10]))
                    {
                        case a:
                            radioButtonOver_ModeSetupM.Checked = false;
                            radioButtonOver_ModeSetupA.Checked = true;
                            break;

                        case b:

                            radioButtonOver_ModeSetupM.Checked = true;
                            radioButtonOver_ModeSetupA.Checked = false;
                            break;
                        default: break;
                    }
                    //语言选择，中文还是英文


                    switch (Convert.ToInt32(reader[11]))
                    {
                        case a:
                            radioButtonLanguage_SetupC.Checked = false;
                            radioButtonLanguage_SetupE.Checked = true;
                            break;
                        case b:
                            radioButtonLanguage_SetupC.Checked = true;
                            radioButtonLanguage_SetupE.Checked = false;

                            break;
                        default: break;
                    }
                    //是否加载缺省值

                    switch (Convert.ToInt32(reader[12]))
                    {
                        case a:
                            radioButtonDefault_LoadYes.Checked = false;
                            radioButtonDefault_LoadNo.Checked = true;
                            break;
                        case b:
                            radioButtonDefault_LoadYes.Checked = true;
                            radioButtonDefault_LoadNo.Checked = false;

                            break;
                        default: break;
                    }
                    //是否初始化测试参数

                    switch (Convert.ToInt32(reader[13]))
                    {
                        case a:
                            radioButtonInitTestParaYes.Checked = false;
                            radioButtonInitTestParaNo.Checked = true;

                            break;
                        case b:
                            radioButtonInitTestParaYes.Checked = true;
                            radioButtonInitTestParaNo.Checked = false;

                            break;
                        default: break;
                    }
                
                }
                MessageBox.Show("方案查询成功！");
                reader.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.ToString(), "方案可能不存在");

            }

            finally
            {
               
                mConnection.Close();
            }
        }
        /// <summary>
        /// 读取设备的系统参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRead_Click(object sender, EventArgs e)
        {
            try
            {
            CommPort mCommPort = CommPort.Instance;
            try
            {

                string str = "ff" + "{0}" +"05"+"05"+ "00";
                mCommPort.SearchDeviceAddress();
                str = string.Format(str, CommPort.mDeviceAddress.ToString("X2"));
                byte[] sendData = mCommPort.convertstringtobyte(str);
                int sum = 0;
                foreach (int i in sendData)
                {
                    sum += i;
                }
                sendData[sendData.Length - 1] = (byte)(sum % 256);
                mCommPort.Send(sendData);
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            tBPES_Dif_max.Text = mCommPort.PES_Dif_max1;
            tBPVDF_Dif_max.Text = mCommPort.PVDF_Dif_max1;
            tBPTFE_Dif_max.Text = mCommPort.PTFE_Dif_max1;
            tBNYLON_Dif_max.Text = mCommPort.NYLON_Dif_max1;
            tBOTHER_Dif_max.Text = mCommPort.OTHER_Dif_max1;
            tBExter_Volm.Text = mCommPort.Exter_Volm1;
            tBSourceP.Text = mCommPort.SourceP1;
            tBAddP_extent.Text = mCommPort.AddP_extent1;
            const Int32 a = 0;
            const Int32 b = 1;
            //打印设置
            switch (Convert.ToInt32(mCommPort.Print_Setup1))
            {
                case a:
                    radioButtonPrint_SetupAuto.Checked = false;
                    radioButtonPrint_SetupManual.Checked = true;
                    break;

                case b:
                    radioButtonPrint_SetupAuto.Checked = true;
                    radioButtonPrint_SetupManual.Checked = false;
                    break;

                default: break;
            }

            //结束还是询问

            switch (Convert.ToInt32(mCommPort.Over_ModeSetup1))
            {
                case a:
                    radioButtonOver_ModeSetupM.Checked = false;
                    radioButtonOver_ModeSetupA.Checked = true;
                    break;

                case b:

                    radioButtonOver_ModeSetupM.Checked = true;
                    radioButtonOver_ModeSetupA.Checked = false;
                    break;
                default: break;
            }
            //语言选择，中文还是英文


            switch (Convert.ToInt32(mCommPort.Language_Setup1))
            {
                case a:
                    radioButtonLanguage_SetupC.Checked = false;
                    radioButtonLanguage_SetupE.Checked = true;
                    break;
                case b:
                    radioButtonLanguage_SetupC.Checked = true;
                    radioButtonLanguage_SetupE.Checked = false;

                    break;
                default: break;
            }
            //是否加载缺省值

            switch (Convert.ToInt32(mCommPort.Default_Load1))
            {
                case a:
                    radioButtonDefault_LoadYes.Checked = false;
                    radioButtonDefault_LoadNo.Checked = true;
                    break;
                case b:
                    radioButtonDefault_LoadYes.Checked = true;
                    radioButtonDefault_LoadNo.Checked = false;

                    break;
                default: break;
            }
            //是否初始化测试参数

            switch (Convert.ToInt32(mCommPort.InitTestPara1))
            {
                case a:
                    radioButtonInitTestParaYes.Checked = false;
                    radioButtonInitTestParaNo.Checked = true;

                    break;
                case b:
                    radioButtonInitTestParaYes.Checked = true;
                    radioButtonInitTestParaNo.Checked = false;

                    break;
                default: break;
            }
            }

            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.ToString(), "方案可能不存在");

            }
        }
        /// <summary>
        /// 写入系统参数到设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxWrite_Click(object sender, EventArgs e)
        {
               try
            {
            CommPort mComPort = CommPort.Instance;
            /// <summary>
            /// 单芯10“PES滤芯的最大扩散流--  2;
            /// 例如：数值 300，显示 30.0
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
           
            string PES_Dif_max =( Convert.ToInt64(tBPES_Dif_max.Text.Replace(".", ""))).ToString("X4");
           
            /// <summary>
            ///  PVDF_Dif_max   -------   单芯10“尼龙滤芯的最大扩散流--  2
            ///  例如：数值 200，显示 20.0
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string PVDF_Dif_max = (Convert.ToInt64(tBPVDF_Dif_max.Text.Replace(".", ""))).ToString("X4");
           

            /// <summary>
            ///  PTFE_Dif_max ------- 单芯10“聚四氟乙烯滤芯的最大扩散流 --  2;
            ///  例如：数值 160，显示 16.0
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string PTFE_Dif_max = (Convert.ToInt64(tBPTFE_Dif_max.Text.Replace(".", ""))).ToString("X4");
           
            /// <summary>
            /// NYLON_Dif_max  ------- 单芯10“尼龙滤芯的最大扩散流 --  2 ;
            /// 例如：数值 180，显示 18.0
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string NYLON_Dif_max = (Convert.ToInt64(tBNYLON_Dif_max.Text.Replace(".", ""))).ToString("X4");
            
            /// <summary>
            ///OTHER_Dif_max -------  单芯10“其它材质的扩散流--  2 ;  
            ///例如：数值 260，显示 26.0
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string OTHER_Dif_max = (Convert.ToInt32(tBOTHER_Dif_max.Text.Replace(".", ""))).ToString("X4");
           
            /// <summary>
            /// Exter_Volm    -----   外部缓冲罐的体积  （0）      ---  4  ;
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string Exter_Volm = (Convert.ToInt32(tBExter_Volm.Text.Replace(".", ""))).ToString("X8");
            
            /// <summary>
            /// SourceP       -----   外部的气源压力     (6000)     --   2     ;
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string SourceP = (Convert.ToInt32(tBSourceP.Text.Replace(".", ""))).ToString("X4");
           
            /// <summary>
            /// AddP_extent   -----   对滤芯的压力增幅   (60)  --   2     ;
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string AddP_extent = (Convert.ToInt32(tBAddP_extent.Text.Replace(".", ""))).ToString("X4");
            
            string Print_Setup = "00";
            string Over_ModeSetup = "00";
            string Language_Setup = "00";
            string Default_Load = "00";
            string InitTestPara = "00";

            //打印设置

            if ((radioButtonPrint_SetupAuto.Checked == false) && (radioButtonPrint_SetupManual.Checked == true))
            {
                Print_Setup = (0).ToString("X2");
            }
            else if ((radioButtonPrint_SetupAuto.Checked == true) && (radioButtonPrint_SetupManual.Checked == false))
            {
                Print_Setup = (1).ToString("X2");
            }
            //结束还是询问


            if ((radioButtonOver_ModeSetupM.Checked == false) && (radioButtonOver_ModeSetupA.Checked == true))
            {
                Over_ModeSetup = (0).ToString("X2");
            }
            else if ((radioButtonOver_ModeSetupM.Checked == true) && (radioButtonOver_ModeSetupA.Checked == false))
            {
                Over_ModeSetup = (1).ToString("X2");
            }
            //语言选择，中文还是英文

            if ((radioButtonLanguage_SetupC.Checked == false) && (radioButtonLanguage_SetupE.Checked == true))
            {
                Language_Setup = (0).ToString("X2");
            }
            else if ((radioButtonLanguage_SetupC.Checked == true) && (radioButtonLanguage_SetupE.Checked == false))
            {
                Language_Setup = (1).ToString("X2");
            }
            //是否加载缺省值

            if ((radioButtonDefault_LoadYes.Checked == false) && (radioButtonDefault_LoadNo.Checked == true))
            {
                Default_Load = (0).ToString("X2");
            }
            else if ((radioButtonDefault_LoadYes.Checked == true) && (radioButtonDefault_LoadNo.Checked == false))
            {
                Default_Load = (1).ToString("X2");
            }
            //是否初始化测试参数

            if ((radioButtonInitTestParaYes.Checked == false) && (radioButtonInitTestParaNo.Checked == true))
            {
                InitTestPara = (0).ToString("X2");
            }
            else if ((radioButtonInitTestParaYes.Checked == true) && (radioButtonInitTestParaNo.Checked == false))
            {
                InitTestPara = (1).ToString("X2");
            }






            try
            {
                mComPort.SearchDeviceAddress();
                string str = "ff" + "{0}" + "1C" + "06" + PES_Dif_max + PVDF_Dif_max  + PTFE_Dif_max  + NYLON_Dif_max +  OTHER_Dif_max + Exter_Volm+ SourceP+ AddP_extent + Print_Setup + Over_ModeSetup + Language_Setup + Default_Load + InitTestPara + "00";
               
                str = string.Format(str, CommPort.mDeviceAddress.ToString("X2"));
                byte[] sendData = mComPort.convertstringtobyte(str);
                int sum = 0;
                foreach (int i in sendData)
                {
                    sum += i;
                }
                sendData[sendData.Length - 1] = (byte)(sum % 256);
                mComPort.Send(sendData);
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            }

               catch (Exception er)
               {
                   MessageBox.Show(er.Message);
               }
        }
        /// <summary>
        /// 保存系统参数到数据库提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSave_MouseEnter(object sender, EventArgs e)
        {
             try
            {

            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pictureBoxSave, "保存系统参数到数据库提示");

            }
             catch (Exception ex)
             {
                 LogClass.WriteLogFile ("Exception:" + ex.ToString());
             }

        }
        /// <summary>
        /// 查询数据库系统方案提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxInquire_MouseEnter(object sender, EventArgs e)
        {
             try
            {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pictureBoxInquire, "查询数据库系统方案提示");
            }
             catch (Exception ex)
             {
                 LogClass.WriteLogFile ("Exception:" + ex.ToString());
             }

        }
        /// <summary>
        /// 读取设备的参数提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRead_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pictureBoxRead, "读取设备的参数提示");
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
        /// <summary>
        /// 把系统的测试参数写入到设备提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxWrite_MouseEnter(object sender, EventArgs e)
        {
            try
            {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.pictureBoxWrite, "把系统的测试参数写入到设备提示");
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
        }
    }
}
