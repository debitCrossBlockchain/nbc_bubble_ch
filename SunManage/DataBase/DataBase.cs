using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ADOX;//引用创建Access数据库的库
using System.IO;
using System.Data.OleDb;
using SunManage;
using System.Data;
using System.Windows.Forms;
namespace SunManage.DataBase
{
    public partial class DataBase
    {
        #region 判断数据是否为空
        /// <summary>
        /// 判断数据库历史数据是否为空
        /// </summary>
        public bool GetTables(OleDbConnection conn, string TableName)
        {

            int result = 0;
            DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                                                             new object[] { null, null, null, "TABLE" });
            try
            {
                if (schemaTable != null)
                {

                    for (Int32 row = 0; row < schemaTable.Rows.Count; row++)
                    {
                        string col_name = schemaTable.Rows[row]["TABLE_NAME"].ToString();
                        if (col_name == TableName)
                        {
                            result++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }
            if (result == 0)
                return false;
            return true;
        }
        #endregion

        #region 建基本泡点测试启动测试数据表
        /// <summary>
        /// 建基本泡点测试启动测试数据表
        /// </summary>

        public void CreatDB(string TableName)
        {
            try
            {
                DataBase mDataBase = new DataBase();
                ADOX.Catalog catalog = new Catalog();
                ADODB.Connection cn = new ADODB.Connection();


                string sAccessConnection = "Provider=Microsoft.Jet.OLEDB.4.0;  Data Source=..\\..\\DataBase\\StartTest.mdb";
                OleDbConnection mConnection;
                mConnection = new OleDbConnection(sAccessConnection);

                mConnection.Open();
                cn.Open(sAccessConnection, null, null, -1);
                catalog.ActiveConnection = cn;

                bool flag = mDataBase.GetTables(mConnection, TableName);
                if (!flag)//判断表名是否存在
                {

                    ADOX.Table table = new ADOX.Table();

                    table.Name = TableName;

                    ADOX.Column column = new ADOX.Column();
                    column.ParentCatalog = catalog;
                    column.Name = "DeviceName";
                    column.Type = DataTypeEnum.adLongVarChar;
                    column.DefinedSize = 50;
                    column.Properties["AutoIncrement"].Value = false;
                    column.Properties["Jet OLEDB:Allow Zero Length"].Value = true;
                    //                        //column.Properties["Jet OLEDB:Allow Zero Length"].Value = true;
                    //                        struct TTest_Param               // ------ 107
                    //{
                    //  unsigned char      Test_type;               // 测试模态      -- 1                    
                    //  unsigned char      Test_Psernum[16];        // 生产序号      -- 16 
                    //  unsigned char      Test_Tsernum[16];        // 产品编号      -- 16                         
                    //  unsigned char      Test_Fsernum[16];        // 滤器序号     --  16
                    //  unsigned char      Test_filt[16];           // 滤材种类     --  16
                    //  unsigned char      Test_LIQU[15];           // 测试液体      -- 15
                    //  unsigned char      Test_Dt[5];              // 日期/时间     -- 5
                    //  unsigned char      Test_LIQUType;           // 测试液体种类  -- 1
                    //  unsigned int       Test_LIQUConsistence;    // 测试液体浓度  -- 2
                    //  unsigned char      Test_Filter_type;        // 测量用过滤器的种类  筒式/平板/囊式/其它  -- 1  
                    //  unsigned short     Test_Filter_Config;      // 过滤材料的规格（或平板滤器的直径） （2.5",5“，10”，20“，30”, 40"） -- 4
                    //  unsigned char      Test_Filter_numer;       // 测试过滤器滤芯的数量           -- 1 
                    //  unsigned int       Test_Filter_Area  ;      // 过滤面积
                    //  unsigned short     Test_Meme_Aper;          // 过滤材料的孔径（精度） 如：0。22um       -- 2
                    //  unsigned short     Test_Velocity ;          // 基本泡点测试模式 / 水浸入测试的测试时间  -- 2
                    //  unsigned int       Test_Up_Volm;            // 滤芯的上游体积                           -- 4 
                    //  unsigned short     Test_startp ;            // 起测压力（ 滤芯的扩散流检测时的压力 ）   -- 2
                    //  unsigned short     Test_SetBp  ;            // 最小泡点                                 -- 2 
                    //  unsigned short     Test_Dif_max  ;          // 最大扩散流                               -- 2

                    // };




                    table.Columns.Append(column, DataTypeEnum.adLongVarChar, 50);
                    table.Keys.Append("FirstTablePrimaryKey", KeyTypeEnum.adKeyPrimary, column, null, null);
                    //（1） Test_type          -------    测试模态 (M/B/A/P/D/H)    -- 1;
                    table.Columns.Append("Htest_type", DataTypeEnum.adWChar, 50);//（1） Test_type          -------    测试模态 (M/B/A/P/D/H)    -- 1;
                    table.Columns["Htest_type"].Attributes = ColumnAttributesEnum.adColNullable;//（1） Test_type          -------    测试模态 (M/B/A/P/D/H)    -- 1;

                    //（2） Test_Psernum[16]   -------   生产序号       -- 16     ;
                    table.Columns.Append("Test_Psernum", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_Psernum"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（3） Test_Tsernum[16]   -------   产品编号       -- 16     ;
                    table.Columns.Append("Test_Tsernum", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_Tsernum"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（4） Test_Fsernum [16]   -------  滤器序号       -- 16     ;
                    table.Columns.Append("Test_Fsernum", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_Fsernum"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（5） Test_filt[16]        -------  滤材种类       -- 16     ;
                    table.Columns.Append("Test_filt", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_filt"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（6）Test_LIQU[15]       -------  测试液体       -- 15    ;
                    table.Columns.Append("Test_LIQU", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_LIQU"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（7）Test_Dt[5]           -------  日期/时间       -- 5    ;
                    table.Columns.Append("HA_STime", DataTypeEnum.adWChar, 50);
                    table.Columns["HA_STime"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（8）Test_LIQUType      -------  测试液体种类    -- 1    ;
                    table.Columns.Append("Test_LIQUType", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_LIQUType"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（9）Test_LIQUConsistence -------  测试液体浓度    -- 2    ;
                    table.Columns.Append("Test_LIQUConsistence", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_LIQUConsistence"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（10）Test_Filter_type ------- 测量用过滤器的种类(筒式/平板/囊式/其它) -- 1 ;
                    table.Columns.Append("Test_Filter_type", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_Filter_type"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（11）Test_Filter_Config  ------- 过滤材料的规格（或平板滤器的直径）  -- 2;
                    table.Columns.Append("Test_Filter_Config", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_Filter_Config"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（12）Test_Filter_numer  -------  测试过滤器滤芯的数量        -- 1 ;
                    table.Columns.Append("Test_Filter_number", DataTypeEnum.adWChar, 50);
                    table.Columns["Test_Filter_number"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（13）Test_Filter_Area   -------  过滤面积           -- 4    ;
                    table.Columns.Append("Test_Filter_Area", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_Filter_Area"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（14）Test_Meme_Aper  -------  过滤材料的孔径（精度）      -- 2  ;
                    table.Columns.Append("Test_Meme_Aper", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_Meme_Aper"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（15）Test_Velocity  ------- 基本泡点测试模式 / 水浸入的测试时间  -- 2 ;
                    table.Columns.Append("Test_Velocity", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_Velocity"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（16）Test_Up_Volm  ------- 滤芯的上游体积  -- 4 ;
                    table.Columns.Append("Test_Up_Volm", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_Up_Volm"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（17）Test_startp   -------  起测压力（ 滤芯的扩散流检测时的压力 ） -- 2 ;
                    table.Columns.Append("Test_startp", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_startp"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（18）Test_SetBp   -------   最小泡点     -- 2 ;
                    table.Columns.Append("Test_SetBp", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_SetBp"].Attributes = ColumnAttributesEnum.adColNullable;

                    //（19）Test_Dif_max   -------   最大扩散流   -- 2  ；
                    table.Columns.Append("Test_Dif_max", DataTypeEnum.adLongVarChar, 50);
                    table.Columns["Test_Dif_max"].Attributes = ColumnAttributesEnum.adColNullable;





                    try
                    {

                        catalog.Tables.Append(table);

                    }

                    catch (Exception ex)
                    {

                        //MessageBox.Show(ex.Message);

                    }

                    //此处一定要关闭连接，否则添加数据时候会出错

                    table = null;

                    catalog = null;

                    Application.DoEvents();
                }

                mConnection.Close();
                cn.Close();

                //新建设备参数数据库表


            }
            catch (Exception ex)
            {
                LogClass.WriteLogFile ("Exception:" + ex.ToString());
            }

        }
    }
        #endregion

}
