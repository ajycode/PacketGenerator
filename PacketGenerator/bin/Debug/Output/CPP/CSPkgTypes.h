#ifndef __CSPkgTypes_H__
#define __CSPkgTypes_H__

#include "xxlib.h"

// predeclares
namespace CSPkgTypes
{
    struct CS_Accountant_Register;
    struct CS_Account_Register_IsExists;
    struct CS_Account_Login;
    struct CS_Account_GetProduct;
    struct CS_Product_Manage;
    struct CS_Account_GetDetails;
    struct CS_Customer_Register;
    struct CS_Customer_Register_IsExists;
    struct CS_Industry_AllSector;
    struct CS_Customer_Login;
    struct CS_Acctountant_GetAround;
    struct CS_Order_Create;
    struct CS_Express_GetAll;
    struct CS_UncompletedOrder_GetList;
    struct CS_Order_GetDetails;
    struct CS_Order_UpdateTotal;
    struct CS_Customer_Order_Confirm;
    struct CS_Get_Payment_Platform;
    struct CS_Customer_Deliver;
    struct CS_Accountant_Receipt_Confirm;
    struct CS_Accountant_Create_Report;
    struct CS_Get_Report_Month;
    struct CS_Get_Report_Quarter;
    struct CS_Customer_Report_Confirm;
    struct CS_Accountant_Send_Back;
    struct CS_Customer_Order_Recive;
    struct CS_Customer_Order_Back;
    struct CS_Accountant_Cancel_Order;
    struct CS_Customer_Cancel_Order;
    struct CS_Accountant_GetListSortData;
    struct CS_Accountant_GetListScreenData;
    struct CS_Accountant_GetList;
    struct CS_CompeletedOrder_GetList;
    struct CS_Grade_AccountantService;
    struct CS_AccountantCredentials_Upload;
    struct CS_UnionPayTn_Get;
    struct CS_ReportFile_Upload;
    struct CS_ReportFile_Download;
    struct CS_ReportFile_Delete;
    struct CS_GetAccountantUncompletedOrderList_web;
    struct CS_AccountantElectronicBusinessCard_Get;
    struct CS_AccountanPictureDown;
    struct CS_FindReportCustom;
    struct CS_Customer_UploadElectronicBill;
    struct CS_GetElectronicBill;
    struct CS_CustomerGetOrderState;
    struct CS_ReportFile_Upload_Year;
    struct CS_ReportFile_Upload_Quarter;
    struct CS_ReportFile_Upload_Month;
    struct CS_ReportFile_Download_Year;
    struct CS_ReportFile_Download_Quarter;
    struct CS_ReportFile_Download_Month;
    struct CS_ReportFileList_Download;
    struct CS_ReportFileOrder_Download;
    struct CS_CheckAccountantInformation;
    struct CS_CheckReportFileFromID;
    struct CS_ReportFile_Find_Year;
    struct CS_ReportFile_Find_Quarter;
    struct CS_ReportFile_Find_Month;
    struct CS_DealAccountantList;
    struct CS_ChangeAccountantInformation;
    struct CS_ReturnAccountantInformation;
    struct CS_AccountantHomePage;
    struct CS_CustomerAnonymous;
    struct CS_FindAccountantCredentials;
    struct CS_AccountantFindCustomer;
    struct CS_AcountantFindCustomerDetail;
    struct CS_UserChangeIcon;
    struct CS_CustomerHomePage;
    struct CS_FindPushMessage;
    struct CS_AccountantFindDocment;
}

// enums
namespace CSPkgTypes
{
    // 获取会计列表
    enum class CS_Accountant_GetListSortData_Type : int
    {
        SortDefault = 0, // 默认方式
        SortGrade = 1, // 评分
        ServeCount = 2, // 服务次数
    };
}

