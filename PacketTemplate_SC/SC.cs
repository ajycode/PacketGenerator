using PacketLibrary;
using System;


//用户注册
[Desc( "会计注册" )]
enum SC_Accountant_Register_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "用户名已经存在" )]
    UserNameExist,
}
[Desc( "会计注册成功" )]
class SC_Accountant_Register_Success
{
    [Desc( "会计用户编号" )]
    int id;
    [Limit (0,90),Desc( "用户的名字" )]
    string name;
    [Limit (0,600),Desc( "头像的地址" )]
    string headIcon;
}
[Desc( "会计注册失败" )]
class SC_Accountant_Register_Failure
{
    SC_Accountant_Register_Failure_Type type;
}


//用户注册检测
[Desc( "用户名检测" )]
enum SC_Account_Register_IsExists_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "用户名已经存在" )]
    UserNameExist,
}
[Desc( "用户名检测" )]
class SC_Account_Register_IsExists_Success
{

}
[Desc( "用户名检测" )]
class SC_Account_Register_IsExists_Failure
{
    SC_Account_Register_IsExists_Failure_Type type;
}


//用户登录
[Desc( "会计登陆" )]
enum SC_Account_Login_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "用户名不存在" )]
    UserNameExist,
    [Desc( "密码错误" )]
    PasswordError,
    [Desc( "账号被锁定" )]
    AccountNumberlLocked,
}
[Desc( "会计登陆" )]
class SC_Account_Login_Success
{
    [Desc( "会计用户编号" )]
    int id;
    [Limit (0,90),Desc( "用户的名字" )]
    string name;
    [Limit (0,600),Desc( "头像的地址" )]
    string headIcon;
}
[Desc( "会计登陆" )]
class SC_Account_Login_Failure
{
    SC_Account_Login_Failure_Type type;
}



[Desc( "会计获取本人受理业务" )]
enum SC_Account_GetProduct_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "会计获取本人受理业务" )]
class SC_Account_GetProduct_Success
{
    List<SC_Account_GetProduct_Product> products;
    List<SC_Account_GetProduct_Industry> industrys;
}
[Desc( "会计获取本人受理业务" )]
class SC_Account_GetProduct_Product
{
    [Desc( "产品ID" )]
    int productID;
    [Limit (0,1150),Desc( "产品名称" )]
    string productname;
    [Desc( "用户ID" )]
    int accountantID;
    [Desc( "创建时间" )]
    DateTime createtime;
    [Desc( "价格" )]
    double price;
    [Desc( "擅长领域的ID集合" )]
    List<int> industryID ;
    [Limit (0,600),Desc( "" )]
    string description;
}
[Desc( "会计获取本人受理业务" )]
class SC_Account_GetProduct_Industry
{
    [Desc( "行业编号" )]
    int id;
    [Limit (0,1150),Desc( "行业名称" )]
    string name;
}
[Desc( "会计获取本人受理业务" )]
class SC_Account_GetProduct_Failure
{
    SC_Account_GetProduct_Failure_Type type;
}



[Desc( "会计更新或添加个人受理业务" )]
enum SC_Product_Manage_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "会计更新或添加个人受理业务" )]
class SC_Product_Manage_Success
{

}
[Desc( "会计更新或添加个人受理业务" )]
class SC_Product_Manage_Failure
{
    SC_Product_Manage_Failure_Type type;
}


[Desc( "获取会计主页个人信息" )]
enum SC_Account_GetDetails_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "未查找到" )]
    NotFound
}
[Desc( "获取会计主页个人信息" )]
class SC_Account_GetDetails_ProductId
{
    [Desc("产品ID")]
    int productId;
    [Limit (0,1150),Desc("产品名称")]
    string productName;
    [Desc("产品价格")]
    double price;
    [Limit (0,900),Desc("行业")]
    string idustry;
}
[Desc( "获取会计主页个人信息" )]
class SC_Account_GetDetails_Success
{
    [Desc("会计编号")]
    int id;
    [Limits(0,90), Desc("昵称")]
    string nickName;
    [Limits(0,90) Desc("身份证号码")]
    string idNumber;
    [Limits(0,90),Desc("会计从业资格编号")]
    string certificateNum;
    [Limits(0,90),Desc("会计审核状态")]
    string state;
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
    [Limit( 0, 900 ), Desc( "头像地址" )]
    string headShot;
    [Desc(" 经度（办公地址）")]
    double longitude;
    [Desc("纬度（办公地址）")]
    double latitude;
    [Limit( 0, 11500 ), Desc( "自我介绍" )]
    string selfIntroduction;

    SC_Account_GetDetails_ProductId product;
}

[Desc( "获取会计主页个人信息" )]
class SC_Account_GetDetails_Failure
{
    SC_Account_GetDetails_Failure_Type type;
}



[Desc( "公司注册" )]
enum SC_Customer_Register_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "用户名已经存在" )]
    UserNameExist,
}
[Desc( "公司注册" )]
class SC_Customer_Register_Success
{
    [Desc( "公司用户编号" )]
    int id;
}
[Desc( "公司注册" )]
class SC_Customer_Register_Failure
{
    SC_Customer_Register_Failure_Type type;
}


[Desc( "公司注册用户名检测" )]
enum SC_Customer_Register_IsExists_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "用户名已存在" )]
    UserNameExist,
}
[Desc( "公司注册用户名检测" )]
class SC_Customer_Register_IsExists_Success
{

}
[Desc( "公司注册用户名检测" )]
class SC_Customer_Register_IsExists_Failure
{
    SC_Customer_Register_IsExists_Failure_Type type;
}


