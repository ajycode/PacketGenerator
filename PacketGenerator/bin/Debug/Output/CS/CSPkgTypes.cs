
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// enums
namespace CSPkgTypes
{
    // 获取会计列表
    public enum  CS_Accountant_GetListSortData_Type : int
    {
        /// <summary>
        /// 默认方式
        /// </summary> 
        SortDefault = 0, 
        /// <summary>
        /// 评分
        /// </summary> 
        SortGrade = 1, 
        /// <summary>
        /// 服务次数
        /// </summary> 
        ServeCount = 2, 
    };
}

// struct declares
namespace CSPkgTypes
{
    // 会计注册
    public class CS_Accountant_Register : IBBWriter, IBBReader 
    {
        /*
         * 真实姓名
        */
        public string name = "";
        /*
         * 收件地址
        */
        public string acceptanceAddress = "";
        /*
         * 办公地址
        */
        public string businessAddress = "";
        /*
         * 联系电话
        */
        public string phone = "";
        /*
         * 登录名
        */
        public string loginName = "";
        /*
         * 密码
        */
        public string password = "";
        /*
         * 身份证号
        */
        public string idNumber = "";
        /*
         * 证书编号（会计资格证）
        */
        public string certificateNO = "";
        /*
         *  经度（办公地址）
        */
        public double longitude;
        /*
         * 纬度（办公地址）
        */
        public double latitude;
        /*
         * 昵称
        */
        public string nickName = "";
        /*
         * 性别(请传：男或女)
        */
        public string gender = "";
        /*
         * 电子邮件
        */
        public string emmail = "";
        /*
         * 自我介绍
        */
        public string selfIntroduction = "";
        /*
         * 极光推送标识
        */
        public string registrationId = "";
        public Dictionary<int, CSPkgTypes.CS_Account_Register_IsExists> dict = new Dictionary<int, CSPkgTypes.CS_Account_Register_IsExists>();
        public const short commandType = 1; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( name );
            bb.Write( acceptanceAddress );
            bb.Write( businessAddress );
            bb.Write( phone );
            bb.Write( loginName );
            bb.Write( password );
            bb.Write( idNumber );
            bb.Write( certificateNO );
            bb.Write( longitude );
            bb.Write( latitude );
            bb.Write( nickName );
            bb.Write( gender );
            bb.Write( emmail );
            bb.Write( selfIntroduction );
            bb.Write( registrationId );
            bb.Write( dict ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             name = bb.ReadString( 0,30 );
             acceptanceAddress = bb.ReadString( 0,300 );
             businessAddress = bb.ReadString( 0,300 );
             phone = bb.ReadString( 0,60 );
             loginName = bb.ReadString( 0,60 );
             password = bb.ReadString( 0,60 );
             idNumber = bb.ReadString( 0,54 );
             certificateNO = bb.ReadString( 0,150 );
             longitude = bb.ReadDouble();
             latitude = bb.ReadDouble();
             nickName = bb.ReadString( 0,60 );
             gender = bb.ReadString( 0,3 );
             emmail = bb.ReadString( 0,150 );
             selfIntroduction = bb.ReadString( 0,3000 );
             registrationId = bb.ReadString( 0,150 );
             dict = bb.ReadDict( 0,0 );
        }

    };
    // 会计判断登陆名是否存在
    public class CS_Account_Register_IsExists : IBBWriter, IBBReader 
    {
        /*
         * 登录名
        */
        public string loginName = "";
        public const short commandType = 2; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( loginName ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             loginName = bb.ReadString( 0,150 );
        }

    };
    // 会计登陆
    public class CS_Account_Login : IBBWriter, IBBReader 
    {
        /*
         * 登录名
        */
        public string loginName = "";
        /*
         * 密码
        */
        public string password = "";
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 极光推送标识
        */
        public string registrationId = "";
        public const short commandType = 3; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( loginName );
            bb.Write( password );
            bb.Write( token );
            bb.Write( registrationId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             loginName = bb.ReadString( 0,60 );
             password = bb.ReadString( 0,60 );
             token = bb.ReadString( 0,150 );
             registrationId = bb.ReadString( 0,150 );
        }

    };
    // 会计获取本人受理业务
    public class CS_Account_GetProduct : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计编号
        */
        public int id;
        public const short commandType = 4; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( id ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             id = bb.ReadInt();
        }

    };
    // 会计更新或添加个人受理业务
    public class CS_Product_Manage : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计用户编号
        */
        public int accountantID;
        /*
         * 业务产品编号
        */
        public int productID;
        /*
         * 业务产品名称
        */
        public string productname = "";
        /*
         * 业务产品价格
        */
        public double price;
        /*
         * 擅长行业领域ID,最多2个ID，以,分割
        */
        public string industryID = "";
        public const short commandType = 5; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( productID );
            bb.Write( productname );
            bb.Write( price );
            bb.Write( industryID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             productID = bb.ReadInt();
             productname = bb.ReadString( 0,150 );
             price = bb.ReadDouble();
             industryID = bb.ReadString( 0,150 );
        }

    };
    // 获取会计主页个人信息
    public class CS_Account_GetDetails : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计用户编号
        */
        public int accountantID;
        /*
         * 公司ID，没有登陆的时候传-1，并传唯一标识
        */
        public int customerID;
        /*
         * 唯一标识
        */
        public string identification = "";
        public const short commandType = 6; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( customerID );
            bb.Write( identification ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             customerID = bb.ReadInt();
             identification = bb.ReadString( 0,300 );
        }

    };
    // 公司注册
    public class CS_Customer_Register : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 联系人
        */
        public string contact = "";
        /*
         * 公司名称
        */
        public string companyName = "";
        /*
         * 公司地址
        */
        public string companyAdress = "";
        /*
         * 公司类型
        */
        public string companyType = "";
        /*
         * 联系电话
        */
        public string phone = "";
        /*
         * 邮件
        */
        public string email = "";
        /*
         * 登陆名
        */
        public string loginname = "";
        /*
         * 密码
        */
        public string password = "";
        /*
         * 纳税资质
        */
        public string taxQualification = "";
        /*
         * 极光推送标识
        */
        public string registrationId = "";
        public const short commandType = 7; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( contact );
            bb.Write( companyName );
            bb.Write( companyAdress );
            bb.Write( companyType );
            bb.Write( phone );
            bb.Write( email );
            bb.Write( loginname );
            bb.Write( password );
            bb.Write( taxQualification );
            bb.Write( registrationId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             contact = bb.ReadString( 0,30 );
             companyName = bb.ReadString( 0,150 );
             companyAdress = bb.ReadString( 0,300 );
             companyType = bb.ReadString( 0,150 );
             phone = bb.ReadString( 0,60 );
             email = bb.ReadString( 0,150 );
             loginname = bb.ReadString( 0,60 );
             password = bb.ReadString( 0,60 );
             taxQualification = bb.ReadString( 0,150 );
             registrationId = bb.ReadString( 0,150 );
        }

    };
    // 公司注册用户名检测
    public class CS_Customer_Register_IsExists : IBBWriter, IBBReader 
    {
        /*
         * 登录名
        */
        public string loginName = "";
        public const short commandType = 8; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( loginName ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             loginName = bb.ReadString( 0,60 );
        }

    };
    // 获取全部行业分类
    public class CS_Industry_AllSector : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        public const short commandType = 9; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
        }

    };
    // 公司登陆
    public class CS_Customer_Login : IBBWriter, IBBReader 
    {
        /*
         * 登录名
        */
        public string loginName = "";
        /*
         * 密码
        */
        public string password = "";
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 极光推送标识
        */
        public string registrationId = "";
        public const short commandType = 10; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( loginName );
            bb.Write( password );
            bb.Write( token );
            bb.Write( registrationId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             loginName = bb.ReadString( 0,60 );
             password = bb.ReadString( 0,60 );
             token = bb.ReadString( 0,150 );
             registrationId = bb.ReadString( 0,150 );
        }

    };
    // 查询附近会计
    public class CS_Acctountant_GetAround : IBBWriter, IBBReader 
    {
        /*
         * 经度
        */
        public double lon;
        /*
         * 纬度
        */
        public double lat;
        /*
         * 半径（米
        */
        public int radius;
        /*
         * 令牌
        */
        public string token = "";
        public const short commandType = 11; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( lon );
            bb.Write( lat );
            bb.Write( radius );
            bb.Write( token ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             lon = bb.ReadDouble();
             lat = bb.ReadDouble();
             radius = bb.ReadInt();
             token = bb.ReadString( 0,150 );
        }

    };
    // 创建订单
    public class CS_Order_Create : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计ID
        */
        public int accountantID;
        /*
         * 客户ID
        */
        public int customerID;
        /*
         * 数量
        */
        public int count;
        /*
         * 开始执行日期
        */
        public DateTime startTime = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单结束日期
        */
        public DateTime endTime = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单周期,（默认赋值1）
        */
        public int cycle;
        /*
         * 订单备注
        */
        public string remark = "";
        /*
         * 产品明细
        */
        public string product = "";
        public const short commandType = 12; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( customerID );
            bb.Write( count );
            bb.Write( startTime );
            bb.Write( endTime );
            bb.Write( cycle );
            bb.Write( remark );
            bb.Write( product ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             customerID = bb.ReadInt();
             count = bb.ReadInt();
             startTime = bb.ReadDate();
             endTime = bb.ReadDate();
             cycle = bb.ReadInt();
             remark = bb.ReadString( 0,600 );
             product = bb.ReadString( 0,150 );
        }

    };
    // 查询全部快递服务
    public class CS_Express_GetAll : IBBWriter, IBBReader 
    {
        public const short commandType = 13; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 查询未完成订单列表
    public class CS_UncompletedOrder_GetList : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计/客户ID
        */
        public int id;
        /*
         * 角色(0表示会计，1表示客户)
        */
        public int role;
        /*
         * 页码(0代表第一页)
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 14; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( id );
            bb.Write( role );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             id = bb.ReadInt();
             role = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 查询订单明细
    public class CS_Order_GetDetails : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 订单ID
        */
        public string orderId = "";
        public const short commandType = 15; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 会计修改订单价格
    public class CS_Order_UpdateTotal : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计ID
        */
        public int accountantID;
        /*
         * 订单ID
        */
        public string orderId = "";
        /*
         * 会计输入的实际订单金额
        */
        public double total;
        public const short commandType = 16; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( orderId );
            bb.Write( total ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
             total = bb.ReadDouble();
        }

    };
    // 客户确认订单
    public class CS_Customer_Order_Confirm : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户ID
        */
        public int customerID;
        /*
         * 订单ID
        */
        public string orderId = "";
        public const short commandType = 17; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 获取支付平台列表
    public class CS_Get_Payment_Platform : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        public const short commandType = 18; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
        }

    };
    // 客户寄送资料
    public class CS_Customer_Deliver : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户ID
        */
        public int customerID;
        /*
         * 订单编号
        */
        public string orderId = "";
        /*
         * 快递回执编号
        */
        public string code = "";
        public const short commandType = 19; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId );
            bb.Write( code ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
             code = bb.ReadString( 0,150 );
        }

    };
    // 会计接收资料确认
    public class CS_Accountant_Receipt_Confirm : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计ID
        */
        public int accountantID;
        /*
         * 订单编号
        */
        public string orderId = "";
        public const short commandType = 20; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 会计填写报表
    public class CS_Accountant_Create_Report : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计ID
        */
        public int accountantID;
        /*
         * 订单编号
        */
        public string orderId = "";
        /*
         * 报表内容
        */
        public string report = "";
        public const short commandType = 21; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( orderId );
            bb.Write( report ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
             report = bb.ReadString( 0,600 );
        }

    };
    // 查询月度报表
    public class CS_Get_Report_Month : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 订单编号
        */
        public string orderId = "";
        public const short commandType = 22; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 查询季度报表
    public class CS_Get_Report_Quarter : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 订单编号
        */
        public string customerId = "";
        /*
         * “-”前代表年份, ”-”后代表季度（传1到4）
        */
        public string time = "";
        public const short commandType = 23; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerId );
            bb.Write( time ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerId = bb.ReadString( 0,150 );
             time = bb.ReadString( 0,150 );
        }

    };
    // 客户对报表审核
    public class CS_Customer_Report_Confirm : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户 ID
        */
        public int customerID;
        /*
         * 订单编号
        */
        public string orderId = "";
        /*
         * 审批结果
        */
        public bool result;
        /*
         * 备注
        */
        public string remark = "";
        public const short commandType = 24; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId );
            bb.Write( result );
            bb.Write( remark ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
             result = bb.ReadBoolean();
             remark = bb.ReadString( 0,600 );
        }

    };
    // 会计返还资料
    public class CS_Accountant_Send_Back : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计 ID
        */
        public int accountantID;
        /*
         * 订单编号
        */
        public string orderId = "";
        /*
         * 审批结果
        */
        public string code = "";
        public const short commandType = 25; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( orderId );
            bb.Write( code ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
             code = bb.ReadString( 0,0 );
        }

    };
    // 客户接收确认，订单完成
    public class CS_Customer_Order_Recive : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户 ID
        */
        public int customerID;
        /*
         * 订单编号
        */
        public string orderId = "";
        public const short commandType = 26; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 客户退回订单至会计定价
    public class CS_Customer_Order_Back : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户 ID
        */
        public int customerID;
        /*
         * 订单编号
        */
        public string orderId = "";
        public const short commandType = 27; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 会计取消订单
    public class CS_Accountant_Cancel_Order : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计 ID
        */
        public int accountantID;
        /*
         * 订单编号
        */
        public string orderId = "";
        public const short commandType = 28; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 客户取消订单
    public class CS_Customer_Cancel_Order : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户 ID
        */
        public int customerID;
        /*
         * 订单编号
        */
        public string orderId = "";
        public const short commandType = 29; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 获取会计列表
    public class CS_Accountant_GetListSortData : IBBWriter, IBBReader 
    {
        /*
         * 排序的字段名
        */
        public CSPkgTypes.CS_Accountant_GetListSortData_Type type;
        /*
         * true大到小,false小到大
        */
        public bool sortType;
        public const short commandType = 30; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type );
            bb.Write( sortType ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (CSPkgTypes.CS_Accountant_GetListSortData_Type) bb.ReadInt();
             sortType = bb.ReadBoolean();
        }

    };
    // 获取会计列表
    public class CS_Accountant_GetListScreenData : IBBWriter, IBBReader 
    {
        /*
         * 字段名
        */
        public string name = "";
        /*
         * 值
        */
        public string number = "";
        public const short commandType = 31; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( name );
            bb.Write( number ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             name = bb.ReadString( 0,150 );
             number = bb.ReadString( 0,50 );
        }

    };
    // 获取会计列表
    public class CS_Accountant_GetList : IBBWriter, IBBReader 
    {
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        /*
         * 排序方式
        */
        public CSPkgTypes.CS_Accountant_GetListSortData sortData = new CSPkgTypes.CS_Accountant_GetListSortData();
        /*
         * 筛选方式
        */
        public CSPkgTypes.CS_Accountant_GetListScreenData screen = new CSPkgTypes.CS_Accountant_GetListScreenData();
        public const short commandType = 32; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( index );
            bb.Write( size );
            bb.Write( sortData );
            bb.Write( screen ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             index = bb.ReadInt();
             size = bb.ReadInt();
             sortData = bb.Read<CSPkgTypes.CS_Accountant_GetListSortData>();
             screen = bb.Read<CSPkgTypes.CS_Accountant_GetListScreenData>();
        }

    };
    // 查询已完成订单列表
    public class CS_CompeletedOrder_GetList : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计/客户ID
        */
        public int id;
        /*
         * 角色(0表示会计，1表示客户)
        */
        public int role;
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 33; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( id );
            bb.Write( role );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             id = bb.ReadInt();
             role = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 客户对会计服务评分
    public class CS_Grade_AccountantService : IBBWriter, IBBReader 
    {
        /*
         * 客户对会计服务评分
        */
        public double grade;
        /*
         * 订单ID
        */
        public string orderId = "";
        public const short commandType = 34; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( grade );
            bb.Write( orderId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             grade = bb.ReadDouble();
             orderId = bb.ReadString( 0,150 );
        }

    };
    // 会计上传证件照片
    public class CS_AccountantCredentials_Upload : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 证件照片文件名
        */
        public string fileName = "";
        /*
         * 证件照片内容,必须base64编码
        */
        public byte[] fileContent = new byte[0];
        /*
         * 会计ID
        */
        public int accountantID;
        /*
         * 证件类型
        */
        public int credential_Type;
        public const short commandType = 35; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( accountantID );
            bb.Write( credential_Type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             accountantID = bb.ReadInt();
             credential_Type = bb.ReadInt();
        }

    };
    // 银联支付获取交易流水号
    public class CS_UnionPayTn_Get : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 客户 ID
        */
        public int customerID;
        /*
         * 订单编号
        */
        public string orderId = "";
        /*
         * 支付金额
        */
        public double total;
        public const short commandType = 36; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customerID );
            bb.Write( orderId );
            bb.Write( total ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
             orderId = bb.ReadString( 0,150 );
             total = bb.ReadDouble();
        }

    };
    // 会计上传报表文件
    public class CS_ReportFile_Upload : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 文件名
        */
        public string fileName = "";
        /*
         * 文件内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 子订单编号
        */
        public string subOrderID = "";
        public const short commandType = 37; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( subOrderID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             subOrderID = bb.ReadString( 0,150 );
        }

    };
    // 下载报表文件
    public class CS_ReportFile_Download : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 文件id
        */
        public int file_id;
        public const short commandType = 38; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( file_id ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             file_id = bb.ReadInt();
        }

    };
    // 删除报表文件
    public class CS_ReportFile_Delete : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 文件id
        */
        public int file_id;
        public const short commandType = 39; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( file_id ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             file_id = bb.ReadInt();
        }

    };
    // 获取某会计未完成订单列表(web版)
    public class CS_GetAccountantUncompletedOrderList_web : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计id
        */
        public int accountant_id;
        /*
         * 页码(0代表第一页)
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 40; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountant_id );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountant_id = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 获取会计电子名片
    public class CS_AccountantElectronicBusinessCard_Get : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计ID
        */
        public int accountantID;
        public const short commandType = 41; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
        }

    };
    // 下载会计图片
    public class CS_AccountanPictureDown : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计ID
        */
        public int accountantID;
        public const short commandType = 42; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantID = bb.ReadInt();
        }

    };
    // 通过公司和年月查找报表
    public class CS_FindReportCustom : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的月
        */
        public int month;
        public const short commandType = 43; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year );
            bb.Write( month ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
             month = bb.ReadInt();
        }

    };
    // 公司上传电子财务信息
    public class CS_Customer_UploadElectronicBill : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的月
        */
        public int month;
        public const short commandType = 44; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( year );
            bb.Write( month ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             year = bb.ReadInt();
             month = bb.ReadInt();
        }

    };
    // 获得公司电子财务信息
    public class CS_GetElectronicBill : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的月
        */
        public int month;
        public const short commandType = 45; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year );
            bb.Write( month ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
             month = bb.ReadInt();
        }

    };
    // 公司查询所有订单的进度
    public class CS_CustomerGetOrderState : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 46; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 上传年度报表文件
    public class CS_ReportFile_Upload_Year : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 子订单编号
        */
        public string subOrderID = "";
        /*
         * excel名称
        */
        public string fileName = "";
        /*
         * excel内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 报表的年
        */
        public int year;
        public const short commandType = 47; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( subOrderID );
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( year ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             subOrderID = bb.ReadString( 0,150 );
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             year = bb.ReadInt();
        }

    };
    // 上传季度报表文件
    public class CS_ReportFile_Upload_Quarter : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 子订单编号
        */
        public string subOrderID = "";
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的季度
        */
        public int quarter;
        public const short commandType = 48; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( subOrderID );
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( year );
            bb.Write( quarter ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             subOrderID = bb.ReadString( 0,150 );
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             year = bb.ReadInt();
             quarter = bb.ReadInt();
        }

    };
    // 上传月度报表文件
    public class CS_ReportFile_Upload_Month : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 子订单编号
        */
        public string subOrderID = "";
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的月
        */
        public int month;
        public const short commandType = 49; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( subOrderID );
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( year );
            bb.Write( month ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             subOrderID = bb.ReadString( 0,150 );
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             year = bb.ReadInt();
             month = bb.ReadInt();
        }

    };
    // 下载年度报表文件
    public class CS_ReportFile_Download_Year : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        public const short commandType = 50; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
        }

    };
    // 下载季度报表文件
    public class CS_ReportFile_Download_Quarter : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的季度
        */
        public int quarter;
        public const short commandType = 51; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year );
            bb.Write( quarter ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
             quarter = bb.ReadInt();
        }

    };
    // 下载月度报表文件
    public class CS_ReportFile_Download_Month : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的月
        */
        public int month;
        public const short commandType = 52; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year );
            bb.Write( month ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
             month = bb.ReadInt();
        }

    };
    // 获得订单下有哪些报表
    public class CS_ReportFileList_Download : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 子订单编号
        */
        public string subOrderID = "";
        public const short commandType = 53; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( subOrderID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             subOrderID = bb.ReadString( 0,150 );
        }

    };
    // 下载报表文件(订单流程内使用)
    public class CS_ReportFileOrder_Download : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 报表文件的ID
        */
        public int fileId;
        public const short commandType = 54; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( fileId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             fileId = bb.ReadInt();
        }

    };
    // 地图点击获得会计详细信息
    public class CS_CheckAccountantInformation : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计的ID
        */
        public int accountantId;
        public const short commandType = 55; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantId = bb.ReadInt();
        }

    };
    // 通过报表文件ID查看文件
    public class CS_CheckReportFileFromID : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 报表文件ID
        */
        public int reportId;
        public const short commandType = 56; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( reportId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             reportId = bb.ReadInt();
        }

    };
    // 查看年度报表文件
    public class CS_ReportFile_Find_Year : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        public const short commandType = 57; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
        }

    };
    // 查看季度报表文件
    public class CS_ReportFile_Find_Quarter : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的季度
        */
        public int quarter;
        public const short commandType = 58; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year );
            bb.Write( quarter ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
             quarter = bb.ReadInt();
        }

    };
    // 查看月度报表文件
    public class CS_ReportFile_Find_Month : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 报表的年
        */
        public int year;
        /*
         * 报表的月
        */
        public int month;
        public const short commandType = 59; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( year );
            bb.Write( month ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             year = bb.ReadInt();
             month = bb.ReadInt();
        }

    };
    // 交易过的会计列表
    public class CS_DealAccountantList : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int customID;
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 60; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( customID );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             customID = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 修改会计个人资料
    public class CS_ChangeAccountantInformation : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计编号
        */
        public int id;
        /*
         * 昵称
        */
        public string nickName = "";
        /*
         * 身份证号码
        */
        public string idNumber = "";
        /*
         * 会计从业资格编号
        */
        public string certificateNum = "";
        /*
         * 真实姓名
        */
        public string name = "";
        /*
         * 收件地址
        */
        public string acceptanceAddress = "";
        /*
         * 办公地址
        */
        public string businessAddress = "";
        /*
         * 联系电话
        */
        public string phone = "";
        /*
         * 性别(请传：男或女)
        */
        public string gender = "";
        /*
         * 电子邮件
        */
        public string email = "";
        /*
         *  经度（办公地址）
        */
        public double longitude;
        /*
         * 纬度（办公地址）
        */
        public double latitude;
        /*
         * 自我介绍
        */
        public string selfIntroduction = "";
        public const short commandType = 61; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( id );
            bb.Write( nickName );
            bb.Write( idNumber );
            bb.Write( certificateNum );
            bb.Write( name );
            bb.Write( acceptanceAddress );
            bb.Write( businessAddress );
            bb.Write( phone );
            bb.Write( gender );
            bb.Write( email );
            bb.Write( longitude );
            bb.Write( latitude );
            bb.Write( selfIntroduction ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             id = bb.ReadInt();
             nickName = bb.ReadString( 0,0 );
             idNumber = bb.ReadString( 0,0 );
             certificateNum = bb.ReadString( 0,0 );
             name = bb.ReadString( 0,90 );
             acceptanceAddress = bb.ReadString( 0,900 );
             businessAddress = bb.ReadString( 0,900 );
             phone = bb.ReadString( 0,60 );
             gender = bb.ReadString( 0,3 );
             email = bb.ReadString( 0,1150 );
             longitude = bb.ReadDouble();
             latitude = bb.ReadDouble();
             selfIntroduction = bb.ReadString( 0,11500 );
        }

    };
    // 会计点击修改，获得自己的数据
    public class CS_ReturnAccountantInformation : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计编号
        */
        public int accountantId;
        public const short commandType = 62; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantId = bb.ReadInt();
        }

    };
    // 会计首页
    public class CS_AccountantHomePage : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 会计编号
        */
        public int accountantId;
        public const short commandType = 63; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( token );
            bb.Write( accountantId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             token = bb.ReadString( 0,150 );
             accountantId = bb.ReadInt();
        }

    };
    // 公司匿名登录
    public class CS_CustomerAnonymous : IBBWriter, IBBReader 
    {
        /*
         * 用户名
        */
        public string username = "";
        /*
         * 极光推送标识
        */
        public string registrationId = "";
        public const short commandType = 64; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( username );
            bb.Write( registrationId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             username = bb.ReadString( 0,300 );
             registrationId = bb.ReadString( 0,150 );
        }

    };
    // 查看会计证件照片
    public class CS_FindAccountantCredentials : IBBWriter, IBBReader 
    {
        /*
         * 会计ID
        */
        public int accountantID;
        public const short commandType = 65; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( accountantID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             accountantID = bb.ReadInt();
        }

    };
    // 会计查看交易过的公司
    public class CS_AccountantFindCustomer : IBBWriter, IBBReader 
    {
        /*
         * 会计编号
        */
        public int accountantId;
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 66; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( accountantId );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             accountantId = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 会计查看交易过的某个公司明细
    public class CS_AcountantFindCustomerDetail : IBBWriter, IBBReader 
    {
        /*
         * 公司ID
        */
        public int customerID;
        /*
         * 会计ID
        */
        public int accountantID;
        public const short commandType = 67; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( customerID );
            bb.Write( accountantID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             customerID = bb.ReadInt();
             accountantID = bb.ReadInt();
        }

    };
    // 用户更换头像
    public class CS_UserChangeIcon : IBBWriter, IBBReader 
    {
        /*
         * ID
        */
        public int id;
        /*
         * 类型true代表公司，false代表会计
        */
        public bool type;
        /*
         * 头像
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 68; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( type );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             type = bb.ReadBoolean();
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 公司主页
    public class CS_CustomerHomePage : IBBWriter, IBBReader 
    {
        /*
         * 公司编号
        */
        public int customerId;
        public const short commandType = 69; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( customerId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             customerId = bb.ReadInt();
        }

    };
    // 查看推送消息
    public class CS_FindPushMessage : IBBWriter, IBBReader 
    {
        /*
         * 用户ID
        */
        public int id;
        /*
         * 用户类型true为公司，false为会计
        */
        public bool type;
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 70; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( type );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             type = bb.ReadBoolean();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
    // 会计查看文档
    public class CS_AccountantFindDocment : IBBWriter, IBBReader 
    {
        /*
         * 会计的ID
        */
        public int accountantID;
        /*
         * 页码（0代表第一页）
        */
        public int index;
        /*
         * 单页显示数量
        */
        public int size;
        public const short commandType = 71; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( accountantID );
            bb.Write( index );
            bb.Write( size ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             accountantID = bb.ReadInt();
             index = bb.ReadInt();
             size = bb.ReadInt();
        }

    };
}