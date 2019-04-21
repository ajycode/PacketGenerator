#ifndef __SCPkgTypes_H__
#define __SCPkgTypes_H__

#include "xxlib.h"

// predeclares
namespace SCPkgTypes
{
    struct SC_Accountant_Register_Success;
    struct SC_Accountant_Register_Failure;
    struct SC_Account_Register_IsExists_Success;
    struct SC_Account_Register_IsExists_Failure;
    struct SC_Account_Login_Success;
    struct SC_Account_Login_Failure;
    struct SC_Account_GetProduct_Success;
    struct SC_Account_GetProduct_Product;
    struct SC_Account_GetProduct_Industry;
    struct SC_Account_GetProduct_Failure;
    struct SC_Product_Manage_Success;
    struct SC_Product_Manage_Failure;
    struct SC_Account_GetDetails_ProductId;
    struct SC_Account_GetDetails_Success;
    struct SC_Account_GetDetails_Failure;
    struct SC_Customer_Register_Success;
    struct SC_Customer_Register_Failure;
    struct SC_Customer_Register_IsExists_Success;
    struct SC_Customer_Register_IsExists_Failure;
    struct SC_Industry_AllSector_Success;
    struct SC_Industry_AllSector_Industry;
    struct SC_Industry_AllSector_Failure;
    struct SC_Customer_Login_Success;
    struct SC_Customer_Login_Failure;
    struct SC_Acctountant_GetAround_Success;
    struct SC_Acctountant_GetAround_Person;
    struct SC_Acctountant_GetAround_Failure;
    struct SC_Order_Create_Success;
    struct SC_Order_Create_Failure;
    struct SC_Express_GetAll_Success;
    struct SC_Express_GetAll_Date;
    struct SC_Express_GetAll_Failure;
    struct SC_UncompletedOrder_GetList_Success;
    struct SC_UncompletedOrder_GetList_Data;
    struct SC_UncompletedOrder_GetList_Failure;
    struct SC_Order_GetDetails_Success;
    struct SC_Order_GetDetails_Failure;
    struct SC_Order_UpdateTotal_Success;
    struct SC_Order_UpdateTotal_Failure;
    struct SC_Customer_Order_Confirm_Success;
    struct SC_Customer_Order_Confirm_Failure;
    struct SC_Get_Payment_Platform_Success;
    struct SC_Get_Payment_Platform_Data;
    struct SC_Get_Payment_Platform_Failure;
    struct SC_Customer_Deliver_Success;
    struct SC_Customer_Deliver_Failure;
    struct SC_Accountant_Receipt_Confirm_Success;
    struct SC_Accountant_Receipt_Confirm_Failure;
    struct SC_Accountant_Create_Report_Success;
    struct SC_Accountant_Create_Report_Failure;
    struct SC_Get_Report_Month_Success;
    struct SC_Get_Report_Month_Failure;
    struct SC_Get_Report_Quarter_Success;
    struct SC_Get_Report_Quarter_Failure;
    struct SC_Customer_Report_Confirm_Success;
    struct SC_Customer_Report_Confirm_Failure;
    struct SC_Accountant_Send_Back_Success;
    struct SC_Accountant_Send_Back_Failure;
    struct SC_Customer_Order_Recive_Success;
    struct SC_Customer_Order_Recive_Failure;
    struct SC_Customer_Order_Back_Success;
    struct SC_Customer_Order_Back_Failure;
    struct SC_Accountant_Cancel_Order_Success;
    struct SC_Accountant_Cancel_Order_Failure;
    struct SC_Customer_Cancel_Order_Success;
    struct SC_Customer_Cancel_Order_Failure;
    struct SC_Accountant_GetList_Success;
    struct SC_Accountant_GetList_Data;
    struct SC_Accountant_GetList_Failure;
    struct SC_CompeletedOrder_GetList_Success;
    struct SC_CompeletedOrder_GetList_Data;
    struct SC_CompeletedOrder_GetList_Failure;
    struct SC_Grade_AccountantService_Success;
    struct SC_Grade_AccountantService_Failure;
    struct SC_AccountantCredentials_Upload_Success;
    struct SC_AccountantCredentials_Upload_Failure;
    struct SC_UnionPayTn_Get_Success;
    struct SC_UnionPayTn_Get_Failure;
    struct SC_ReportFile_Upload_Success;
    struct SC_ReportFile_Upload_Failure;
    struct SC_ReportFile_Download_Success;
    struct SC_ReportFile_Download_Failure;
    struct SC_ReportFile_Delete_Success;
    struct SC_ReportFile_Delete_Failure;
    struct SC_GetAccountantUncompletedOrderList_web_Success;
    struct SC_GetAccountantUncompletedOrderList_web_file_info;
    struct SC_GetAccountantUncompletedOrderList_web_Data;
    struct SC_GetAccountantUncompletedOrderList_web_Failure;
    struct SC_AccountantElectronicBusinessCard_Get_Success;
    struct SC_AccountantElectronicBusinessCard_Get_Failure;
    struct SC_Communication_Failure;
    struct SC_AccountanPictureDown_Success_Data;
    struct SC_AccountanPictureDown_Success;
    struct SC_AccountanPictureDown_Failure;
    struct SC_FindReportCustom_Success_Data;
    struct SC_FindReportCustom_Success;
    struct SC_FindReportCustom_Failure;
    struct SC_Customer_UploadElectronicBill_Success;
    struct SC_Customer_UploadElectronicBill_Failure;
    struct SC_GetElectronicBill_Success_Data;
    struct SC_GetElectronicBill_Success;
    struct SC_GetElectronicBill_Failure;
    struct SC_CustomerGetOrderState_Success_Data;
    struct SC_CustomerGetOrderState_Success;
    struct SC_CustomerGetOrderState_Failure;
    struct SC_ReportFile_Upload_Year_Success;
    struct SC_ReportFile_Upload_Year_Failure;
    struct SC_ReportFile_Upload_Quarter_Success;
    struct SC_ReportFile_Upload_Quarter_Failure;
    struct SC_ReportFile_Upload_Month_Success;
    struct SC_ReportFile_Upload_Month_Failure;
    struct SC_ReportFile_Download_Year_Success;
    struct SC_ReportFile_Download_Year_Failure;
    struct SC_ReportFile_Download_Quarter_Success;
    struct SC_ReportFile_Download_Quarter_Failure;
    struct SC_ReportFile_Download_Month_Success;
    struct SC_ReportFile_Download_Month_Failure;
    struct SC_ReportFileList_Download_Success_Data;
    struct SC_ReportFileList_Download_Success;
    struct SC_ReportFileList_Download_Failure;
    struct SC_ReportFileOrder_Download_Success;
    struct SC_ReportFileOrder_Download_Failure;
    struct SC_CheckAccountantInformation_Success_Data;
    struct SC_CheckAccountantInformation_Success;
    struct SC_CheckAccountantInformation_Failure;
    struct SC_CheckReportFileFromID_Success;
    struct SC_CheckReportFileFromID_Failure;
    struct SC_ReportFile_Find_Year_Success;
    struct SC_ReportFile_Find_Year_Failure;
    struct SC_ReportFile_Find_Quarter_Success;
    struct SC_ReportFile_Find_Quarter_Failure;
    struct SC_ReportFile_Find_Month_Success;
    struct SC_ReportFile_Find_Month_Failure;
    struct SC_DealAccountantList_Success;
    struct SC_DealAccountantList_Data;
    struct SC_DealAccountantList_Failure;
    struct SC_ChangeAccountantInformation_Success;
    struct SC_ChangeAccountantInformation_Failure;
    struct SC_ReturnAccountantInformation_Success;
    struct SC_ReturnAccountantInformation_Failure;
    struct SC_AccountantHomePage_Success;
    struct SC_AccountantHomePage_Failure;
    struct SC_CustomerAnonymous_Success;
    struct SC_CustomerAnonymous_Failure;
    struct SC_Anonymous_Failure;
    struct SC_FindAccountantCredentials_Success_Data;
    struct SC_FindAccountantCredentials_Success;
    struct SC_FindAccountantCredentials_Failure;
    struct SC_AccountantFindCustomer_Success_Data;
    struct SC_AccountantFindCustomer_Success;
    struct SC_AccountantFindCustomer_Failure;
    struct SC_AcountantFindCustomerDetail_Success;
    struct SC_AcountantFindCustomerDetail_Failure;
    struct SC_UserChangeIcon_Success;
    struct SC_UserChangeIcon_Failure;
    struct SC_CustomerHomePage_Success;
    struct SC_CustomerHomePage_Failure;
    struct SC_FindPushMessage_Success_Data;
    struct SC_FindPushMessage_Success;
    struct SC_FindPushMessage_Failure;
    struct SC_AccountantFindDocment_Success_Data;
    struct SC_AccountantFindDocment_Success;
    struct SC_AccountantFindDocment_Failure;
}