[Desc( "获取全部行业分类" )]
enum SC_Industry_AllSector_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "获取全部行业分类" )]
class SC_Industry_AllSector_Success
{
    List<SC_Industry_AllSector_Industry> industrys;
}
[Desc( "获取全部行业分类" )]
class SC_Industry_AllSector_Industry
{
    [Desc( "行业编号" )]
    int id;
    [Limit (0,1150),Desc( "行业名称" )]
    string name;
}
[Desc( "获取全部行业分类" )]
class SC_Industry_AllSector_Failure
{
    SC_Industry_AllSector_Failure_Type type;
}


[Desc( "公司登陆" )]
enum SC_Customer_Login_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "用户名或密码错误" )]
    UsernameOrPasswordError,
    [Desc( "账号被锁定" )]
    AccountNumberLocked,
}
[Desc( "公司登陆" )]
class SC_Customer_Login_Success
{
    [Desc( "公司用户编号" )]
    int id;
    [Limit(0,150), Desc("公司名字")]
    string name;
}
[Desc( "公司登陆" )]
class SC_Customer_Login_Failure
{
    SC_Customer_Login_Failure_Type type;
}




[Desc( "查询附近会计" )]
enum SC_Acctountant_GetAround_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "查询附近会计" )]
class SC_Acctountant_GetAround_Success
{
    List<SC_Acctountant_GetAround_Person> person;
}
[Desc( "查询附近会计" )]
class SC_Acctountant_GetAround_Person
{
    [Desc( "会计用户编号" )]
    int id;
    [Limit( 0, 90 ), Desc( "会计名字" )]
    string name;
    [Limit(0,150),Desc("用户认证")]
    string accountantAuth;
    [Limit(0,3000),Desc("个人简介")]
    string introduction;
    [Desc("服务次数")]
    int completeCount;
    [Desc("好评度")]
    double grade;
    [Desc( "经度" )]
    double longitude;
    [Desc( "纬度" )]
    double latitude;
}
[Desc( "查询附近会计" )]
class SC_Acctountant_GetAround_Failure
{
    SC_Acctountant_GetAround_Failure_Type type;
}


[Desc( "创建订单" )]
enum SC_Order_Create_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "不能在未完成之前对当前会计重复下单" )]
    AccountantRepeat,
    [Desc( "当前时间已经有会计做过账" )]
    AcounttanOver,
}
[Desc( "创建订单" )]
class SC_Order_Create_Success
{
    bool isPushSuccess;
}
[Desc( "创建订单" )]
class SC_Order_Create_Failure
{
    SC_Order_Create_Failure_Type type;
}


[Desc( "查询全部快递服务" )]
enum SC_Express_GetAll_Failure_Type
{
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "查询全部快递服务" )]
class SC_Express_GetAll_Success
{
    List<SC_Express_GetAll_Date> person;
}
[Desc( "查询全部快递服务" )]
class SC_Express_GetAll_Date
{
    [Desc( "快递平台ID" )]
    int productId;
    [Limit( 0, 1150 ), Desc( "快递平台名称" )]
    string productName;
    [Desc( "快递价格" )]
    double price;
}
[Desc( "查询全部快递服务" )]
class SC_Express_GetAll_Failure
{
    SC_Express_GetAll_Failure_Type type;
}


[Desc( "查询未完成订单列表" )]
enum SC_UncompletedOrder_GetList_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "查询未完成订单列表" )]
class SC_UncompletedOrder_GetList_Success
{
    List<SC_UncompletedOrder_GetList_Data> data;
}
[Desc( "查询未完成订单列表" )]
class SC_UncompletedOrder_GetList_Data
{
    [Limit( 0, 1150 ),Desc("订单ID" )]
    string orderId;
    [Limit( 0, 1150 ), Desc( "公司名称" )]
    string name;
    [Desc( "订单创建时间" )]
    DateTime orderDate;
    [Desc( "订单当前状态" )]
    int stateCode;
    [Desc( "订单价格" )]
    double total;
    [Limit( 0, 1150 ), Desc( "用户看见的订单ID号" )]
    string idView;
    [Desc( "子订单SubOrder表自带的自增字段用于排序" )]
    int number;
}
[Desc( "查询未完成订单列表" )]
class SC_UncompletedOrder_GetList_Failure
{
    SC_UncompletedOrder_GetList_Failure_Type type;
}


