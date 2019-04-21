#pragma warning disable 0169
using PacketLibrary;
using System;

[Desc("会计注册"), Condation("name", "安建宇")]
class CS_Accountant_Register
{
    [Limit (0,30),Desc("真实姓名")]
    string name;
    [Limit (0,300),Desc("收件地址")]
    string acceptanceAddress;
    [Limit (0,300),Desc("办公地址")]
    string businessAddress;
    [Limit (0,60),Desc("联系电话")]
    string phone;
    [Limit (0,60),Desc("登录名")]
    string loginName;
    [Limit (0,60),Desc("密码")]
    string password;
    [Limit (0,54),Desc("身份证号")]
    string idNumber;
    [Limit (0,150),Desc("证书编号（会计资格证）")]
    string certificateNO;
    [Desc(" 经度（办公地址）")]
    double longitude;
    [Desc("纬度（办公地址）")]
    double latitude;
    [Limit( 0, 60 ), Desc( "昵称" )]
    string nickName;
    [Limit( 0, 3 ), Desc( "性别(请传：男或女)" )]
    string gender;
    [Limit( 0, 150 ), Desc( "电子邮件" ), Default("电子邮件")]
    string emmail;
    [Limit( 0, 3000 ), Desc( "自我介绍" )]
    string selfIntroduction;
    [Limit (0,150),Desc("极光推送标识")]
    string registrationId;
    Dict<int, CS_Account_Register_IsExists> dict;
};


[Desc("会计判断登陆名是否存在")]
class CS_Account_Register_IsExists
{
    [Limit (0,150),Desc("登录名")]
    string loginName;
}

[Desc("会计登陆")]
class CS_Account_Login
{
    [Limit (0,60),Desc("登录名")]
    string loginName;
    [Limit (0,60),Desc("密码")]
    string password;
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("极光推送标识")]
    string registrationId;
}


[Desc( "会计获取本人受理业务" )]
class CS_Account_GetProduct
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计编号")]
    int id;
}


[Desc( "会计更新或添加个人受理业务" )]
class CS_Product_Manage
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计用户编号")]
    int accountantID;
    [Desc("业务产品编号")]
    int productID;
    [Limit( 0, 150 ), Desc( "业务产品名称" )]
    string productname;
    [Desc("业务产品价格")]
    double price;
    [Limit( 0, 150 ), Desc( "擅长行业领域ID,最多2个ID，以,分割" )]
    string industryID;

}
[Desc( "获取会计主页个人信息" )]
class CS_Account_GetDetails
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计用户编号")]
    int accountantID;
    [Desc("公司ID，没有登陆的时候传-1，并传唯一标识")]
    int customerID;
    [Limit(0,300),Desc("唯一标识")]
    string identification;
}
[Desc( "公司注册" )]
class CS_Customer_Register
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,30),Desc("联系人")]
    string contact;
    [Limit( 0, 150 ), Desc( "公司名称" )]
    string companyName;
    [Limit( 0, 300 ), Desc( "公司地址" )]
    string companyAdress;
    [Limit( 0, 150 ), Desc( "公司类型" )]
    string companyType;
    [Limit( 0, 60 ), Desc( "联系电话" )]
    string phone;
    [Limit( 0, 150 ), Desc( "邮件" )]
    string email;
    [Limit( 0, 60 ), Desc( "登陆名" )]
    string loginname;
    [Limit( 0, 60 ), Desc( "密码" )]
    string password;
    [Limit( 0, 150 ), Desc( "纳税资质" )]
    string taxQualification;
    [Limit (0,150),Desc("极光推送标识")]
    string registrationId;
}

[Desc( "公司注册用户名检测" )]
class CS_Customer_Register_IsExists
{
    [Limit (0,60),Desc("登录名")]
    string loginName;
}

[Desc( "获取全部行业分类" )]
class CS_Industry_AllSector
{
    [Limit (0,150),Desc("令牌")]
    string token;
}


[Desc( "公司登陆" )]
class CS_Customer_Login
{
    [Limit (0,60),Desc("登录名")]
    string loginName;
    [Limit (0,60),Desc("密码")]
    string password;
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("极光推送标识")]
    string registrationId;
}