// enums
namespace SCPkgTypes
{
    // 会计注册
    enum class SC_Accountant_Register_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        UserNameExist = 2, // 用户名已经存在
    };
    // 用户名检测
    enum class SC_Account_Register_IsExists_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        UserNameExist = 2, // 用户名已经存在
    };
    // 会计登陆
    enum class SC_Account_Login_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        UserNameExist = 2, // 用户名不存在
        PasswordError = 3, // 密码错误
        AccountNumberlLocked = 4, // 账号被锁定
    };
    // 会计获取本人受理业务
    enum class SC_Account_GetProduct_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
    };
    // 会计更新或添加个人受理业务
    enum class SC_Product_Manage_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
    };
    // 获取会计主页个人信息
    enum class SC_Account_GetDetails_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        NotFound = 2, // 未查找到
    };
    // 公司注册
    enum class SC_Customer_Register_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        UserNameExist = 2, // 用户名已经存在
    };
    // 公司注册用户名检测
    enum class SC_Customer_Register_IsExists_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        UserNameExist = 2, // 用户名已存在
    };
    // 获取全部行业分类
    enum class SC_Industry_AllSector_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
    };
    // 公司登陆
    enum class SC_Customer_Login_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        UsernameOrPasswordError = 2, // 用户名或密码错误
        AccountNumberLocked = 3, // 账号被锁定
    };
    // 查询附近会计
    enum class SC_Acctountant_GetAround_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
    };
    // 创建订单
    enum class SC_Order_Create_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        AccountantRepeat = 2, // 不能在未完成之前对当前会计重复下单
        AcounttanOver = 3, // 当前时间已经有会计做过账
    };
    // 查询全部快递服务
    enum class SC_Express_GetAll_Failure_Type : int
    {
        ExecuteError = 0, // 数据库执行错误
    };
    // 查询未完成订单列表
    enum class SC_UncompletedOrder_GetList_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
    };
    // 查询订单明细
    enum class SC_Order_GetDetails_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
    };
    // 会计修改订单价格
    enum class SC_Order_UpdateTotal_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        ExecuteError = 1, // 数据库执行错误
        NotFindOrder = 2, // 未找到该订单
    };
    // 客户确认订单
    enum class SC_Customer_Order_Confirm_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 获取支付平台列表
    enum class SC_Get_Payment_Platform_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 客户寄送资料
    enum class SC_Customer_Deliver_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 会计接收资料确认
    enum class SC_Accountant_Receipt_Confirm_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 会计填写报表
    enum class SC_Accountant_Create_Report_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 查询月度报表
    enum class SC_Get_Report_Month_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 查询季度报表
    enum class SC_Get_Report_Quarter_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 客户对报表审核
    enum class SC_Customer_Report_Confirm_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 会计返还资料
    enum class SC_Accountant_Send_Back_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 客户接收确认，订单完成
    enum class SC_Customer_Order_Recive_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 客户退回订单至会计定价
    enum class SC_Customer_Order_Back_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 会计取消订单
    enum class SC_Accountant_Cancel_Order_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 客户取消订单
    enum class SC_Customer_Cancel_Order_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 获取会计列表
    enum class SC_Accountant_GetList_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 查询已完成订单列表
    enum class SC_CompeletedOrder_GetList_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 客户对会计服务评分
    enum class SC_Grade_AccountantService_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 会计上传证件照片
    enum class SC_AccountantCredentials_Upload_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindAccountant = 2, // 不存在该会计
    };
    // 银联支付获取交易流水号
    enum class SC_UnionPayTn_Get_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 会计上传报表文件
    enum class SC_ReportFile_Upload_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 下载报表文件
    enum class SC_ReportFile_Download_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindFile = 2, // 未找到该文件
    };
    // 删除报表文件
    enum class SC_ReportFile_Delete_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 获取某会计未完成订单列表(web版)
    enum class SC_GetAccountantUncompletedOrderList_web_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 获取会计电子名片
    enum class SC_AccountantElectronicBusinessCard_Get_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindAccountant = 2, // 未找到该会计
    };
    // 通信错误
    enum class SC_Communication_Failure_Type : int
    {
        SerializeError = 0, // 序列化错误
    };
    // 下载会计图片
    enum class SC_AccountanPictureDown_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 公司查询月度报表
    enum class SC_FindReportCustom_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该报表
    };
    // 公司上传电子财务信息
    enum class SC_Customer_UploadElectronicBill_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 不存在该客户
    };
    // 获得公司电子财务信息
    enum class SC_GetElectronicBill_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 不存在该客户
    };
    // 公司查询所有订单的进度
    enum class SC_CustomerGetOrderState_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 上传年度报表文件
    enum class SC_ReportFile_Upload_Year_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 上传季度报表文件
    enum class SC_ReportFile_Upload_Quarter_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 上传月度报表文件
    enum class SC_ReportFile_Upload_Month_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
    };
    // 下载年度报表文件
    enum class SC_ReportFile_Download_Year_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReport = 2, // 未找到该年的报表
    };
    // 下载季度报表文件
    enum class SC_ReportFile_Download_Quarter_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReport = 2, // 未找到该季度的报表
    };
    // 下载月度报表文件
    enum class SC_ReportFile_Download_Month_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReport = 2, // 未找到该月的报表
    };
    // 下载报表文件列表(订单流程内使用)
    enum class SC_ReportFileList_Download_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 下载报表文件列表(订单流程内使用)
    enum class SC_ReportFileList_Download_Success_Data_Type : int
    {
        Month = 0, // 月报表
        Quarter = 1, // 季度报表
        Year = 2, // 年报表
    };
    // 下载报表文件(订单流程内使用)
    enum class SC_ReportFileOrder_Download_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindFile = 2, // 没有找到该文件
    };
    // 地图点击获得会计详细信息
    enum class SC_CheckAccountantInformation_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindAccountant = 2, // 没有找到该会计
    };
    // 通过报表文件ID查看文件
    enum class SC_CheckReportFileFromID_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReportFile = 2, // 没有找到该报表文件
    };
    // 查看年度报表文件
    enum class SC_ReportFile_Find_Year_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReport = 2, // 未找到该年的报表
    };
    // 查看季度报表文件
    enum class SC_ReportFile_Find_Quarter_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReport = 2, // 未找到该季度的报表
    };
    // 查看月度报表文件
    enum class SC_ReportFile_Find_Month_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindReport = 2, // 未找到该月的报表
    };
    // 交易过的会计列表
    enum class SC_DealAccountantList_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 修改会计个人资料
    enum class SC_ChangeAccountantInformation_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotChangeEverything = 2, // 有未完成的订单是所有信息都不能修改
        NotFindAcountant = 3, // 没有这个用户
        NotChangeNum = 4, // 正在审核或者审核通过后不能再修改身份证号码和会计从业证号码
    };
    // 会计点击修改，获得自己的数据
    enum class SC_ReturnAccountantInformation_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindAcountant = 2, // 没有这个用户
    };
    enum class SC_AccountantHomePage_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindAcountant = 2, // 没有这个用户
    };
    // 公司匿名登录
    enum class SC_CustomerAnonymous_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 验证服务器失败
    enum class SC_Anonymous_Failure_Type : int
    {
        Failure = 0, // 验证服务器失败
    };
    // 查看会计证件照片
    enum class SC_FindAccountantCredentials_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 会计查看交易过的公司
    enum class SC_AccountantFindCustomer_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    // 会计查看交易过的某个公司明细
    enum class SC_AcountantFindCustomerDetail_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindOrder = 2, // 未找到该订单
        NotFindCustomer = 3, // 未找到改公司
    };
    // 更换头像
    enum class SC_UserChangeIcon_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
    };
    enum class SC_CustomerHomePage_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindCustomer = 2, // 没有这个公司
    };
    // 查看推送消息
    enum class SC_FindPushMessage_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindID = 2, // 没有这个客户
    };
    // 会计查看文档
    enum class SC_AccountantFindDocment_Failure_Type : int
    {
        ParamError = 0, // 参数错误
        BusinessLogicExcuteFailed = 1, // 业务逻辑执行失败
        NotFindAccountant = 2, // 没有这个会计
    };
}