[Desc( "查询订单明细" )]
enum SC_Order_GetDetails_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
}
[Desc( "查询订单明细" )]
class SC_Order_GetDetails_Success
{
    [Limit( 0, 1150 ), Desc( "订单编号" )]
    string orderID;
    [Limit( 0, 1150 ), Desc( "公司名称" )]
    string companyName;
    [Limit( 0, 1150 ), Desc( "公司所属行业" )]
    string companyType;
    [Limit( 0, 1150 ), Desc( "纳税资质" )]
    string taxQualification;
    [Limit( 0, 900 ), Desc( "公司地址" )]
    string companyAdress;
    [Limit( 0, 90 ), Desc( "公司联系人" )]
    string contact;
    [Limit( 0, 60 ), Desc( "公司电话" )]
    string customerPhone;
    [Limit( 0, 90 ), Desc( "会计姓名" )]
    string accountantName;
    [Limit( 0, 60 ), Desc( "会计电话" )]
    string accountantPhone;
    [Limit( 0, 1150 ), Desc( "会计收件地址" )]
    string accountantAdress;
    [Desc( "订单数量" )]
    int count;
    [Desc( "订单金额" )]
    double total;
    [Desc( "创建订单时间" )]
    DateTime createTime;
    [Desc( "订单执行时间" )]
    DateTime startTime;
    [Desc( "订单结束时间" )]
    DateTime endTime;
    [Desc( "订单周期" )]
    int cycle;
    [Desc( "状态码" )]
    int stateCode;
    [Limit( 0, 600 ), Desc( "订单备注" )]
    string remark;
    [Limit( 0, 1150 ), Desc( "用于显示的字符串为某些字段的拼接" )]
    string idView;
    [Limit( 0, 1150 ), Desc( "产品列表" )]
    string product;
    [Limit( 0, 1150 ), Desc( "快递回执编号" )]
    string expressNumber;
    [Limit( 0, 1150 ), Desc( "快递客服电话" )]
    string expressTel;
}
[Desc( "查询订单明细" )]
class SC_Order_GetDetails_Failure
{
    SC_Order_GetDetails_Failure_Type type;
}



[Desc( "会计修改订单价格" )]
enum SC_Order_UpdateTotal_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "数据库执行错误" )]
    ExecuteError,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "会计修改订单价格" )]
class SC_Order_UpdateTotal_Success
{
    bool isPushSuccess;
}
[Desc( "会计修改订单价格" )]
class SC_Order_UpdateTotal_Failure
{
    SC_Order_UpdateTotal_Failure_Type type;
}



[Desc( "客户确认订单" )]
enum SC_Customer_Order_Confirm_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户确认订单" )]
class SC_Customer_Order_Confirm_Success
{
    bool isPushSuccess;
}
[Desc( "客户确认订单" )]
class SC_Customer_Order_Confirm_Failure
{
    SC_Customer_Order_Confirm_Failure_Type type;
}



[Desc( "获取支付平台列表" )]
enum SC_Get_Payment_Platform_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "获取支付平台列表" )]
class SC_Get_Payment_Platform_Success
{
    List<SC_Get_Payment_Platform_Data> data;
}
[Desc( "获取支付平台列表" )]
class SC_Get_Payment_Platform_Data
{
    [Desc( "支付平台编号" )]
    int id;
    [Limit (0,1150),Desc( "支付平台名称" )]
    string name;
}
[Desc( "获取支付平台列表" )]
class SC_Get_Payment_Platform_Failure
{
    SC_Get_Payment_Platform_Failure_Type type;
}






[Desc( "客户寄送资料" )]
enum SC_Customer_Deliver_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户寄送资料" )]
class SC_Customer_Deliver_Success
{
    bool isPushSuccess;
}
[Desc( "客户寄送资料" )]
class SC_Customer_Deliver_Failure
{
    SC_Customer_Deliver_Failure_Type type;
}




[Desc( "会计接收资料确认" )]
enum SC_Accountant_Receipt_Confirm_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "会计接收资料确认" )]
class SC_Accountant_Receipt_Confirm_Success
{
    bool isPushSuccess;
}
[Desc( "会计接收资料确认" )]
class SC_Accountant_Receipt_Confirm_Failure
{
    SC_Accountant_Receipt_Confirm_Failure_Type type;
}



[Desc( "会计填写报表" )]
enum SC_Accountant_Create_Report_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "会计填写报表" )]
class SC_Accountant_Create_Report_Success
{
    bool isPushSuccess;
}
[Desc( "会计填写报表" )]
class SC_Accountant_Create_Report_Failure
{
    SC_Accountant_Create_Report_Failure_Type type;
}



[Desc( "查询月度报表" )]
enum SC_Get_Report_Month_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "查询月度报表" )]
class SC_Get_Report_Month_Success
{
    [Desc("订单编号")]
    double national_tax_total;
    [Desc("订单编号")]
    double land_tax_total;
    [Desc("订单编号")]
    double non_tax_income_total;
    [Limit (0,900),Desc("订单编号")]
    string national_tax;
    [Limit (0,11500),Desc("订单编号")]
    string land_tax;
}
[Desc( "查询月度报表" )]
class SC_Get_Report_Month_Failure
{
    SC_Get_Report_Month_Failure_Type type;
}


[Desc( "查询季度报表" )]
enum SC_Get_Report_Quarter_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "查询季度报表" )]
class SC_Get_Report_Quarter_Success
{
    [Desc("订单编号")]
    double national_tax_total;
    [Desc("订单编号")]
    double land_tax_total;
    [Desc("订单编号")]
    double non_tax_income_total;
    [Limit (0,900),Desc("订单编号")]
    string national_tax;
    [Limit (0,11500),Desc("订单编号")]
    string land_tax;
}
[Desc( "查询季度报表" )]
class SC_Get_Report_Quarter_Failure
{
    SC_Get_Report_Quarter_Failure_Type type;
}



[Desc( "客户对报表审核" )]
enum SC_Customer_Report_Confirm_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户对报表审核" )]
class SC_Customer_Report_Confirm_Success
{
    bool isPushSuccess;
}
[Desc( "客户对报表审核" )]
class SC_Customer_Report_Confirm_Failure
{
    SC_Customer_Report_Confirm_Failure_Type type;
}



[Desc( "会计返还资料" )]
enum SC_Accountant_Send_Back_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "会计返还资料" )]
class SC_Accountant_Send_Back_Success
{
    bool isPushSuccess;
}
[Desc( "会计返还资料" )]
class SC_Accountant_Send_Back_Failure
{
    SC_Accountant_Send_Back_Failure_Type type;
}


