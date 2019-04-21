
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// enums
namespace SCPkgTypes
{
    // 会计注册
    public enum  SC_Accountant_Register_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 用户名已经存在
        /// </summary> 
        UserNameExist = 2, 
    };
    // 用户名检测
    public enum  SC_Account_Register_IsExists_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 用户名已经存在
        /// </summary> 
        UserNameExist = 2, 
    };
    // 会计登陆
    public enum  SC_Account_Login_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 用户名不存在
        /// </summary> 
        UserNameExist = 2, 
        /// <summary>
        /// 密码错误
        /// </summary> 
        PasswordError = 3, 
        /// <summary>
        /// 账号被锁定
        /// </summary> 
        AccountNumberlLocked = 4, 
    };
    // 会计获取本人受理业务
    public enum  SC_Account_GetProduct_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
    };
    // 会计更新或添加个人受理业务
    public enum  SC_Product_Manage_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
    };
    // 获取会计主页个人信息
    public enum  SC_Account_GetDetails_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 未查找到
        /// </summary> 
        NotFound = 2, 
    };
    // 公司注册
    public enum  SC_Customer_Register_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 用户名已经存在
        /// </summary> 
        UserNameExist = 2, 
    };
    // 公司注册用户名检测
    public enum  SC_Customer_Register_IsExists_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 用户名已存在
        /// </summary> 
        UserNameExist = 2, 
    };
    // 获取全部行业分类
    public enum  SC_Industry_AllSector_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
    };
    // 公司登陆
    public enum  SC_Customer_Login_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 用户名或密码错误
        /// </summary> 
        UsernameOrPasswordError = 2, 
        /// <summary>
        /// 账号被锁定
        /// </summary> 
        AccountNumberLocked = 3, 
    };
    // 查询附近会计
    public enum  SC_Acctountant_GetAround_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
    };
    // 创建订单
    public enum  SC_Order_Create_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 不能在未完成之前对当前会计重复下单
        /// </summary> 
        AccountantRepeat = 2, 
        /// <summary>
        /// 当前时间已经有会计做过账
        /// </summary> 
        AcounttanOver = 3, 
    };
    // 查询全部快递服务
    public enum  SC_Express_GetAll_Failure_Type : int
    {
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 0, 
    };
    // 查询未完成订单列表
    public enum  SC_UncompletedOrder_GetList_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
    };
    // 查询订单明细
    public enum  SC_Order_GetDetails_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
    };
    // 会计修改订单价格
    public enum  SC_Order_UpdateTotal_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 数据库执行错误
        /// </summary> 
        ExecuteError = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 客户确认订单
    public enum  SC_Customer_Order_Confirm_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 获取支付平台列表
    public enum  SC_Get_Payment_Platform_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 客户寄送资料
    public enum  SC_Customer_Deliver_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 会计接收资料确认
    public enum  SC_Accountant_Receipt_Confirm_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 会计填写报表
    public enum  SC_Accountant_Create_Report_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 查询月度报表
    public enum  SC_Get_Report_Month_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 查询季度报表
    public enum  SC_Get_Report_Quarter_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 客户对报表审核
    public enum  SC_Customer_Report_Confirm_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 会计返还资料
    public enum  SC_Accountant_Send_Back_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 客户接收确认，订单完成
    public enum  SC_Customer_Order_Recive_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 客户退回订单至会计定价
    public enum  SC_Customer_Order_Back_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 会计取消订单
    public enum  SC_Accountant_Cancel_Order_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 客户取消订单
    public enum  SC_Customer_Cancel_Order_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 获取会计列表
    public enum  SC_Accountant_GetList_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 查询已完成订单列表
    public enum  SC_CompeletedOrder_GetList_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 客户对会计服务评分
    public enum  SC_Grade_AccountantService_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 会计上传证件照片
    public enum  SC_AccountantCredentials_Upload_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 不存在该会计
        /// </summary> 
        NotFindAccountant = 2, 
    };
    // 银联支付获取交易流水号
    public enum  SC_UnionPayTn_Get_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 会计上传报表文件
    public enum  SC_ReportFile_Upload_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 下载报表文件
    public enum  SC_ReportFile_Download_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该文件
        /// </summary> 
        NotFindFile = 2, 
    };
    // 删除报表文件
    public enum  SC_ReportFile_Delete_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 获取某会计未完成订单列表(web版)
    public enum  SC_GetAccountantUncompletedOrderList_web_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 获取会计电子名片
    public enum  SC_AccountantElectronicBusinessCard_Get_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该会计
        /// </summary> 
        NotFindAccountant = 2, 
    };
    // 通信错误
    public enum  SC_Communication_Failure_Type : int
    {
        /// <summary>
        /// 序列化错误
        /// </summary> 
        SerializeError = 0, 
    };
    // 下载会计图片
    public enum  SC_AccountanPictureDown_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 公司查询月度报表
    public enum  SC_FindReportCustom_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该报表
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 公司上传电子财务信息
    public enum  SC_Customer_UploadElectronicBill_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 不存在该客户
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 获得公司电子财务信息
    public enum  SC_GetElectronicBill_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 不存在该客户
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 公司查询所有订单的进度
    public enum  SC_CustomerGetOrderState_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 上传年度报表文件
    public enum  SC_ReportFile_Upload_Year_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 上传季度报表文件
    public enum  SC_ReportFile_Upload_Quarter_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 上传月度报表文件
    public enum  SC_ReportFile_Upload_Month_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
    };
    // 下载年度报表文件
    public enum  SC_ReportFile_Download_Year_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该年的报表
        /// </summary> 
        NotFindReport = 2, 
    };
    // 下载季度报表文件
    public enum  SC_ReportFile_Download_Quarter_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该季度的报表
        /// </summary> 
        NotFindReport = 2, 
    };
    // 下载月度报表文件
    public enum  SC_ReportFile_Download_Month_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该月的报表
        /// </summary> 
        NotFindReport = 2, 
    };
    // 下载报表文件列表(订单流程内使用)
    public enum  SC_ReportFileList_Download_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 下载报表文件列表(订单流程内使用)
    public enum  SC_ReportFileList_Download_Success_Data_Type : int
    {
        /// <summary>
        /// 月报表
        /// </summary> 
        Month = 0, 
        /// <summary>
        /// 季度报表
        /// </summary> 
        Quarter = 1, 
        /// <summary>
        /// 年报表
        /// </summary> 
        Year = 2, 
    };
    // 下载报表文件(订单流程内使用)
    public enum  SC_ReportFileOrder_Download_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有找到该文件
        /// </summary> 
        NotFindFile = 2, 
    };
    // 地图点击获得会计详细信息
    public enum  SC_CheckAccountantInformation_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有找到该会计
        /// </summary> 
        NotFindAccountant = 2, 
    };
    // 通过报表文件ID查看文件
    public enum  SC_CheckReportFileFromID_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有找到该报表文件
        /// </summary> 
        NotFindReportFile = 2, 
    };
    // 查看年度报表文件
    public enum  SC_ReportFile_Find_Year_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该年的报表
        /// </summary> 
        NotFindReport = 2, 
    };
    // 查看季度报表文件
    public enum  SC_ReportFile_Find_Quarter_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该季度的报表
        /// </summary> 
        NotFindReport = 2, 
    };
    // 查看月度报表文件
    public enum  SC_ReportFile_Find_Month_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该月的报表
        /// </summary> 
        NotFindReport = 2, 
    };
    // 交易过的会计列表
    public enum  SC_DealAccountantList_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 修改会计个人资料
    public enum  SC_ChangeAccountantInformation_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 有未完成的订单是所有信息都不能修改
        /// </summary> 
        NotChangeEverything = 2, 
        /// <summary>
        /// 没有这个用户
        /// </summary> 
        NotFindAcountant = 3, 
        /// <summary>
        /// 正在审核或者审核通过后不能再修改身份证号码和会计从业证号码
        /// </summary> 
        NotChangeNum = 4, 
    };
    // 会计点击修改，获得自己的数据
    public enum  SC_ReturnAccountantInformation_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有这个用户
        /// </summary> 
        NotFindAcountant = 2, 
    };
    public enum  SC_AccountantHomePage_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有这个用户
        /// </summary> 
        NotFindAcountant = 2, 
    };
    // 公司匿名登录
    public enum  SC_CustomerAnonymous_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 验证服务器失败
    public enum  SC_Anonymous_Failure_Type : int
    {
        /// <summary>
        /// 验证服务器失败
        /// </summary> 
        Failure = 0, 
    };
    // 查看会计证件照片
    public enum  SC_FindAccountantCredentials_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 会计查看交易过的公司
    public enum  SC_AccountantFindCustomer_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    // 会计查看交易过的某个公司明细
    public enum  SC_AcountantFindCustomerDetail_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 未找到该订单
        /// </summary> 
        NotFindOrder = 2, 
        /// <summary>
        /// 未找到改公司
        /// </summary> 
        NotFindCustomer = 3, 
    };
    // 更换头像
    public enum  SC_UserChangeIcon_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
    };
    public enum  SC_CustomerHomePage_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有这个公司
        /// </summary> 
        NotFindCustomer = 2, 
    };
    // 查看推送消息
    public enum  SC_FindPushMessage_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有这个客户
        /// </summary> 
        NotFindID = 2, 
    };
    // 会计查看文档
    public enum  SC_AccountantFindDocment_Failure_Type : int
    {
        /// <summary>
        /// 参数错误
        /// </summary> 
        ParamError = 0, 
        /// <summary>
        /// 业务逻辑执行失败
        /// </summary> 
        BusinessLogicExcuteFailed = 1, 
        /// <summary>
        /// 没有这个会计
        /// </summary> 
        NotFindAccountant = 2, 
    };
}

