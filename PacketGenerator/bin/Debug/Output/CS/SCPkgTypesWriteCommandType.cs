
static class ByteBufferExt
{
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Register_Success v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Register_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Register_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Register_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_Register_IsExists_Success v)
    {
        bb.Write( SCPkgTypes.SC_Account_Register_IsExists_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_Register_IsExists_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Account_Register_IsExists_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_Login_Success v)
    {
        bb.Write( SCPkgTypes.SC_Account_Login_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_Login_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Account_Login_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetProduct_Success v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetProduct_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetProduct_Product v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetProduct_Product.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetProduct_Industry v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetProduct_Industry.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetProduct_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetProduct_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Product_Manage_Success v)
    {
        bb.Write( SCPkgTypes.SC_Product_Manage_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Product_Manage_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Product_Manage_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetDetails_ProductId v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetDetails_ProductId.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetDetails_Success v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetDetails_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Account_GetDetails_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Account_GetDetails_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Register_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Register_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Register_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Register_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Register_IsExists_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Register_IsExists_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Register_IsExists_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Register_IsExists_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Industry_AllSector_Success v)
    {
        bb.Write( SCPkgTypes.SC_Industry_AllSector_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Industry_AllSector_Industry v)
    {
        bb.Write( SCPkgTypes.SC_Industry_AllSector_Industry.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Industry_AllSector_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Industry_AllSector_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Login_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Login_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Login_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Login_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Acctountant_GetAround_Success v)
    {
        bb.Write( SCPkgTypes.SC_Acctountant_GetAround_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Acctountant_GetAround_Person v)
    {
        bb.Write( SCPkgTypes.SC_Acctountant_GetAround_Person.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Acctountant_GetAround_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Acctountant_GetAround_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Order_Create_Success v)
    {
        bb.Write( SCPkgTypes.SC_Order_Create_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Order_Create_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Order_Create_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Express_GetAll_Success v)
    {
        bb.Write( SCPkgTypes.SC_Express_GetAll_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Express_GetAll_Date v)
    {
        bb.Write( SCPkgTypes.SC_Express_GetAll_Date.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Express_GetAll_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Express_GetAll_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UncompletedOrder_GetList_Success v)
    {
        bb.Write( SCPkgTypes.SC_UncompletedOrder_GetList_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UncompletedOrder_GetList_Data v)
    {
        bb.Write( SCPkgTypes.SC_UncompletedOrder_GetList_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UncompletedOrder_GetList_Failure v)
    {
        bb.Write( SCPkgTypes.SC_UncompletedOrder_GetList_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Order_GetDetails_Success v)
    {
        bb.Write( SCPkgTypes.SC_Order_GetDetails_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Order_GetDetails_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Order_GetDetails_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Order_UpdateTotal_Success v)
    {
        bb.Write( SCPkgTypes.SC_Order_UpdateTotal_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Order_UpdateTotal_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Order_UpdateTotal_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Order_Confirm_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Order_Confirm_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Order_Confirm_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Order_Confirm_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Payment_Platform_Success v)
    {
        bb.Write( SCPkgTypes.SC_Get_Payment_Platform_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Payment_Platform_Data v)
    {
        bb.Write( SCPkgTypes.SC_Get_Payment_Platform_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Payment_Platform_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Get_Payment_Platform_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Deliver_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Deliver_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Deliver_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Deliver_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Receipt_Confirm_Success v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Receipt_Confirm_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Receipt_Confirm_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Receipt_Confirm_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Create_Report_Success v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Create_Report_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Create_Report_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Create_Report_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Report_Month_Success v)
    {
        bb.Write( SCPkgTypes.SC_Get_Report_Month_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Report_Month_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Get_Report_Month_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Report_Quarter_Success v)
    {
        bb.Write( SCPkgTypes.SC_Get_Report_Quarter_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Get_Report_Quarter_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Get_Report_Quarter_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Report_Confirm_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Report_Confirm_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Report_Confirm_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Report_Confirm_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Send_Back_Success v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Send_Back_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Send_Back_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Send_Back_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Order_Recive_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Order_Recive_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Order_Recive_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Order_Recive_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Order_Back_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Order_Back_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Order_Back_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Order_Back_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Cancel_Order_Success v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Cancel_Order_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_Cancel_Order_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_Cancel_Order_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Cancel_Order_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Cancel_Order_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_Cancel_Order_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_Cancel_Order_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_GetList_Success v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_GetList_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_GetList_Data v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_GetList_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Accountant_GetList_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Accountant_GetList_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CompeletedOrder_GetList_Success v)
    {
        bb.Write( SCPkgTypes.SC_CompeletedOrder_GetList_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CompeletedOrder_GetList_Data v)
    {
        bb.Write( SCPkgTypes.SC_CompeletedOrder_GetList_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CompeletedOrder_GetList_Failure v)
    {
        bb.Write( SCPkgTypes.SC_CompeletedOrder_GetList_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Grade_AccountantService_Success v)
    {
        bb.Write( SCPkgTypes.SC_Grade_AccountantService_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Grade_AccountantService_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Grade_AccountantService_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantCredentials_Upload_Success v)
    {
        bb.Write( SCPkgTypes.SC_AccountantCredentials_Upload_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantCredentials_Upload_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AccountantCredentials_Upload_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UnionPayTn_Get_Success v)
    {
        bb.Write( SCPkgTypes.SC_UnionPayTn_Get_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UnionPayTn_Get_Failure v)
    {
        bb.Write( SCPkgTypes.SC_UnionPayTn_Get_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Delete_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Delete_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Delete_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Delete_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Success v)
    {
        bb.Write( SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_file_info v)
    {
        bb.Write( SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_file_info.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Data v)
    {
        bb.Write( SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Failure v)
    {
        bb.Write( SCPkgTypes.SC_GetAccountantUncompletedOrderList_web_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantElectronicBusinessCard_Get_Success v)
    {
        bb.Write( SCPkgTypes.SC_AccountantElectronicBusinessCard_Get_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantElectronicBusinessCard_Get_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AccountantElectronicBusinessCard_Get_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Communication_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Communication_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountanPictureDown_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_AccountanPictureDown_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountanPictureDown_Success v)
    {
        bb.Write( SCPkgTypes.SC_AccountanPictureDown_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountanPictureDown_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AccountanPictureDown_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindReportCustom_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_FindReportCustom_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindReportCustom_Success v)
    {
        bb.Write( SCPkgTypes.SC_FindReportCustom_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindReportCustom_Failure v)
    {
        bb.Write( SCPkgTypes.SC_FindReportCustom_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_UploadElectronicBill_Success v)
    {
        bb.Write( SCPkgTypes.SC_Customer_UploadElectronicBill_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Customer_UploadElectronicBill_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Customer_UploadElectronicBill_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetElectronicBill_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_GetElectronicBill_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetElectronicBill_Success v)
    {
        bb.Write( SCPkgTypes.SC_GetElectronicBill_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_GetElectronicBill_Failure v)
    {
        bb.Write( SCPkgTypes.SC_GetElectronicBill_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerGetOrderState_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_CustomerGetOrderState_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerGetOrderState_Success v)
    {
        bb.Write( SCPkgTypes.SC_CustomerGetOrderState_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerGetOrderState_Failure v)
    {
        bb.Write( SCPkgTypes.SC_CustomerGetOrderState_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Year_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Year_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Year_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Year_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Quarter_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Quarter_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Quarter_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Quarter_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Month_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Month_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Upload_Month_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Upload_Month_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Year_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Year_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Year_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Year_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Quarter_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Quarter_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Quarter_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Quarter_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Month_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Month_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Download_Month_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Download_Month_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFileList_Download_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_ReportFileList_Download_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFileList_Download_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFileList_Download_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFileList_Download_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFileList_Download_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFileOrder_Download_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFileOrder_Download_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFileOrder_Download_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFileOrder_Download_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CheckAccountantInformation_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_CheckAccountantInformation_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CheckAccountantInformation_Success v)
    {
        bb.Write( SCPkgTypes.SC_CheckAccountantInformation_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CheckAccountantInformation_Failure v)
    {
        bb.Write( SCPkgTypes.SC_CheckAccountantInformation_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CheckReportFileFromID_Success v)
    {
        bb.Write( SCPkgTypes.SC_CheckReportFileFromID_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CheckReportFileFromID_Failure v)
    {
        bb.Write( SCPkgTypes.SC_CheckReportFileFromID_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Find_Year_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Find_Year_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Find_Year_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Find_Year_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Find_Quarter_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Find_Quarter_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Find_Quarter_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Find_Quarter_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Find_Month_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Find_Month_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReportFile_Find_Month_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReportFile_Find_Month_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_DealAccountantList_Success v)
    {
        bb.Write( SCPkgTypes.SC_DealAccountantList_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_DealAccountantList_Data v)
    {
        bb.Write( SCPkgTypes.SC_DealAccountantList_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_DealAccountantList_Failure v)
    {
        bb.Write( SCPkgTypes.SC_DealAccountantList_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ChangeAccountantInformation_Success v)
    {
        bb.Write( SCPkgTypes.SC_ChangeAccountantInformation_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ChangeAccountantInformation_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ChangeAccountantInformation_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReturnAccountantInformation_Success v)
    {
        bb.Write( SCPkgTypes.SC_ReturnAccountantInformation_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_ReturnAccountantInformation_Failure v)
    {
        bb.Write( SCPkgTypes.SC_ReturnAccountantInformation_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantHomePage_Success v)
    {
        bb.Write( SCPkgTypes.SC_AccountantHomePage_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantHomePage_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AccountantHomePage_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerAnonymous_Success v)
    {
        bb.Write( SCPkgTypes.SC_CustomerAnonymous_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerAnonymous_Failure v)
    {
        bb.Write( SCPkgTypes.SC_CustomerAnonymous_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_Anonymous_Failure v)
    {
        bb.Write( SCPkgTypes.SC_Anonymous_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindAccountantCredentials_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_FindAccountantCredentials_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindAccountantCredentials_Success v)
    {
        bb.Write( SCPkgTypes.SC_FindAccountantCredentials_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindAccountantCredentials_Failure v)
    {
        bb.Write( SCPkgTypes.SC_FindAccountantCredentials_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantFindCustomer_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_AccountantFindCustomer_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantFindCustomer_Success v)
    {
        bb.Write( SCPkgTypes.SC_AccountantFindCustomer_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantFindCustomer_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AccountantFindCustomer_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AcountantFindCustomerDetail_Success v)
    {
        bb.Write( SCPkgTypes.SC_AcountantFindCustomerDetail_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AcountantFindCustomerDetail_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AcountantFindCustomerDetail_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UserChangeIcon_Success v)
    {
        bb.Write( SCPkgTypes.SC_UserChangeIcon_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_UserChangeIcon_Failure v)
    {
        bb.Write( SCPkgTypes.SC_UserChangeIcon_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerHomePage_Success v)
    {
        bb.Write( SCPkgTypes.SC_CustomerHomePage_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_CustomerHomePage_Failure v)
    {
        bb.Write( SCPkgTypes.SC_CustomerHomePage_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindPushMessage_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_FindPushMessage_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindPushMessage_Success v)
    {
        bb.Write( SCPkgTypes.SC_FindPushMessage_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_FindPushMessage_Failure v)
    {
        bb.Write( SCPkgTypes.SC_FindPushMessage_Failure.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantFindDocment_Success_Data v)
    {
        bb.Write( SCPkgTypes.SC_AccountantFindDocment_Success_Data.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantFindDocment_Success v)
    {
        bb.Write( SCPkgTypes.SC_AccountantFindDocment_Success.commandType );
        bb.Write( v );
    } 
    public static void WriteCommand(this ByteBuffer bb,SCPkgTypes.SC_AccountantFindDocment_Failure v)
    {
        bb.Write( SCPkgTypes.SC_AccountantFindDocment_Failure.commandType );
        bb.Write( v );
    } 
}