[Desc( "查询附近会计" )]
class CS_Acctountant_GetAround
{
    [Desc("经度")]
    double lon;
    [Desc("纬度")]
    double lat;
    [Desc("半径（米")]
    int radius;
    [Limit (0,150),Desc("令牌")]
    string token;
}
[Desc( "创建订单" )]
class CS_Order_Create
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计ID")]
    int accountantID;
    [Desc("客户ID")]
    int customerID;
    [Desc("数量")]
    int count;
    [Desc("开始执行日期")]
    DateTime startTime;
    [Desc("订单结束日期")]
    DateTime endTime;
    [Desc("订单周期,（默认赋值1）")]
    int cycle;
    [Limit (0,600),Desc("订单备注")]
    string remark;
    [Limit (0,150),Desc("产品明细")]
    string product;
}

[Desc( "查询全部快递服务" )]
class CS_Express_GetAll
{

}

[Desc( "查询未完成订单列表" )]
class CS_UncompletedOrder_GetList
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计/客户ID")]
    int id;
    [Desc("角色(0表示会计，1表示客户)")]
    int role;
    [Desc("页码(0代表第一页)")]
    int index;
    [Desc("单页显示数量")]
    int size;
}


[Desc( "查询订单明细" )]
class CS_Order_GetDetails
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("订单ID")]
    string orderId;
}

[Desc( "会计修改订单价格" )]
class CS_Order_UpdateTotal
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计ID")]
    int accountantID;
    [Limit (0,150),Desc("订单ID")]
    string orderId;
    [Desc("会计输入的实际订单金额")]
    double total;
}

[Desc( "客户确认订单" )]
class CS_Customer_Order_Confirm
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户ID")]
    int customerID;
    [Limit (0,150),Desc("订单ID")]
    string orderId;
}

[Desc( "获取支付平台列表" )]
class CS_Get_Payment_Platform
{
    [Limit (0,150),Desc("令牌")]
    string token;
}



[Desc( "客户寄送资料" )]
class CS_Customer_Deliver
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户ID")]
    int customerID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
    [Limit (0,150),Desc("快递回执编号")]
    string code;
}

[Desc( "会计接收资料确认" )]
class CS_Accountant_Receipt_Confirm
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计ID")]
    int accountantID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
}

[Desc( "会计填写报表" )]
class CS_Accountant_Create_Report
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计ID")]
    int accountantID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
    [Limit (0,600),Desc("报表内容")]
    string report;
}

[Desc( "查询月度报表" )]
class CS_Get_Report_Month
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
}

[Desc( "查询季度报表" )]
class CS_Get_Report_Quarter
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("订单编号")]
    string customerId;
    [Limit (0,150),Desc("“-”前代表年份, ”-”后代表季度（传1到4）")]
    string time;
}


[Desc( "客户对报表审核" )]
class CS_Customer_Report_Confirm
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户 ID")]
    int customerID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
    [Desc("审批结果")]
    bool result;
    [Limit (0,600),Desc("备注")]
    string remark;
}

[Desc( "会计返还资料" )]
class CS_Accountant_Send_Back
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计 ID")]
    int accountantID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
    [Desc("审批结果")]
    string code;
}

[Desc( "客户接收确认，订单完成" )]
class CS_Customer_Order_Recive
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户 ID")]
    int customerID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
}

[Desc( "客户退回订单至会计定价" )]
class CS_Customer_Order_Back
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户 ID")]
    int customerID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
}

[Desc( "会计取消订单" )]
class CS_Accountant_Cancel_Order
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计 ID")]
    int accountantID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
}

[Desc( "客户取消订单" )]
class CS_Customer_Cancel_Order
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户 ID")]
    int customerID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
}

[Desc( "获取会计列表" )]
enum CS_Accountant_GetListSortData_Type : byte
{
    [Desc("默认方式")]
    SortDefault,
    [Desc("评分")]
    SortGrade,
    [Desc( "服务次数" )]
    ServeCount,
}

[Desc( "获取会计列表" )]
class CS_Accountant_GetListSortData
{
    [Desc("排序的字段名")]
    CS_Accountant_GetListSortData_Type type;
    [Desc("true大到小,false小到大")]
    bool sortType;
}
[Desc( "获取会计列表" )]
class CS_Accountant_GetListScreenData
{
    [Limit (0,150),Desc("字段名")]
    string name;
    [Limit(0,50),Desc("值")]
    string number;
}