// struct declares
namespace SCPkgTypes
{
    // 会计注册成功
    public class SC_Accountant_Register_Success : IBBWriter, IBBReader 
    {
        /*
         * 会计用户编号
        */
        public int id;
        /*
         * 用户的名字
        */
        public string name = "";
        /*
         * 头像的地址
        */
        public string headIcon = "";
        public const short commandType = 1; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name );
            bb.Write( headIcon ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,90 );
             headIcon = bb.ReadString( 0,600 );
        }

    };
    // 会计注册失败
    public class SC_Accountant_Register_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Accountant_Register_Failure_Type type;
        public const short commandType = 2; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Accountant_Register_Failure_Type) bb.ReadInt();
        }

    };
    // 用户名检测
    public class SC_Account_Register_IsExists_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 3; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 用户名检测
    public class SC_Account_Register_IsExists_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Account_Register_IsExists_Failure_Type type;
        public const short commandType = 4; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Account_Register_IsExists_Failure_Type) bb.ReadInt();
        }

    };
    // 会计登陆
    public class SC_Account_Login_Success : IBBWriter, IBBReader 
    {
        /*
         * 会计用户编号
        */
        public int id;
        /*
         * 用户的名字
        */
        public string name = "";
        /*
         * 头像的地址
        */
        public string headIcon = "";
        public const short commandType = 5; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name );
            bb.Write( headIcon ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,90 );
             headIcon = bb.ReadString( 0,600 );
        }

    };
    // 会计登陆
    public class SC_Account_Login_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Account_Login_Failure_Type type;
        public const short commandType = 6; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Account_Login_Failure_Type) bb.ReadInt();
        }

    };
    // 会计获取本人受理业务
    public class SC_Account_GetProduct_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_Account_GetProduct_Product> products = new List<SCPkgTypes.SC_Account_GetProduct_Product>();
        public List<SCPkgTypes.SC_Account_GetProduct_Industry> industrys = new List<SCPkgTypes.SC_Account_GetProduct_Industry>();
        public const short commandType = 7; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( products );
            bb.Write( industrys ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             products = bb.ReadListObject<SCPkgTypes.SC_Account_GetProduct_Product>( 0,0 );
             industrys = bb.ReadListObject<SCPkgTypes.SC_Account_GetProduct_Industry>( 0,0 );
        }

    };
    // 会计获取本人受理业务
    public class SC_Account_GetProduct_Product : IBBWriter, IBBReader 
    {
        /*
         * 产品ID
        */
        public int productID;
        /*
         * 产品名称
        */
        public string productname = "";
        /*
         * 用户ID
        */
        public int accountantID;
        /*
         * 创建时间
        */
        public DateTime createtime = new DateTime(1991,1,1,0,0,0);
        /*
         * 价格
        */
        public double price;
        /*
         * 擅长领域的ID集合
        */
        public List<int> industryID = new List<int>();
        public string description = "";
        public const short commandType = 8; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( productID );
            bb.Write( productname );
            bb.Write( accountantID );
            bb.Write( createtime );
            bb.Write( price );
            bb.Write( industryID );
            bb.Write( description ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             productID = bb.ReadInt();
             productname = bb.ReadString( 0,1150 );
             accountantID = bb.ReadInt();
             createtime = bb.ReadDate();
             price = bb.ReadDouble();
             industryID = bb.ReadListInt( 0,0 );
             description = bb.ReadString( 0,600 );
        }

    };
    // 会计获取本人受理业务
    public class SC_Account_GetProduct_Industry : IBBWriter, IBBReader 
    {
        /*
         * 行业编号
        */
        public int id;
        /*
         * 行业名称
        */
        public string name = "";
        public const short commandType = 9; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,1150 );
        }

    };
    // 会计获取本人受理业务
    public class SC_Account_GetProduct_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Account_GetProduct_Failure_Type type;
        public const short commandType = 10; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Account_GetProduct_Failure_Type) bb.ReadInt();
        }

    };
    // 会计更新或添加个人受理业务
    public class SC_Product_Manage_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 11; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 会计更新或添加个人受理业务
    public class SC_Product_Manage_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Product_Manage_Failure_Type type;
        public const short commandType = 12; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Product_Manage_Failure_Type) bb.ReadInt();
        }

    };
    // 获取会计主页个人信息
    public class SC_Account_GetDetails_ProductId : IBBWriter, IBBReader 
    {
        /*
         * 产品ID
        */
        public int productId;
        /*
         * 产品名称
        */
        public string productName = "";
        /*
         * 产品价格
        */
        public double price;
        /*
         * 行业
        */
        public string idustry = "";
        public const short commandType = 13; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( productId );
            bb.Write( productName );
            bb.Write( price );
            bb.Write( idustry ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             productId = bb.ReadInt();
             productName = bb.ReadString( 0,1150 );
             price = bb.ReadDouble();
             idustry = bb.ReadString( 0,900 );
        }

    };
    // 获取会计主页个人信息
    public class SC_Account_GetDetails_Success : IBBWriter, IBBReader 
    {
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
         * 会计审核状态
        */
        public string state = "";
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
         * 头像地址
        */
        public string headShot = "";
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
        public SCPkgTypes.SC_Account_GetDetails_ProductId product = new SCPkgTypes.SC_Account_GetDetails_ProductId();
        public const short commandType = 14; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( nickName );
            bb.Write( idNumber );
            bb.Write( certificateNum );
            bb.Write( state );
            bb.Write( name );
            bb.Write( acceptanceAddress );
            bb.Write( businessAddress );
            bb.Write( phone );
            bb.Write( gender );
            bb.Write( email );
            bb.Write( headShot );
            bb.Write( longitude );
            bb.Write( latitude );
            bb.Write( selfIntroduction );
            bb.Write( product ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             nickName = bb.ReadString( 0,0 );
             idNumber = bb.ReadString( 0,0 );
             certificateNum = bb.ReadString( 0,0 );
             state = bb.ReadString( 0,0 );
             name = bb.ReadString( 0,90 );
             acceptanceAddress = bb.ReadString( 0,900 );
             businessAddress = bb.ReadString( 0,900 );
             phone = bb.ReadString( 0,60 );
             gender = bb.ReadString( 0,3 );
             email = bb.ReadString( 0,1150 );
             headShot = bb.ReadString( 0,900 );
             longitude = bb.ReadDouble();
             latitude = bb.ReadDouble();
             selfIntroduction = bb.ReadString( 0,11500 );
             product = bb.Read<SCPkgTypes.SC_Account_GetDetails_ProductId>();
        }

    };
    // 获取会计主页个人信息
    public class SC_Account_GetDetails_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Account_GetDetails_Failure_Type type;
        public const short commandType = 15; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Account_GetDetails_Failure_Type) bb.ReadInt();
        }

    };
    // 公司注册
    public class SC_Customer_Register_Success : IBBWriter, IBBReader 
    {
        /*
         * 公司用户编号
        */
        public int id;
        public const short commandType = 16; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
        }

    };
    // 公司注册
    public class SC_Customer_Register_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Register_Failure_Type type;
        public const short commandType = 17; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Register_Failure_Type) bb.ReadInt();
        }

    };
    // 公司注册用户名检测
    public class SC_Customer_Register_IsExists_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 18; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 公司注册用户名检测
    public class SC_Customer_Register_IsExists_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Register_IsExists_Failure_Type type;
        public const short commandType = 19; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Register_IsExists_Failure_Type) bb.ReadInt();
        }

    };
    // 获取全部行业分类
    public class SC_Industry_AllSector_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_Industry_AllSector_Industry> industrys = new List<SCPkgTypes.SC_Industry_AllSector_Industry>();
        public const short commandType = 20; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( industrys ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             industrys = bb.ReadListObject<SCPkgTypes.SC_Industry_AllSector_Industry>( 0,0 );
        }

    };
    // 获取全部行业分类
    public class SC_Industry_AllSector_Industry : IBBWriter, IBBReader 
    {
        /*
         * 行业编号
        */
        public int id;
        /*
         * 行业名称
        */
        public string name = "";
        public const short commandType = 21; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,1150 );
        }

    };
    // 获取全部行业分类
    public class SC_Industry_AllSector_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Industry_AllSector_Failure_Type type;
        public const short commandType = 22; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Industry_AllSector_Failure_Type) bb.ReadInt();
        }

    };
    // 公司登陆
    public class SC_Customer_Login_Success : IBBWriter, IBBReader 
    {
        /*
         * 公司用户编号
        */
        public int id;
        /*
         * 公司名字
        */
        public string name = "";
        public const short commandType = 23; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,150 );
        }

    };
    // 公司登陆
    public class SC_Customer_Login_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Login_Failure_Type type;
        public const short commandType = 24; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Login_Failure_Type) bb.ReadInt();
        }

    };
    // 查询附近会计
    public class SC_Acctountant_GetAround_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_Acctountant_GetAround_Person> person = new List<SCPkgTypes.SC_Acctountant_GetAround_Person>();
        public const short commandType = 25; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( person ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             person = bb.ReadListObject<SCPkgTypes.SC_Acctountant_GetAround_Person>( 0,0 );
        }

    };
    // 查询附近会计
    public class SC_Acctountant_GetAround_Person : IBBWriter, IBBReader 
    {
        /*
         * 会计用户编号
        */
        public int id;
        /*
         * 会计名字
        */
        public string name = "";
        /*
         * 用户认证
        */
        public string accountantAuth = "";
        /*
         * 个人简介
        */
        public string introduction = "";
        /*
         * 服务次数
        */
        public int completeCount;
        /*
         * 好评度
        */
        public double grade;
        /*
         * 经度
        */
        public double longitude;
        /*
         * 纬度
        */
        public double latitude;
        public const short commandType = 26; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name );
            bb.Write( accountantAuth );
            bb.Write( introduction );
            bb.Write( completeCount );
            bb.Write( grade );
            bb.Write( longitude );
            bb.Write( latitude ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,90 );
             accountantAuth = bb.ReadString( 0,150 );
             introduction = bb.ReadString( 0,3000 );
             completeCount = bb.ReadInt();
             grade = bb.ReadDouble();
             longitude = bb.ReadDouble();
             latitude = bb.ReadDouble();
        }

    };
    // 查询附近会计
    public class SC_Acctountant_GetAround_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Acctountant_GetAround_Failure_Type type;
        public const short commandType = 27; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Acctountant_GetAround_Failure_Type) bb.ReadInt();
        }

    };
    // 创建订单
    public class SC_Order_Create_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 28; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 创建订单
    public class SC_Order_Create_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Order_Create_Failure_Type type;
        public const short commandType = 29; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Order_Create_Failure_Type) bb.ReadInt();
        }

    };
    // 查询全部快递服务
    public class SC_Express_GetAll_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_Express_GetAll_Date> person = new List<SCPkgTypes.SC_Express_GetAll_Date>();
        public const short commandType = 30; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( person ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             person = bb.ReadListObject<SCPkgTypes.SC_Express_GetAll_Date>( 0,0 );
        }

    };
    // 查询全部快递服务
    public class SC_Express_GetAll_Date : IBBWriter, IBBReader 
    {
        /*
         * 快递平台ID
        */
        public int productId;
        /*
         * 快递平台名称
        */
        public string productName = "";
        /*
         * 快递价格
        */
        public double price;
        public const short commandType = 31; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( productId );
            bb.Write( productName );
            bb.Write( price ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             productId = bb.ReadInt();
             productName = bb.ReadString( 0,1150 );
             price = bb.ReadDouble();
        }

    };
    // 查询全部快递服务
    public class SC_Express_GetAll_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Express_GetAll_Failure_Type type;
        public const short commandType = 32; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Express_GetAll_Failure_Type) bb.ReadInt();
        }

    };
    // 查询未完成订单列表
    public class SC_UncompletedOrder_GetList_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_UncompletedOrder_GetList_Data> data = new List<SCPkgTypes.SC_UncompletedOrder_GetList_Data>();
        public const short commandType = 33; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_UncompletedOrder_GetList_Data>( 0,0 );
        }

    };
    // 查询未完成订单列表
    public class SC_UncompletedOrder_GetList_Data : IBBWriter, IBBReader 
    {
        /*
         * 订单ID
        */
        public string orderId = "";
        /*
         * 公司名称
        */
        public string name = "";
        /*
         * 订单创建时间
        */
        public DateTime orderDate = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单当前状态
        */
        public int stateCode;
        /*
         * 订单价格
        */
        public double total;
        /*
         * 用户看见的订单ID号
        */
        public string idView = "";
        /*
         * 子订单SubOrder表自带的自增字段用于排序
        */
        public int number;
        public const short commandType = 34; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( orderId );
            bb.Write( name );
            bb.Write( orderDate );
            bb.Write( stateCode );
            bb.Write( total );
            bb.Write( idView );
            bb.Write( number ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             orderId = bb.ReadString( 0,1150 );
             name = bb.ReadString( 0,1150 );
             orderDate = bb.ReadDate();
             stateCode = bb.ReadInt();
             total = bb.ReadDouble();
             idView = bb.ReadString( 0,1150 );
             number = bb.ReadInt();
        }

    };
    // 查询未完成订单列表
    public class SC_UncompletedOrder_GetList_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_UncompletedOrder_GetList_Failure_Type type;
        public const short commandType = 35; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_UncompletedOrder_GetList_Failure_Type) bb.ReadInt();
        }

    };
    // 查询订单明细
    public class SC_Order_GetDetails_Success : IBBWriter, IBBReader 
    {
        /*
         * 订单编号
        */
        public string orderID = "";
        /*
         * 公司名称
        */
        public string companyName = "";
        /*
         * 公司所属行业
        */
        public string companyType = "";
        /*
         * 纳税资质
        */
        public string taxQualification = "";
        /*
         * 公司地址
        */
        public string companyAdress = "";
        /*
         * 公司联系人
        */
        public string contact = "";
        /*
         * 公司电话
        */
        public string customerPhone = "";
        /*
         * 会计姓名
        */
        public string accountantName = "";
        /*
         * 会计电话
        */
        public string accountantPhone = "";
        /*
         * 会计收件地址
        */
        public string accountantAdress = "";
        /*
         * 订单数量
        */
        public int count;
        /*
         * 订单金额
        */
        public double total;
        /*
         * 创建订单时间
        */
        public DateTime createTime = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单执行时间
        */
        public DateTime startTime = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单结束时间
        */
        public DateTime endTime = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单周期
        */
        public int cycle;
        /*
         * 状态码
        */
        public int stateCode;
        /*
         * 订单备注
        */
        public string remark = "";
        /*
         * 用于显示的字符串为某些字段的拼接
        */
        public string idView = "";
        /*
         * 产品列表
        */
        public string product = "";
        /*
         * 快递回执编号
        */
        public string expressNumber = "";
        /*
         * 快递客服电话
        */
        public string expressTel = "";
        public const short commandType = 36; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( orderID );
            bb.Write( companyName );
            bb.Write( companyType );
            bb.Write( taxQualification );
            bb.Write( companyAdress );
            bb.Write( contact );
            bb.Write( customerPhone );
            bb.Write( accountantName );
            bb.Write( accountantPhone );
            bb.Write( accountantAdress );
            bb.Write( count );
            bb.Write( total );
            bb.Write( createTime );
            bb.Write( startTime );
            bb.Write( endTime );
            bb.Write( cycle );
            bb.Write( stateCode );
            bb.Write( remark );
            bb.Write( idView );
            bb.Write( product );
            bb.Write( expressNumber );
            bb.Write( expressTel ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             orderID = bb.ReadString( 0,1150 );
             companyName = bb.ReadString( 0,1150 );
             companyType = bb.ReadString( 0,1150 );
             taxQualification = bb.ReadString( 0,1150 );
             companyAdress = bb.ReadString( 0,900 );
             contact = bb.ReadString( 0,90 );
             customerPhone = bb.ReadString( 0,60 );
             accountantName = bb.ReadString( 0,90 );
             accountantPhone = bb.ReadString( 0,60 );
             accountantAdress = bb.ReadString( 0,1150 );
             count = bb.ReadInt();
             total = bb.ReadDouble();
             createTime = bb.ReadDate();
             startTime = bb.ReadDate();
             endTime = bb.ReadDate();
             cycle = bb.ReadInt();
             stateCode = bb.ReadInt();
             remark = bb.ReadString( 0,600 );
             idView = bb.ReadString( 0,1150 );
             product = bb.ReadString( 0,1150 );
             expressNumber = bb.ReadString( 0,1150 );
             expressTel = bb.ReadString( 0,1150 );
        }

    };
    // 查询订单明细
    public class SC_Order_GetDetails_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Order_GetDetails_Failure_Type type;
        public const short commandType = 37; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Order_GetDetails_Failure_Type) bb.ReadInt();
        }

    };
    // 会计修改订单价格
    public class SC_Order_UpdateTotal_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 38; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 会计修改订单价格
    public class SC_Order_UpdateTotal_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Order_UpdateTotal_Failure_Type type;
        public const short commandType = 39; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Order_UpdateTotal_Failure_Type) bb.ReadInt();
        }

    };
    // 客户确认订单
    public class SC_Customer_Order_Confirm_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 40; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 客户确认订单
    public class SC_Customer_Order_Confirm_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Order_Confirm_Failure_Type type;
        public const short commandType = 41; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Order_Confirm_Failure_Type) bb.ReadInt();
        }

    };
    // 获取支付平台列表
    public class SC_Get_Payment_Platform_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_Get_Payment_Platform_Data> data = new List<SCPkgTypes.SC_Get_Payment_Platform_Data>();
        public const short commandType = 42; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_Get_Payment_Platform_Data>( 0,0 );
        }

    };
    // 获取支付平台列表
    public class SC_Get_Payment_Platform_Data : IBBWriter, IBBReader 
    {
        /*
         * 支付平台编号
        */
        public int id;
        /*
         * 支付平台名称
        */
        public string name = "";
        public const short commandType = 43; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,1150 );
        }

    };
    // 获取支付平台列表
    public class SC_Get_Payment_Platform_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Get_Payment_Platform_Failure_Type type;
        public const short commandType = 44; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Get_Payment_Platform_Failure_Type) bb.ReadInt();
        }

    };
    // 客户寄送资料
    public class SC_Customer_Deliver_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 45; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 客户寄送资料
    public class SC_Customer_Deliver_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Deliver_Failure_Type type;
        public const short commandType = 46; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Deliver_Failure_Type) bb.ReadInt();
        }

    };
    // 会计接收资料确认
    public class SC_Accountant_Receipt_Confirm_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 47; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 会计接收资料确认
    public class SC_Accountant_Receipt_Confirm_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Accountant_Receipt_Confirm_Failure_Type type;
        public const short commandType = 48; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Accountant_Receipt_Confirm_Failure_Type) bb.ReadInt();
        }

    };
    // 会计填写报表
    public class SC_Accountant_Create_Report_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 49; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 会计填写报表
    public class SC_Accountant_Create_Report_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Accountant_Create_Report_Failure_Type type;
        public const short commandType = 50; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Accountant_Create_Report_Failure_Type) bb.ReadInt();
        }

    };
    // 查询月度报表
    public class SC_Get_Report_Month_Success : IBBWriter, IBBReader 
    {
        /*
         * 订单编号
        */
        public double national_tax_total;
        /*
         * 订单编号
        */
        public double land_tax_total;
        /*
         * 订单编号
        */
        public double non_tax_income_total;
        /*
         * 订单编号
        */
        public string national_tax = "";
        /*
         * 订单编号
        */
        public string land_tax = "";
        public const short commandType = 51; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( national_tax_total );
            bb.Write( land_tax_total );
            bb.Write( non_tax_income_total );
            bb.Write( national_tax );
            bb.Write( land_tax ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             national_tax_total = bb.ReadDouble();
             land_tax_total = bb.ReadDouble();
             non_tax_income_total = bb.ReadDouble();
             national_tax = bb.ReadString( 0,900 );
             land_tax = bb.ReadString( 0,11500 );
        }

    };
    // 查询月度报表
    public class SC_Get_Report_Month_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Get_Report_Month_Failure_Type type;
        public const short commandType = 52; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Get_Report_Month_Failure_Type) bb.ReadInt();
        }

    };
    // 查询季度报表
    public class SC_Get_Report_Quarter_Success : IBBWriter, IBBReader 
    {
        /*
         * 订单编号
        */
        public double national_tax_total;
        /*
         * 订单编号
        */
        public double land_tax_total;
        /*
         * 订单编号
        */
        public double non_tax_income_total;
        /*
         * 订单编号
        */
        public string national_tax = "";
        /*
         * 订单编号
        */
        public string land_tax = "";
        public const short commandType = 53; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( national_tax_total );
            bb.Write( land_tax_total );
            bb.Write( non_tax_income_total );
            bb.Write( national_tax );
            bb.Write( land_tax ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             national_tax_total = bb.ReadDouble();
             land_tax_total = bb.ReadDouble();
             non_tax_income_total = bb.ReadDouble();
             national_tax = bb.ReadString( 0,900 );
             land_tax = bb.ReadString( 0,11500 );
        }

    };
    // 查询季度报表
    public class SC_Get_Report_Quarter_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Get_Report_Quarter_Failure_Type type;
        public const short commandType = 54; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Get_Report_Quarter_Failure_Type) bb.ReadInt();
        }

    };
    // 客户对报表审核
    public class SC_Customer_Report_Confirm_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 55; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 客户对报表审核
    public class SC_Customer_Report_Confirm_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Report_Confirm_Failure_Type type;
        public const short commandType = 56; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Report_Confirm_Failure_Type) bb.ReadInt();
        }

    };
    // 会计返还资料
    public class SC_Accountant_Send_Back_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 57; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 会计返还资料
    public class SC_Accountant_Send_Back_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Accountant_Send_Back_Failure_Type type;
        public const short commandType = 58; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Accountant_Send_Back_Failure_Type) bb.ReadInt();
        }

    };
    // 客户接收确认，订单完成
    public class SC_Customer_Order_Recive_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 59; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 客户接收确认，订单完成
    public class SC_Customer_Order_Recive_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Order_Recive_Failure_Type type;
        public const short commandType = 60; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Order_Recive_Failure_Type) bb.ReadInt();
        }

    };
    // 客户退回订单至会计定价
    public class SC_Customer_Order_Back_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 61; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 客户退回订单至会计定价
    public class SC_Customer_Order_Back_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Order_Back_Failure_Type type;
        public const short commandType = 62; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Order_Back_Failure_Type) bb.ReadInt();
        }

    };
    // 会计取消订单
    public class SC_Accountant_Cancel_Order_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 63; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 会计取消订单
    public class SC_Accountant_Cancel_Order_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Accountant_Cancel_Order_Failure_Type type;
        public const short commandType = 64; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Accountant_Cancel_Order_Failure_Type) bb.ReadInt();
        }

    };
    // 客户取消订单
    public class SC_Customer_Cancel_Order_Success : IBBWriter, IBBReader 
    {
        public bool isPushSuccess;
        public const short commandType = 65; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( isPushSuccess ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             isPushSuccess = bb.ReadBoolean();
        }

    };
    // 客户取消订单
    public class SC_Customer_Cancel_Order_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_Cancel_Order_Failure_Type type;
        public const short commandType = 66; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_Cancel_Order_Failure_Type) bb.ReadInt();
        }

    };
    // 获取会计列表
    public class SC_Accountant_GetList_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_Accountant_GetList_Data> data = new List<SCPkgTypes.SC_Accountant_GetList_Data>();
        public const short commandType = 67; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_Accountant_GetList_Data>( 0,0 );
        }

    };
    // 获取会计列表
    public class SC_Accountant_GetList_Data : IBBWriter, IBBReader 
    {
        /*
         * 编号
        */
        public int id;
        /*
         * 名字
        */
        public string name = "";
        /*
         * 电话号码
        */
        public string phone = "";
        /*
         * 头像
        */
        public string headShot = "";
        /*
         * 完成订单数量
        */
        public int completedorder;
        /*
         * 行业
        */
        public string industry = "";
        /*
         * 产品名称
        */
        public string productname = "";
        /*
         * 产品ID
        */
        public int productID;
        /*
         * 价格
        */
        public double price;
        public const short commandType = 68; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name );
            bb.Write( phone );
            bb.Write( headShot );
            bb.Write( completedorder );
            bb.Write( industry );
            bb.Write( productname );
            bb.Write( productID );
            bb.Write( price ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,90 );
             phone = bb.ReadString( 0,60 );
             headShot = bb.ReadString( 0,900 );
             completedorder = bb.ReadInt();
             industry = bb.ReadString( 0,1150 );
             productname = bb.ReadString( 0,1150 );
             productID = bb.ReadInt();
             price = bb.ReadDouble();
        }

    };
    // 获取会计列表
    public class SC_Accountant_GetList_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Accountant_GetList_Failure_Type type;
        public const short commandType = 69; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Accountant_GetList_Failure_Type) bb.ReadInt();
        }

    };
    // 查询已完成订单列表
    public class SC_CompeletedOrder_GetList_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_CompeletedOrder_GetList_Data> data = new List<SCPkgTypes.SC_CompeletedOrder_GetList_Data>();
        public const short commandType = 70; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_CompeletedOrder_GetList_Data>( 0,0 );
        }

    };
    // 查询已完成订单列表
    public class SC_CompeletedOrder_GetList_Data : IBBWriter, IBBReader 
    {
        /*
         * 订单ID
        */
        public string orderId = "";
        /*
         * 公司名字
        */
        public string name = "";
        /*
         * 订单创建时间
        */
        public DateTime orderDate = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单状态
        */
        public int stateCode;
        /*
         * 价格
        */
        public double total;
        /*
         * 用户看见的订单ID号
        */
        public string idView = "";
        /*
         * 子订单数据表自增主键ID
        */
        public int number;
        public const short commandType = 71; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( orderId );
            bb.Write( name );
            bb.Write( orderDate );
            bb.Write( stateCode );
            bb.Write( total );
            bb.Write( idView );
            bb.Write( number ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             orderId = bb.ReadString( 0,1150 );
             name = bb.ReadString( 0,1150 );
             orderDate = bb.ReadDate();
             stateCode = bb.ReadInt();
             total = bb.ReadDouble();
             idView = bb.ReadString( 0,1150 );
             number = bb.ReadInt();
        }

    };
    // 查询已完成订单列表
    public class SC_CompeletedOrder_GetList_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_CompeletedOrder_GetList_Failure_Type type;
        public const short commandType = 72; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_CompeletedOrder_GetList_Failure_Type) bb.ReadInt();
        }

    };
    // 客户对会计服务评分
    public class SC_Grade_AccountantService_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 73; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 客户对会计服务评分
    public class SC_Grade_AccountantService_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Grade_AccountantService_Failure_Type type;
        public const short commandType = 74; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Grade_AccountantService_Failure_Type) bb.ReadInt();
        }

    };
    // 会计上传证件照片
    public class SC_AccountantCredentials_Upload_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 75; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 会计上传证件照片
    public class SC_AccountantCredentials_Upload_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AccountantCredentials_Upload_Failure_Type type;
        public const short commandType = 76; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AccountantCredentials_Upload_Failure_Type) bb.ReadInt();
        }

    };
    // 银联支付获取交易流水号
    public class SC_UnionPayTn_Get_Success : IBBWriter, IBBReader 
    {
        /*
         * 流水号
        */
        public string tn = "";
        public const short commandType = 77; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( tn ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             tn = bb.ReadString( 0,1150 );
        }

    };
    // 银联支付获取交易流水号
    public class SC_UnionPayTn_Get_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_UnionPayTn_Get_Failure_Type type;
        public const short commandType = 78; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_UnionPayTn_Get_Failure_Type) bb.ReadInt();
        }

    };
    // 会计上传报表文件
    public class SC_ReportFile_Upload_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 79; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 会计上传报表文件
    public class SC_ReportFile_Upload_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Upload_Failure_Type type;
        public const short commandType = 80; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Upload_Failure_Type) bb.ReadInt();
        }

    };
    // 下载报表文件
    public class SC_ReportFile_Download_Success : IBBWriter, IBBReader 
    {
        /*
         * 文件内容,必须base64编码
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 81; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 下载报表文件
    public class SC_ReportFile_Download_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Download_Failure_Type type;
        public const short commandType = 82; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Download_Failure_Type) bb.ReadInt();
        }

    };
    // 删除报表文件
    public class SC_ReportFile_Delete_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 83; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 删除报表文件
    public class SC_ReportFile_Delete_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Delete_Failure_Type type;
        public const short commandType = 84; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Delete_Failure_Type) bb.ReadInt();
        }

    };
    // 获取某会计未完成订单列表(web版)
    public class SC_GetAccountantUncompletedOrderList_web_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Data> data = new List<SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Data>();
        public const short commandType = 85; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Data>( 0,0 );
        }

    };
    // 获取某会计未完成订单列表(web版)
    public class SC_GetAccountantUncompletedOrderList_web_file_info : IBBWriter, IBBReader 
    {
        public int file_id;
        public string file_name = "";
        public const short commandType = 86; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( file_id );
            bb.Write( file_name ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             file_id = bb.ReadInt();
             file_name = bb.ReadString( 0,0 );
        }

    };
    // 获取某会计未完成订单列表(web版)
    public class SC_GetAccountantUncompletedOrderList_web_Data : IBBWriter, IBBReader 
    {
        /*
         * 订单id
        */
        public string orderID = "";
        /*
         * 公司ID
        */
        public int customerID;
        /*
         * 公司名字
        */
        public string companyName = "";
        /*
         * 订单创建时间
        */
        public DateTime orderDate = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单开始时间
        */
        public DateTime orderStartDate = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单状态
        */
        public int stateCode;
        /*
         * 订单价格
        */
        public double total;
        /*
         * 用户看的见得订单号
        */
        public string iDView = "";
        /*
         * 订单自增号
        */
        public int number;
        /*
         * 文件信息列表
        */
        public List<SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_file_info> file_info_list = new List<SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_file_info>();
        public const short commandType = 87; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( orderID );
            bb.Write( customerID );
            bb.Write( companyName );
            bb.Write( orderDate );
            bb.Write( orderStartDate );
            bb.Write( stateCode );
            bb.Write( total );
            bb.Write( iDView );
            bb.Write( number );
            bb.Write( file_info_list ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             orderID = bb.ReadString( 0,50 );
             customerID = bb.ReadInt();
             companyName = bb.ReadString( 0,50 );
             orderDate = bb.ReadDate();
             orderStartDate = bb.ReadDate();
             stateCode = bb.ReadInt();
             total = bb.ReadDouble();
             iDView = bb.ReadString( 0,0 );
             number = bb.ReadInt();
             file_info_list = bb.ReadListObject<SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_file_info>( 0,0 );
        }

    };
    // 获取某会计未完成订单列表(web版)
    public class SC_GetAccountantUncompletedOrderList_web_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Failure_Type type;
        public const short commandType = 88; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Failure_Type) bb.ReadInt();
        }

    };
    // 获取会计电子名片
    public class SC_AccountantElectronicBusinessCard_Get_Success : IBBWriter, IBBReader 
    {
        /*
         * 完成订单数
        */
        public int completedOrder;
        /*
         * 会计名字
        */
        public string name = "";
        /*
         * 会计排名
        */
        public int rank;
        public const short commandType = 89; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( completedOrder );
            bb.Write( name );
            bb.Write( rank ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             completedOrder = bb.ReadInt();
             name = bb.ReadString( 0,90 );
             rank = bb.ReadInt();
        }

    };
    // 获取会计电子名片
    public class SC_AccountantElectronicBusinessCard_Get_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AccountantElectronicBusinessCard_Get_Failure_Type type;
        public const short commandType = 90; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AccountantElectronicBusinessCard_Get_Failure_Type) bb.ReadInt();
        }

    };
    // 通信错误
    public class SC_Communication_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Communication_Failure_Type type;
        public const short commandType = 91; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Communication_Failure_Type) bb.ReadInt();
        }

    };
    // 下载会计图片
    public class SC_AccountanPictureDown_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 图片内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 图片类型的名称
        */
        public string picName = "";
        public const short commandType = 92; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileContent );
            bb.Write( picName ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileContent = bb.ReadBytes( 0,3048576 );
             picName = bb.ReadString( 0,150 );
        }

    };
    // 下载会计图片
    public class SC_AccountanPictureDown_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_AccountanPictureDown_Success_Data> data = new List<SCPkgTypes.SC_AccountanPictureDown_Success_Data>();
        public const short commandType = 93; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_AccountanPictureDown_Success_Data>( 0,0 );
        }

    };
    // 下载会计图片
    public class SC_AccountanPictureDown_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AccountanPictureDown_Failure_Type type;
        public const short commandType = 94; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AccountanPictureDown_Failure_Type) bb.ReadInt();
        }

    };
    // 公司查询月度报表
    public class SC_FindReportCustom_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 产品名称
        */
        public string productName = "";
        /*
         * 产品名称
        */
        public string customerName = "";
        /*
         * 订单编号
        */
        public double national_tax_total;
        /*
         * 订单编号
        */
        public double land_tax_total;
        /*
         * 订单编号
        */
        public double non_tax_income_total;
        /*
         * 订单编号
        */
        public string national_tax = "";
        /*
         * 订单编号
        */
        public string land_tax = "";
        public const short commandType = 95; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( productName );
            bb.Write( customerName );
            bb.Write( national_tax_total );
            bb.Write( land_tax_total );
            bb.Write( non_tax_income_total );
            bb.Write( national_tax );
            bb.Write( land_tax ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             productName = bb.ReadString( 0,150 );
             customerName = bb.ReadString( 0,150 );
             national_tax_total = bb.ReadDouble();
             land_tax_total = bb.ReadDouble();
             non_tax_income_total = bb.ReadDouble();
             national_tax = bb.ReadString( 0,900 );
             land_tax = bb.ReadString( 0,11500 );
        }

    };
    // 公司查询月度报表
    public class SC_FindReportCustom_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_FindReportCustom_Success_Data> data = new List<SCPkgTypes.SC_FindReportCustom_Success_Data>();
        public const short commandType = 96; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_FindReportCustom_Success_Data>( 0,0 );
        }

    };
    // 公司查询月度报表
    public class SC_FindReportCustom_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_FindReportCustom_Failure_Type type;
        public const short commandType = 97; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_FindReportCustom_Failure_Type) bb.ReadInt();
        }

    };
    // 公司上传电子财务信息
    public class SC_Customer_UploadElectronicBill_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 98; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 公司上传电子财务信息
    public class SC_Customer_UploadElectronicBill_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Customer_UploadElectronicBill_Failure_Type type;
        public const short commandType = 99; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Customer_UploadElectronicBill_Failure_Type) bb.ReadInt();
        }

    };
    // 获得公司电子财务信息
    public class SC_GetElectronicBill_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 100; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileName );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 获得公司电子财务信息
    public class SC_GetElectronicBill_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_GetElectronicBill_Success_Data> data = new List<SCPkgTypes.SC_GetElectronicBill_Success_Data>();
        public const short commandType = 101; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_GetElectronicBill_Success_Data>( 0,0 );
        }

    };
    // 获得公司电子财务信息
    public class SC_GetElectronicBill_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_GetElectronicBill_Failure_Type type;
        public const short commandType = 102; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_GetElectronicBill_Failure_Type) bb.ReadInt();
        }

    };
    // 公司查询所有订单的进度
    public class SC_CustomerGetOrderState_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 下哪个月单时间
        */
        public DateTime startTime = new DateTime(1991,1,1,0,0,0);
        /*
         * 订单IdView编号
        */
        public string idView = "";
        /*
         * 订单状态
        */
        public int stateCode;
        public const short commandType = 103; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( startTime );
            bb.Write( idView );
            bb.Write( stateCode ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             startTime = bb.ReadDate();
             idView = bb.ReadString( 0,150 );
             stateCode = bb.ReadInt();
        }

    };
    // 公司查询所有订单的进度
    public class SC_CustomerGetOrderState_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_CustomerGetOrderState_Success_Data> data = new List<SCPkgTypes.SC_CustomerGetOrderState_Success_Data>();
        public const short commandType = 104; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_CustomerGetOrderState_Success_Data>( 0,0 );
        }

    };
    // 公司查询所有订单的进度
    public class SC_CustomerGetOrderState_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_CustomerGetOrderState_Failure_Type type;
        public const short commandType = 105; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_CustomerGetOrderState_Failure_Type) bb.ReadInt();
        }

    };
    // 上传年度报表文件
    public class SC_ReportFile_Upload_Year_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 106; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 上传年度报表文件
    public class SC_ReportFile_Upload_Year_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Upload_Year_Failure_Type type;
        public const short commandType = 107; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Upload_Year_Failure_Type) bb.ReadInt();
        }

    };
    // 上传季度报表文件
    public class SC_ReportFile_Upload_Quarter_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 108; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 上传季度报表文件
    public class SC_ReportFile_Upload_Quarter_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Upload_Quarter_Failure_Type type;
        public const short commandType = 109; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Upload_Quarter_Failure_Type) bb.ReadInt();
        }

    };
    // 上传月度报表文件
    public class SC_ReportFile_Upload_Month_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 110; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 上传月度报表文件
    public class SC_ReportFile_Upload_Month_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Upload_Month_Failure_Type type;
        public const short commandType = 111; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Upload_Month_Failure_Type) bb.ReadInt();
        }

    };
    // 下载年度报表文件
    public class SC_ReportFile_Download_Year_Success : IBBWriter, IBBReader 
    {
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 112; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileName );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 下载年度报表文件
    public class SC_ReportFile_Download_Year_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Download_Year_Failure_Type type;
        public const short commandType = 113; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Download_Year_Failure_Type) bb.ReadInt();
        }

    };
    // 下载季度报表文件
    public class SC_ReportFile_Download_Quarter_Success : IBBWriter, IBBReader 
    {
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 114; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileName );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 下载季度报表文件
    public class SC_ReportFile_Download_Quarter_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Download_Quarter_Failure_Type type;
        public const short commandType = 115; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Download_Quarter_Failure_Type) bb.ReadInt();
        }

    };
    // 下载月度报表文件
    public class SC_ReportFile_Download_Month_Success : IBBWriter, IBBReader 
    {
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 116; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileName );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 下载月度报表文件
    public class SC_ReportFile_Download_Month_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Download_Month_Failure_Type type;
        public const short commandType = 117; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Download_Month_Failure_Type) bb.ReadInt();
        }

    };
    // 下载报表文件列表(订单流程内使用)
    public class SC_ReportFileList_Download_Success_Data : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFileList_Download_Success_Data_Type dataType;
        public int number;
        public const short commandType = 118; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)dataType );
            bb.Write( number ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             dataType = (SCPkgTypes.SC_ReportFileList_Download_Success_Data_Type) bb.ReadInt();
             number = bb.ReadInt();
        }

    };
    // 下载报表文件列表(订单流程内使用)
    public class SC_ReportFileList_Download_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_ReportFileList_Download_Success_Data> data = new List<SCPkgTypes.SC_ReportFileList_Download_Success_Data>();
        public const short commandType = 119; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_ReportFileList_Download_Success_Data>( 0,0 );
        }

    };
    // 下载报表文件列表(订单流程内使用)
    public class SC_ReportFileList_Download_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFileList_Download_Failure_Type type;
        public const short commandType = 120; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFileList_Download_Failure_Type) bb.ReadInt();
        }

    };
    // 下载报表文件(订单流程内使用)
    public class SC_ReportFileOrder_Download_Success : IBBWriter, IBBReader 
    {
        /*
         * 图片名称
        */
        public string fileName = "";
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        /*
         * 报表类型1->年度报表,2->季度报表,3->月度报表
        */
        public int fileType;
        public const short commandType = 121; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileName );
            bb.Write( fileContent );
            bb.Write( fileType ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
             fileType = bb.ReadInt();
        }

    };
    // 下载报表文件(订单流程内使用)
    public class SC_ReportFileOrder_Download_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFileOrder_Download_Failure_Type type;
        public const short commandType = 122; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFileOrder_Download_Failure_Type) bb.ReadInt();
        }

    };
    // 地图点击获得会计详细信息
    public class SC_CheckAccountantInformation_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 证书名称
        */
        public string credentialName = "";
        /*
         * 证书是否经过认证
        */
        public bool isAuth;
        public const short commandType = 123; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( credentialName );
            bb.Write( isAuth ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             credentialName = bb.ReadString( 0,150 );
             isAuth = bb.ReadBoolean();
        }

    };
    // 地图点击获得会计详细信息
    public class SC_CheckAccountantInformation_Success : IBBWriter, IBBReader 
    {
        /*
         * 姓名
        */
        public string name = "";
        /*
         * 性别
        */
        public string gender = "";
        /*
         * 用户认证
        */
        public string accountantAuth = "";
        /*
         * 个人简介
        */
        public string introduction = "";
        /*
         * 服务次数
        */
        public int completeCount;
        /*
         * 好评度
        */
        public double grade;
        /*
         * 擅长领域
        */
        public List<int> industryID = new List<int>();
        /*
         * 专业证书
        */
        public List<SCPkgTypes.SC_CheckAccountantInformation_Success_Data> data = new List<SCPkgTypes.SC_CheckAccountantInformation_Success_Data>();
        public const short commandType = 124; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( name );
            bb.Write( gender );
            bb.Write( accountantAuth );
            bb.Write( introduction );
            bb.Write( completeCount );
            bb.Write( grade );
            bb.Write( industryID );
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             name = bb.ReadString( 0,150 );
             gender = bb.ReadString( 0,10 );
             accountantAuth = bb.ReadString( 0,150 );
             introduction = bb.ReadString( 0,3000 );
             completeCount = bb.ReadInt();
             grade = bb.ReadDouble();
             industryID = bb.ReadListInt( 0,0 );
             data = bb.ReadListObject<SCPkgTypes.SC_CheckAccountantInformation_Success_Data>( 0,0 );
        }

    };
    // 地图点击获得会计详细信息
    public class SC_CheckAccountantInformation_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_CheckAccountantInformation_Failure_Type type;
        public const short commandType = 125; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_CheckAccountantInformation_Failure_Type) bb.ReadInt();
        }

    };
    // 通过报表文件ID查看文件
    public class SC_CheckReportFileFromID_Success : IBBWriter, IBBReader 
    {
        /*
         * url地址
        */
        public string name = "";
        public const short commandType = 126; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( name ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             name = bb.ReadString( 0,2000 );
        }

    };
    // 通过报表文件ID查看文件
    public class SC_CheckReportFileFromID_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_CheckReportFileFromID_Failure_Type type;
        public const short commandType = 127; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_CheckReportFileFromID_Failure_Type) bb.ReadInt();
        }

    };
    // 查看年度报表文件
    public class SC_ReportFile_Find_Year_Success : IBBWriter, IBBReader 
    {
        /*
         * 报表文件id
        */
        public int fileID;
        public const short commandType = 128; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileID = bb.ReadInt();
        }

    };
    // 查看年度报表文件
    public class SC_ReportFile_Find_Year_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Find_Year_Failure_Type type;
        public const short commandType = 129; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Find_Year_Failure_Type) bb.ReadInt();
        }

    };
    // 查看季度报表文件
    public class SC_ReportFile_Find_Quarter_Success : IBBWriter, IBBReader 
    {
        /*
         * 报表文件id
        */
        public int fileID;
        public const short commandType = 130; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileID = bb.ReadInt();
        }

    };
    // 查看季度报表文件
    public class SC_ReportFile_Find_Quarter_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Find_Quarter_Failure_Type type;
        public const short commandType = 131; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Find_Quarter_Failure_Type) bb.ReadInt();
        }

    };
    // 查看月度报表文件
    public class SC_ReportFile_Find_Month_Success : IBBWriter, IBBReader 
    {
        /*
         * 报表文件id
        */
        public int fileID;
        public const short commandType = 132; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileID = bb.ReadInt();
        }

    };
    // 查看月度报表文件
    public class SC_ReportFile_Find_Month_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReportFile_Find_Month_Failure_Type type;
        public const short commandType = 133; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReportFile_Find_Month_Failure_Type) bb.ReadInt();
        }

    };
    // 交易过的会计列表
    public class SC_DealAccountantList_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_DealAccountantList_Data> data = new List<SCPkgTypes.SC_DealAccountantList_Data>();
        public const short commandType = 134; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_DealAccountantList_Data>( 0,0 );
        }

    };
    // 交易过的会计列表
    public class SC_DealAccountantList_Data : IBBWriter, IBBReader 
    {
        /*
         * 编号
        */
        public int id;
        /*
         * 名字
        */
        public string name = "";
        /*
         * 电话号码
        */
        public string phone = "";
        /*
         * 头像
        */
        public string headShot = "";
        /*
         * 完成订单数量
        */
        public int completedorder;
        /*
         * 行业
        */
        public string industry = "";
        /*
         * 产品名称
        */
        public string productname = "";
        /*
         * 产品ID
        */
        public int productID;
        /*
         * 价格
        */
        public double price;
        public const short commandType = 135; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( id );
            bb.Write( name );
            bb.Write( phone );
            bb.Write( headShot );
            bb.Write( completedorder );
            bb.Write( industry );
            bb.Write( productname );
            bb.Write( productID );
            bb.Write( price ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             id = bb.ReadInt();
             name = bb.ReadString( 0,90 );
             phone = bb.ReadString( 0,60 );
             headShot = bb.ReadString( 0,900 );
             completedorder = bb.ReadInt();
             industry = bb.ReadString( 0,1150 );
             productname = bb.ReadString( 0,1150 );
             productID = bb.ReadInt();
             price = bb.ReadDouble();
        }

    };
    // 交易过的会计列表
    public class SC_DealAccountantList_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_DealAccountantList_Failure_Type type;
        public const short commandType = 136; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_DealAccountantList_Failure_Type) bb.ReadInt();
        }

    };
    // 修改会计个人资料
    public class SC_ChangeAccountantInformation_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 137; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 修改会计个人资料
    public class SC_ChangeAccountantInformation_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ChangeAccountantInformation_Failure_Type type;
        public const short commandType = 138; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ChangeAccountantInformation_Failure_Type) bb.ReadInt();
        }

    };
    // 会计点击修改，获得自己的数据
    public class SC_ReturnAccountantInformation_Success : IBBWriter, IBBReader 
    {
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
        /*
         * 状态
        */
        public string state = "";
        public const short commandType = 139; 

        public void WriteToBuffer( ByteBuffer bb )
        {
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
            bb.Write( state ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
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
             state = bb.ReadString( 0,150 );
        }

    };
    // 会计点击修改，获得自己的数据
    public class SC_ReturnAccountantInformation_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_ReturnAccountantInformation_Failure_Type type;
        public const short commandType = 140; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_ReturnAccountantInformation_Failure_Type) bb.ReadInt();
        }

    };
    // 会计首页
    public class SC_AccountantHomePage_Success : IBBWriter, IBBReader 
    {
        /*
         * 姓名
        */
        public string name = "";
        /*
         * 性别
        */
        public string gender = "";
        /*
         * 今日订单
        */
        public int todayOrderNum;
        /*
         * 今日浏览量
        */
        public int todayPageView;
        /*
         * 会计头像
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 141; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( name );
            bb.Write( gender );
            bb.Write( todayOrderNum );
            bb.Write( todayPageView );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             name = bb.ReadString( 0,60 );
             gender = bb.ReadString( 0,3 );
             todayOrderNum = bb.ReadInt();
             todayPageView = bb.ReadInt();
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 会计首页
    public class SC_AccountantHomePage_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AccountantHomePage_Failure_Type type;
        public const short commandType = 142; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AccountantHomePage_Failure_Type) bb.ReadInt();
        }

    };
    // 公司匿名登录
    public class SC_CustomerAnonymous_Success : IBBWriter, IBBReader 
    {
        /*
         * 令牌
        */
        public string token = "";
        /*
         * 公司ID
        */
        public int id;
        public const short commandType = 143; 

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
    // 公司匿名登录
    public class SC_CustomerAnonymous_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_CustomerAnonymous_Failure_Type type;
        public const short commandType = 144; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_CustomerAnonymous_Failure_Type) bb.ReadInt();
        }

    };
    // 验证服务器失败
    public class SC_Anonymous_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_Anonymous_Failure_Type type;
        public const short commandType = 145; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_Anonymous_Failure_Type) bb.ReadInt();
        }

    };
    // 查看会计证件照片
    public class SC_FindAccountantCredentials_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 文件名
        */
        public string fileName = "";
        /*
         * 文件类型
        */
        public int fileType;
        /*
         * 内容
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 146; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( fileName );
            bb.Write( fileType );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             fileName = bb.ReadString( 0,800 );
             fileType = bb.ReadInt();
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 查看会计证件照片
    public class SC_FindAccountantCredentials_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_FindAccountantCredentials_Success_Data> data = new List<SCPkgTypes.SC_FindAccountantCredentials_Success_Data>();
        public const short commandType = 147; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_FindAccountantCredentials_Success_Data>( 0,0 );
        }

    };
    // 查看会计证件照片
    public class SC_FindAccountantCredentials_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_FindAccountantCredentials_Failure_Type type;
        public const short commandType = 148; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_FindAccountantCredentials_Failure_Type) bb.ReadInt();
        }

    };
    // 会计查看交易过的公司
    public class SC_AccountantFindCustomer_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 公司名称
        */
        public string customerName = "";
        /*
         * 纳税资质
        */
        public string taxQualification = "";
        /*
         * 公司ID
        */
        public int customerID;
        public const short commandType = 149; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( customerName );
            bb.Write( taxQualification );
            bb.Write( customerID ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             customerName = bb.ReadString( 0,150 );
             taxQualification = bb.ReadString( 0,150 );
             customerID = bb.ReadInt();
        }

    };
    // 会计查看交易过的公司
    public class SC_AccountantFindCustomer_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_AccountantFindCustomer_Success_Data> data = new List<SCPkgTypes.SC_AccountantFindCustomer_Success_Data>();
        public const short commandType = 150; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_AccountantFindCustomer_Success_Data>( 0,0 );
        }

    };
    // 会计查看交易过的公司
    public class SC_AccountantFindCustomer_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AccountantFindCustomer_Failure_Type type;
        public const short commandType = 151; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AccountantFindCustomer_Failure_Type) bb.ReadInt();
        }

    };
    // 会计查看交易过的某个公司明细
    public class SC_AcountantFindCustomerDetail_Success : IBBWriter, IBBReader 
    {
        /*
         * 公司名称
        */
        public string customerName = "";
        /*
         * 公司地址
        */
        public string customerAddress = "";
        /*
         * 公司类型
        */
        public string customerType = "";
        /*
         * 公司邮件地址
        */
        public string customerEmail = "";
        /*
         * 公司纳税资质
        */
        public string customerQualification = "";
        /*
         * 合作次数
        */
        public int count;
        public const short commandType = 152; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( customerName );
            bb.Write( customerAddress );
            bb.Write( customerType );
            bb.Write( customerEmail );
            bb.Write( customerQualification );
            bb.Write( count ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             customerName = bb.ReadString( 0,150 );
             customerAddress = bb.ReadString( 0,300 );
             customerType = bb.ReadString( 0,150 );
             customerEmail = bb.ReadString( 0,150 );
             customerQualification = bb.ReadString( 0,150 );
             count = bb.ReadInt();
        }

    };
    // 会计查看交易过的某个公司明细
    public class SC_AcountantFindCustomerDetail_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AcountantFindCustomerDetail_Failure_Type type;
        public const short commandType = 153; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AcountantFindCustomerDetail_Failure_Type) bb.ReadInt();
        }

    };
    // 会计更换头像
    public class SC_UserChangeIcon_Success : IBBWriter, IBBReader 
    {
        public const short commandType = 154; 

        public void WriteToBuffer( ByteBuffer bb )
        { 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
        }

    };
    // 更换头像
    public class SC_UserChangeIcon_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_UserChangeIcon_Failure_Type type;
        public const short commandType = 155; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_UserChangeIcon_Failure_Type) bb.ReadInt();
        }

    };
    // 公司主页
    public class SC_CustomerHomePage_Success : IBBWriter, IBBReader 
    {
        /*
         * 公司名称
        */
        public string customerName = "";
        /*
         * 公司头像
        */
        public byte[] fileContent = new byte[0];
        public const short commandType = 156; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( customerName );
            bb.Write( fileContent ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             customerName = bb.ReadString( 0,150 );
             fileContent = bb.ReadBytes( 0,3048576 );
        }

    };
    // 公司主页
    public class SC_CustomerHomePage_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_CustomerHomePage_Failure_Type type;
        public const short commandType = 157; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_CustomerHomePage_Failure_Type) bb.ReadInt();
        }

    };
    // 查看推送消息
    public class SC_FindPushMessage_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 推送内容
        */
        public string pushHint = "";
        /*
         * 公司地址
        */
        public DateTime pushTime = new DateTime(1991,1,1,0,0,0);
        public const short commandType = 158; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( pushHint );
            bb.Write( pushTime ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             pushHint = bb.ReadString( 0,150 );
             pushTime = bb.ReadDate();
        }

    };
    // 查看推送消息
    public class SC_FindPushMessage_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_FindPushMessage_Success_Data> data = new List<SCPkgTypes.SC_FindPushMessage_Success_Data>();
        public const short commandType = 159; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_FindPushMessage_Success_Data>( 0,0 );
        }

    };
    // 查看推送消息
    public class SC_FindPushMessage_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_FindPushMessage_Failure_Type type;
        public const short commandType = 160; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_FindPushMessage_Failure_Type) bb.ReadInt();
        }

    };
    // 会计查看文档
    public class SC_AccountantFindDocment_Success_Data : IBBWriter, IBBReader 
    {
        /*
         * 公司名称
        */
        public string customerName = "";
        /*
         * 报表类型
        */
        public int typeId;
        /*
         * 年
        */
        public int year;
        /*
         * 季度
        */
        public int quarter;
        /*
         * 月
        */
        public int month;
        /*
         * 文件ID
        */
        public int fileId;
        public const short commandType = 161; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( customerName );
            bb.Write( typeId );
            bb.Write( year );
            bb.Write( quarter );
            bb.Write( month );
            bb.Write( fileId ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             customerName = bb.ReadString( 0,300 );
             typeId = bb.ReadInt();
             year = bb.ReadInt();
             quarter = bb.ReadInt();
             month = bb.ReadInt();
             fileId = bb.ReadInt();
        }

    };
    // 会计查看文档
    public class SC_AccountantFindDocment_Success : IBBWriter, IBBReader 
    {
        public List<SCPkgTypes.SC_AccountantFindDocment_Success_Data> data = new List<SCPkgTypes.SC_AccountantFindDocment_Success_Data>();
        public const short commandType = 162; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( data ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             data = bb.ReadListObject<SCPkgTypes.SC_AccountantFindDocment_Success_Data>( 0,0 );
        }

    };
    // 会计查看文档
    public class SC_AccountantFindDocment_Failure : IBBWriter, IBBReader 
    {
        public SCPkgTypes.SC_AccountantFindDocment_Failure_Type type;
        public const short commandType = 163; 

        public void WriteToBuffer( ByteBuffer bb )
        {
            bb.Write( (int)type ); 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {
             type = (SCPkgTypes.SC_AccountantFindDocment_Failure_Type) bb.ReadInt();
        }

    };
}