[Desc( "客户接收确认，订单完成" )]
enum SC_Customer_Order_Recive_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户接收确认，订单完成" )]
class SC_Customer_Order_Recive_Success
{
    bool isPushSuccess;
}
[Desc( "客户接收确认，订单完成" )]
class SC_Customer_Order_Recive_Failure
{
    SC_Customer_Order_Recive_Failure_Type type;
}


[Desc( "客户退回订单至会计定价" )]
enum SC_Customer_Order_Back_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户退回订单至会计定价" )]
class SC_Customer_Order_Back_Success
{
    bool isPushSuccess;
}
[Desc( "客户退回订单至会计定价" )]
class SC_Customer_Order_Back_Failure
{
    SC_Customer_Order_Back_Failure_Type type;
}



[Desc( "会计取消订单" )]
enum SC_Accountant_Cancel_Order_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "会计取消订单" )]
class SC_Accountant_Cancel_Order_Success
{
    bool isPushSuccess;
}
[Desc( "会计取消订单" )]
class SC_Accountant_Cancel_Order_Failure
{
    SC_Accountant_Cancel_Order_Failure_Type type;
}


[Desc( "客户取消订单" )]
enum SC_Customer_Cancel_Order_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户取消订单" )]
class SC_Customer_Cancel_Order_Success
{
    bool isPushSuccess;
}
[Desc( "客户取消订单" )]
class SC_Customer_Cancel_Order_Failure
{
    SC_Customer_Cancel_Order_Failure_Type type;
}


[Desc( "获取会计列表" )]
enum SC_Accountant_GetList_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "获取会计列表" )]
class SC_Accountant_GetList_Success
{
    List<SC_Accountant_GetList_Data> data;
}
[Desc( "获取会计列表" )]
class SC_Accountant_GetList_Data
{
    [Desc("编号")]
    int id;
    [Limit (0,90),Desc("名字")]
    string name;
    [Limit (0,60),Desc("电话号码")]
    string phone;
    [Limit (0,900),Desc("头像")]
    string headShot;
    [Desc("完成订单数量")]
    int completedorder;
    [Limit (0,1150),Desc("行业")]
    string industry;
    [Limit (0,1150),Desc("产品名称")]
    string productname;
    [Desc("产品ID")]
    int productID;
    [Desc("价格")]
    double price;
}
[Desc( "获取会计列表" )]
class SC_Accountant_GetList_Failure
{
    SC_Accountant_GetList_Failure_Type type;
}




[Desc( "查询已完成订单列表" )]
enum SC_CompeletedOrder_GetList_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "查询已完成订单列表" )]
class SC_CompeletedOrder_GetList_Success
{
    List<SC_CompeletedOrder_GetList_Data> data;
}
[Desc( "查询已完成订单列表" )]
class SC_CompeletedOrder_GetList_Data
{
    [Limit (0,1150),Desc("订单ID")]
    string orderId;
    [Limit (0,1150),Desc("公司名字")]
    string name;
    [Desc("订单创建时间")]
    DateTime orderDate;
    [Desc("订单状态")]
    int stateCode;
    [Desc("价格")]
    double total;
    [Limit (0,1150),Desc("用户看见的订单ID号")]
    string idView;
    [Desc("子订单数据表自增主键ID")]
    int number;
}
[Desc( "查询已完成订单列表" )]
class SC_CompeletedOrder_GetList_Failure
{
    SC_CompeletedOrder_GetList_Failure_Type type;
}


[Desc( "客户对会计服务评分" )]
enum SC_Grade_AccountantService_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "客户对会计服务评分" )]
class SC_Grade_AccountantService_Success
{

}
[Desc( "客户对会计服务评分" )]
class SC_Grade_AccountantService_Failure
{
    SC_Grade_AccountantService_Failure_Type type;
}


[Desc( "会计上传证件照片" )]
enum SC_AccountantCredentials_Upload_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "不存在该会计" )]
    NotFindAccountant,
}
[Desc( "会计上传证件照片" )]
class SC_AccountantCredentials_Upload_Success
{

}
[Desc( "会计上传证件照片" )]
class SC_AccountantCredentials_Upload_Failure
{
    SC_AccountantCredentials_Upload_Failure_Type type;
}


[Desc( "银联支付获取交易流水号" )]
enum SC_UnionPayTn_Get_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "银联支付获取交易流水号" )]
class SC_UnionPayTn_Get_Success
{
    [Limit (0,1150),Desc("流水号")]
    string tn;
}
[Desc( "银联支付获取交易流水号" )]
class SC_UnionPayTn_Get_Failure
{
    SC_UnionPayTn_Get_Failure_Type type;
}




[Desc( "会计上传报表文件" )]
enum SC_ReportFile_Upload_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "会计上传报表文件" )]
class SC_ReportFile_Upload_Success
{
}
[Desc( "会计上传报表文件" )]
class SC_ReportFile_Upload_Failure
{
    SC_ReportFile_Upload_Failure_Type type;
}

[Desc( "下载报表文件" )]
enum SC_ReportFile_Download_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该文件" )]
    NotFindFile,
}
[Desc( "下载报表文件" )]
class SC_ReportFile_Download_Success
{
    [Limit (0,3048576),Desc("文件内容,必须base64编码")]
    byte[] fileContent;
}
[Desc( "下载报表文件" )]
class SC_ReportFile_Download_Failure
{
    SC_ReportFile_Download_Failure_Type type;
}