[Desc( "获取会计列表" )]
class CS_Accountant_GetList
{
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
    [Desc("排序方式")]
    CS_Accountant_GetListSortData sortData;
    [Desc("筛选方式")]
    CS_Accountant_GetListScreenData screen;
}


[Desc( "查询已完成订单列表" )]
class CS_CompeletedOrder_GetList
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计/客户ID")]
    int id;
    [Desc("角色(0表示会计，1表示客户)")]
    int role;
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
}


[Desc( "客户对会计服务评分" )]
class CS_Grade_AccountantService
{
    [Desc("客户对会计服务评分")]
    double grade;
    [Limit (0,150),Desc("订单ID")]
    string orderId;
}

[Desc( "会计上传证件照片" )]
class CS_AccountantCredentials_Upload
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("证件照片文件名")]
    string fileName;
    [Limit (0,3048576),Desc("证件照片内容,必须base64编码")]
    byte[] fileContent;
    [Desc("会计ID")]
    int accountantID;
    [Desc("证件类型")]
    int credential_Type;
}

[Desc( "银联支付获取交易流水号" )]
class CS_UnionPayTn_Get
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("客户 ID")]
    int customerID;
    [Limit (0,150),Desc("订单编号")]
    string orderId;
    [Desc( "支付金额" )]
    double total;
}



[Desc( "会计上传报表文件" )]
class CS_ReportFile_Upload
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("文件名")]
    string fileName;
    [Limit (0,3048576),Desc("文件内容")]
    byte[] fileContent;
    [Limit (0,150),Desc("子订单编号")]
    string subOrderID;
}

[Desc( "下载报表文件" )]
class CS_ReportFile_Download
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("文件id")]
    int file_id;
}

[Desc( "删除报表文件" )]
class CS_ReportFile_Delete
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("文件id")]
    int file_id;
}

[Desc( "获取某会计未完成订单列表(web版)" )]
class CS_GetAccountantUncompletedOrderList_web
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计id")]
    int accountant_id;
    [Desc("页码(0代表第一页)")]
    int index;
    [Desc("单页显示数量")]
    int size;
}

[Desc( "获取会计电子名片" )]
class CS_AccountantElectronicBusinessCard_Get
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计ID")]
    int accountantID;
}

[Desc( "下载会计图片" )]
class CS_AccountanPictureDown
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计ID")]
    int accountantID;
}

[Desc("通过公司和年月查找报表")]
class CS_FindReportCustom
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
    [Desc("报表的月")]
    int month;
}

[Desc("公司上传电子财务信息")]
class CS_Customer_UploadElectronicBill
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
    [Desc("报表的年")]
    int year;
    [Desc("报表的月")]
    int month;
}

[Desc( "获得公司电子财务信息" )]
class CS_GetElectronicBill
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
    [Desc("报表的月")]
    int month;
}

[Desc( "公司查询所有订单的进度" )]
class CS_CustomerGetOrderState
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
}

[Desc( "上传年度报表文件" )]
class CS_ReportFile_Upload_Year
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("子订单编号")]
    string subOrderID;
    [Limit (0,150),Desc("excel名称")]
    string fileName;
    [Limit (0,3048576),Desc("excel内容")]
    byte[] fileContent;
    [Desc("报表的年")]
    int year;
}

[Desc( "上传季度报表文件" )]
class CS_ReportFile_Upload_Quarter
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("子订单编号")]
    string subOrderID;
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
    [Desc("报表的年")]
    int year;
    [Desc("报表的季度")]
    int quarter;
}


[Desc( "上传月度报表文件" )]
class CS_ReportFile_Upload_Month
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("子订单编号")]
    string subOrderID;
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
    [Desc("报表的年")]
    int year;
    [Desc("报表的月")]
    int month;
}


[Desc( "下载年度报表文件" )]
class CS_ReportFile_Download_Year
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
}

[Desc( "下载季度报表文件" )]
class CS_ReportFile_Download_Quarter
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
    [Desc("报表的季度")]
    int quarter;
}

