﻿
#include "EnumToString.h"
char const* const EnumToString::Get( SCPkgTypes::SC_Accountant_Register_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Register_Failure_Type::ParamError: 
            return "SC_Accountant_Register_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Accountant_Register_Failure_Type::ExecuteError: 
            return "SC_Accountant_Register_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Accountant_Register_Failure_Type::UserNameExist: 
            return "SC_Accountant_Register_Failure_Type::UserNameExist 用户名已经存在";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Accountant_Register_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Register_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Accountant_Register_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Accountant_Register_Failure_Type::UserNameExist: 
            return "用户名已经存在";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Account_Register_IsExists_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_Register_IsExists_Failure_Type::ParamError: 
            return "SC_Account_Register_IsExists_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Account_Register_IsExists_Failure_Type::ExecuteError: 
            return "SC_Account_Register_IsExists_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Account_Register_IsExists_Failure_Type::UserNameExist: 
            return "SC_Account_Register_IsExists_Failure_Type::UserNameExist 用户名已经存在";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Account_Register_IsExists_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_Register_IsExists_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Account_Register_IsExists_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Account_Register_IsExists_Failure_Type::UserNameExist: 
            return "用户名已经存在";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Account_Login_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_Login_Failure_Type::ParamError: 
            return "SC_Account_Login_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Account_Login_Failure_Type::ExecuteError: 
            return "SC_Account_Login_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Account_Login_Failure_Type::UserNameExist: 
            return "SC_Account_Login_Failure_Type::UserNameExist 用户名不存在";
        case SCPkgTypes::SC_Account_Login_Failure_Type::PasswordError: 
            return "SC_Account_Login_Failure_Type::PasswordError 密码错误";
        case SCPkgTypes::SC_Account_Login_Failure_Type::AccountNumberlLocked: 
            return "SC_Account_Login_Failure_Type::AccountNumberlLocked 账号被锁定";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Account_Login_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_Login_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Account_Login_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Account_Login_Failure_Type::UserNameExist: 
            return "用户名不存在";
        case SCPkgTypes::SC_Account_Login_Failure_Type::PasswordError: 
            return "密码错误";
        case SCPkgTypes::SC_Account_Login_Failure_Type::AccountNumberlLocked: 
            return "账号被锁定";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Account_GetProduct_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_GetProduct_Failure_Type::ParamError: 
            return "SC_Account_GetProduct_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Account_GetProduct_Failure_Type::ExecuteError: 
            return "SC_Account_GetProduct_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Account_GetProduct_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_GetProduct_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Account_GetProduct_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Product_Manage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Product_Manage_Failure_Type::ParamError: 
            return "SC_Product_Manage_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Product_Manage_Failure_Type::ExecuteError: 
            return "SC_Product_Manage_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Product_Manage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Product_Manage_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Product_Manage_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Account_GetDetails_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_GetDetails_Failure_Type::ParamError: 
            return "SC_Account_GetDetails_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Account_GetDetails_Failure_Type::ExecuteError: 
            return "SC_Account_GetDetails_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Account_GetDetails_Failure_Type::NotFound: 
            return "SC_Account_GetDetails_Failure_Type::NotFound 未查找到";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Account_GetDetails_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Account_GetDetails_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Account_GetDetails_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Account_GetDetails_Failure_Type::NotFound: 
            return "未查找到";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Register_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Register_Failure_Type::ParamError: 
            return "SC_Customer_Register_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Register_Failure_Type::ExecuteError: 
            return "SC_Customer_Register_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Customer_Register_Failure_Type::UserNameExist: 
            return "SC_Customer_Register_Failure_Type::UserNameExist 用户名已经存在";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Register_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Register_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Register_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Customer_Register_Failure_Type::UserNameExist: 
            return "用户名已经存在";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type::ParamError: 
            return "SC_Customer_Register_IsExists_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type::ExecuteError: 
            return "SC_Customer_Register_IsExists_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type::UserNameExist: 
            return "SC_Customer_Register_IsExists_Failure_Type::UserNameExist 用户名已存在";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Customer_Register_IsExists_Failure_Type::UserNameExist: 
            return "用户名已存在";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Industry_AllSector_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Industry_AllSector_Failure_Type::ParamError: 
            return "SC_Industry_AllSector_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Industry_AllSector_Failure_Type::ExecuteError: 
            return "SC_Industry_AllSector_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Industry_AllSector_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Industry_AllSector_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Industry_AllSector_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Login_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Login_Failure_Type::ParamError: 
            return "SC_Customer_Login_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Login_Failure_Type::ExecuteError: 
            return "SC_Customer_Login_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Customer_Login_Failure_Type::UsernameOrPasswordError: 
            return "SC_Customer_Login_Failure_Type::UsernameOrPasswordError 用户名或密码错误";
        case SCPkgTypes::SC_Customer_Login_Failure_Type::AccountNumberLocked: 
            return "SC_Customer_Login_Failure_Type::AccountNumberLocked 账号被锁定";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Login_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Login_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Login_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Customer_Login_Failure_Type::UsernameOrPasswordError: 
            return "用户名或密码错误";
        case SCPkgTypes::SC_Customer_Login_Failure_Type::AccountNumberLocked: 
            return "账号被锁定";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Acctountant_GetAround_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Acctountant_GetAround_Failure_Type::ParamError: 
            return "SC_Acctountant_GetAround_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Acctountant_GetAround_Failure_Type::ExecuteError: 
            return "SC_Acctountant_GetAround_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Acctountant_GetAround_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Acctountant_GetAround_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Acctountant_GetAround_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Order_Create_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Order_Create_Failure_Type::ParamError: 
            return "SC_Order_Create_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Order_Create_Failure_Type::ExecuteError: 
            return "SC_Order_Create_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Order_Create_Failure_Type::AccountantRepeat: 
            return "SC_Order_Create_Failure_Type::AccountantRepeat 不能在未完成之前对当前会计重复下单";
        case SCPkgTypes::SC_Order_Create_Failure_Type::AcounttanOver: 
            return "SC_Order_Create_Failure_Type::AcounttanOver 当前时间已经有会计做过账";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Order_Create_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Order_Create_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Order_Create_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Order_Create_Failure_Type::AccountantRepeat: 
            return "不能在未完成之前对当前会计重复下单";
        case SCPkgTypes::SC_Order_Create_Failure_Type::AcounttanOver: 
            return "当前时间已经有会计做过账";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Express_GetAll_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Express_GetAll_Failure_Type::ExecuteError: 
            return "SC_Express_GetAll_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Express_GetAll_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Express_GetAll_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type::ParamError: 
            return "SC_UncompletedOrder_GetList_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type::ExecuteError: 
            return "SC_UncompletedOrder_GetList_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_UncompletedOrder_GetList_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Order_GetDetails_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Order_GetDetails_Failure_Type::ParamError: 
            return "SC_Order_GetDetails_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Order_GetDetails_Failure_Type::ExecuteError: 
            return "SC_Order_GetDetails_Failure_Type::ExecuteError 数据库执行错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Order_GetDetails_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Order_GetDetails_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Order_GetDetails_Failure_Type::ExecuteError: 
            return "数据库执行错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Order_UpdateTotal_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Order_UpdateTotal_Failure_Type::ParamError: 
            return "SC_Order_UpdateTotal_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Order_UpdateTotal_Failure_Type::ExecuteError: 
            return "SC_Order_UpdateTotal_Failure_Type::ExecuteError 数据库执行错误";
        case SCPkgTypes::SC_Order_UpdateTotal_Failure_Type::NotFindOrder: 
            return "SC_Order_UpdateTotal_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Order_UpdateTotal_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Order_UpdateTotal_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Order_UpdateTotal_Failure_Type::ExecuteError: 
            return "数据库执行错误";
        case SCPkgTypes::SC_Order_UpdateTotal_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type::ParamError: 
            return "SC_Customer_Order_Confirm_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_Order_Confirm_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type::NotFindOrder: 
            return "SC_Customer_Order_Confirm_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Order_Confirm_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Get_Payment_Platform_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Get_Payment_Platform_Failure_Type::ParamError: 
            return "SC_Get_Payment_Platform_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Get_Payment_Platform_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Get_Payment_Platform_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Get_Payment_Platform_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Get_Payment_Platform_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Get_Payment_Platform_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Deliver_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Deliver_Failure_Type::ParamError: 
            return "SC_Customer_Deliver_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Deliver_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_Deliver_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Deliver_Failure_Type::NotFindOrder: 
            return "SC_Customer_Deliver_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Deliver_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Deliver_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Deliver_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Deliver_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type::ParamError: 
            return "SC_Accountant_Receipt_Confirm_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Accountant_Receipt_Confirm_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type::NotFindOrder: 
            return "SC_Accountant_Receipt_Confirm_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Accountant_Create_Report_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Create_Report_Failure_Type::ParamError: 
            return "SC_Accountant_Create_Report_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Accountant_Create_Report_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Accountant_Create_Report_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Create_Report_Failure_Type::NotFindOrder: 
            return "SC_Accountant_Create_Report_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Accountant_Create_Report_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Create_Report_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Accountant_Create_Report_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Create_Report_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Get_Report_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Get_Report_Month_Failure_Type::ParamError: 
            return "SC_Get_Report_Month_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Get_Report_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Get_Report_Month_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Get_Report_Month_Failure_Type::NotFindOrder: 
            return "SC_Get_Report_Month_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Get_Report_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Get_Report_Month_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Get_Report_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Get_Report_Month_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Get_Report_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Get_Report_Quarter_Failure_Type::ParamError: 
            return "SC_Get_Report_Quarter_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Get_Report_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Get_Report_Quarter_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Get_Report_Quarter_Failure_Type::NotFindOrder: 
            return "SC_Get_Report_Quarter_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Get_Report_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Get_Report_Quarter_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Get_Report_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Get_Report_Quarter_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type::ParamError: 
            return "SC_Customer_Report_Confirm_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_Report_Confirm_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type::NotFindOrder: 
            return "SC_Customer_Report_Confirm_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Report_Confirm_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Accountant_Send_Back_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Send_Back_Failure_Type::ParamError: 
            return "SC_Accountant_Send_Back_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Accountant_Send_Back_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Accountant_Send_Back_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Send_Back_Failure_Type::NotFindOrder: 
            return "SC_Accountant_Send_Back_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Accountant_Send_Back_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Send_Back_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Accountant_Send_Back_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Send_Back_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Order_Recive_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Order_Recive_Failure_Type::ParamError: 
            return "SC_Customer_Order_Recive_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Order_Recive_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_Order_Recive_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Order_Recive_Failure_Type::NotFindOrder: 
            return "SC_Customer_Order_Recive_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Order_Recive_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Order_Recive_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Order_Recive_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Order_Recive_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Order_Back_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Order_Back_Failure_Type::ParamError: 
            return "SC_Customer_Order_Back_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Order_Back_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_Order_Back_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Order_Back_Failure_Type::NotFindOrder: 
            return "SC_Customer_Order_Back_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Order_Back_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Order_Back_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Order_Back_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Order_Back_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type::ParamError: 
            return "SC_Accountant_Cancel_Order_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Accountant_Cancel_Order_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type::NotFindOrder: 
            return "SC_Accountant_Cancel_Order_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Accountant_Cancel_Order_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type::ParamError: 
            return "SC_Customer_Cancel_Order_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_Cancel_Order_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type::NotFindOrder: 
            return "SC_Customer_Cancel_Order_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_Cancel_Order_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Accountant_GetList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_GetList_Failure_Type::ParamError: 
            return "SC_Accountant_GetList_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Accountant_GetList_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Accountant_GetList_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Accountant_GetList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Accountant_GetList_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Accountant_GetList_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type::ParamError: 
            return "SC_CompeletedOrder_GetList_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_CompeletedOrder_GetList_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_CompeletedOrder_GetList_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Grade_AccountantService_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Grade_AccountantService_Failure_Type::ParamError: 
            return "SC_Grade_AccountantService_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Grade_AccountantService_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Grade_AccountantService_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Grade_AccountantService_Failure_Type::NotFindOrder: 
            return "SC_Grade_AccountantService_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Grade_AccountantService_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Grade_AccountantService_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Grade_AccountantService_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Grade_AccountantService_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type::ParamError: 
            return "SC_AccountantCredentials_Upload_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AccountantCredentials_Upload_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type::NotFindAccountant: 
            return "SC_AccountantCredentials_Upload_Failure_Type::NotFindAccountant 不存在该会计";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantCredentials_Upload_Failure_Type::NotFindAccountant: 
            return "不存在该会计";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_UnionPayTn_Get_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_UnionPayTn_Get_Failure_Type::ParamError: 
            return "SC_UnionPayTn_Get_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_UnionPayTn_Get_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_UnionPayTn_Get_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_UnionPayTn_Get_Failure_Type::NotFindOrder: 
            return "SC_UnionPayTn_Get_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_UnionPayTn_Get_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_UnionPayTn_Get_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_UnionPayTn_Get_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_UnionPayTn_Get_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Upload_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Failure_Type::ParamError: 
            return "SC_ReportFile_Upload_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Upload_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Failure_Type::NotFindOrder: 
            return "SC_ReportFile_Upload_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Upload_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Download_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Failure_Type::ParamError: 
            return "SC_ReportFile_Download_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Download_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Failure_Type::NotFindFile: 
            return "SC_ReportFile_Download_Failure_Type::NotFindFile 未找到该文件";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Download_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Failure_Type::NotFindFile: 
            return "未找到该文件";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Delete_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Delete_Failure_Type::ParamError: 
            return "SC_ReportFile_Delete_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Delete_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Delete_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Delete_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Delete_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Delete_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type::ParamError: 
            return "SC_GetAccountantUncompletedOrderList_web_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_GetAccountantUncompletedOrderList_web_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type::ParamError: 
            return "SC_AccountantElectronicBusinessCard_Get_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AccountantElectronicBusinessCard_Get_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type::NotFindAccountant: 
            return "SC_AccountantElectronicBusinessCard_Get_Failure_Type::NotFindAccountant 未找到该会计";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure_Type::NotFindAccountant: 
            return "未找到该会计";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Communication_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Communication_Failure_Type::SerializeError: 
            return "SC_Communication_Failure_Type::SerializeError 序列化错误";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Communication_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Communication_Failure_Type::SerializeError: 
            return "序列化错误";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AccountanPictureDown_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountanPictureDown_Failure_Type::ParamError: 
            return "SC_AccountanPictureDown_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AccountanPictureDown_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AccountanPictureDown_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AccountanPictureDown_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountanPictureDown_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AccountanPictureDown_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_FindReportCustom_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_FindReportCustom_Failure_Type::ParamError: 
            return "SC_FindReportCustom_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_FindReportCustom_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_FindReportCustom_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_FindReportCustom_Failure_Type::NotFindOrder: 
            return "SC_FindReportCustom_Failure_Type::NotFindOrder 未找到该报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_FindReportCustom_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_FindReportCustom_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_FindReportCustom_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_FindReportCustom_Failure_Type::NotFindOrder: 
            return "未找到该报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type::ParamError: 
            return "SC_Customer_UploadElectronicBill_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_Customer_UploadElectronicBill_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type::NotFindOrder: 
            return "SC_Customer_UploadElectronicBill_Failure_Type::NotFindOrder 不存在该客户";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_Customer_UploadElectronicBill_Failure_Type::NotFindOrder: 
            return "不存在该客户";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_GetElectronicBill_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_GetElectronicBill_Failure_Type::ParamError: 
            return "SC_GetElectronicBill_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_GetElectronicBill_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_GetElectronicBill_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_GetElectronicBill_Failure_Type::NotFindOrder: 
            return "SC_GetElectronicBill_Failure_Type::NotFindOrder 不存在该客户";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_GetElectronicBill_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_GetElectronicBill_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_GetElectronicBill_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_GetElectronicBill_Failure_Type::NotFindOrder: 
            return "不存在该客户";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_CustomerGetOrderState_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CustomerGetOrderState_Failure_Type::ParamError: 
            return "SC_CustomerGetOrderState_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_CustomerGetOrderState_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_CustomerGetOrderState_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_CustomerGetOrderState_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CustomerGetOrderState_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_CustomerGetOrderState_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type::ParamError: 
            return "SC_ReportFile_Upload_Year_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Upload_Year_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type::NotFindOrder: 
            return "SC_ReportFile_Upload_Year_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Year_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type::ParamError: 
            return "SC_ReportFile_Upload_Quarter_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Upload_Quarter_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type::NotFindOrder: 
            return "SC_ReportFile_Upload_Quarter_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type::ParamError: 
            return "SC_ReportFile_Upload_Month_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Upload_Month_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type::NotFindOrder: 
            return "SC_ReportFile_Upload_Month_Failure_Type::NotFindOrder 未找到该订单";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Upload_Month_Failure_Type::NotFindOrder: 
            return "未找到该订单";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type::ParamError: 
            return "SC_ReportFile_Download_Year_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Download_Year_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type::NotFindReport: 
            return "SC_ReportFile_Download_Year_Failure_Type::NotFindReport 未找到该年的报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Year_Failure_Type::NotFindReport: 
            return "未找到该年的报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type::ParamError: 
            return "SC_ReportFile_Download_Quarter_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Download_Quarter_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type::NotFindReport: 
            return "SC_ReportFile_Download_Quarter_Failure_Type::NotFindReport 未找到该季度的报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Quarter_Failure_Type::NotFindReport: 
            return "未找到该季度的报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type::ParamError: 
            return "SC_ReportFile_Download_Month_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Download_Month_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type::NotFindReport: 
            return "SC_ReportFile_Download_Month_Failure_Type::NotFindReport 未找到该月的报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Download_Month_Failure_Type::NotFindReport: 
            return "未找到该月的报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFileList_Download_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFileList_Download_Failure_Type::ParamError: 
            return "SC_ReportFileList_Download_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFileList_Download_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFileList_Download_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFileList_Download_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFileList_Download_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFileList_Download_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type::Month: 
            return "SC_ReportFileList_Download_Success_Data_Type::Month 月报表";
        case SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type::Quarter: 
            return "SC_ReportFileList_Download_Success_Data_Type::Quarter 季度报表";
        case SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type::Year: 
            return "SC_ReportFileList_Download_Success_Data_Type::Year 年报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type::Month: 
            return "月报表";
        case SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type::Quarter: 
            return "季度报表";
        case SCPkgTypes::SC_ReportFileList_Download_Success_Data_Type::Year: 
            return "年报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type::ParamError: 
            return "SC_ReportFileOrder_Download_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFileOrder_Download_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type::NotFindFile: 
            return "SC_ReportFileOrder_Download_Failure_Type::NotFindFile 没有找到该文件";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFileOrder_Download_Failure_Type::NotFindFile: 
            return "没有找到该文件";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_CheckAccountantInformation_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CheckAccountantInformation_Failure_Type::ParamError: 
            return "SC_CheckAccountantInformation_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_CheckAccountantInformation_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_CheckAccountantInformation_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_CheckAccountantInformation_Failure_Type::NotFindAccountant: 
            return "SC_CheckAccountantInformation_Failure_Type::NotFindAccountant 没有找到该会计";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_CheckAccountantInformation_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CheckAccountantInformation_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_CheckAccountantInformation_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_CheckAccountantInformation_Failure_Type::NotFindAccountant: 
            return "没有找到该会计";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_CheckReportFileFromID_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CheckReportFileFromID_Failure_Type::ParamError: 
            return "SC_CheckReportFileFromID_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_CheckReportFileFromID_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_CheckReportFileFromID_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_CheckReportFileFromID_Failure_Type::NotFindReportFile: 
            return "SC_CheckReportFileFromID_Failure_Type::NotFindReportFile 没有找到该报表文件";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_CheckReportFileFromID_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CheckReportFileFromID_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_CheckReportFileFromID_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_CheckReportFileFromID_Failure_Type::NotFindReportFile: 
            return "没有找到该报表文件";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type::ParamError: 
            return "SC_ReportFile_Find_Year_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Find_Year_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type::NotFindReport: 
            return "SC_ReportFile_Find_Year_Failure_Type::NotFindReport 未找到该年的报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Find_Year_Failure_Type::NotFindReport: 
            return "未找到该年的报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type::ParamError: 
            return "SC_ReportFile_Find_Quarter_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Find_Quarter_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type::NotFindReport: 
            return "SC_ReportFile_Find_Quarter_Failure_Type::NotFindReport 未找到该季度的报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Find_Quarter_Failure_Type::NotFindReport: 
            return "未找到该季度的报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type::ParamError: 
            return "SC_ReportFile_Find_Month_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReportFile_Find_Month_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type::NotFindReport: 
            return "SC_ReportFile_Find_Month_Failure_Type::NotFindReport 未找到该月的报表";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReportFile_Find_Month_Failure_Type::NotFindReport: 
            return "未找到该月的报表";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_DealAccountantList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_DealAccountantList_Failure_Type::ParamError: 
            return "SC_DealAccountantList_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_DealAccountantList_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_DealAccountantList_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_DealAccountantList_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_DealAccountantList_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_DealAccountantList_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::ParamError: 
            return "SC_ChangeAccountantInformation_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ChangeAccountantInformation_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::NotChangeEverything: 
            return "SC_ChangeAccountantInformation_Failure_Type::NotChangeEverything 有未完成的订单是所有信息都不能修改";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::NotFindAcountant: 
            return "SC_ChangeAccountantInformation_Failure_Type::NotFindAcountant 没有这个用户";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::NotChangeNum: 
            return "SC_ChangeAccountantInformation_Failure_Type::NotChangeNum 正在审核或者审核通过后不能再修改身份证号码和会计从业证号码";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::NotChangeEverything: 
            return "有未完成的订单是所有信息都不能修改";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::NotFindAcountant: 
            return "没有这个用户";
        case SCPkgTypes::SC_ChangeAccountantInformation_Failure_Type::NotChangeNum: 
            return "正在审核或者审核通过后不能再修改身份证号码和会计从业证号码";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type::ParamError: 
            return "SC_ReturnAccountantInformation_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_ReturnAccountantInformation_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type::NotFindAcountant: 
            return "SC_ReturnAccountantInformation_Failure_Type::NotFindAcountant 没有这个用户";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_ReturnAccountantInformation_Failure_Type::NotFindAcountant: 
            return "没有这个用户";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AccountantHomePage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantHomePage_Failure_Type::ParamError: 
            return "SC_AccountantHomePage_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AccountantHomePage_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AccountantHomePage_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantHomePage_Failure_Type::NotFindAcountant: 
            return "SC_AccountantHomePage_Failure_Type::NotFindAcountant 没有这个用户";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AccountantHomePage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantHomePage_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AccountantHomePage_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantHomePage_Failure_Type::NotFindAcountant: 
            return "没有这个用户";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_CustomerAnonymous_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CustomerAnonymous_Failure_Type::ParamError: 
            return "SC_CustomerAnonymous_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_CustomerAnonymous_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_CustomerAnonymous_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_CustomerAnonymous_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CustomerAnonymous_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_CustomerAnonymous_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_Anonymous_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Anonymous_Failure_Type::Failure: 
            return "SC_Anonymous_Failure_Type::Failure 验证服务器失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_Anonymous_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_Anonymous_Failure_Type::Failure: 
            return "验证服务器失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_FindAccountantCredentials_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_FindAccountantCredentials_Failure_Type::ParamError: 
            return "SC_FindAccountantCredentials_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_FindAccountantCredentials_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_FindAccountantCredentials_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_FindAccountantCredentials_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_FindAccountantCredentials_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_FindAccountantCredentials_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AccountantFindCustomer_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantFindCustomer_Failure_Type::ParamError: 
            return "SC_AccountantFindCustomer_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AccountantFindCustomer_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AccountantFindCustomer_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AccountantFindCustomer_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantFindCustomer_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AccountantFindCustomer_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::ParamError: 
            return "SC_AcountantFindCustomerDetail_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AcountantFindCustomerDetail_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::NotFindOrder: 
            return "SC_AcountantFindCustomerDetail_Failure_Type::NotFindOrder 未找到该订单";
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::NotFindCustomer: 
            return "SC_AcountantFindCustomerDetail_Failure_Type::NotFindCustomer 未找到改公司";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::NotFindOrder: 
            return "未找到该订单";
        case SCPkgTypes::SC_AcountantFindCustomerDetail_Failure_Type::NotFindCustomer: 
            return "未找到改公司";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_UserChangeIcon_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_UserChangeIcon_Failure_Type::ParamError: 
            return "SC_UserChangeIcon_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_UserChangeIcon_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_UserChangeIcon_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_UserChangeIcon_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_UserChangeIcon_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_UserChangeIcon_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_CustomerHomePage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CustomerHomePage_Failure_Type::ParamError: 
            return "SC_CustomerHomePage_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_CustomerHomePage_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_CustomerHomePage_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_CustomerHomePage_Failure_Type::NotFindCustomer: 
            return "SC_CustomerHomePage_Failure_Type::NotFindCustomer 没有这个公司";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_CustomerHomePage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_CustomerHomePage_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_CustomerHomePage_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_CustomerHomePage_Failure_Type::NotFindCustomer: 
            return "没有这个公司";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_FindPushMessage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_FindPushMessage_Failure_Type::ParamError: 
            return "SC_FindPushMessage_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_FindPushMessage_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_FindPushMessage_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_FindPushMessage_Failure_Type::NotFindID: 
            return "SC_FindPushMessage_Failure_Type::NotFindID 没有这个客户";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_FindPushMessage_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_FindPushMessage_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_FindPushMessage_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_FindPushMessage_Failure_Type::NotFindID: 
            return "没有这个客户";
    }
}
char const* const EnumToString::Get( SCPkgTypes::SC_AccountantFindDocment_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantFindDocment_Failure_Type::ParamError: 
            return "SC_AccountantFindDocment_Failure_Type::ParamError 参数错误";
        case SCPkgTypes::SC_AccountantFindDocment_Failure_Type::BusinessLogicExcuteFailed: 
            return "SC_AccountantFindDocment_Failure_Type::BusinessLogicExcuteFailed 业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantFindDocment_Failure_Type::NotFindAccountant: 
            return "SC_AccountantFindDocment_Failure_Type::NotFindAccountant 没有这个会计";
    }
}
char const* const EnumToString::GetShow( SCPkgTypes::SC_AccountantFindDocment_Failure_Type e )
{
    switch(e)
    {
        case SCPkgTypes::SC_AccountantFindDocment_Failure_Type::ParamError: 
            return "参数错误";
        case SCPkgTypes::SC_AccountantFindDocment_Failure_Type::BusinessLogicExcuteFailed: 
            return "业务逻辑执行失败";
        case SCPkgTypes::SC_AccountantFindDocment_Failure_Type::NotFindAccountant: 
            return "没有这个会计";
    }
}