[Desc( "删除报表文件" )]
enum SC_ReportFile_Delete_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "删除报表文件" )]
class SC_ReportFile_Delete_Success
{
}
[Desc( "删除报表文件" )]
class SC_ReportFile_Delete_Failure
{
    SC_ReportFile_Delete_Failure_Type type;
}


[Desc( "获取某会计未完成订单列表(web版)" )]
enum SC_GetAccountantUncompletedOrderList_web_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "获取某会计未完成订单列表(web版)" )]
class SC_GetAccountantUncompletedOrderList_web_Success
{
    List<SC_GetAccountantUncompletedOrderList_web_Data> data;
}
[Desc( "获取某会计未完成订单列表(web版)" )]
class SC_GetAccountantUncompletedOrderList_web_file_info
{
    int file_id;
    string file_name;
}
[Desc( "获取某会计未完成订单列表(web版)" )]
class SC_GetAccountantUncompletedOrderList_web_Data
{
    [Limit( 0, 50 ), Desc( "订单id" )]
    string orderID;
    [Desc("公司ID")]
    int customerID;
    [Limit( 0, 50 ), Desc( "公司名字" )]
    string companyName;

    [Desc( "订单创建时间" )]
    DateTime orderDate;

    [Desc( "订单开始时间" )]
    DateTime orderStartDate;

    [Desc( "订单状态" )]
    int stateCode;

    [Desc( "订单价格" )]
    double total;

    [Desc( "用户看的见得订单号" )]
    string iDView;

    [Desc( "订单自增号" )]
    int number;
 
    [Desc("文件信息列表")]
    public List<SC_GetAccountantUncompletedOrderList_web_file_info> file_info_list;
}
[Desc( "获取某会计未完成订单列表(web版)" )]
class SC_GetAccountantUncompletedOrderList_web_Failure
{
    SC_GetAccountantUncompletedOrderList_web_Failure_Type type;
}


[Desc( "获取会计电子名片" )]
enum SC_AccountantElectronicBusinessCard_Get_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该会计" )]
    NotFindAccountant,
}

[Desc( "获取会计电子名片" )]
class SC_AccountantElectronicBusinessCard_Get_Success
{
    [Desc("完成订单数")]
    int completedOrder;
    [Limit (0,90),Desc("会计名字")]
    string name;
    [Desc("会计排名")]
    int rank;
}

[Desc( "获取会计电子名片" )]
class SC_AccountantElectronicBusinessCard_Get_Failure
{
    SC_AccountantElectronicBusinessCard_Get_Failure_Type type;
}

//通信层错误
[Desc( "通信错误" )]
enum SC_Communication_Failure_Type
{
    [Desc( "序列化错误" )]
    SerializeError,
}
[Desc( "通信错误" )]
class SC_Communication_Failure
{
    SC_Communication_Failure_Type type;
}



[Desc( "下载会计图片" )]
enum SC_AccountanPictureDown_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "下载会计图片" )]
class SC_AccountanPictureDown_Success_Data
{
    [Limit (0,3048576),Desc("图片内容")]
    byte[] fileContent;
    [Limit(0,150),Desc("图片类型的名称")]
    string picName;
}


[Desc( "下载会计图片" )]
class SC_AccountanPictureDown_Success
{
    List<SC_AccountanPictureDown_Success_Data> data;
}

[Desc( "下载会计图片" )]
class SC_AccountanPictureDown_Failure
{
    SC_AccountanPictureDown_Failure_Type type;
}




[Desc( "公司查询月度报表" )]
enum SC_FindReportCustom_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该报表" )]
    NotFindOrder,
}
[Desc( "公司查询月度报表" )]
class SC_FindReportCustom_Success_Data
{
    [Limit(0,150),Desc("产品名称")]
    string productName;
    [Limit(0,150),Desc("产品名称")]
    string customerName;
    [Desc("订单编号")]
    double national_tax_total;
    [Desc("订单编号")]
    double land_tax_total;
    [Desc("订单编号")]
    double non_tax_income_total;
    [Limit (0,900),Desc("订单编号")]
    string national_tax;
    [Limit (0,11500),Desc("订单编号")]
    string land_tax;
}
[Desc( "公司查询月度报表" )]
class SC_FindReportCustom_Success
{
    List<SC_FindReportCustom_Success_Data>  data;
}
[Desc( "公司查询月度报表" )]
class SC_FindReportCustom_Failure
{
    SC_FindReportCustom_Failure_Type type;
}


[Desc( "公司上传电子财务信息" )]
enum SC_Customer_UploadElectronicBill_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "不存在该客户" )]
    NotFindOrder,
}
[Desc( "公司上传电子财务信息" )]
class SC_Customer_UploadElectronicBill_Success
{
}
[Desc( "公司上传电子财务信息" )]
class SC_Customer_UploadElectronicBill_Failure
{
    SC_Customer_UploadElectronicBill_Failure_Type type;
}


[Desc( "获得公司电子财务信息" )]
enum SC_GetElectronicBill_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "不存在该客户" )]
    NotFindOrder,
}
[Desc( "获得公司电子财务信息" )]
class SC_GetElectronicBill_Success_Data
{
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
}
[Desc( "获得公司电子财务信息" )]
class SC_GetElectronicBill_Success
{
    List<SC_GetElectronicBill_Success_Data> data;
}
[Desc( "获得公司电子财务信息" )]
class SC_GetElectronicBill_Failure
{
    SC_GetElectronicBill_Failure_Type type;
}



