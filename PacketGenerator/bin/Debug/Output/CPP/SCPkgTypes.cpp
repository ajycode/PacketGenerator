
#include "SCPkgTypes.h"
using namespace xxlib;
namespace SCPkgTypes
{
        const short SCPkgTypes::SC_Accountant_Register_Success::commandType = 1;
        const short SCPkgTypes::SC_Accountant_Register_Failure::commandType = 2;
        const short SCPkgTypes::SC_Account_Register_IsExists_Success::commandType = 3;
        const short SCPkgTypes::SC_Account_Register_IsExists_Failure::commandType = 4;
        const short SCPkgTypes::SC_Account_Login_Success::commandType = 5;
        const short SCPkgTypes::SC_Account_Login_Failure::commandType = 6;
        const short SCPkgTypes::SC_Account_GetProduct_Success::commandType = 7;
        const short SCPkgTypes::SC_Account_GetProduct_Product::commandType = 8;
        const short SCPkgTypes::SC_Account_GetProduct_Industry::commandType = 9;
        const short SCPkgTypes::SC_Account_GetProduct_Failure::commandType = 10;
        const short SCPkgTypes::SC_Product_Manage_Success::commandType = 11;
        const short SCPkgTypes::SC_Product_Manage_Failure::commandType = 12;
        const short SCPkgTypes::SC_Account_GetDetails_ProductId::commandType = 13;
        const short SCPkgTypes::SC_Account_GetDetails_Success::commandType = 14;
        const short SCPkgTypes::SC_Account_GetDetails_Failure::commandType = 15;
        const short SCPkgTypes::SC_Customer_Register_Success::commandType = 16;
        const short SCPkgTypes::SC_Customer_Register_Failure::commandType = 17;
        const short SCPkgTypes::SC_Customer_Register_IsExists_Success::commandType = 18;
        const short SCPkgTypes::SC_Customer_Register_IsExists_Failure::commandType = 19;
        const short SCPkgTypes::SC_Industry_AllSector_Success::commandType = 20;
        const short SCPkgTypes::SC_Industry_AllSector_Industry::commandType = 21;
        const short SCPkgTypes::SC_Industry_AllSector_Failure::commandType = 22;
        const short SCPkgTypes::SC_Customer_Login_Success::commandType = 23;
        const short SCPkgTypes::SC_Customer_Login_Failure::commandType = 24;
        const short SCPkgTypes::SC_Acctountant_GetAround_Success::commandType = 25;
        const short SCPkgTypes::SC_Acctountant_GetAround_Person::commandType = 26;
        const short SCPkgTypes::SC_Acctountant_GetAround_Failure::commandType = 27;
        const short SCPkgTypes::SC_Order_Create_Success::commandType = 28;
        const short SCPkgTypes::SC_Order_Create_Failure::commandType = 29;
        const short SCPkgTypes::SC_Express_GetAll_Success::commandType = 30;
        const short SCPkgTypes::SC_Express_GetAll_Date::commandType = 31;
        const short SCPkgTypes::SC_Express_GetAll_Failure::commandType = 32;
        const short SCPkgTypes::SC_UncompletedOrder_GetList_Success::commandType = 33;
        const short SCPkgTypes::SC_UncompletedOrder_GetList_Data::commandType = 34;
        const short SCPkgTypes::SC_UncompletedOrder_GetList_Failure::commandType = 35;
        const short SCPkgTypes::SC_Order_GetDetails_Success::commandType = 36;
        const short SCPkgTypes::SC_Order_GetDetails_Failure::commandType = 37;
        const short SCPkgTypes::SC_Order_UpdateTotal_Success::commandType = 38;
        const short SCPkgTypes::SC_Order_UpdateTotal_Failure::commandType = 39;
        const short SCPkgTypes::SC_Customer_Order_Confirm_Success::commandType = 40;
        const short SCPkgTypes::SC_Customer_Order_Confirm_Failure::commandType = 41;
        const short SCPkgTypes::SC_Get_Payment_Platform_Success::commandType = 42;
        const short SCPkgTypes::SC_Get_Payment_Platform_Data::commandType = 43;
        const short SCPkgTypes::SC_Get_Payment_Platform_Failure::commandType = 44;
        const short SCPkgTypes::SC_Customer_Deliver_Success::commandType = 45;
        const short SCPkgTypes::SC_Customer_Deliver_Failure::commandType = 46;
        const short SCPkgTypes::SC_Accountant_Receipt_Confirm_Success::commandType = 47;
        const short SCPkgTypes::SC_Accountant_Receipt_Confirm_Failure::commandType = 48;
        const short SCPkgTypes::SC_Accountant_Create_Report_Success::commandType = 49;
        const short SCPkgTypes::SC_Accountant_Create_Report_Failure::commandType = 50;
        const short SCPkgTypes::SC_Get_Report_Month_Success::commandType = 51;
        const short SCPkgTypes::SC_Get_Report_Month_Failure::commandType = 52;
        const short SCPkgTypes::SC_Get_Report_Quarter_Success::commandType = 53;
        const short SCPkgTypes::SC_Get_Report_Quarter_Failure::commandType = 54;
        const short SCPkgTypes::SC_Customer_Report_Confirm_Success::commandType = 55;
        const short SCPkgTypes::SC_Customer_Report_Confirm_Failure::commandType = 56;
        const short SCPkgTypes::SC_Accountant_Send_Back_Success::commandType = 57;
        const short SCPkgTypes::SC_Accountant_Send_Back_Failure::commandType = 58;
        const short SCPkgTypes::SC_Customer_Order_Recive_Success::commandType = 59;
        const short SCPkgTypes::SC_Customer_Order_Recive_Failure::commandType = 60;
        const short SCPkgTypes::SC_Customer_Order_Back_Success::commandType = 61;
        const short SCPkgTypes::SC_Customer_Order_Back_Failure::commandType = 62;
        const short SCPkgTypes::SC_Accountant_Cancel_Order_Success::commandType = 63;
        const short SCPkgTypes::SC_Accountant_Cancel_Order_Failure::commandType = 64;
        const short SCPkgTypes::SC_Customer_Cancel_Order_Success::commandType = 65;
        const short SCPkgTypes::SC_Customer_Cancel_Order_Failure::commandType = 66;
        const short SCPkgTypes::SC_Accountant_GetList_Success::commandType = 67;
        const short SCPkgTypes::SC_Accountant_GetList_Data::commandType = 68;
        const short SCPkgTypes::SC_Accountant_GetList_Failure::commandType = 69;
        const short SCPkgTypes::SC_CompeletedOrder_GetList_Success::commandType = 70;
        const short SCPkgTypes::SC_CompeletedOrder_GetList_Data::commandType = 71;
        const short SCPkgTypes::SC_CompeletedOrder_GetList_Failure::commandType = 72;
        const short SCPkgTypes::SC_Grade_AccountantService_Success::commandType = 73;
        const short SCPkgTypes::SC_Grade_AccountantService_Failure::commandType = 74;
        const short SCPkgTypes::SC_AccountantCredentials_Upload_Success::commandType = 75;
        const short SCPkgTypes::SC_AccountantCredentials_Upload_Failure::commandType = 76;
        const short SCPkgTypes::SC_UnionPayTn_Get_Success::commandType = 77;
        const short SCPkgTypes::SC_UnionPayTn_Get_Failure::commandType = 78;
        const short SCPkgTypes::SC_ReportFile_Upload_Success::commandType = 79;
        const short SCPkgTypes::SC_ReportFile_Upload_Failure::commandType = 80;
        const short SCPkgTypes::SC_ReportFile_Download_Success::commandType = 81;
        const short SCPkgTypes::SC_ReportFile_Download_Failure::commandType = 82;
        const short SCPkgTypes::SC_ReportFile_Delete_Success::commandType = 83;
        const short SCPkgTypes::SC_ReportFile_Delete_Failure::commandType = 84;
        const short SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Success::commandType = 85;
        const short SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_file_info::commandType = 86;
        const short SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Data::commandType = 87;
        const short SCPkgTypes::SC_GetAccountantUncompletedOrderList_web_Failure::commandType = 88;
        const short SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Success::commandType = 89;
        const short SCPkgTypes::SC_AccountantElectronicBusinessCard_Get_Failure::commandType = 90;
        const short SCPkgTypes::SC_Communication_Failure::commandType = 91;
        const short SCPkgTypes::SC_AccountanPictureDown_Success_Data::commandType = 92;
        const short SCPkgTypes::SC_AccountanPictureDown_Success::commandType = 93;
        const short SCPkgTypes::SC_AccountanPictureDown_Failure::commandType = 94;
        const short SCPkgTypes::SC_FindReportCustom_Success_Data::commandType = 95;
        const short SCPkgTypes::SC_FindReportCustom_Success::commandType = 96;
        const short SCPkgTypes::SC_FindReportCustom_Failure::commandType = 97;
        const short SCPkgTypes::SC_Customer_UploadElectronicBill_Success::commandType = 98;
        const short SCPkgTypes::SC_Customer_UploadElectronicBill_Failure::commandType = 99;
        const short SCPkgTypes::SC_GetElectronicBill_Success_Data::commandType = 100;
        const short SCPkgTypes::SC_GetElectronicBill_Success::commandType = 101;
        const short SCPkgTypes::SC_GetElectronicBill_Failure::commandType = 102;
        const short SCPkgTypes::SC_CustomerGetOrderState_Success_Data::commandType = 103;
        const short SCPkgTypes::SC_CustomerGetOrderState_Success::commandType = 104;
        const short SCPkgTypes::SC_CustomerGetOrderState_Failure::commandType = 105;
        const short SCPkgTypes::SC_ReportFile_Upload_Year_Success::commandType = 106;
        const short SCPkgTypes::SC_ReportFile_Upload_Year_Failure::commandType = 107;
        const short SCPkgTypes::SC_ReportFile_Upload_Quarter_Success::commandType = 108;
        const short SCPkgTypes::SC_ReportFile_Upload_Quarter_Failure::commandType = 109;
        const short SCPkgTypes::SC_ReportFile_Upload_Month_Success::commandType = 110;
        const short SCPkgTypes::SC_ReportFile_Upload_Month_Failure::commandType = 111;
        const short SCPkgTypes::SC_ReportFile_Download_Year_Success::commandType = 112;
        const short SCPkgTypes::SC_ReportFile_Download_Year_Failure::commandType = 113;
        const short SCPkgTypes::SC_ReportFile_Download_Quarter_Success::commandType = 114;
        const short SCPkgTypes::SC_ReportFile_Download_Quarter_Failure::commandType = 115;
        const short SCPkgTypes::SC_ReportFile_Download_Month_Success::commandType = 116;
        const short SCPkgTypes::SC_ReportFile_Download_Month_Failure::commandType = 117;
        const short SCPkgTypes::SC_ReportFileList_Download_Success_Data::commandType = 118;
        const short SCPkgTypes::SC_ReportFileList_Download_Success::commandType = 119;
        const short SCPkgTypes::SC_ReportFileList_Download_Failure::commandType = 120;
        const short SCPkgTypes::SC_ReportFileOrder_Download_Success::commandType = 121;
        const short SCPkgTypes::SC_ReportFileOrder_Download_Failure::commandType = 122;
        const short SCPkgTypes::SC_CheckAccountantInformation_Success_Data::commandType = 123;
        const short SCPkgTypes::SC_CheckAccountantInformation_Success::commandType = 124;
        const short SCPkgTypes::SC_CheckAccountantInformation_Failure::commandType = 125;
        const short SCPkgTypes::SC_CheckReportFileFromID_Success::commandType = 126;
        const short SCPkgTypes::SC_CheckReportFileFromID_Failure::commandType = 127;
        const short SCPkgTypes::SC_ReportFile_Find_Year_Success::commandType = 128;
        const short SCPkgTypes::SC_ReportFile_Find_Year_Failure::commandType = 129;
        const short SCPkgTypes::SC_ReportFile_Find_Quarter_Success::commandType = 130;
        const short SCPkgTypes::SC_ReportFile_Find_Quarter_Failure::commandType = 131;
        const short SCPkgTypes::SC_ReportFile_Find_Month_Success::commandType = 132;
        const short SCPkgTypes::SC_ReportFile_Find_Month_Failure::commandType = 133;
        const short SCPkgTypes::SC_DealAccountantList_Success::commandType = 134;
        const short SCPkgTypes::SC_DealAccountantList_Data::commandType = 135;
        const short SCPkgTypes::SC_DealAccountantList_Failure::commandType = 136;
        const short SCPkgTypes::SC_ChangeAccountantInformation_Success::commandType = 137;
        const short SCPkgTypes::SC_ChangeAccountantInformation_Failure::commandType = 138;
        const short SCPkgTypes::SC_ReturnAccountantInformation_Success::commandType = 139;
        const short SCPkgTypes::SC_ReturnAccountantInformation_Failure::commandType = 140;
        const short SCPkgTypes::SC_AccountantHomePage_Success::commandType = 141;
        const short SCPkgTypes::SC_AccountantHomePage_Failure::commandType = 142;
        const short SCPkgTypes::SC_CustomerAnonymous_Success::commandType = 143;
        const short SCPkgTypes::SC_CustomerAnonymous_Failure::commandType = 144;
        const short SCPkgTypes::SC_Anonymous_Failure::commandType = 145;
        const short SCPkgTypes::SC_FindAccountantCredentials_Success_Data::commandType = 146;
        const short SCPkgTypes::SC_FindAccountantCredentials_Success::commandType = 147;
        const short SCPkgTypes::SC_FindAccountantCredentials_Failure::commandType = 148;
        const short SCPkgTypes::SC_AccountantFindCustomer_Success_Data::commandType = 149;
        const short SCPkgTypes::SC_AccountantFindCustomer_Success::commandType = 150;
        const short SCPkgTypes::SC_AccountantFindCustomer_Failure::commandType = 151;
        const short SCPkgTypes::SC_AcountantFindCustomerDetail_Success::commandType = 152;
        const short SCPkgTypes::SC_AcountantFindCustomerDetail_Failure::commandType = 153;
        const short SCPkgTypes::SC_UserChangeIcon_Success::commandType = 154;
        const short SCPkgTypes::SC_UserChangeIcon_Failure::commandType = 155;
        const short SCPkgTypes::SC_CustomerHomePage_Success::commandType = 156;
        const short SCPkgTypes::SC_CustomerHomePage_Failure::commandType = 157;
        const short SCPkgTypes::SC_FindPushMessage_Success_Data::commandType = 158;
        const short SCPkgTypes::SC_FindPushMessage_Success::commandType = 159;
        const short SCPkgTypes::SC_FindPushMessage_Failure::commandType = 160;
        const short SCPkgTypes::SC_AccountantFindDocment_Success_Data::commandType = 161;
        const short SCPkgTypes::SC_AccountantFindDocment_Success::commandType = 162;
        const short SCPkgTypes::SC_AccountantFindDocment_Failure::commandType = 163;
        void SC_Accountant_Register_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name, headIcon ); 
        }

        bool SC_Accountant_Register_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( headIcon, 0, 600 ) ) return false;
            return true;
        }
        void SC_Accountant_Register_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Accountant_Register_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Account_Register_IsExists_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_Account_Register_IsExists_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_Account_Register_IsExists_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Account_Register_IsExists_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Account_Login_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name, headIcon ); 
        }

        bool SC_Account_Login_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( headIcon, 0, 600 ) ) return false;
            return true;
        }
        void SC_Account_Login_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Account_Login_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Account_GetProduct_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( products, industrys ); 
        }

        bool SC_Account_GetProduct_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( products ) ) return false;
            if( !bb.Read( industrys ) ) return false;
            return true;
        }
        void SC_Account_GetProduct_Product::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( productID, productname, accountantID, createtime, price, industryID, description ); 
        }

        bool SC_Account_GetProduct_Product::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( productID ) ) return false;
            if( !bb.Read( productname, 0, 1150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( createtime ) ) return false;
            if( !bb.Read( price ) ) return false;
            if( !bb.Read( industryID ) ) return false;
            if( !bb.Read( description, 0, 600 ) ) return false;
            return true;
        }
        void SC_Account_GetProduct_Industry::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name ); 
        }

        bool SC_Account_GetProduct_Industry::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 1150 ) ) return false;
            return true;
        }
        void SC_Account_GetProduct_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Account_GetProduct_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Product_Manage_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_Product_Manage_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_Product_Manage_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Product_Manage_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Account_GetDetails_ProductId::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( productId, productName, price, idustry ); 
        }

        bool SC_Account_GetDetails_ProductId::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( productId ) ) return false;
            if( !bb.Read( productName, 0, 1150 ) ) return false;
            if( !bb.Read( price ) ) return false;
            if( !bb.Read( idustry, 0, 900 ) ) return false;
            return true;
        }
        void SC_Account_GetDetails_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, nickName, idNumber, certificateNum, state, name, acceptanceAddress, businessAddress, phone, gender, email, headShot, longitude, latitude, selfIntroduction, product ); 
        }

        bool SC_Account_GetDetails_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( nickName ) ) return false;
            if( !bb.Read( idNumber ) ) return false;
            if( !bb.Read( certificateNum ) ) return false;
            if( !bb.Read( state ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( acceptanceAddress, 0, 900 ) ) return false;
            if( !bb.Read( businessAddress, 0, 900 ) ) return false;
            if( !bb.Read( phone, 0, 60 ) ) return false;
            if( !bb.Read( gender, 0, 3 ) ) return false;
            if( !bb.Read( email, 0, 1150 ) ) return false;
            if( !bb.Read( headShot, 0, 900 ) ) return false;
            if( !bb.Read( longitude ) ) return false;
            if( !bb.Read( latitude ) ) return false;
            if( !bb.Read( selfIntroduction, 0, 11500 ) ) return false;
            if( !bb.Read( product ) ) return false;
            return true;
        }
        void SC_Account_GetDetails_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Account_GetDetails_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Register_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id ); 
        }

        bool SC_Customer_Register_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            return true;
        }
        void SC_Customer_Register_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Register_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Register_IsExists_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_Customer_Register_IsExists_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_Customer_Register_IsExists_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Register_IsExists_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Industry_AllSector_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( industrys ); 
        }

        bool SC_Industry_AllSector_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( industrys ) ) return false;
            return true;
        }
        void SC_Industry_AllSector_Industry::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name ); 
        }

        bool SC_Industry_AllSector_Industry::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 1150 ) ) return false;
            return true;
        }
        void SC_Industry_AllSector_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Industry_AllSector_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Login_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name ); 
        }

        bool SC_Customer_Login_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 150 ) ) return false;
            return true;
        }
        void SC_Customer_Login_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Login_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Acctountant_GetAround_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( person ); 
        }

        bool SC_Acctountant_GetAround_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( person ) ) return false;
            return true;
        }
        void SC_Acctountant_GetAround_Person::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name, accountantAuth, introduction, completeCount, grade, longitude, latitude ); 
        }

        bool SC_Acctountant_GetAround_Person::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( accountantAuth, 0, 150 ) ) return false;
            if( !bb.Read( introduction, 0, 3000 ) ) return false;
            if( !bb.Read( completeCount ) ) return false;
            if( !bb.Read( grade ) ) return false;
            if( !bb.Read( longitude ) ) return false;
            if( !bb.Read( latitude ) ) return false;
            return true;
        }
        void SC_Acctountant_GetAround_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Acctountant_GetAround_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Order_Create_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Order_Create_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Order_Create_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Order_Create_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Express_GetAll_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( person ); 
        }

        bool SC_Express_GetAll_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( person ) ) return false;
            return true;
        }
        void SC_Express_GetAll_Date::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( productId, productName, price ); 
        }

        bool SC_Express_GetAll_Date::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( productId ) ) return false;
            if( !bb.Read( productName, 0, 1150 ) ) return false;
            if( !bb.Read( price ) ) return false;
            return true;
        }
        void SC_Express_GetAll_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Express_GetAll_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_UncompletedOrder_GetList_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_UncompletedOrder_GetList_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_UncompletedOrder_GetList_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( orderId, name, orderDate, stateCode, total, idView, number ); 
        }

        bool SC_UncompletedOrder_GetList_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( orderId, 0, 1150 ) ) return false;
            if( !bb.Read( name, 0, 1150 ) ) return false;
            if( !bb.Read( orderDate ) ) return false;
            if( !bb.Read( stateCode ) ) return false;
            if( !bb.Read( total ) ) return false;
            if( !bb.Read( idView, 0, 1150 ) ) return false;
            if( !bb.Read( number ) ) return false;
            return true;
        }
        void SC_UncompletedOrder_GetList_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_UncompletedOrder_GetList_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Order_GetDetails_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( orderID, companyName, companyType, taxQualification, companyAdress, contact, customerPhone, accountantName, accountantPhone, accountantAdress, count, total, createTime, startTime, endTime, cycle, stateCode, remark, idView, product, expressNumber, expressTel ); 
        }

        bool SC_Order_GetDetails_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( orderID, 0, 1150 ) ) return false;
            if( !bb.Read( companyName, 0, 1150 ) ) return false;
            if( !bb.Read( companyType, 0, 1150 ) ) return false;
            if( !bb.Read( taxQualification, 0, 1150 ) ) return false;
            if( !bb.Read( companyAdress, 0, 900 ) ) return false;
            if( !bb.Read( contact, 0, 90 ) ) return false;
            if( !bb.Read( customerPhone, 0, 60 ) ) return false;
            if( !bb.Read( accountantName, 0, 90 ) ) return false;
            if( !bb.Read( accountantPhone, 0, 60 ) ) return false;
            if( !bb.Read( accountantAdress, 0, 1150 ) ) return false;
            if( !bb.Read( count ) ) return false;
            if( !bb.Read( total ) ) return false;
            if( !bb.Read( createTime ) ) return false;
            if( !bb.Read( startTime ) ) return false;
            if( !bb.Read( endTime ) ) return false;
            if( !bb.Read( cycle ) ) return false;
            if( !bb.Read( stateCode ) ) return false;
            if( !bb.Read( remark, 0, 600 ) ) return false;
            if( !bb.Read( idView, 0, 1150 ) ) return false;
            if( !bb.Read( product, 0, 1150 ) ) return false;
            if( !bb.Read( expressNumber, 0, 1150 ) ) return false;
            if( !bb.Read( expressTel, 0, 1150 ) ) return false;
            return true;
        }
        void SC_Order_GetDetails_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Order_GetDetails_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Order_UpdateTotal_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Order_UpdateTotal_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Order_UpdateTotal_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Order_UpdateTotal_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Order_Confirm_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Customer_Order_Confirm_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Customer_Order_Confirm_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Order_Confirm_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Get_Payment_Platform_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_Get_Payment_Platform_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_Get_Payment_Platform_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name ); 
        }

        bool SC_Get_Payment_Platform_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 1150 ) ) return false;
            return true;
        }
        void SC_Get_Payment_Platform_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Get_Payment_Platform_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Deliver_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Customer_Deliver_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Customer_Deliver_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Deliver_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Accountant_Receipt_Confirm_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Accountant_Receipt_Confirm_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Accountant_Receipt_Confirm_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Accountant_Receipt_Confirm_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Accountant_Create_Report_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Accountant_Create_Report_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Accountant_Create_Report_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Accountant_Create_Report_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Get_Report_Month_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( national_tax_total, land_tax_total, non_tax_income_total, national_tax, land_tax ); 
        }

        bool SC_Get_Report_Month_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( national_tax_total ) ) return false;
            if( !bb.Read( land_tax_total ) ) return false;
            if( !bb.Read( non_tax_income_total ) ) return false;
            if( !bb.Read( national_tax, 0, 900 ) ) return false;
            if( !bb.Read( land_tax, 0, 11500 ) ) return false;
            return true;
        }
        void SC_Get_Report_Month_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Get_Report_Month_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Get_Report_Quarter_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( national_tax_total, land_tax_total, non_tax_income_total, national_tax, land_tax ); 
        }

        bool SC_Get_Report_Quarter_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( national_tax_total ) ) return false;
            if( !bb.Read( land_tax_total ) ) return false;
            if( !bb.Read( non_tax_income_total ) ) return false;
            if( !bb.Read( national_tax, 0, 900 ) ) return false;
            if( !bb.Read( land_tax, 0, 11500 ) ) return false;
            return true;
        }
        void SC_Get_Report_Quarter_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Get_Report_Quarter_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Report_Confirm_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Customer_Report_Confirm_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Customer_Report_Confirm_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Report_Confirm_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Accountant_Send_Back_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Accountant_Send_Back_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Accountant_Send_Back_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Accountant_Send_Back_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Order_Recive_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Customer_Order_Recive_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Customer_Order_Recive_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Order_Recive_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Order_Back_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Customer_Order_Back_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Customer_Order_Back_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Order_Back_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Accountant_Cancel_Order_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Accountant_Cancel_Order_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Accountant_Cancel_Order_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Accountant_Cancel_Order_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_Cancel_Order_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( isPushSuccess ); 
        }

        bool SC_Customer_Cancel_Order_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( isPushSuccess ) ) return false;
            return true;
        }
        void SC_Customer_Cancel_Order_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_Cancel_Order_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Accountant_GetList_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_Accountant_GetList_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_Accountant_GetList_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name, phone, headShot, completedorder, industry, productname, productID, price ); 
        }

        bool SC_Accountant_GetList_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( phone, 0, 60 ) ) return false;
            if( !bb.Read( headShot, 0, 900 ) ) return false;
            if( !bb.Read( completedorder ) ) return false;
            if( !bb.Read( industry, 0, 1150 ) ) return false;
            if( !bb.Read( productname, 0, 1150 ) ) return false;
            if( !bb.Read( productID ) ) return false;
            if( !bb.Read( price ) ) return false;
            return true;
        }
        void SC_Accountant_GetList_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Accountant_GetList_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_CompeletedOrder_GetList_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_CompeletedOrder_GetList_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_CompeletedOrder_GetList_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( orderId, name, orderDate, stateCode, total, idView, number ); 
        }

        bool SC_CompeletedOrder_GetList_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( orderId, 0, 1150 ) ) return false;
            if( !bb.Read( name, 0, 1150 ) ) return false;
            if( !bb.Read( orderDate ) ) return false;
            if( !bb.Read( stateCode ) ) return false;
            if( !bb.Read( total ) ) return false;
            if( !bb.Read( idView, 0, 1150 ) ) return false;
            if( !bb.Read( number ) ) return false;
            return true;
        }
        void SC_CompeletedOrder_GetList_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_CompeletedOrder_GetList_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Grade_AccountantService_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_Grade_AccountantService_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_Grade_AccountantService_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Grade_AccountantService_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AccountantCredentials_Upload_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_AccountantCredentials_Upload_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_AccountantCredentials_Upload_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AccountantCredentials_Upload_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_UnionPayTn_Get_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( tn ); 
        }

        bool SC_UnionPayTn_Get_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( tn, 0, 1150 ) ) return false;
            return true;
        }
        void SC_UnionPayTn_Get_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_UnionPayTn_Get_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Upload_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_ReportFile_Upload_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_ReportFile_Upload_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Upload_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileContent ); 
        }

        bool SC_ReportFile_Download_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Download_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Delete_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_ReportFile_Delete_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_ReportFile_Delete_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Delete_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_GetAccountantUncompletedOrderList_web_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_GetAccountantUncompletedOrderList_web_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_GetAccountantUncompletedOrderList_web_file_info::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( file_id, file_name ); 
        }

        bool SC_GetAccountantUncompletedOrderList_web_file_info::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( file_id ) ) return false;
            if( !bb.Read( file_name ) ) return false;
            return true;
        }
        void SC_GetAccountantUncompletedOrderList_web_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( orderID, customerID, companyName, orderDate, orderStartDate, stateCode, total, iDView, number, file_info_list ); 
        }

        bool SC_GetAccountantUncompletedOrderList_web_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( orderID, 0, 50 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( companyName, 0, 50 ) ) return false;
            if( !bb.Read( orderDate ) ) return false;
            if( !bb.Read( orderStartDate ) ) return false;
            if( !bb.Read( stateCode ) ) return false;
            if( !bb.Read( total ) ) return false;
            if( !bb.Read( iDView ) ) return false;
            if( !bb.Read( number ) ) return false;
            if( !bb.Read( file_info_list ) ) return false;
            return true;
        }
        void SC_GetAccountantUncompletedOrderList_web_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_GetAccountantUncompletedOrderList_web_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AccountantElectronicBusinessCard_Get_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( completedOrder, name, rank ); 
        }

        bool SC_AccountantElectronicBusinessCard_Get_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( completedOrder ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( rank ) ) return false;
            return true;
        }
        void SC_AccountantElectronicBusinessCard_Get_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AccountantElectronicBusinessCard_Get_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Communication_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Communication_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AccountanPictureDown_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileContent, picName ); 
        }

        bool SC_AccountanPictureDown_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( picName, 0, 150 ) ) return false;
            return true;
        }
        void SC_AccountanPictureDown_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_AccountanPictureDown_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_AccountanPictureDown_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AccountanPictureDown_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_FindReportCustom_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( productName, customerName, national_tax_total, land_tax_total, non_tax_income_total, national_tax, land_tax ); 
        }

        bool SC_FindReportCustom_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( productName, 0, 150 ) ) return false;
            if( !bb.Read( customerName, 0, 150 ) ) return false;
            if( !bb.Read( national_tax_total ) ) return false;
            if( !bb.Read( land_tax_total ) ) return false;
            if( !bb.Read( non_tax_income_total ) ) return false;
            if( !bb.Read( national_tax, 0, 900 ) ) return false;
            if( !bb.Read( land_tax, 0, 11500 ) ) return false;
            return true;
        }
        void SC_FindReportCustom_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_FindReportCustom_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_FindReportCustom_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_FindReportCustom_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Customer_UploadElectronicBill_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_Customer_UploadElectronicBill_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_Customer_UploadElectronicBill_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Customer_UploadElectronicBill_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_GetElectronicBill_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileName, fileContent ); 
        }

        bool SC_GetElectronicBill_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_GetElectronicBill_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_GetElectronicBill_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_GetElectronicBill_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_GetElectronicBill_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_CustomerGetOrderState_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( startTime, idView, stateCode ); 
        }

        bool SC_CustomerGetOrderState_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( startTime ) ) return false;
            if( !bb.Read( idView, 0, 150 ) ) return false;
            if( !bb.Read( stateCode ) ) return false;
            return true;
        }
        void SC_CustomerGetOrderState_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_CustomerGetOrderState_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_CustomerGetOrderState_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_CustomerGetOrderState_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Upload_Year_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_ReportFile_Upload_Year_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_ReportFile_Upload_Year_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Upload_Year_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Upload_Quarter_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_ReportFile_Upload_Quarter_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_ReportFile_Upload_Quarter_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Upload_Quarter_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Upload_Month_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_ReportFile_Upload_Month_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_ReportFile_Upload_Month_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Upload_Month_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Year_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileName, fileContent ); 
        }

        bool SC_ReportFile_Download_Year_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Year_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Download_Year_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Quarter_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileName, fileContent ); 
        }

        bool SC_ReportFile_Download_Quarter_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Quarter_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Download_Quarter_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Month_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileName, fileContent ); 
        }

        bool SC_ReportFile_Download_Month_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_ReportFile_Download_Month_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Download_Month_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFileList_Download_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( dataType, number ); 
        }

        bool SC_ReportFileList_Download_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( dataType ) ) return false;
            if( !bb.Read( number ) ) return false;
            return true;
        }
        void SC_ReportFileList_Download_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_ReportFileList_Download_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_ReportFileList_Download_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFileList_Download_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFileOrder_Download_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileName, fileContent, fileType ); 
        }

        bool SC_ReportFileOrder_Download_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( fileType ) ) return false;
            return true;
        }
        void SC_ReportFileOrder_Download_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFileOrder_Download_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_CheckAccountantInformation_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( credentialName, isAuth ); 
        }

        bool SC_CheckAccountantInformation_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( credentialName, 0, 150 ) ) return false;
            if( !bb.Read( isAuth ) ) return false;
            return true;
        }
        void SC_CheckAccountantInformation_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( name, gender, accountantAuth, introduction, completeCount, grade, industryID, data ); 
        }

        bool SC_CheckAccountantInformation_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( name, 0, 150 ) ) return false;
            if( !bb.Read( gender, 0, 10 ) ) return false;
            if( !bb.Read( accountantAuth, 0, 150 ) ) return false;
            if( !bb.Read( introduction, 0, 3000 ) ) return false;
            if( !bb.Read( completeCount ) ) return false;
            if( !bb.Read( grade ) ) return false;
            if( !bb.Read( industryID ) ) return false;
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_CheckAccountantInformation_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_CheckAccountantInformation_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_CheckReportFileFromID_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( name ); 
        }

        bool SC_CheckReportFileFromID_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( name, 0, 2000 ) ) return false;
            return true;
        }
        void SC_CheckReportFileFromID_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_CheckReportFileFromID_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Find_Year_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileID ); 
        }

        bool SC_ReportFile_Find_Year_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileID ) ) return false;
            return true;
        }
        void SC_ReportFile_Find_Year_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Find_Year_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Find_Quarter_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileID ); 
        }

        bool SC_ReportFile_Find_Quarter_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileID ) ) return false;
            return true;
        }
        void SC_ReportFile_Find_Quarter_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Find_Quarter_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReportFile_Find_Month_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileID ); 
        }

        bool SC_ReportFile_Find_Month_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileID ) ) return false;
            return true;
        }
        void SC_ReportFile_Find_Month_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReportFile_Find_Month_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_DealAccountantList_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_DealAccountantList_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_DealAccountantList_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, name, phone, headShot, completedorder, industry, productname, productID, price ); 
        }

        bool SC_DealAccountantList_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( phone, 0, 60 ) ) return false;
            if( !bb.Read( headShot, 0, 900 ) ) return false;
            if( !bb.Read( completedorder ) ) return false;
            if( !bb.Read( industry, 0, 1150 ) ) return false;
            if( !bb.Read( productname, 0, 1150 ) ) return false;
            if( !bb.Read( productID ) ) return false;
            if( !bb.Read( price ) ) return false;
            return true;
        }
        void SC_DealAccountantList_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_DealAccountantList_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ChangeAccountantInformation_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_ChangeAccountantInformation_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_ChangeAccountantInformation_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ChangeAccountantInformation_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_ReturnAccountantInformation_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( nickName, idNumber, certificateNum, name, acceptanceAddress, businessAddress, phone, gender, email, longitude, latitude, selfIntroduction, state ); 
        }

        bool SC_ReturnAccountantInformation_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( nickName ) ) return false;
            if( !bb.Read( idNumber ) ) return false;
            if( !bb.Read( certificateNum ) ) return false;
            if( !bb.Read( name, 0, 90 ) ) return false;
            if( !bb.Read( acceptanceAddress, 0, 900 ) ) return false;
            if( !bb.Read( businessAddress, 0, 900 ) ) return false;
            if( !bb.Read( phone, 0, 60 ) ) return false;
            if( !bb.Read( gender, 0, 3 ) ) return false;
            if( !bb.Read( email, 0, 1150 ) ) return false;
            if( !bb.Read( longitude ) ) return false;
            if( !bb.Read( latitude ) ) return false;
            if( !bb.Read( selfIntroduction, 0, 11500 ) ) return false;
            if( !bb.Read( state, 0, 150 ) ) return false;
            return true;
        }
        void SC_ReturnAccountantInformation_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_ReturnAccountantInformation_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AccountantHomePage_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( name, gender, todayOrderNum, todayPageView, fileContent ); 
        }

        bool SC_AccountantHomePage_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( name, 0, 60 ) ) return false;
            if( !bb.Read( gender, 0, 3 ) ) return false;
            if( !bb.Read( todayOrderNum ) ) return false;
            if( !bb.Read( todayPageView ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_AccountantHomePage_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AccountantHomePage_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_CustomerAnonymous_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, id ); 
        }

        bool SC_CustomerAnonymous_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( id ) ) return false;
            return true;
        }
        void SC_CustomerAnonymous_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_CustomerAnonymous_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_Anonymous_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_Anonymous_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_FindAccountantCredentials_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( fileName, fileType, fileContent ); 
        }

        bool SC_FindAccountantCredentials_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( fileName, 0, 800 ) ) return false;
            if( !bb.Read( fileType ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_FindAccountantCredentials_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_FindAccountantCredentials_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_FindAccountantCredentials_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_FindAccountantCredentials_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AccountantFindCustomer_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( customerName, taxQualification, customerID ); 
        }

        bool SC_AccountantFindCustomer_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( customerName, 0, 150 ) ) return false;
            if( !bb.Read( taxQualification, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            return true;
        }
        void SC_AccountantFindCustomer_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_AccountantFindCustomer_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_AccountantFindCustomer_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AccountantFindCustomer_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AcountantFindCustomerDetail_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( customerName, customerAddress, customerType, customerEmail, customerQualification, count ); 
        }

        bool SC_AcountantFindCustomerDetail_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( customerName, 0, 150 ) ) return false;
            if( !bb.Read( customerAddress, 0, 300 ) ) return false;
            if( !bb.Read( customerType, 0, 150 ) ) return false;
            if( !bb.Read( customerEmail, 0, 150 ) ) return false;
            if( !bb.Read( customerQualification, 0, 150 ) ) return false;
            if( !bb.Read( count ) ) return false;
            return true;
        }
        void SC_AcountantFindCustomerDetail_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AcountantFindCustomerDetail_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_UserChangeIcon_Success::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool SC_UserChangeIcon_Success::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void SC_UserChangeIcon_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_UserChangeIcon_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_CustomerHomePage_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( customerName, fileContent ); 
        }

        bool SC_CustomerHomePage_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( customerName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void SC_CustomerHomePage_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_CustomerHomePage_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_FindPushMessage_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( pushHint, pushTime ); 
        }

        bool SC_FindPushMessage_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( pushHint, 0, 150 ) ) return false;
            if( !bb.Read( pushTime ) ) return false;
            return true;
        }
        void SC_FindPushMessage_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_FindPushMessage_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_FindPushMessage_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_FindPushMessage_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
        void SC_AccountantFindDocment_Success_Data::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( customerName, typeId, year, quarter, month, fileId ); 
        }

        bool SC_AccountantFindDocment_Success_Data::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( customerName, 0, 300 ) ) return false;
            if( !bb.Read( typeId ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( quarter ) ) return false;
            if( !bb.Read( month ) ) return false;
            if( !bb.Read( fileId ) ) return false;
            return true;
        }
        void SC_AccountantFindDocment_Success::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( data ); 
        }

        bool SC_AccountantFindDocment_Success::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( data ) ) return false;
            return true;
        }
        void SC_AccountantFindDocment_Failure::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type ); 
        }

        bool SC_AccountantFindDocment_Failure::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            return true;
        }
}