// struct declares
namespace SCPkgTypes
{
    // 会计注册成功
    struct SC_Accountant_Register_Success : xxlib::Memmoveable
    {
        SC_Accountant_Register_Success(){}
        /*
         * 会计用户编号
        */
        int id = 0 ;
        /*
         * 用户的名字
        */
        xxlib::String name ;
        /*
         * 头像的地址
        */
        xxlib::String headIcon ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计注册失败
    struct SC_Accountant_Register_Failure : xxlib::Memmoveable
    {
        SC_Accountant_Register_Failure(){}
        ::SCPkgTypes::SC_Accountant_Register_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 用户名检测
    struct SC_Account_Register_IsExists_Success : xxlib::Memmoveable
    {
        SC_Account_Register_IsExists_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 用户名检测
    struct SC_Account_Register_IsExists_Failure : xxlib::Memmoveable
    {
        SC_Account_Register_IsExists_Failure(){}
        ::SCPkgTypes::SC_Account_Register_IsExists_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计登陆
    struct SC_Account_Login_Success : xxlib::Memmoveable
    {
        SC_Account_Login_Success(){}
        /*
         * 会计用户编号
        */
        int id = 0 ;
        /*
         * 用户的名字
        */
        xxlib::String name ;
        /*
         * 头像的地址
        */
        xxlib::String headIcon ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计登陆
    struct SC_Account_Login_Failure : xxlib::Memmoveable
    {
        SC_Account_Login_Failure(){}
        ::SCPkgTypes::SC_Account_Login_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计获取本人受理业务
    struct SC_Account_GetProduct_Success : xxlib::Memmoveable
    {
        SC_Account_GetProduct_Success(){}
        xxlib::List<::SCPkgTypes::SC_Account_GetProduct_Product> products ;
        xxlib::List<::SCPkgTypes::SC_Account_GetProduct_Industry> industrys ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计获取本人受理业务
    struct SC_Account_GetProduct_Product : xxlib::Memmoveable
    {
        SC_Account_GetProduct_Product(){}
        /*
         * 产品ID
        */
        int productID = 0 ;
        /*
         * 产品名称
        */
        xxlib::String productname ;
        /*
         * 用户ID
        */
        int accountantID = 0 ;
        /*
         * 创建时间
        */
        xxlib::SimpleDate createtime ;
        /*
         * 价格
        */
        double price = 0 ;
        /*
         * 擅长领域的ID集合
        */
        xxlib::List<int> industryID ;
        xxlib::String description ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计获取本人受理业务
    struct SC_Account_GetProduct_Industry : xxlib::Memmoveable
    {
        SC_Account_GetProduct_Industry(){}
        /*
         * 行业编号
        */
        int id = 0 ;
        /*
         * 行业名称
        */
        xxlib::String name ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计获取本人受理业务
    struct SC_Account_GetProduct_Failure : xxlib::Memmoveable
    {
        SC_Account_GetProduct_Failure(){}
        ::SCPkgTypes::SC_Account_GetProduct_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计更新或添加个人受理业务
    struct SC_Product_Manage_Success : xxlib::Memmoveable
    {
        SC_Product_Manage_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计更新或添加个人受理业务
    struct SC_Product_Manage_Failure : xxlib::Memmoveable
    {
        SC_Product_Manage_Failure(){}
        ::SCPkgTypes::SC_Product_Manage_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计主页个人信息
    struct SC_Account_GetDetails_ProductId : xxlib::Memmoveable
    {
        SC_Account_GetDetails_ProductId(){}
        /*
         * 产品ID
        */
        int productId = 0 ;
        /*
         * 产品名称
        */
        xxlib::String productName ;
        /*
         * 产品价格
        */
        double price = 0 ;
        /*
         * 行业
        */
        xxlib::String idustry ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计主页个人信息
    struct SC_Account_GetDetails_Success : xxlib::Memmoveable
    {
        SC_Account_GetDetails_Success(){}
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
         * 会计审核状态
        */
        xxlib::String state ;
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
         * 头像地址
        */
        xxlib::String headShot ;
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
        ::SCPkgTypes::SC_Account_GetDetails_ProductId product ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计主页个人信息
    struct SC_Account_GetDetails_Failure : xxlib::Memmoveable
    {
        SC_Account_GetDetails_Failure(){}
        ::SCPkgTypes::SC_Account_GetDetails_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司注册
    struct SC_Customer_Register_Success : xxlib::Memmoveable
    {
        SC_Customer_Register_Success(){}
        /*
         * 公司用户编号
        */
        int id = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司注册
    struct SC_Customer_Register_Failure : xxlib::Memmoveable
    {
        SC_Customer_Register_Failure(){}
        ::SCPkgTypes::SC_Customer_Register_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司注册用户名检测
    struct SC_Customer_Register_IsExists_Success : xxlib::Memmoveable
    {
        SC_Customer_Register_IsExists_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司注册用户名检测
    struct SC_Customer_Register_IsExists_Failure : xxlib::Memmoveable
    {
        SC_Customer_Register_IsExists_Failure(){}
        ::SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取全部行业分类
    struct SC_Industry_AllSector_Success : xxlib::Memmoveable
    {
        SC_Industry_AllSector_Success(){}
        xxlib::List<::SCPkgTypes::SC_Industry_AllSector_Industry> industrys ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取全部行业分类
    struct SC_Industry_AllSector_Industry : xxlib::Memmoveable
    {
        SC_Industry_AllSector_Industry(){}
        /*
         * 行业编号
        */
        int id = 0 ;
        /*
         * 行业名称
        */
        xxlib::String name ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取全部行业分类
    struct SC_Industry_AllSector_Failure : xxlib::Memmoveable
    {
        SC_Industry_AllSector_Failure(){}
        ::SCPkgTypes::SC_Industry_AllSector_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司登陆
    struct SC_Customer_Login_Success : xxlib::Memmoveable
    {
        SC_Customer_Login_Success(){}
        /*
         * 公司用户编号
        */
        int id = 0 ;
        /*
         * 公司名字
        */
        xxlib::String name ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司登陆
    struct SC_Customer_Login_Failure : xxlib::Memmoveable
    {
        SC_Customer_Login_Failure(){}
        ::SCPkgTypes::SC_Customer_Login_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询附近会计
    struct SC_Acctountant_GetAround_Success : xxlib::Memmoveable
    {
        SC_Acctountant_GetAround_Success(){}
        xxlib::List<::SCPkgTypes::SC_Acctountant_GetAround_Person> person ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询附近会计
    struct SC_Acctountant_GetAround_Person : xxlib::Memmoveable
    {
        SC_Acctountant_GetAround_Person(){}
        /*
         * 会计用户编号
        */
        int id = 0 ;
        /*
         * 会计名字
        */
        xxlib::String name ;
        /*
         * 用户认证
        */
        xxlib::String accountantAuth ;
        /*
         * 个人简介
        */
        xxlib::String introduction ;
        /*
         * 服务次数
        */
        int completeCount = 0 ;
        /*
         * 好评度
        */
        double grade = 0 ;
        /*
         * 经度
        */
        double longitude = 0 ;
        /*
         * 纬度
        */
        double latitude = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询附近会计
    struct SC_Acctountant_GetAround_Failure : xxlib::Memmoveable
    {
        SC_Acctountant_GetAround_Failure(){}
        ::SCPkgTypes::SC_Acctountant_GetAround_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 创建订单
    struct SC_Order_Create_Success : xxlib::Memmoveable
    {
        SC_Order_Create_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 创建订单
    struct SC_Order_Create_Failure : xxlib::Memmoveable
    {
        SC_Order_Create_Failure(){}
        ::SCPkgTypes::SC_Order_Create_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询全部快递服务
    struct SC_Express_GetAll_Success : xxlib::Memmoveable
    {
        SC_Express_GetAll_Success(){}
        xxlib::List<::SCPkgTypes::SC_Express_GetAll_Date> person ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询全部快递服务
    struct SC_Express_GetAll_Date : xxlib::Memmoveable
    {
        SC_Express_GetAll_Date(){}
        /*
         * 快递平台ID
        */
        int productId = 0 ;
        /*
         * 快递平台名称
        */
        xxlib::String productName ;
        /*
         * 快递价格
        */
        double price = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询全部快递服务
    struct SC_Express_GetAll_Failure : xxlib::Memmoveable
    {
        SC_Express_GetAll_Failure(){}
        ::SCPkgTypes::SC_Express_GetAll_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询未完成订单列表
    struct SC_UncompletedOrder_GetList_Success : xxlib::Memmoveable
    {
        SC_UncompletedOrder_GetList_Success(){}
        xxlib::List<::SCPkgTypes::SC_UncompletedOrder_GetList_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询未完成订单列表
    struct SC_UncompletedOrder_GetList_Data : xxlib::Memmoveable
    {
        SC_UncompletedOrder_GetList_Data(){}
        /*
         * 订单ID
        */
        xxlib::String orderId ;
        /*
         * 公司名称
        */
        xxlib::String name ;
        /*
         * 订单创建时间
        */
        xxlib::SimpleDate orderDate ;
        /*
         * 订单当前状态
        */
        int stateCode = 0 ;
        /*
         * 订单价格
        */
        double total = 0 ;
        /*
         * 用户看见的订单ID号
        */
        xxlib::String idView ;
        /*
         * 子订单SubOrder表自带的自增字段用于排序
        */
        int number = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询未完成订单列表
    struct SC_UncompletedOrder_GetList_Failure : xxlib::Memmoveable
    {
        SC_UncompletedOrder_GetList_Failure(){}
        ::SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询订单明细
    struct SC_Order_GetDetails_Success : xxlib::Memmoveable
    {
        SC_Order_GetDetails_Success(){}
        /*
         * 订单编号
        */
        xxlib::String orderID ;
        /*
         * 公司名称
        */
        xxlib::String companyName ;
        /*
         * 公司所属行业
        */
        xxlib::String companyType ;
        /*
         * 纳税资质
        */
        xxlib::String taxQualification ;
        /*
         * 公司地址
        */
        xxlib::String companyAdress ;
        /*
         * 公司联系人
        */
        xxlib::String contact ;
        /*
         * 公司电话
        */
        xxlib::String customerPhone ;
        /*
         * 会计姓名
        */
        xxlib::String accountantName ;
        /*
         * 会计电话
        */
        xxlib::String accountantPhone ;
        /*
         * 会计收件地址
        */
        xxlib::String accountantAdress ;
        /*
         * 订单数量
        */
        int count = 0 ;
        /*
         * 订单金额
        */
        double total = 0 ;
        /*
         * 创建订单时间
        */
        xxlib::SimpleDate createTime ;
        /*
         * 订单执行时间
        */
        xxlib::SimpleDate startTime ;
        /*
         * 订单结束时间
        */
        xxlib::SimpleDate endTime ;
        /*
         * 订单周期
        */
        int cycle = 0 ;
        /*
         * 状态码
        */
        int stateCode = 0 ;
        /*
         * 订单备注
        */
        xxlib::String remark ;
        /*
         * 用于显示的字符串为某些字段的拼接
        */
        xxlib::String idView ;
        /*
         * 产品列表
        */
        xxlib::String product ;
        /*
         * 快递回执编号
        */
        xxlib::String expressNumber ;
        /*
         * 快递客服电话
        */
        xxlib::String expressTel ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询订单明细
    struct SC_Order_GetDetails_Failure : xxlib::Memmoveable
    {
        SC_Order_GetDetails_Failure(){}
        ::SCPkgTypes::SC_Order_GetDetails_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计修改订单价格
    struct SC_Order_UpdateTotal_Success : xxlib::Memmoveable
    {
        SC_Order_UpdateTotal_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计修改订单价格
    struct SC_Order_UpdateTotal_Failure : xxlib::Memmoveable
    {
        SC_Order_UpdateTotal_Failure(){}
        ::SCPkgTypes::SC_Order_UpdateTotal_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户确认订单
    struct SC_Customer_Order_Confirm_Success : xxlib::Memmoveable
    {
        SC_Customer_Order_Confirm_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户确认订单
    struct SC_Customer_Order_Confirm_Failure : xxlib::Memmoveable
    {
        SC_Customer_Order_Confirm_Failure(){}
        ::SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取支付平台列表
    struct SC_Get_Payment_Platform_Success : xxlib::Memmoveable
    {
        SC_Get_Payment_Platform_Success(){}
        xxlib::List<::SCPkgTypes::SC_Get_Payment_Platform_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取支付平台列表
    struct SC_Get_Payment_Platform_Data : xxlib::Memmoveable
    {
        SC_Get_Payment_Platform_Data(){}
        /*
         * 支付平台编号
        */
        int id = 0 ;
        /*
         * 支付平台名称
        */
        xxlib::String name ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取支付平台列表
    struct SC_Get_Payment_Platform_Failure : xxlib::Memmoveable
    {
        SC_Get_Payment_Platform_Failure(){}
        ::SCPkgTypes::SC_Get_Payment_Platform_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户寄送资料
    struct SC_Customer_Deliver_Success : xxlib::Memmoveable
    {
        SC_Customer_Deliver_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户寄送资料
    struct SC_Customer_Deliver_Failure : xxlib::Memmoveable
    {
        SC_Customer_Deliver_Failure(){}
        ::SCPkgTypes::SC_Customer_Deliver_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计接收资料确认
    struct SC_Accountant_Receipt_Confirm_Success : xxlib::Memmoveable
    {
        SC_Accountant_Receipt_Confirm_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计接收资料确认
    struct SC_Accountant_Receipt_Confirm_Failure : xxlib::Memmoveable
    {
        SC_Accountant_Receipt_Confirm_Failure(){}
        ::SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计填写报表
    struct SC_Accountant_Create_Report_Success : xxlib::Memmoveable
    {
        SC_Accountant_Create_Report_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计填写报表
    struct SC_Accountant_Create_Report_Failure : xxlib::Memmoveable
    {
        SC_Accountant_Create_Report_Failure(){}
        ::SCPkgTypes::SC_Accountant_Create_Report_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询月度报表
    struct SC_Get_Report_Month_Success : xxlib::Memmoveable
    {
        SC_Get_Report_Month_Success(){}
        /*
         * 订单编号
        */
        double national_tax_total = 0 ;
        /*
         * 订单编号
        */
        double land_tax_total = 0 ;
        /*
         * 订单编号
        */
        double non_tax_income_total = 0 ;
        /*
         * 订单编号
        */
        xxlib::String national_tax ;
        /*
         * 订单编号
        */
        xxlib::String land_tax ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询月度报表
    struct SC_Get_Report_Month_Failure : xxlib::Memmoveable
    {
        SC_Get_Report_Month_Failure(){}
        ::SCPkgTypes::SC_Get_Report_Month_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询季度报表
    struct SC_Get_Report_Quarter_Success : xxlib::Memmoveable
    {
        SC_Get_Report_Quarter_Success(){}
        /*
         * 订单编号
        */
        double national_tax_total = 0 ;
        /*
         * 订单编号
        */
        double land_tax_total = 0 ;
        /*
         * 订单编号
        */
        double non_tax_income_total = 0 ;
        /*
         * 订单编号
        */
        xxlib::String national_tax ;
        /*
         * 订单编号
        */
        xxlib::String land_tax ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询季度报表
    struct SC_Get_Report_Quarter_Failure : xxlib::Memmoveable
    {
        SC_Get_Report_Quarter_Failure(){}
        ::SCPkgTypes::SC_Get_Report_Quarter_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户对报表审核
    struct SC_Customer_Report_Confirm_Success : xxlib::Memmoveable
    {
        SC_Customer_Report_Confirm_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户对报表审核
    struct SC_Customer_Report_Confirm_Failure : xxlib::Memmoveable
    {
        SC_Customer_Report_Confirm_Failure(){}
        ::SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计返还资料
    struct SC_Accountant_Send_Back_Success : xxlib::Memmoveable
    {
        SC_Accountant_Send_Back_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计返还资料
    struct SC_Accountant_Send_Back_Failure : xxlib::Memmoveable
    {
        SC_Accountant_Send_Back_Failure(){}
        ::SCPkgTypes::SC_Accountant_Send_Back_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户接收确认，订单完成
    struct SC_Customer_Order_Recive_Success : xxlib::Memmoveable
    {
        SC_Customer_Order_Recive_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户接收确认，订单完成
    struct SC_Customer_Order_Recive_Failure : xxlib::Memmoveable
    {
        SC_Customer_Order_Recive_Failure(){}
        ::SCPkgTypes::SC_Customer_Order_Recive_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户退回订单至会计定价
    struct SC_Customer_Order_Back_Success : xxlib::Memmoveable
    {
        SC_Customer_Order_Back_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户退回订单至会计定价
    struct SC_Customer_Order_Back_Failure : xxlib::Memmoveable
    {
        SC_Customer_Order_Back_Failure(){}
        ::SCPkgTypes::SC_Customer_Order_Back_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计取消订单
    struct SC_Accountant_Cancel_Order_Success : xxlib::Memmoveable
    {
        SC_Accountant_Cancel_Order_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计取消订单
    struct SC_Accountant_Cancel_Order_Failure : xxlib::Memmoveable
    {
        SC_Accountant_Cancel_Order_Failure(){}
        ::SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户取消订单
    struct SC_Customer_Cancel_Order_Success : xxlib::Memmoveable
    {
        SC_Customer_Cancel_Order_Success(){}
        bool isPushSuccess = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户取消订单
    struct SC_Customer_Cancel_Order_Failure : xxlib::Memmoveable
    {
        SC_Customer_Cancel_Order_Failure(){}
        ::SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计列表
    struct SC_Accountant_GetList_Success : xxlib::Memmoveable
    {
        SC_Accountant_GetList_Success(){}
        xxlib::List<::SCPkgTypes::SC_Accountant_GetList_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计列表
    struct SC_Accountant_GetList_Data : xxlib::Memmoveable
    {
        SC_Accountant_GetList_Data(){}
        /*
         * 编号
        */
        int id = 0 ;
        /*
         * 名字
        */
        xxlib::String name ;
        /*
         * 电话号码
        */
        xxlib::String phone ;
        /*
         * 头像
        */
        xxlib::String headShot ;
        /*
         * 完成订单数量
        */
        int completedorder = 0 ;
        /*
         * 行业
        */
        xxlib::String industry ;
        /*
         * 产品名称
        */
        xxlib::String productname ;
        /*
         * 产品ID
        */
        int productID = 0 ;
        /*
         * 价格
        */
        double price = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计列表
    struct SC_Accountant_GetList_Failure : xxlib::Memmoveable
    {
        SC_Accountant_GetList_Failure(){}
        ::SCPkgTypes::SC_Accountant_GetList_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询已完成订单列表
    struct SC_CompeletedOrder_GetList_Success : xxlib::Memmoveable
    {
        SC_CompeletedOrder_GetList_Success(){}
        xxlib::List<::SCPkgTypes::SC_CompeletedOrder_GetList_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询已完成订单列表
    struct SC_CompeletedOrder_GetList_Data : xxlib::Memmoveable
    {
        SC_CompeletedOrder_GetList_Data(){}
        /*
         * 订单ID
        */
        xxlib::String orderId ;
        /*
         * 公司名字
        */
        xxlib::String name ;
        /*
         * 订单创建时间
        */
        xxlib::SimpleDate orderDate ;
        /*
         * 订单状态
        */
        int stateCode = 0 ;
        /*
         * 价格
        */
        double total = 0 ;
        /*
         * 用户看见的订单ID号
        */
        xxlib::String idView ;
        /*
         * 子订单数据表自增主键ID
        */
        int number = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查询已完成订单列表
    struct SC_CompeletedOrder_GetList_Failure : xxlib::Memmoveable
    {
        SC_CompeletedOrder_GetList_Failure(){}
        ::SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户对会计服务评分
    struct SC_Grade_AccountantService_Success : xxlib::Memmoveable
    {
        SC_Grade_AccountantService_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 客户对会计服务评分
    struct SC_Grade_AccountantService_Failure : xxlib::Memmoveable
    {
        SC_Grade_AccountantService_Failure(){}
        ::SCPkgTypes::SC_Grade_AccountantService_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计上传证件照片
    struct SC_AccountantCredentials_Upload_Success : xxlib::Memmoveable
    {
        SC_AccountantCredentials_Upload_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计上传证件照片
    struct SC_AccountantCredentials_Upload_Failure : xxlib::Memmoveable
    {
        SC_AccountantCredentials_Upload_Failure(){}
        ::SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 银联支付获取交易流水号
    struct SC_UnionPayTn_Get_Success : xxlib::Memmoveable
    {
        SC_UnionPayTn_Get_Success(){}
        /*
         * 流水号
        */
        xxlib::String tn ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 银联支付获取交易流水号
    struct SC_UnionPayTn_Get_Failure : xxlib::Memmoveable
    {
        SC_UnionPayTn_Get_Failure(){}
        ::SCPkgTypes::SC_UnionPayTn_Get_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计上传报表文件
    struct SC_ReportFile_Upload_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计上传报表文件
    struct SC_ReportFile_Upload_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Upload_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件
    struct SC_ReportFile_Download_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Success(){}
        /*
         * 文件内容,必须base64编码
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件
    struct SC_ReportFile_Download_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Download_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 删除报表文件
    struct SC_ReportFile_Delete_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Delete_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 删除报表文件
    struct SC_ReportFile_Delete_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Delete_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Delete_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取某会计未完成订单列表(web版)
    struct SC_GetAccountantUncompletedOrderList_web_Success : xxlib::Memmoveable
    {
        SC_GetAccountantUncompletedOrderList_web_Success(){}
        xxlib::List<::SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取某会计未完成订单列表(web版)
    struct SC_GetAccountantUncompletedOrderList_web_file_info : xxlib::Memmoveable
    {
        SC_GetAccountantUncompletedOrderList_web_file_info(){}
        int file_id = 0 ;
        xxlib::String file_name ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取某会计未完成订单列表(web版)
    struct SC_GetAccountantUncompletedOrderList_web_Data : xxlib::Memmoveable
    {
        SC_GetAccountantUncompletedOrderList_web_Data(){}
        /*
         * 订单id
        */
        xxlib::String orderID ;
        /*
         * 公司ID
        */
        int customerID = 0 ;
        /*
         * 公司名字
        */
        xxlib::String companyName ;
        /*
         * 订单创建时间
        */
        xxlib::SimpleDate orderDate ;
        /*
         * 订单开始时间
        */
        xxlib::SimpleDate orderStartDate ;
        /*
         * 订单状态
        */
        int stateCode = 0 ;
        /*
         * 订单价格
        */
        double total = 0 ;
        /*
         * 用户看的见得订单号
        */
        xxlib::String iDView ;
        /*
         * 订单自增号
        */
        int number = 0 ;
        /*
         * 文件信息列表
        */
        xxlib::List<::SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_file_info> file_info_list ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取某会计未完成订单列表(web版)
    struct SC_GetAccountantUncompletedOrderList_web_Failure : xxlib::Memmoveable
    {
        SC_GetAccountantUncompletedOrderList_web_Failure(){}
        ::SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计电子名片
    struct SC_AccountantElectronicBusinessCard_Get_Success : xxlib::Memmoveable
    {
        SC_AccountantElectronicBusinessCard_Get_Success(){}
        /*
         * 完成订单数
        */
        int completedOrder = 0 ;
        /*
         * 会计名字
        */
        xxlib::String name ;
        /*
         * 会计排名
        */
        int rank = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获取会计电子名片
    struct SC_AccountantElectronicBusinessCard_Get_Failure : xxlib::Memmoveable
    {
        SC_AccountantElectronicBusinessCard_Get_Failure(){}
        ::SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 通信错误
    struct SC_Communication_Failure : xxlib::Memmoveable
    {
        SC_Communication_Failure(){}
        ::SCPkgTypes::SC_Communication_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载会计图片
    struct SC_AccountanPictureDown_Success_Data : xxlib::Memmoveable
    {
        SC_AccountanPictureDown_Success_Data(){}
        /*
         * 图片内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 图片类型的名称
        */
        xxlib::String picName ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载会计图片
    struct SC_AccountanPictureDown_Success : xxlib::Memmoveable
    {
        SC_AccountanPictureDown_Success(){}
        xxlib::List<::SCPkgTypes::SC_AccountanPictureDown_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载会计图片
    struct SC_AccountanPictureDown_Failure : xxlib::Memmoveable
    {
        SC_AccountanPictureDown_Failure(){}
        ::SCPkgTypes::SC_AccountanPictureDown_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询月度报表
    struct SC_FindReportCustom_Success_Data : xxlib::Memmoveable
    {
        SC_FindReportCustom_Success_Data(){}
        /*
         * 产品名称
        */
        xxlib::String productName ;
        /*
         * 产品名称
        */
        xxlib::String customerName ;
        /*
         * 订单编号
        */
        double national_tax_total = 0 ;
        /*
         * 订单编号
        */
        double land_tax_total = 0 ;
        /*
         * 订单编号
        */
        double non_tax_income_total = 0 ;
        /*
         * 订单编号
        */
        xxlib::String national_tax ;
        /*
         * 订单编号
        */
        xxlib::String land_tax ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询月度报表
    struct SC_FindReportCustom_Success : xxlib::Memmoveable
    {
        SC_FindReportCustom_Success(){}
        xxlib::List<::SCPkgTypes::SC_FindReportCustom_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询月度报表
    struct SC_FindReportCustom_Failure : xxlib::Memmoveable
    {
        SC_FindReportCustom_Failure(){}
        ::SCPkgTypes::SC_FindReportCustom_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司上传电子财务信息
    struct SC_Customer_UploadElectronicBill_Success : xxlib::Memmoveable
    {
        SC_Customer_UploadElectronicBill_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司上传电子财务信息
    struct SC_Customer_UploadElectronicBill_Failure : xxlib::Memmoveable
    {
        SC_Customer_UploadElectronicBill_Failure(){}
        ::SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获得公司电子财务信息
    struct SC_GetElectronicBill_Success_Data : xxlib::Memmoveable
    {
        SC_GetElectronicBill_Success_Data(){}
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获得公司电子财务信息
    struct SC_GetElectronicBill_Success : xxlib::Memmoveable
    {
        SC_GetElectronicBill_Success(){}
        xxlib::List<::SCPkgTypes::SC_GetElectronicBill_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 获得公司电子财务信息
    struct SC_GetElectronicBill_Failure : xxlib::Memmoveable
    {
        SC_GetElectronicBill_Failure(){}
        ::SCPkgTypes::SC_GetElectronicBill_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询所有订单的进度
    struct SC_CustomerGetOrderState_Success_Data : xxlib::Memmoveable
    {
        SC_CustomerGetOrderState_Success_Data(){}
        /*
         * 下哪个月单时间
        */
        xxlib::SimpleDate startTime ;
        /*
         * 订单IdView编号
        */
        xxlib::String idView ;
        /*
         * 订单状态
        */
        int stateCode = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询所有订单的进度
    struct SC_CustomerGetOrderState_Success : xxlib::Memmoveable
    {
        SC_CustomerGetOrderState_Success(){}
        xxlib::List<::SCPkgTypes::SC_CustomerGetOrderState_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司查询所有订单的进度
    struct SC_CustomerGetOrderState_Failure : xxlib::Memmoveable
    {
        SC_CustomerGetOrderState_Failure(){}
        ::SCPkgTypes::SC_CustomerGetOrderState_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传年度报表文件
    struct SC_ReportFile_Upload_Year_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Year_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传年度报表文件
    struct SC_ReportFile_Upload_Year_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Year_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传季度报表文件
    struct SC_ReportFile_Upload_Quarter_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Quarter_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传季度报表文件
    struct SC_ReportFile_Upload_Quarter_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Quarter_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传月度报表文件
    struct SC_ReportFile_Upload_Month_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Month_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 上传月度报表文件
    struct SC_ReportFile_Upload_Month_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Upload_Month_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载年度报表文件
    struct SC_ReportFile_Download_Year_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Year_Success(){}
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载年度报表文件
    struct SC_ReportFile_Download_Year_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Year_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载季度报表文件
    struct SC_ReportFile_Download_Quarter_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Quarter_Success(){}
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载季度报表文件
    struct SC_ReportFile_Download_Quarter_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Quarter_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载月度报表文件
    struct SC_ReportFile_Download_Month_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Month_Success(){}
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载月度报表文件
    struct SC_ReportFile_Download_Month_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Download_Month_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件列表(订单流程内使用)
    struct SC_ReportFileList_Download_Success_Data : xxlib::Memmoveable
    {
        SC_ReportFileList_Download_Success_Data(){}
        ::SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type dataType ;
        int number = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件列表(订单流程内使用)
    struct SC_ReportFileList_Download_Success : xxlib::Memmoveable
    {
        SC_ReportFileList_Download_Success(){}
        xxlib::List<::SCPkgTypes::SC_ReportFileList_Download_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件列表(订单流程内使用)
    struct SC_ReportFileList_Download_Failure : xxlib::Memmoveable
    {
        SC_ReportFileList_Download_Failure(){}
        ::SCPkgTypes::SC_ReportFileList_Download_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件(订单流程内使用)
    struct SC_ReportFileOrder_Download_Success : xxlib::Memmoveable
    {
        SC_ReportFileOrder_Download_Success(){}
        /*
         * 图片名称
        */
        xxlib::String fileName ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        /*
         * 报表类型1->年度报表,2->季度报表,3->月度报表
        */
        int fileType = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 下载报表文件(订单流程内使用)
    struct SC_ReportFileOrder_Download_Failure : xxlib::Memmoveable
    {
        SC_ReportFileOrder_Download_Failure(){}
        ::SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 地图点击获得会计详细信息
    struct SC_CheckAccountantInformation_Success_Data : xxlib::Memmoveable
    {
        SC_CheckAccountantInformation_Success_Data(){}
        /*
         * 证书名称
        */
        xxlib::String credentialName ;
        /*
         * 证书是否经过认证
        */
        bool isAuth = false ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 地图点击获得会计详细信息
    struct SC_CheckAccountantInformation_Success : xxlib::Memmoveable
    {
        SC_CheckAccountantInformation_Success(){}
        /*
         * 姓名
        */
        xxlib::String name ;
        /*
         * 性别
        */
        xxlib::String gender ;
        /*
         * 用户认证
        */
        xxlib::String accountantAuth ;
        /*
         * 个人简介
        */
        xxlib::String introduction ;
        /*
         * 服务次数
        */
        int completeCount = 0 ;
        /*
         * 好评度
        */
        double grade = 0 ;
        /*
         * 擅长领域
        */
        xxlib::List<int> industryID ;
        /*
         * 专业证书
        */
        xxlib::List<::SCPkgTypes::SC_CheckAccountantInformation_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 地图点击获得会计详细信息
    struct SC_CheckAccountantInformation_Failure : xxlib::Memmoveable
    {
        SC_CheckAccountantInformation_Failure(){}
        ::SCPkgTypes::SC_CheckAccountantInformation_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 通过报表文件ID查看文件
    struct SC_CheckReportFileFromID_Success : xxlib::Memmoveable
    {
        SC_CheckReportFileFromID_Success(){}
        /*
         * url地址
        */
        xxlib::String name ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 通过报表文件ID查看文件
    struct SC_CheckReportFileFromID_Failure : xxlib::Memmoveable
    {
        SC_CheckReportFileFromID_Failure(){}
        ::SCPkgTypes::SC_CheckReportFileFromID_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看年度报表文件
    struct SC_ReportFile_Find_Year_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Find_Year_Success(){}
        /*
         * 报表文件id
        */
        int fileID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看年度报表文件
    struct SC_ReportFile_Find_Year_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Find_Year_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看季度报表文件
    struct SC_ReportFile_Find_Quarter_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Find_Quarter_Success(){}
        /*
         * 报表文件id
        */
        int fileID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看季度报表文件
    struct SC_ReportFile_Find_Quarter_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Find_Quarter_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看月度报表文件
    struct SC_ReportFile_Find_Month_Success : xxlib::Memmoveable
    {
        SC_ReportFile_Find_Month_Success(){}
        /*
         * 报表文件id
        */
        int fileID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看月度报表文件
    struct SC_ReportFile_Find_Month_Failure : xxlib::Memmoveable
    {
        SC_ReportFile_Find_Month_Failure(){}
        ::SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 交易过的会计列表
    struct SC_DealAccountantList_Success : xxlib::Memmoveable
    {
        SC_DealAccountantList_Success(){}
        xxlib::List<::SCPkgTypes::SC_DealAccountantList_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 交易过的会计列表
    struct SC_DealAccountantList_Data : xxlib::Memmoveable
    {
        SC_DealAccountantList_Data(){}
        /*
         * 编号
        */
        int id = 0 ;
        /*
         * 名字
        */
        xxlib::String name ;
        /*
         * 电话号码
        */
        xxlib::String phone ;
        /*
         * 头像
        */
        xxlib::String headShot ;
        /*
         * 完成订单数量
        */
        int completedorder = 0 ;
        /*
         * 行业
        */
        xxlib::String industry ;
        /*
         * 产品名称
        */
        xxlib::String productname ;
        /*
         * 产品ID
        */
        int productID = 0 ;
        /*
         * 价格
        */
        double price = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 交易过的会计列表
    struct SC_DealAccountantList_Failure : xxlib::Memmoveable
    {
        SC_DealAccountantList_Failure(){}
        ::SCPkgTypes::SC_DealAccountantList_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 修改会计个人资料
    struct SC_ChangeAccountantInformation_Success : xxlib::Memmoveable
    {
        SC_ChangeAccountantInformation_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 修改会计个人资料
    struct SC_ChangeAccountantInformation_Failure : xxlib::Memmoveable
    {
        SC_ChangeAccountantInformation_Failure(){}
        ::SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计点击修改，获得自己的数据
    struct SC_ReturnAccountantInformation_Success : xxlib::Memmoveable
    {
        SC_ReturnAccountantInformation_Success(){}
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
        /*
         * 状态
        */
        xxlib::String state ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计点击修改，获得自己的数据
    struct SC_ReturnAccountantInformation_Failure : xxlib::Memmoveable
    {
        SC_ReturnAccountantInformation_Failure(){}
        ::SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计首页
    struct SC_AccountantHomePage_Success : xxlib::Memmoveable
    {
        SC_AccountantHomePage_Success(){}
        /*
         * 姓名
        */
        xxlib::String name ;
        /*
         * 性别
        */
        xxlib::String gender ;
        /*
         * 今日订单
        */
        int todayOrderNum = 0 ;
        /*
         * 今日浏览量
        */
        int todayPageView = 0 ;
        /*
         * 会计头像
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计首页
    struct SC_AccountantHomePage_Failure : xxlib::Memmoveable
    {
        SC_AccountantHomePage_Failure(){}
        ::SCPkgTypes::SC_AccountantHomePage_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司匿名登录
    struct SC_CustomerAnonymous_Success : xxlib::Memmoveable
    {
        SC_CustomerAnonymous_Success(){}
        /*
         * 令牌
        */
        xxlib::String token ;
        /*
         * 公司ID
        */
        int id = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司匿名登录
    struct SC_CustomerAnonymous_Failure : xxlib::Memmoveable
    {
        SC_CustomerAnonymous_Failure(){}
        ::SCPkgTypes::SC_CustomerAnonymous_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 验证服务器失败
    struct SC_Anonymous_Failure : xxlib::Memmoveable
    {
        SC_Anonymous_Failure(){}
        ::SCPkgTypes::SC_Anonymous_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看会计证件照片
    struct SC_FindAccountantCredentials_Success_Data : xxlib::Memmoveable
    {
        SC_FindAccountantCredentials_Success_Data(){}
        /*
         * 文件名
        */
        xxlib::String fileName ;
        /*
         * 文件类型
        */
        int fileType = 0 ;
        /*
         * 内容
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看会计证件照片
    struct SC_FindAccountantCredentials_Success : xxlib::Memmoveable
    {
        SC_FindAccountantCredentials_Success(){}
        xxlib::List<::SCPkgTypes::SC_FindAccountantCredentials_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看会计证件照片
    struct SC_FindAccountantCredentials_Failure : xxlib::Memmoveable
    {
        SC_FindAccountantCredentials_Failure(){}
        ::SCPkgTypes::SC_FindAccountantCredentials_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的公司
    struct SC_AccountantFindCustomer_Success_Data : xxlib::Memmoveable
    {
        SC_AccountantFindCustomer_Success_Data(){}
        /*
         * 公司名称
        */
        xxlib::String customerName ;
        /*
         * 纳税资质
        */
        xxlib::String taxQualification ;
        /*
         * 公司ID
        */
        int customerID = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的公司
    struct SC_AccountantFindCustomer_Success : xxlib::Memmoveable
    {
        SC_AccountantFindCustomer_Success(){}
        xxlib::List<::SCPkgTypes::SC_AccountantFindCustomer_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的公司
    struct SC_AccountantFindCustomer_Failure : xxlib::Memmoveable
    {
        SC_AccountantFindCustomer_Failure(){}
        ::SCPkgTypes::SC_AccountantFindCustomer_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的某个公司明细
    struct SC_AcountantFindCustomerDetail_Success : xxlib::Memmoveable
    {
        SC_AcountantFindCustomerDetail_Success(){}
        /*
         * 公司名称
        */
        xxlib::String customerName ;
        /*
         * 公司地址
        */
        xxlib::String customerAddress ;
        /*
         * 公司类型
        */
        xxlib::String customerType ;
        /*
         * 公司邮件地址
        */
        xxlib::String customerEmail ;
        /*
         * 公司纳税资质
        */
        xxlib::String customerQualification ;
        /*
         * 合作次数
        */
        int count = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看交易过的某个公司明细
    struct SC_AcountantFindCustomerDetail_Failure : xxlib::Memmoveable
    {
        SC_AcountantFindCustomerDetail_Failure(){}
        ::SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计更换头像
    struct SC_UserChangeIcon_Success : xxlib::Memmoveable
    {
        SC_UserChangeIcon_Success(){}
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 更换头像
    struct SC_UserChangeIcon_Failure : xxlib::Memmoveable
    {
        SC_UserChangeIcon_Failure(){}
        ::SCPkgTypes::SC_UserChangeIcon_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司主页
    struct SC_CustomerHomePage_Success : xxlib::Memmoveable
    {
        SC_CustomerHomePage_Success(){}
        /*
         * 公司名称
        */
        xxlib::String customerName ;
        /*
         * 公司头像
        */
        xxlib::ByteBuffer fileContent ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 公司主页
    struct SC_CustomerHomePage_Failure : xxlib::Memmoveable
    {
        SC_CustomerHomePage_Failure(){}
        ::SCPkgTypes::SC_CustomerHomePage_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看推送消息
    struct SC_FindPushMessage_Success_Data : xxlib::Memmoveable
    {
        SC_FindPushMessage_Success_Data(){}
        /*
         * 推送内容
        */
        xxlib::String pushHint ;
        /*
         * 公司地址
        */
        xxlib::SimpleDate pushTime ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看推送消息
    struct SC_FindPushMessage_Success : xxlib::Memmoveable
    {
        SC_FindPushMessage_Success(){}
        xxlib::List<::SCPkgTypes::SC_FindPushMessage_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 查看推送消息
    struct SC_FindPushMessage_Failure : xxlib::Memmoveable
    {
        SC_FindPushMessage_Failure(){}
        ::SCPkgTypes::SC_FindPushMessage_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看文档
    struct SC_AccountantFindDocment_Success_Data : xxlib::Memmoveable
    {
        SC_AccountantFindDocment_Success_Data(){}
        /*
         * 公司名称
        */
        xxlib::String customerName ;
        /*
         * 报表类型
        */
        int typeId = 0 ;
        /*
         * 年
        */
        int year = 0 ;
        /*
         * 季度
        */
        int quarter = 0 ;
        /*
         * 月
        */
        int month = 0 ;
        /*
         * 文件ID
        */
        int fileId = 0 ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看文档
    struct SC_AccountantFindDocment_Success : xxlib::Memmoveable
    {
        SC_AccountantFindDocment_Success(){}
        xxlib::List<::SCPkgTypes::SC_AccountantFindDocment_Success_Data> data ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
    // 会计查看文档
    struct SC_AccountantFindDocment_Failure : xxlib::Memmoveable
    {
        SC_AccountantFindDocment_Failure(){}
        ::SCPkgTypes::SC_AccountantFindDocment_Failure_Type type ;
        const static short commandType; 

        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );
    };
}
#endif