[Desc( "公司查询所有订单的进度" )]
enum SC_CustomerGetOrderState_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "公司查询所有订单的进度" )]
class SC_CustomerGetOrderState_Success_Data
{
    [Desc("下哪个月单时间")]
    DateTime startTime;
    [Limit(0,150),Desc("订单IdView编号")]
    string idView;
    [Desc("订单状态")]
    int stateCode;
}

[Desc( "公司查询所有订单的进度" )]
class SC_CustomerGetOrderState_Success
{
   List<SC_CustomerGetOrderState_Success_Data> data;
}

[Desc( "公司查询所有订单的进度" )]
class SC_CustomerGetOrderState_Failure
{
    SC_CustomerGetOrderState_Failure_Type type;
}



[Desc( "上传年度报表文件" )]
enum SC_ReportFile_Upload_Year_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "上传年度报表文件" )]
class SC_ReportFile_Upload_Year_Success
{

}
[Desc( "上传年度报表文件" )]
class SC_ReportFile_Upload_Year_Failure
{
    SC_ReportFile_Upload_Year_Failure_Type type;
}



[Desc( "上传季度报表文件" )]
enum SC_ReportFile_Upload_Quarter_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "上传季度报表文件" )]
class SC_ReportFile_Upload_Quarter_Success
{

}
[Desc( "上传季度报表文件" )]
class SC_ReportFile_Upload_Quarter_Failure
{
    SC_ReportFile_Upload_Quarter_Failure_Type type;
}



[Desc( "上传月度报表文件" )]
enum SC_ReportFile_Upload_Month_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该订单" )]
    NotFindOrder,
}
[Desc( "上传月度报表文件" )]
class SC_ReportFile_Upload_Month_Success
{

}
[Desc( "上传月度报表文件" )]
class SC_ReportFile_Upload_Month_Failure
{
    SC_ReportFile_Upload_Month_Failure_Type type;
}


[Desc( "下载年度报表文件" )]
enum SC_ReportFile_Download_Year_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该年的报表" )]
    NotFindReport,
}
[Desc( "下载年度报表文件" )]
class SC_ReportFile_Download_Year_Success
{
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
}
[Desc( "下载年度报表文件" )]
class SC_ReportFile_Download_Year_Failure
{
    SC_ReportFile_Download_Year_Failure_Type type;
}



[Desc( "下载季度报表文件" )]
enum SC_ReportFile_Download_Quarter_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该季度的报表" )]
    NotFindReport,
}
[Desc( "下载季度报表文件" )]
class SC_ReportFile_Download_Quarter_Success
{
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
}
[Desc( "下载季度报表文件" )]
class SC_ReportFile_Download_Quarter_Failure
{
    SC_ReportFile_Download_Quarter_Failure_Type type;
}




[Desc( "下载月度报表文件" )]
enum SC_ReportFile_Download_Month_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该月的报表" )]
    NotFindReport,
}
[Desc( "下载月度报表文件" )]
class SC_ReportFile_Download_Month_Success
{
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
}
[Desc( "下载月度报表文件" )]
class SC_ReportFile_Download_Month_Failure
{
    SC_ReportFile_Download_Month_Failure_Type type;
}



[Desc( "下载报表文件列表(订单流程内使用)" )]
enum SC_ReportFileList_Download_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "下载报表文件列表(订单流程内使用)" )]
enum SC_ReportFileList_Download_Success_Data_Type
{
    [Desc( "月报表" )]
    Month,
    [Desc( "季度报表" )]
    Quarter,
    [Desc("年报表")]
    Year,
}
[Desc( "下载报表文件列表(订单流程内使用)" )]
class SC_ReportFileList_Download_Success_Data
{
    SC_ReportFileList_Download_Success_Data_Type dataType;
    int number;
}

[ Desc( "下载报表文件列表(订单流程内使用)" )]
class SC_ReportFileList_Download_Success
{
    List<SC_ReportFileList_Download_Success_Data> data;
}
[Desc( "下载报表文件列表(订单流程内使用)" )]
class SC_ReportFileList_Download_Failure
{
    SC_ReportFileList_Download_Failure_Type type;
}



[Desc( "下载报表文件(订单流程内使用)" )]
enum SC_ReportFileOrder_Download_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc("没有找到该文件")]
    NotFindFile,
}
[Desc( "下载报表文件(订单流程内使用)" )]
class SC_ReportFileOrder_Download_Success
{
    [Limit (0,150),Desc("图片名称")]
    string fileName;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
    [Desc( "报表类型1->年度报表,2->季度报表,3->月度报表" )]
    int fileType;
}
[Desc( "下载报表文件(订单流程内使用)" )]
class SC_ReportFileOrder_Download_Failure
{
    SC_ReportFileOrder_Download_Failure_Type type;
}