[Desc( "下载月度报表文件" )]
class CS_ReportFile_Download_Month
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
    [Desc("报表的月")]
    int month;
}

[Desc( "获得订单下有哪些报表" )]
class CS_ReportFileList_Download
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Limit (0,150),Desc("子订单编号")]
    string subOrderID;
 
}


[Desc( "下载报表文件(订单流程内使用)" )]
class CS_ReportFileOrder_Download
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("报表文件的ID")]
    int fileId;

}


[Desc("地图点击获得会计详细信息")]
class CS_CheckAccountantInformation
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计的ID")]
    int accountantId;
}

[Desc( "通过报表文件ID查看文件" )]
class CS_CheckReportFileFromID
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("报表文件ID")]
    int reportId;
}



[Desc( "查看年度报表文件" )]
class CS_ReportFile_Find_Year
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
}

[Desc( "查看季度报表文件" )]
class CS_ReportFile_Find_Quarter
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
    [Desc("报表的季度")]
    int quarter;
}

[Desc( "查看月度报表文件" )]
class CS_ReportFile_Find_Month
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("报表的年")]
    int year;
    [Desc("报表的月")]
    int month;
}

[Desc( "交易过的会计列表" )]
class CS_DealAccountantList
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int customID;
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
}


[Desc( "修改会计个人资料" )]
class CS_ChangeAccountantInformation
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计编号")]
    int id;
    [Limits(0,90), Desc("昵称")]
    string nickName;
    [Limits(0,90) Desc("身份证号码")]
    string idNumber;
    [Limits(0,90),Desc("会计从业资格编号")]
    string certificateNum;
    [Limit (0,90),Desc("真实姓名")]
    string name;
    [Limit (0,900),Desc("收件地址")]
    string acceptanceAddress;
    [Limit (0,900),Desc("办公地址")]
    string businessAddress;
    [Limit (0,60),Desc("联系电话")]
    string phone;
    [Limit( 0, 3 ), Desc( "性别(请传：男或女)" )]
    string gender;
    [Limit( 0, 1150 ), Desc( "电子邮件" )]
    string email;
    [Desc(" 经度（办公地址）")]
    double longitude;
    [Desc("纬度（办公地址）")]
    double latitude;
    [Limit( 0, 11500 ), Desc( "自我介绍" )]
    string selfIntroduction;
}


[Desc("会计点击修改，获得自己的数据")]
class CS_ReturnAccountantInformation
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计编号")]
    int accountantId;
}


[Desc("会计首页")]
class CS_AccountantHomePage
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("会计编号")]
    int accountantId;
}


[Desc( "公司匿名登录" )]
class CS_CustomerAnonymous
{
    [Limit(0,300),Desc("用户名")]
    string username;
    [Limit (0,150),Desc("极光推送标识")]
    string registrationId;
}

[Desc( "查看会计证件照片" )]
class CS_FindAccountantCredentials
{
    [Desc("会计ID")]
    int accountantID;
}

[Desc( "会计查看交易过的公司" )]
class CS_AccountantFindCustomer
{
    [Desc("会计编号")]
    int accountantId;
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
}

[Desc( "会计查看交易过的某个公司明细" )]
class CS_AcountantFindCustomerDetail
{
    [Desc("公司ID")]
    int customerID;
    [Desc("会计ID")]
    int accountantID;
}

[Desc("用户更换头像")]
class CS_UserChangeIcon
{
    [Desc("ID")]
    int id;
    [Desc("类型true代表公司，false代表会计")]
    bool type;
    [Limit (0,3048576),Desc("头像")]
    byte[] fileContent;
}

[Desc( "公司主页" )]
class CS_CustomerHomePage
{
    [Desc("公司编号")]
    int customerId;
}

[Desc("查看推送消息")]
class CS_FindPushMessage
{
    [Desc("用户ID")]
    int id;
    [Desc("用户类型true为公司，false为会计")]
    bool type;
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
}


[Desc("会计查看文档")]
class CS_AccountantFindDocment
{
    [Desc("会计的ID")]
    int accountantID;
    [Desc("页码（0代表第一页）")]
    int index;
    [Desc("单页显示数量")]
    int size;
}



