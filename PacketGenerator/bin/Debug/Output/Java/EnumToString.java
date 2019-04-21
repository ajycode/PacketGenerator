
public class EnumToString
{
    public static string Get(SC_Accountant_Register_Failure_Type e )
    {
        switch(e)
        {
            case SC_Accountant_Register_Failure_Type.ParamError: 
                return "SC_Accountant_Register_Failure_Type.ParamError 参数错误";
            case SC_Accountant_Register_Failure_Type.ExecuteError: 
                return "SC_Accountant_Register_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Accountant_Register_Failure_Type.UserNameExist: 
                return "SC_Accountant_Register_Failure_Type.UserNameExist 用户名已经存在";
        }
    }
    public static string Get(SC_Account_Register_IsExists_Failure_Type e )
    {
        switch(e)
        {
            case SC_Account_Register_IsExists_Failure_Type.ParamError: 
                return "SC_Account_Register_IsExists_Failure_Type.ParamError 参数错误";
            case SC_Account_Register_IsExists_Failure_Type.ExecuteError: 
                return "SC_Account_Register_IsExists_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Account_Register_IsExists_Failure_Type.UserNameExist: 
                return "SC_Account_Register_IsExists_Failure_Type.UserNameExist 用户名已经存在";
        }
    }
    public static string Get(SC_Account_Login_Failure_Type e )
    {
        switch(e)
        {
            case SC_Account_Login_Failure_Type.ParamError: 
                return "SC_Account_Login_Failure_Type.ParamError 参数错误";
            case SC_Account_Login_Failure_Type.ExecuteError: 
                return "SC_Account_Login_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Account_Login_Failure_Type.UserNameExist: 
                return "SC_Account_Login_Failure_Type.UserNameExist 用户名不存在";
            case SC_Account_Login_Failure_Type.PasswordError: 
                return "SC_Account_Login_Failure_Type.PasswordError 密码错误";
            case SC_Account_Login_Failure_Type.AccountNumberlLocked: 
                return "SC_Account_Login_Failure_Type.AccountNumberlLocked 账号被锁定";
        }
    }
    public static string Get(SC_Account_GetProduct_Failure_Type e )
    {
        switch(e)
        {
            case SC_Account_GetProduct_Failure_Type.ParamError: 
                return "SC_Account_GetProduct_Failure_Type.ParamError 参数错误";
            case SC_Account_GetProduct_Failure_Type.ExecuteError: 
                return "SC_Account_GetProduct_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_Product_Manage_Failure_Type e )
    {
        switch(e)
        {
            case SC_Product_Manage_Failure_Type.ParamError: 
                return "SC_Product_Manage_Failure_Type.ParamError 参数错误";
            case SC_Product_Manage_Failure_Type.ExecuteError: 
                return "SC_Product_Manage_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_Account_GetDetails_Failure_Type e )
    {
        switch(e)
        {
            case SC_Account_GetDetails_Failure_Type.ParamError: 
                return "SC_Account_GetDetails_Failure_Type.ParamError 参数错误";
            case SC_Account_GetDetails_Failure_Type.ExecuteError: 
                return "SC_Account_GetDetails_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Account_GetDetails_Failure_Type.NotFound: 
                return "SC_Account_GetDetails_Failure_Type.NotFound 未查找到";
        }
    }
    public static string Get(SC_Customer_Register_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Register_Failure_Type.ParamError: 
                return "SC_Customer_Register_Failure_Type.ParamError 参数错误";
            case SC_Customer_Register_Failure_Type.ExecuteError: 
                return "SC_Customer_Register_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Customer_Register_Failure_Type.UserNameExist: 
                return "SC_Customer_Register_Failure_Type.UserNameExist 用户名已经存在";
        }
    }
    public static string Get(SC_Customer_Register_IsExists_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Register_IsExists_Failure_Type.ParamError: 
                return "SC_Customer_Register_IsExists_Failure_Type.ParamError 参数错误";
            case SC_Customer_Register_IsExists_Failure_Type.ExecuteError: 
                return "SC_Customer_Register_IsExists_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Customer_Register_IsExists_Failure_Type.UserNameExist: 
                return "SC_Customer_Register_IsExists_Failure_Type.UserNameExist 用户名已存在";
        }
    }
    public static string Get(SC_Industry_AllSector_Failure_Type e )
    {
        switch(e)
        {
            case SC_Industry_AllSector_Failure_Type.ParamError: 
                return "SC_Industry_AllSector_Failure_Type.ParamError 参数错误";
            case SC_Industry_AllSector_Failure_Type.ExecuteError: 
                return "SC_Industry_AllSector_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_Customer_Login_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Login_Failure_Type.ParamError: 
                return "SC_Customer_Login_Failure_Type.ParamError 参数错误";
            case SC_Customer_Login_Failure_Type.ExecuteError: 
                return "SC_Customer_Login_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Customer_Login_Failure_Type.UsernameOrPasswordError: 
                return "SC_Customer_Login_Failure_Type.UsernameOrPasswordError 用户名或密码错误";
            case SC_Customer_Login_Failure_Type.AccountNumberLocked: 
                return "SC_Customer_Login_Failure_Type.AccountNumberLocked 账号被锁定";
        }
    }
    public static string Get(SC_Acctountant_GetAround_Failure_Type e )
    {
        switch(e)
        {
            case SC_Acctountant_GetAround_Failure_Type.ParamError: 
                return "SC_Acctountant_GetAround_Failure_Type.ParamError 参数错误";
            case SC_Acctountant_GetAround_Failure_Type.ExecuteError: 
                return "SC_Acctountant_GetAround_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_Order_Create_Failure_Type e )
    {
        switch(e)
        {
            case SC_Order_Create_Failure_Type.ParamError: 
                return "SC_Order_Create_Failure_Type.ParamError 参数错误";
            case SC_Order_Create_Failure_Type.ExecuteError: 
                return "SC_Order_Create_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Order_Create_Failure_Type.AccountantRepeat: 
                return "SC_Order_Create_Failure_Type.AccountantRepeat 不能在未完成之前对当前会计重复下单";
            case SC_Order_Create_Failure_Type.AcounttanOver: 
                return "SC_Order_Create_Failure_Type.AcounttanOver 当前时间已经有会计做过账";
        }
    }
    public static string Get(SC_Express_GetAll_Failure_Type e )
    {
        switch(e)
        {
            case SC_Express_GetAll_Failure_Type.ExecuteError: 
                return "SC_Express_GetAll_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_UncompletedOrder_GetList_Failure_Type e )
    {
        switch(e)
        {
            case SC_UncompletedOrder_GetList_Failure_Type.ParamError: 
                return "SC_UncompletedOrder_GetList_Failure_Type.ParamError 参数错误";
            case SC_UncompletedOrder_GetList_Failure_Type.ExecuteError: 
                return "SC_UncompletedOrder_GetList_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_Order_GetDetails_Failure_Type e )
    {
        switch(e)
        {
            case SC_Order_GetDetails_Failure_Type.ParamError: 
                return "SC_Order_GetDetails_Failure_Type.ParamError 参数错误";
            case SC_Order_GetDetails_Failure_Type.ExecuteError: 
                return "SC_Order_GetDetails_Failure_Type.ExecuteError 数据库执行错误";
        }
    }
    public static string Get(SC_Order_UpdateTotal_Failure_Type e )
    {
        switch(e)
        {
            case SC_Order_UpdateTotal_Failure_Type.ParamError: 
                return "SC_Order_UpdateTotal_Failure_Type.ParamError 参数错误";
            case SC_Order_UpdateTotal_Failure_Type.ExecuteError: 
                return "SC_Order_UpdateTotal_Failure_Type.ExecuteError 数据库执行错误";
            case SC_Order_UpdateTotal_Failure_Type.NotFindOrder: 
                return "SC_Order_UpdateTotal_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Customer_Order_Confirm_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Order_Confirm_Failure_Type.ParamError: 
                return "SC_Customer_Order_Confirm_Failure_Type.ParamError 参数错误";
            case SC_Customer_Order_Confirm_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_Order_Confirm_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_Order_Confirm_Failure_Type.NotFindOrder: 
                return "SC_Customer_Order_Confirm_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Get_Payment_Platform_Failure_Type e )
    {
        switch(e)
        {
            case SC_Get_Payment_Platform_Failure_Type.ParamError: 
                return "SC_Get_Payment_Platform_Failure_Type.ParamError 参数错误";
            case SC_Get_Payment_Platform_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Get_Payment_Platform_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_Customer_Deliver_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Deliver_Failure_Type.ParamError: 
                return "SC_Customer_Deliver_Failure_Type.ParamError 参数错误";
            case SC_Customer_Deliver_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_Deliver_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_Deliver_Failure_Type.NotFindOrder: 
                return "SC_Customer_Deliver_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Accountant_Receipt_Confirm_Failure_Type e )
    {
        switch(e)
        {
            case SC_Accountant_Receipt_Confirm_Failure_Type.ParamError: 
                return "SC_Accountant_Receipt_Confirm_Failure_Type.ParamError 参数错误";
            case SC_Accountant_Receipt_Confirm_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Accountant_Receipt_Confirm_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Accountant_Receipt_Confirm_Failure_Type.NotFindOrder: 
                return "SC_Accountant_Receipt_Confirm_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Accountant_Create_Report_Failure_Type e )
    {
        switch(e)
        {
            case SC_Accountant_Create_Report_Failure_Type.ParamError: 
                return "SC_Accountant_Create_Report_Failure_Type.ParamError 参数错误";
            case SC_Accountant_Create_Report_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Accountant_Create_Report_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Accountant_Create_Report_Failure_Type.NotFindOrder: 
                return "SC_Accountant_Create_Report_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Get_Report_Month_Failure_Type e )
    {
        switch(e)
        {
            case SC_Get_Report_Month_Failure_Type.ParamError: 
                return "SC_Get_Report_Month_Failure_Type.ParamError 参数错误";
            case SC_Get_Report_Month_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Get_Report_Month_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Get_Report_Month_Failure_Type.NotFindOrder: 
                return "SC_Get_Report_Month_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Get_Report_Quarter_Failure_Type e )
    {
        switch(e)
        {
            case SC_Get_Report_Quarter_Failure_Type.ParamError: 
                return "SC_Get_Report_Quarter_Failure_Type.ParamError 参数错误";
            case SC_Get_Report_Quarter_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Get_Report_Quarter_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Get_Report_Quarter_Failure_Type.NotFindOrder: 
                return "SC_Get_Report_Quarter_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Customer_Report_Confirm_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Report_Confirm_Failure_Type.ParamError: 
                return "SC_Customer_Report_Confirm_Failure_Type.ParamError 参数错误";
            case SC_Customer_Report_Confirm_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_Report_Confirm_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_Report_Confirm_Failure_Type.NotFindOrder: 
                return "SC_Customer_Report_Confirm_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Accountant_Send_Back_Failure_Type e )
    {
        switch(e)
        {
            case SC_Accountant_Send_Back_Failure_Type.ParamError: 
                return "SC_Accountant_Send_Back_Failure_Type.ParamError 参数错误";
            case SC_Accountant_Send_Back_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Accountant_Send_Back_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Accountant_Send_Back_Failure_Type.NotFindOrder: 
                return "SC_Accountant_Send_Back_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Customer_Order_Recive_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Order_Recive_Failure_Type.ParamError: 
                return "SC_Customer_Order_Recive_Failure_Type.ParamError 参数错误";
            case SC_Customer_Order_Recive_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_Order_Recive_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_Order_Recive_Failure_Type.NotFindOrder: 
                return "SC_Customer_Order_Recive_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Customer_Order_Back_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Order_Back_Failure_Type.ParamError: 
                return "SC_Customer_Order_Back_Failure_Type.ParamError 参数错误";
            case SC_Customer_Order_Back_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_Order_Back_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_Order_Back_Failure_Type.NotFindOrder: 
                return "SC_Customer_Order_Back_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Accountant_Cancel_Order_Failure_Type e )
    {
        switch(e)
        {
            case SC_Accountant_Cancel_Order_Failure_Type.ParamError: 
                return "SC_Accountant_Cancel_Order_Failure_Type.ParamError 参数错误";
            case SC_Accountant_Cancel_Order_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Accountant_Cancel_Order_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Accountant_Cancel_Order_Failure_Type.NotFindOrder: 
                return "SC_Accountant_Cancel_Order_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Customer_Cancel_Order_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_Cancel_Order_Failure_Type.ParamError: 
                return "SC_Customer_Cancel_Order_Failure_Type.ParamError 参数错误";
            case SC_Customer_Cancel_Order_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_Cancel_Order_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_Cancel_Order_Failure_Type.NotFindOrder: 
                return "SC_Customer_Cancel_Order_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_Accountant_GetList_Failure_Type e )
    {
        switch(e)
        {
            case SC_Accountant_GetList_Failure_Type.ParamError: 
                return "SC_Accountant_GetList_Failure_Type.ParamError 参数错误";
            case SC_Accountant_GetList_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Accountant_GetList_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_CompeletedOrder_GetList_Failure_Type e )
    {
        switch(e)
        {
            case SC_CompeletedOrder_GetList_Failure_Type.ParamError: 
                return "SC_CompeletedOrder_GetList_Failure_Type.ParamError 参数错误";
            case SC_CompeletedOrder_GetList_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_CompeletedOrder_GetList_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_Grade_AccountantService_Failure_Type e )
    {
        switch(e)
        {
            case SC_Grade_AccountantService_Failure_Type.ParamError: 
                return "SC_Grade_AccountantService_Failure_Type.ParamError 参数错误";
            case SC_Grade_AccountantService_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Grade_AccountantService_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Grade_AccountantService_Failure_Type.NotFindOrder: 
                return "SC_Grade_AccountantService_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_AccountantCredentials_Upload_Failure_Type e )
    {
        switch(e)
        {
            case SC_AccountantCredentials_Upload_Failure_Type.ParamError: 
                return "SC_AccountantCredentials_Upload_Failure_Type.ParamError 参数错误";
            case SC_AccountantCredentials_Upload_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AccountantCredentials_Upload_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_AccountantCredentials_Upload_Failure_Type.NotFindAccountant: 
                return "SC_AccountantCredentials_Upload_Failure_Type.NotFindAccountant 不存在该会计";
        }
    }
    public static string Get(SC_UnionPayTn_Get_Failure_Type e )
    {
        switch(e)
        {
            case SC_UnionPayTn_Get_Failure_Type.ParamError: 
                return "SC_UnionPayTn_Get_Failure_Type.ParamError 参数错误";
            case SC_UnionPayTn_Get_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_UnionPayTn_Get_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_UnionPayTn_Get_Failure_Type.NotFindOrder: 
                return "SC_UnionPayTn_Get_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_ReportFile_Upload_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Upload_Failure_Type.ParamError: 
                return "SC_ReportFile_Upload_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Upload_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Upload_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Upload_Failure_Type.NotFindOrder: 
                return "SC_ReportFile_Upload_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_ReportFile_Download_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Download_Failure_Type.ParamError: 
                return "SC_ReportFile_Download_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Download_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Download_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Download_Failure_Type.NotFindFile: 
                return "SC_ReportFile_Download_Failure_Type.NotFindFile 未找到该文件";
        }
    }
    public static string Get(SC_ReportFile_Delete_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Delete_Failure_Type.ParamError: 
                return "SC_ReportFile_Delete_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Delete_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Delete_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_GetAccountantUncompletedOrderList_web_Failure_Type e )
    {
        switch(e)
        {
            case SC_GetAccountantUncompletedOrderList_web_Failure_Type.ParamError: 
                return "SC_GetAccountantUncompletedOrderList_web_Failure_Type.ParamError 参数错误";
            case SC_GetAccountantUncompletedOrderList_web_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_GetAccountantUncompletedOrderList_web_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_AccountantElectronicBusinessCard_Get_Failure_Type e )
    {
        switch(e)
        {
            case SC_AccountantElectronicBusinessCard_Get_Failure_Type.ParamError: 
                return "SC_AccountantElectronicBusinessCard_Get_Failure_Type.ParamError 参数错误";
            case SC_AccountantElectronicBusinessCard_Get_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AccountantElectronicBusinessCard_Get_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_AccountantElectronicBusinessCard_Get_Failure_Type.NotFindAccountant: 
                return "SC_AccountantElectronicBusinessCard_Get_Failure_Type.NotFindAccountant 未找到该会计";
        }
    }
    public static string Get(SC_Communication_Failure_Type e )
    {
        switch(e)
        {
            case SC_Communication_Failure_Type.SerializeError: 
                return "SC_Communication_Failure_Type.SerializeError 序列化错误";
        }
    }
    public static string Get(SC_AccountanPictureDown_Failure_Type e )
    {
        switch(e)
        {
            case SC_AccountanPictureDown_Failure_Type.ParamError: 
                return "SC_AccountanPictureDown_Failure_Type.ParamError 参数错误";
            case SC_AccountanPictureDown_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AccountanPictureDown_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_FindReportCustom_Failure_Type e )
    {
        switch(e)
        {
            case SC_FindReportCustom_Failure_Type.ParamError: 
                return "SC_FindReportCustom_Failure_Type.ParamError 参数错误";
            case SC_FindReportCustom_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_FindReportCustom_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_FindReportCustom_Failure_Type.NotFindOrder: 
                return "SC_FindReportCustom_Failure_Type.NotFindOrder 未找到该报表";
        }
    }
    public static string Get(SC_Customer_UploadElectronicBill_Failure_Type e )
    {
        switch(e)
        {
            case SC_Customer_UploadElectronicBill_Failure_Type.ParamError: 
                return "SC_Customer_UploadElectronicBill_Failure_Type.ParamError 参数错误";
            case SC_Customer_UploadElectronicBill_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_Customer_UploadElectronicBill_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_Customer_UploadElectronicBill_Failure_Type.NotFindOrder: 
                return "SC_Customer_UploadElectronicBill_Failure_Type.NotFindOrder 不存在该客户";
        }
    }
    public static string Get(SC_GetElectronicBill_Failure_Type e )
    {
        switch(e)
        {
            case SC_GetElectronicBill_Failure_Type.ParamError: 
                return "SC_GetElectronicBill_Failure_Type.ParamError 参数错误";
            case SC_GetElectronicBill_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_GetElectronicBill_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_GetElectronicBill_Failure_Type.NotFindOrder: 
                return "SC_GetElectronicBill_Failure_Type.NotFindOrder 不存在该客户";
        }
    }
    public static string Get(SC_CustomerGetOrderState_Failure_Type e )
    {
        switch(e)
        {
            case SC_CustomerGetOrderState_Failure_Type.ParamError: 
                return "SC_CustomerGetOrderState_Failure_Type.ParamError 参数错误";
            case SC_CustomerGetOrderState_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_CustomerGetOrderState_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_ReportFile_Upload_Year_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Upload_Year_Failure_Type.ParamError: 
                return "SC_ReportFile_Upload_Year_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Upload_Year_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Upload_Year_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Upload_Year_Failure_Type.NotFindOrder: 
                return "SC_ReportFile_Upload_Year_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_ReportFile_Upload_Quarter_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Upload_Quarter_Failure_Type.ParamError: 
                return "SC_ReportFile_Upload_Quarter_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Upload_Quarter_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Upload_Quarter_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Upload_Quarter_Failure_Type.NotFindOrder: 
                return "SC_ReportFile_Upload_Quarter_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_ReportFile_Upload_Month_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Upload_Month_Failure_Type.ParamError: 
                return "SC_ReportFile_Upload_Month_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Upload_Month_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Upload_Month_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Upload_Month_Failure_Type.NotFindOrder: 
                return "SC_ReportFile_Upload_Month_Failure_Type.NotFindOrder 未找到该订单";
        }
    }
    public static string Get(SC_ReportFile_Download_Year_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Download_Year_Failure_Type.ParamError: 
                return "SC_ReportFile_Download_Year_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Download_Year_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Download_Year_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Download_Year_Failure_Type.NotFindReport: 
                return "SC_ReportFile_Download_Year_Failure_Type.NotFindReport 未找到该年的报表";
        }
    }
    public static string Get(SC_ReportFile_Download_Quarter_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Download_Quarter_Failure_Type.ParamError: 
                return "SC_ReportFile_Download_Quarter_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Download_Quarter_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Download_Quarter_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Download_Quarter_Failure_Type.NotFindReport: 
                return "SC_ReportFile_Download_Quarter_Failure_Type.NotFindReport 未找到该季度的报表";
        }
    }
    public static string Get(SC_ReportFile_Download_Month_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Download_Month_Failure_Type.ParamError: 
                return "SC_ReportFile_Download_Month_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Download_Month_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Download_Month_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Download_Month_Failure_Type.NotFindReport: 
                return "SC_ReportFile_Download_Month_Failure_Type.NotFindReport 未找到该月的报表";
        }
    }
    public static string Get(SC_ReportFileList_Download_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFileList_Download_Failure_Type.ParamError: 
                return "SC_ReportFileList_Download_Failure_Type.ParamError 参数错误";
            case SC_ReportFileList_Download_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFileList_Download_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_ReportFileList_Download_Success_Data_Type e )
    {
        switch(e)
        {
            case SC_ReportFileList_Download_Success_Data_Type.Month: 
                return "SC_ReportFileList_Download_Success_Data_Type.Month 月报表";
            case SC_ReportFileList_Download_Success_Data_Type.Quarter: 
                return "SC_ReportFileList_Download_Success_Data_Type.Quarter 季度报表";
            case SC_ReportFileList_Download_Success_Data_Type.Year: 
                return "SC_ReportFileList_Download_Success_Data_Type.Year 年报表";
        }
    }
    public static string Get(SC_ReportFileOrder_Download_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFileOrder_Download_Failure_Type.ParamError: 
                return "SC_ReportFileOrder_Download_Failure_Type.ParamError 参数错误";
            case SC_ReportFileOrder_Download_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFileOrder_Download_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFileOrder_Download_Failure_Type.NotFindFile: 
                return "SC_ReportFileOrder_Download_Failure_Type.NotFindFile 没有找到该文件";
        }
    }
    public static string Get(SC_CheckAccountantInformation_Failure_Type e )
    {
        switch(e)
        {
            case SC_CheckAccountantInformation_Failure_Type.ParamError: 
                return "SC_CheckAccountantInformation_Failure_Type.ParamError 参数错误";
            case SC_CheckAccountantInformation_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_CheckAccountantInformation_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_CheckAccountantInformation_Failure_Type.NotFindAccountant: 
                return "SC_CheckAccountantInformation_Failure_Type.NotFindAccountant 没有找到该会计";
        }
    }
    public static string Get(SC_CheckReportFileFromID_Failure_Type e )
    {
        switch(e)
        {
            case SC_CheckReportFileFromID_Failure_Type.ParamError: 
                return "SC_CheckReportFileFromID_Failure_Type.ParamError 参数错误";
            case SC_CheckReportFileFromID_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_CheckReportFileFromID_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_CheckReportFileFromID_Failure_Type.NotFindReportFile: 
                return "SC_CheckReportFileFromID_Failure_Type.NotFindReportFile 没有找到该报表文件";
        }
    }
    public static string Get(SC_ReportFile_Find_Year_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Find_Year_Failure_Type.ParamError: 
                return "SC_ReportFile_Find_Year_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Find_Year_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Find_Year_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Find_Year_Failure_Type.NotFindReport: 
                return "SC_ReportFile_Find_Year_Failure_Type.NotFindReport 未找到该年的报表";
        }
    }
    public static string Get(SC_ReportFile_Find_Quarter_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Find_Quarter_Failure_Type.ParamError: 
                return "SC_ReportFile_Find_Quarter_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Find_Quarter_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Find_Quarter_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Find_Quarter_Failure_Type.NotFindReport: 
                return "SC_ReportFile_Find_Quarter_Failure_Type.NotFindReport 未找到该季度的报表";
        }
    }
    public static string Get(SC_ReportFile_Find_Month_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReportFile_Find_Month_Failure_Type.ParamError: 
                return "SC_ReportFile_Find_Month_Failure_Type.ParamError 参数错误";
            case SC_ReportFile_Find_Month_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReportFile_Find_Month_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReportFile_Find_Month_Failure_Type.NotFindReport: 
                return "SC_ReportFile_Find_Month_Failure_Type.NotFindReport 未找到该月的报表";
        }
    }
    public static string Get(SC_DealAccountantList_Failure_Type e )
    {
        switch(e)
        {
            case SC_DealAccountantList_Failure_Type.ParamError: 
                return "SC_DealAccountantList_Failure_Type.ParamError 参数错误";
            case SC_DealAccountantList_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_DealAccountantList_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_ChangeAccountantInformation_Failure_Type e )
    {
        switch(e)
        {
            case SC_ChangeAccountantInformation_Failure_Type.ParamError: 
                return "SC_ChangeAccountantInformation_Failure_Type.ParamError 参数错误";
            case SC_ChangeAccountantInformation_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ChangeAccountantInformation_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ChangeAccountantInformation_Failure_Type.NotChangeEverything: 
                return "SC_ChangeAccountantInformation_Failure_Type.NotChangeEverything 有未完成的订单是所有信息都不能修改";
            case SC_ChangeAccountantInformation_Failure_Type.NotFindAcountant: 
                return "SC_ChangeAccountantInformation_Failure_Type.NotFindAcountant 没有这个用户";
            case SC_ChangeAccountantInformation_Failure_Type.NotChangeNum: 
                return "SC_ChangeAccountantInformation_Failure_Type.NotChangeNum 正在审核或者审核通过后不能再修改身份证号码和会计从业证号码";
        }
    }
    public static string Get(SC_ReturnAccountantInformation_Failure_Type e )
    {
        switch(e)
        {
            case SC_ReturnAccountantInformation_Failure_Type.ParamError: 
                return "SC_ReturnAccountantInformation_Failure_Type.ParamError 参数错误";
            case SC_ReturnAccountantInformation_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_ReturnAccountantInformation_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_ReturnAccountantInformation_Failure_Type.NotFindAcountant: 
                return "SC_ReturnAccountantInformation_Failure_Type.NotFindAcountant 没有这个用户";
        }
    }
    public static string Get(SC_AccountantHomePage_Failure_Type e )
    {
        switch(e)
        {
            case SC_AccountantHomePage_Failure_Type.ParamError: 
                return "SC_AccountantHomePage_Failure_Type.ParamError 参数错误";
            case SC_AccountantHomePage_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AccountantHomePage_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_AccountantHomePage_Failure_Type.NotFindAcountant: 
                return "SC_AccountantHomePage_Failure_Type.NotFindAcountant 没有这个用户";
        }
    }
    public static string Get(SC_CustomerAnonymous_Failure_Type e )
    {
        switch(e)
        {
            case SC_CustomerAnonymous_Failure_Type.ParamError: 
                return "SC_CustomerAnonymous_Failure_Type.ParamError 参数错误";
            case SC_CustomerAnonymous_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_CustomerAnonymous_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_Anonymous_Failure_Type e )
    {
        switch(e)
        {
            case SC_Anonymous_Failure_Type.Failure: 
                return "SC_Anonymous_Failure_Type.Failure 验证服务器失败";
        }
    }
    public static string Get(SC_FindAccountantCredentials_Failure_Type e )
    {
        switch(e)
        {
            case SC_FindAccountantCredentials_Failure_Type.ParamError: 
                return "SC_FindAccountantCredentials_Failure_Type.ParamError 参数错误";
            case SC_FindAccountantCredentials_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_FindAccountantCredentials_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_AccountantFindCustomer_Failure_Type e )
    {
        switch(e)
        {
            case SC_AccountantFindCustomer_Failure_Type.ParamError: 
                return "SC_AccountantFindCustomer_Failure_Type.ParamError 参数错误";
            case SC_AccountantFindCustomer_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AccountantFindCustomer_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_AcountantFindCustomerDetail_Failure_Type e )
    {
        switch(e)
        {
            case SC_AcountantFindCustomerDetail_Failure_Type.ParamError: 
                return "SC_AcountantFindCustomerDetail_Failure_Type.ParamError 参数错误";
            case SC_AcountantFindCustomerDetail_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AcountantFindCustomerDetail_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_AcountantFindCustomerDetail_Failure_Type.NotFindOrder: 
                return "SC_AcountantFindCustomerDetail_Failure_Type.NotFindOrder 未找到该订单";
            case SC_AcountantFindCustomerDetail_Failure_Type.NotFindCustomer: 
                return "SC_AcountantFindCustomerDetail_Failure_Type.NotFindCustomer 未找到改公司";
        }
    }
    public static string Get(SC_UserChangeIcon_Failure_Type e )
    {
        switch(e)
        {
            case SC_UserChangeIcon_Failure_Type.ParamError: 
                return "SC_UserChangeIcon_Failure_Type.ParamError 参数错误";
            case SC_UserChangeIcon_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_UserChangeIcon_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
        }
    }
    public static string Get(SC_CustomerHomePage_Failure_Type e )
    {
        switch(e)
        {
            case SC_CustomerHomePage_Failure_Type.ParamError: 
                return "SC_CustomerHomePage_Failure_Type.ParamError 参数错误";
            case SC_CustomerHomePage_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_CustomerHomePage_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_CustomerHomePage_Failure_Type.NotFindCustomer: 
                return "SC_CustomerHomePage_Failure_Type.NotFindCustomer 没有这个公司";
        }
    }
    public static string Get(SC_FindPushMessage_Failure_Type e )
    {
        switch(e)
        {
            case SC_FindPushMessage_Failure_Type.ParamError: 
                return "SC_FindPushMessage_Failure_Type.ParamError 参数错误";
            case SC_FindPushMessage_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_FindPushMessage_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_FindPushMessage_Failure_Type.NotFindID: 
                return "SC_FindPushMessage_Failure_Type.NotFindID 没有这个客户";
        }
    }
    public static string Get(SC_AccountantFindDocment_Failure_Type e )
    {
        switch(e)
        {
            case SC_AccountantFindDocment_Failure_Type.ParamError: 
                return "SC_AccountantFindDocment_Failure_Type.ParamError 参数错误";
            case SC_AccountantFindDocment_Failure_Type.BusinessLogicExcuteFailed: 
                return "SC_AccountantFindDocment_Failure_Type.BusinessLogicExcuteFailed 业务逻辑执行失败";
            case SC_AccountantFindDocment_Failure_Type.NotFindAccountant: 
                return "SC_AccountantFindDocment_Failure_Type.NotFindAccountant 没有这个会计";
        }
    }
}