[Desc( "地图点击获得会计详细信息" )]
enum SC_CheckAccountantInformation_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有找到该会计" )]
    NotFindAccountant,
}
[Desc( "地图点击获得会计详细信息" )]
class SC_CheckAccountantInformation_Success_Data
{
    [Limit (0,150),Desc("证书名称")]
    string credentialName;
    [Desc("证书是否经过认证")]
    bool isAuth;
}
[Desc( "地图点击获得会计详细信息" )]
class SC_CheckAccountantInformation_Success
{
    [Limit (0,150),Desc("姓名")]
    string name;
    [Limit(0,10),Desc("性别")]
    string gender;
    [Limit(0,150),Desc("用户认证")]
    string accountantAuth;
    [Limit(0,3000),Desc("个人简介")]
    string introduction;
    [Desc("服务次数")]
    int completeCount;
    [Desc("好评度")]
    double grade;
    [Desc("擅长领域")]
    List<int> industryID;
    [Desc("专业证书")]
    List<SC_CheckAccountantInformation_Success_Data> data;
}
[Desc( "地图点击获得会计详细信息" )]
class SC_CheckAccountantInformation_Failure
{
    SC_CheckAccountantInformation_Failure_Type type;
}



[Desc( "通过报表文件ID查看文件" )]
enum SC_CheckReportFileFromID_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有找到该报表文件" )]
    NotFindReportFile,
}

[Desc( "通过报表文件ID查看文件" )]
class SC_CheckReportFileFromID_Success
{
    [Limit (0,2000),Desc("url地址")]
    string name;
}
[Desc( "通过报表文件ID查看文件" )]
class SC_CheckReportFileFromID_Failure
{
    SC_CheckReportFileFromID_Failure_Type type;
}



[Desc( "查看年度报表文件" )]
enum SC_ReportFile_Find_Year_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该年的报表" )]
    NotFindReport,
}
[Desc( "查看年度报表文件" )]
class SC_ReportFile_Find_Year_Success
{
    [Desc("报表文件id")]
    int fileID;
}
[Desc( "查看年度报表文件" )]
class SC_ReportFile_Find_Year_Failure
{
    SC_ReportFile_Find_Year_Failure_Type type;
}



[Desc( "查看季度报表文件" )]
enum SC_ReportFile_Find_Quarter_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该季度的报表" )]
    NotFindReport,
}
[Desc( "查看季度报表文件" )]
class SC_ReportFile_Find_Quarter_Success
{
    [Desc("报表文件id")]
    int fileID;
}
[Desc( "查看季度报表文件" )]
class SC_ReportFile_Find_Quarter_Failure
{
    SC_ReportFile_Find_Quarter_Failure_Type type;
}




[Desc( "查看月度报表文件" )]
enum SC_ReportFile_Find_Month_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "未找到该月的报表" )]
    NotFindReport,
}
[Desc( "查看月度报表文件" )]
class SC_ReportFile_Find_Month_Success
{
    [Desc("报表文件id")]
    int fileID;
}
[Desc( "查看月度报表文件" )]
class SC_ReportFile_Find_Month_Failure
{
    SC_ReportFile_Find_Month_Failure_Type type;
}




[Desc( "交易过的会计列表" )]
enum SC_DealAccountantList_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "交易过的会计列表" )]
class SC_DealAccountantList_Success
{
    List<SC_DealAccountantList_Data> data;
}
[Desc( "交易过的会计列表" )]
class SC_DealAccountantList_Data
{
    [Desc("编号")]
    int id;
    [Limit (0,90),Desc("名字")]
    string name;
    [Limit (0,60),Desc("电话号码")]
    string phone;
    [Limit (0,900),Desc("头像")]
    string headShot;
    [Desc("完成订单数量")]
    int completedorder;
    [Limit (0,1150),Desc("行业")]
    string industry;
    [Limit (0,1150),Desc("产品名称")]
    string productname;
    [Desc("产品ID")]
    int productID;
    [Desc("价格")]
    double price;
}
[Desc( "交易过的会计列表" )]
class SC_DealAccountantList_Failure
{
    SC_DealAccountantList_Failure_Type type;
}




[Desc( "修改会计个人资料" )]
enum SC_ChangeAccountantInformation_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "有未完成的订单是所有信息都不能修改" )]
    NotChangeEverything,
    [Desc("没有这个用户")]
    NotFindAcountant,
    [Desc("正在审核或者审核通过后不能再修改身份证号码和会计从业证号码")]
    NotChangeNum,
}
[Desc( "修改会计个人资料" )]
class SC_ChangeAccountantInformation_Success
{

}
[Desc( "修改会计个人资料" )]
class SC_ChangeAccountantInformation_Failure
{
    SC_ChangeAccountantInformation_Failure_Type type;
}

[Desc( "会计点击修改，获得自己的数据" )]
enum SC_ReturnAccountantInformation_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有这个用户" )]
    NotFindAcountant,
}
[Desc( "会计点击修改，获得自己的数据" )]
class SC_ReturnAccountantInformation_Success
{
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
    [Limit(0,150),Desc("状态")]
    string state;
}
[Desc( "会计点击修改，获得自己的数据" )]
class SC_ReturnAccountantInformation_Failure
{
    SC_ReturnAccountantInformation_Failure_Type type;
}



enum SC_AccountantHomePage_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有这个用户" )]
    NotFindAcountant,
}

[Desc( "会计首页" )]
class SC_AccountantHomePage_Success
{
    [Limit(0,60),Desc("姓名")]
    string name;
    [Limit(0,3),Desc("性别")]
    string gender;
    [Desc("今日订单")]
    int todayOrderNum;
    [Desc("今日浏览量")]
    int todayPageView;
    [Limit (0,3048576),Desc("会计头像")]
    byte[] fileContent;
}
[Desc( "会计首页" )]
class SC_AccountantHomePage_Failure
{
    SC_AccountantHomePage_Failure_Type type;
}