// struct declares
namespace CSPkgTypes
{
    // 会计注册
    struct CS_Accountant_Register : xxlib::Memmoveable
    {
        CS_Accountant_Register(){}
        /*
         * 真实姓名
        */
        xxlib::String name ;
        /*
         * 收件地址
        */
        xxlib::String acceptanceAddress ;
        /*
         * 办公地址
        */
        xxlib::String businessAddress ;
        /*
         * 联系电话
        */
        xxlib::String phone ;
        /*
         * 登录名
        */
        xxlib::String loginName ;
        /*
         * 密码
        */
        xxlib::String password ;
        /*
         * 身份证号
        */
        xxlib::String idNumber ;
        /*
         * 证书编号（会计资格证）
        */
        xxlib::String certificateNO ;
        /*
         *  经度（办公地址）
        */
        double longitude = 0 ;
        /*
         * 纬度（办公地址）
        */
        double latitude = 0 ;
        /*
         * 昵称
        */
        xxlib::String nickName ;
        /*
         * 性别(请传：男或女)
        */
        xxlib::String gender ;
        /*
         * 电子邮件
        */
        xxlib::String emmail ;
        /*
         * 自我介绍
        */
        xxlib::String selfIntroduction ;
        /*
         * 极光推送标识
        */
        xxlib::String registrationId ;
        xxlib::Dict<int,::CSPkgTypes::CS_Account_Register_IsExists> dict ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计判断登陆名是否存在
    struct CS_Account_Register_IsExists : xxlib::Memmoveable
    {
        CS_Account_Register_IsExists(){}
        /*
         * 登录名
        */
        xxlib::String loginName ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计登陆
    struct CS_Account_Login : xxlib::Memmoveable
    {
        CS_Account_Login(){}
        /*
         * 登录名
        */
        xxlib::String loginName ;
        /*
         * 密码
        */
        xxlib::String password ;
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 极光推送标识
        */
        xxlib::String registrationId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计获取本人受理业务
    struct CS_Account_GetProduct : xxlib::Memmoveable
    {
        CS_Account_GetProduct(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计编号
        */
        int id = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计更新或添加个人受理业务
    struct CS_Product_Manage : xxlib::Memmoveable
    {
        CS_Product_Manage(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计用户编号
        */
        int accountantID = 0 ;
        /*
         * 业务产品编号
        */
        int productID = 0 ;
        /*
         * 业务产品名称
        */
        xxlib::String productname ;
        /*
         * 业务产品价格
        */
        double price = 0 ;
        /*
         * 擅长行业领域ID,最多2个ID，以,分割
        */
        xxlib::String industryID ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计主页个人信息
    struct CS_Account_GetDetails : xxlib::Memmoveable
    {
        CS_Account_GetDetails(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计用户编号
        */
        int accountantID = 0 ;
        /*
         * 公司ID，没有登陆的时候传-1，并传唯一标识
        */
        int customerID = 0 ;
        /*
         * 唯一标识
        */
        xxlib::String identification ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司注册
    struct CS_Customer_Register : xxlib::Memmoveable
    {
        CS_Customer_Register(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 联系人
        */
        xxlib::String contact ;
        /*
         * 公司名称
        */
        xxlib::String companyName ;
        /*
         * 公司地址
        */
        xxlib::String companyAdress ;
        /*
         * 公司类型
        */
        xxlib::String companyType ;
        /*
         * 联系电话
        */
        xxlib::String phone ;
        /*
         * 邮件
        */
        xxlib::String email ;
        /*
         * 登陆名
        */
        xxlib::String loginname ;
        /*
         * 密码
        */
        xxlib::String password ;
        /*
         * 纳税资质
        */
        xxlib::String taxQualification ;
        /*
         * 极光推送标识
        */
        xxlib::String registrationId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司注册用户名检测
    struct CS_Customer_Register_IsExists : xxlib::Memmoveable
    {
        CS_Customer_Register_IsExists(){}
        /*
         * 登录名
        */
        xxlib::String loginName ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取全部行业分类
    struct CS_Industry_AllSector : xxlib::Memmoveable
    {
        CS_Industry_AllSector(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司登陆
    struct CS_Customer_Login : xxlib::Memmoveable
    {
        CS_Customer_Login(){}
        /*
         * 登录名
        */
        xxlib::String loginName ;
        /*
         * 密码
        */
        xxlib::String password ;
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 极光推送标识
        */
        xxlib::String registrationId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询附近会计
    struct CS_Acctountant_GetAround : xxlib::Memmoveable
    {
        CS_Acctountant_GetAround(){}
        /*
         * 经度
        */
        double lon = 0 ;
        /*
         * 纬度
        */
        double lat = 0 ;
        /*
         * 半径（米
        */
        int radius = 0 ;
        /*
         * 令牌
        */
        xxlib::String token ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 创建订单
    struct CS_Order_Create : xxlib::Memmoveable
    {
        CS_Order_Create(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        /*
         * 客户ID
        */
        int customerID = 0 ;
        /*
         * 数量
        */
        int count = 0 ;
        /*
         * 开始执行日期
        */
        xxlib::SimpleDate startTime ;
        /*
         * 订单结束日期
        */
        xxlib::SimpleDate endTime ;
        /*
         * 订单周期,（默认赋值1）
        */
        int cycle = 0 ;
        /*
         * 订单备注
        */
        xxlib::String remark ;
        /*
         * 产品明细
        */
        xxlib::String product ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询全部快递服务
    struct CS_Express_GetAll : xxlib::Memmoveable
    {
        CS_Express_GetAll(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询未完成订单列表
    struct CS_UncompletedOrder_GetList : xxlib::Memmoveable
    {
        CS_UncompletedOrder_GetList(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计/客户ID
        */
        int id = 0 ;
        /*
         * 角色(0表示会计，1表示客户)
        */
        int role = 0 ;
        /*
         * 页码(0代表第一页)
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询订单明细
    struct CS_Order_GetDetails : xxlib::Memmoveable
    {
        CS_Order_GetDetails(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 订单ID
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计修改订单价格
    struct CS_Order_UpdateTotal : xxlib::Memmoveable
    {
        CS_Order_UpdateTotal(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        /*
         * 订单ID
        */
        xxlib::String orderId ;
        /*
         * 会计输入的实际订单金额
        */
        double total = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户确认订单
    struct CS_Customer_Order_Confirm : xxlib::Memmoveable
    {
        CS_Customer_Order_Confirm(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户ID
        */
        int customerID = 0 ;
        /*
         * 订单ID
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取支付平台列表
    struct CS_Get_Payment_Platform : xxlib::Memmoveable
    {
        CS_Get_Payment_Platform(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户寄送资料
    struct CS_Customer_Deliver : xxlib::Memmoveable
    {
        CS_Customer_Deliver(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户ID
        */
        int customerID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        /*
         * 快递回执编号
        */
        xxlib::String code ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计接收资料确认
    struct CS_Accountant_Receipt_Confirm : xxlib::Memmoveable
    {
        CS_Accountant_Receipt_Confirm(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计填写报表
    struct CS_Accountant_Create_Report : xxlib::Memmoveable
    {
        CS_Accountant_Create_Report(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        /*
         * 报表内容
        */
        xxlib::String report ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询月度报表
    struct CS_Get_Report_Month : xxlib::Memmoveable
    {
        CS_Get_Report_Month(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询季度报表
    struct CS_Get_Report_Quarter : xxlib::Memmoveable
    {
        CS_Get_Report_Quarter(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 订单编号
        */
        xxlib::String customerId ;
        /*
         * “-”前代表年份, ”-”后代表季度（传1到4）
        */
        xxlib::String time ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户对报表审核
    struct CS_Customer_Report_Confirm : xxlib::Memmoveable
    {
        CS_Customer_Report_Confirm(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户 ID
        */
        int customerID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        /*
         * 审批结果
        */
        bool result = false ;
        /*
         * 备注
        */
        xxlib::String remark ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计返还资料
    struct CS_Accountant_Send_Back : xxlib::Memmoveable
    {
        CS_Accountant_Send_Back(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计 ID
        */
        int accountantID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        /*
         * 审批结果
        */
        xxlib::String code ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户接收确认，订单完成
    struct CS_Customer_Order_Recive : xxlib::Memmoveable
    {
        CS_Customer_Order_Recive(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户 ID
        */
        int customerID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户退回订单至会计定价
    struct CS_Customer_Order_Back : xxlib::Memmoveable
    {
        CS_Customer_Order_Back(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户 ID
        */
        int customerID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计取消订单
    struct CS_Accountant_Cancel_Order : xxlib::Memmoveable
    {
        CS_Accountant_Cancel_Order(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计 ID
        */
        int accountantID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户取消订单
    struct CS_Customer_Cancel_Order : xxlib::Memmoveable
    {
        CS_Customer_Cancel_Order(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户 ID
        */
        int customerID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计列表
    struct CS_Accountant_GetListSortData : xxlib::Memmoveable
    {
        CS_Accountant_GetListSortData(){}
        /*
         * 排序的字段名
        */
        ::CSPkgTypes::CS_Accountant_GetListSortData_Type type ;
        /*
         * true大到小,false小到大
        */
        bool sortType = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计列表
    struct CS_Accountant_GetListScreenData : xxlib::Memmoveable
    {
        CS_Accountant_GetListScreenData(){}
        /*
         * 字段名
        */
        xxlib::String name ;
        /*
         * 值
        */
        xxlib::String number ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计列表
    struct CS_Accountant_GetList : xxlib::Memmoveable
    {
        CS_Accountant_GetList(){}
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        /*
         * 排序方式
        */
        ::CSPkgTypes::CS_Accountant_GetListSortData sortData ;
        /*
         * 筛选方式
        */
        ::CSPkgTypes::CS_Accountant_GetListScreenData screen ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询已完成订单列表
    struct CS_CompeletedOrder_GetList : xxlib::Memmoveable
    {
        CS_CompeletedOrder_GetList(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计/客户ID
        */
        int id = 0 ;
        /*
         * 角色(0表示会计，1表示客户)
        */
        int role = 0 ;
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户对会计服务评分
    struct CS_Grade_AccountantService : xxlib::Memmoveable
    {
        CS_Grade_AccountantService(){}
        /*
         * 客户对会计服务评分
        */
        double grade = 0 ;
        /*
         * 订单ID
        */
        xxlib::String orderId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计上传证件照片
    struct CS_AccountantCredentials_Upload : xxlib::Memmoveable
    {
        CS_AccountantCredentials_Upload(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 证件照片文件名
        */
        xxlib::String fileName ;
        /*
         * 证件照片内容,必须base64编码
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        /*
         * 证件类型
        */
        int credential_Type = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 银联支付获取交易流水号
    struct CS_UnionPayTn_Get : xxlib::Memmoveable
    {
        CS_UnionPayTn_Get(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 客户 ID
        */
        int customerID = 0 ;
        /*
         * 订单编号
        */
        xxlib::String orderId ;
        /*
         * 支付金额
        */
        double total = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计上传报表文件
    struct CS_ReportFile_Upload : xxlib::Memmoveable
    {
        CS_ReportFile_Upload(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 文件名
        */
        xxlib::String fileName ;
        /*
         * 文件内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 子订单编号
        */
        xxlib::String subOrderID ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件
    struct CS_ReportFile_Download : xxlib::Memmoveable
    {
        CS_ReportFile_Download(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 文件id
        */
        int file_id = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 删除报表文件
    struct CS_ReportFile_Delete : xxlib::Memmoveable
    {
        CS_ReportFile_Delete(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 文件id
        */
        int file_id = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取某会计未完成订单列表(web版)
    struct CS_GetAccountantUncompletedOrderList_web : xxlib::Memmoveable
    {
        CS_GetAccountantUncompletedOrderList_web(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计id
        */
        int accountant_id = 0 ;
        /*
         * 页码(0代表第一页)
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计电子名片
    struct CS_AccountantElectronicBusinessCard_Get : xxlib::Memmoveable
    {
        CS_AccountantElectronicBusinessCard_Get(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载会计图片
    struct CS_AccountanPictureDown : xxlib::Memmoveable
    {
        CS_AccountanPictureDown(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 通过公司和年月查找报表
    struct CS_FindReportCustom : xxlib::Memmoveable
    {
        CS_FindReportCustom(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的月
        */
        int month = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司上传电子财务信息
    struct CS_Customer_UploadElectronicBill : xxlib::Memmoveable
    {
        CS_Customer_UploadElectronicBill(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的月
        */
        int month = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获得公司电子财务信息
    struct CS_GetElectronicBill : xxlib::Memmoveable
    {
        CS_GetElectronicBill(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的月
        */
        int month = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询所有订单的进度
    struct CS_CustomerGetOrderState : xxlib::Memmoveable
    {
        CS_CustomerGetOrderState(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传年度报表文件
    struct CS_ReportFile_Upload_Year : xxlib::Memmoveable
    {
        CS_ReportFile_Upload_Year(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 子订单编号
        */
        xxlib::String subOrderID ;
        /*
         * excel名称
        */
        xxlib::String fileName ;
        /*
         * excel内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 报表的年
        */
        int year = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传季度报表文件
    struct CS_ReportFile_Upload_Quarter : xxlib::Memmoveable
    {
        CS_ReportFile_Upload_Quarter(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 子订单编号
        */
        xxlib::String subOrderID ;
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的季度
        */
        int quarter = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传月度报表文件
    struct CS_ReportFile_Upload_Month : xxlib::Memmoveable
    {
        CS_ReportFile_Upload_Month(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 子订单编号
        */
        xxlib::String subOrderID ;
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的月
        */
        int month = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载年度报表文件
    struct CS_ReportFile_Download_Year : xxlib::Memmoveable
    {
        CS_ReportFile_Download_Year(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载季度报表文件
    struct CS_ReportFile_Download_Quarter : xxlib::Memmoveable
    {
        CS_ReportFile_Download_Quarter(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的季度
        */
        int quarter = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载月度报表文件
    struct CS_ReportFile_Download_Month : xxlib::Memmoveable
    {
        CS_ReportFile_Download_Month(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的月
        */
        int month = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获得订单下有哪些报表
    struct CS_ReportFileList_Download : xxlib::Memmoveable
    {
        CS_ReportFileList_Download(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 子订单编号
        */
        xxlib::String subOrderID ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件(订单流程内使用)
    struct CS_ReportFileOrder_Download : xxlib::Memmoveable
    {
        CS_ReportFileOrder_Download(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 报表文件的ID
        */
        int fileId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 地图点击获得会计详细信息
    struct CS_CheckAccountantInformation : xxlib::Memmoveable
    {
        CS_CheckAccountantInformation(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计的ID
        */
        int accountantId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 通过报表文件ID查看文件
    struct CS_CheckReportFileFromID : xxlib::Memmoveable
    {
        CS_CheckReportFileFromID(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 报表文件ID
        */
        int reportId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看年度报表文件
    struct CS_ReportFile_Find_Year : xxlib::Memmoveable
    {
        CS_ReportFile_Find_Year(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看季度报表文件
    struct CS_ReportFile_Find_Quarter : xxlib::Memmoveable
    {
        CS_ReportFile_Find_Quarter(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的季度
        */
        int quarter = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看月度报表文件
    struct CS_ReportFile_Find_Month : xxlib::Memmoveable
    {
        CS_ReportFile_Find_Month(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 报表的年
        */
        int year = 0 ;
        /*
         * 报表的月
        */
        int month = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 交易过的会计列表
    struct CS_DealAccountantList : xxlib::Memmoveable
    {
        CS_DealAccountantList(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int customID = 0 ;
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 修改会计个人资料
    struct CS_ChangeAccountantInformation : xxlib::Memmoveable
    {
        CS_ChangeAccountantInformation(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计编号
        */
        int id = 0 ;
        /*
         * 昵称
        */
        xxlib::String nickName ;
        /*
         * 身份证号码
        */
        xxlib::String idNumber ;
        /*
         * 会计从业资格编号
        */
        xxlib::String certificateNum ;
        /*
         * 真实姓名
        */
        xxlib::String name ;
        /*
         * 收件地址
        */
        xxlib::String acceptanceAddress ;
        /*
         * 办公地址
        */
        xxlib::String businessAddress ;
        /*
         * 联系电话
        */
        xxlib::String phone ;
        /*
         * 性别(请传：男或女)
        */
        xxlib::String gender ;
        /*
         * 电子邮件
        */
        xxlib::String email ;
        /*
         *  经度（办公地址）
        */
        double longitude = 0 ;
        /*
         * 纬度（办公地址）
        */
        double latitude = 0 ;
        /*
         * 自我介绍
        */
        xxlib::String selfIntroduction ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计点击修改，获得自己的数据
    struct CS_ReturnAccountantInformation : xxlib::Memmoveable
    {
        CS_ReturnAccountantInformation(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计编号
        */
        int accountantId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计首页
    struct CS_AccountantHomePage : xxlib::Memmoveable
    {
        CS_AccountantHomePage(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 会计编号
        */
        int accountantId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司匿名登录
    struct CS_CustomerAnonymous : xxlib::Memmoveable
    {
        CS_CustomerAnonymous(){}
        /*
         * 用户名
        */
        xxlib::String username ;
        /*
         * 极光推送标识
        */
        xxlib::String registrationId ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看会计证件照片
    struct CS_FindAccountantCredentials : xxlib::Memmoveable
    {
        CS_FindAccountantCredentials(){}
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的公司
    struct CS_AccountantFindCustomer : xxlib::Memmoveable
    {
        CS_AccountantFindCustomer(){}
        /*
         * 会计编号
        */
        int accountantId = 0 ;
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的某个公司明细
    struct CS_AcountantFindCustomerDetail : xxlib::Memmoveable
    {
        CS_AcountantFindCustomerDetail(){}
        /*
         * 公司ID
        */
        int customerID = 0 ;
        /*
         * 会计ID
        */
        int accountantID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 用户更换头像
    struct CS_UserChangeIcon : xxlib::Memmoveable
    {
        CS_UserChangeIcon(){}
        /*
         * ID
        */
        int id = 0 ;
        /*
         * 类型true代表公司，false代表会计
        */
        bool type = false ;
        /*
         * 头像
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司主页
    struct CS_CustomerHomePage : xxlib::Memmoveable
    {
        CS_CustomerHomePage(){}
        /*
         * 公司编号
        */
        int customerId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看推送消息
    struct CS_FindPushMessage : xxlib::Memmoveable
    {
        CS_FindPushMessage(){}
        /*
         * 用户ID
        */
        int id = 0 ;
        /*
         * 用户类型true为公司，false为会计
        */
        bool type = false ;
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看文档
    struct CS_AccountantFindDocment : xxlib::Memmoveable
    {
        CS_AccountantFindDocment(){}
        /*
         * 会计的ID
        */
        int accountantID = 0 ;
        /*
         * 页码（0代表第一页）
        */
        int index = 0 ;
        /*
         * 单页显示数量
        */
        int size = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
}
#endif