[Desc( "公司匿名登录" )]
enum SC_CustomerAnonymous_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "公司匿名登录" )]
class SC_CustomerAnonymous_Success
{
    [Limit (0,150),Desc("令牌")]
    string token;
    [Desc("公司ID")]
    int id;
}
[Desc( "公司匿名登录" )]
class SC_CustomerAnonymous_Failure
{
    SC_CustomerAnonymous_Failure_Type type;
}

[Desc("验证服务器失败")]
enum SC_Anonymous_Failure_Type
{
    [Desc( "验证服务器失败" )]
    Failure,
}

[Desc("验证服务器失败")]
class SC_Anonymous_Failure
{
    SC_Anonymous_Failure_Type type;
}



[Desc( "查看会计证件照片" )]
enum SC_FindAccountantCredentials_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "查看会计证件照片" )]
class SC_FindAccountantCredentials_Success_Data
{
    [Limit(0,800),Desc("文件名")]
    string fileName;
    [Desc("文件类型")]
    int fileType;
    [Limit (0,3048576),Desc("内容")]
    byte[] fileContent;
}
[Desc( "查看会计证件照片" )]
class SC_FindAccountantCredentials_Success
{
    List<SC_FindAccountantCredentials_Success_Data> data;
}
[Desc( "查看会计证件照片" )]
class SC_FindAccountantCredentials_Failure
{
    SC_FindAccountantCredentials_Failure_Type type;
}


[Desc( "会计查看交易过的公司" )]
enum SC_AccountantFindCustomer_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "会计查看交易过的公司" )]
class SC_AccountantFindCustomer_Success_Data
{
    [Limit(0,150),Desc("公司名称")]
    string customerName;
    [Limit(0,150),Desc("纳税资质")]
    string taxQualification;
    [Desc("公司ID")]
    int customerID;
}
[Desc( "会计查看交易过的公司" )]
class SC_AccountantFindCustomer_Success
{
    List<SC_AccountantFindCustomer_Success_Data> data;
}
[Desc( "会计查看交易过的公司" )]
class SC_AccountantFindCustomer_Failure
{
    SC_AccountantFindCustomer_Failure_Type type;
}


[Desc( "会计查看交易过的某个公司明细" )]
enum SC_AcountantFindCustomerDetail_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc("未找到该订单")]
    NotFindOrder,
    [Desc("未找到改公司")]
    NotFindCustomer
}
[Desc( "会计查看交易过的某个公司明细" )]
class SC_AcountantFindCustomerDetail_Success
{
    [Limit(0,150),Desc("公司名称")]
    string customerName;
    [Limit(0,300),Desc("公司地址")]
    string customerAddress;
    [Limit(0,150),Desc("公司类型")]
    string customerType;
    [Limit(0,150),Desc("公司邮件地址")]
    string customerEmail;
    [Limit(0,150),Desc("公司纳税资质")]
    string customerQualification;
    [Desc("合作次数")]
    int count;
}
[Desc( "会计查看交易过的某个公司明细" )]
class SC_AcountantFindCustomerDetail_Failure
{
    SC_AcountantFindCustomerDetail_Failure_Type type;
}


[Desc( "更换头像" )]
enum SC_UserChangeIcon_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
}
[Desc( "会计更换头像" )]
class SC_UserChangeIcon_Success
{
  
}
[Desc( "更换头像" )]
class SC_UserChangeIcon_Failure
{
    SC_UserChangeIcon_Failure_Type type;
}


enum SC_CustomerHomePage_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有这个公司" )]
    NotFindCustomer,
}

[Desc( "公司主页" )]
class SC_CustomerHomePage_Success
{
    [Limit(0,150),Desc("公司名称")]
    string customerName;
    [Limit (0,3048576),Desc("公司头像")]
    byte[] fileContent;
}
[Desc( "公司主页" )]
class SC_CustomerHomePage_Failure
{
    SC_CustomerHomePage_Failure_Type type;
}

[Desc( "查看推送消息" )]
enum SC_FindPushMessage_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有这个客户" )]
    NotFindID,
}
[Desc( "查看推送消息" )]
class SC_FindPushMessage_Success_Data
{
    [Limit(0,150),Desc("推送内容")]
    string pushHint;
    [Desc("公司地址")]
    DateTime pushTime;
}
[Desc( "查看推送消息" )]
class SC_FindPushMessage_Success
{
    List<SC_FindPushMessage_Success_Data> data;
}
[Desc( "查看推送消息" )]
class SC_FindPushMessage_Failure
{
    SC_FindPushMessage_Failure_Type type;
}



[Desc( "会计查看文档" )]
enum SC_AccountantFindDocment_Failure_Type
{
    [Desc( "参数错误" )]
    ParamError,
    [Desc( "业务逻辑执行失败" )]
    BusinessLogicExcuteFailed,
    [Desc( "没有这个会计" )]
    NotFindAccountant,
}
[Desc( "会计查看文档" )]
class SC_AccountantFindDocment_Success_Data
{
    [Limit(0,300),Desc("公司名称")]
    string customerName;
    [Desc("报表类型")]
    int typeId;
    [Desc("年")]
    int year;
    [Desc("季度")]
    int quarter;
    [Desc("月")]
    int month;
    [Desc("文件ID")]
    int fileId;
}
[Desc( "会计查看文档" )]
class SC_AccountantFindDocment_Success
{
    List<SC_AccountantFindDocment_Success_Data> data;
}
[Desc("会计查看文档")]
class SC_AccountantFindDocment_Failure
{
    SC_AccountantFindDocment_Failure_Type type;
}
