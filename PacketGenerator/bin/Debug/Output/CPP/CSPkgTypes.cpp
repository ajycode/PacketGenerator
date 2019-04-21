
#include "CSPkgTypes.h"
using namespace xxlib;
namespace CSPkgTypes
{
        const short CSPkgTypes::CS_Accountant_Register::commandType = 1;
        const short CSPkgTypes::CS_Account_Register_IsExists::commandType = 2;
        const short CSPkgTypes::CS_Account_Login::commandType = 3;
        const short CSPkgTypes::CS_Account_GetProduct::commandType = 4;
        const short CSPkgTypes::CS_Product_Manage::commandType = 5;
        const short CSPkgTypes::CS_Account_GetDetails::commandType = 6;
        const short CSPkgTypes::CS_Customer_Register::commandType = 7;
        const short CSPkgTypes::CS_Customer_Register_IsExists::commandType = 8;
        const short CSPkgTypes::CS_Industry_AllSector::commandType = 9;
        const short CSPkgTypes::CS_Customer_Login::commandType = 10;
        const short CSPkgTypes::CS_Acctountant_GetAround::commandType = 11;
        const short CSPkgTypes::CS_Order_Create::commandType = 12;
        const short CSPkgTypes::CS_Express_GetAll::commandType = 13;
        const short CSPkgTypes::CS_UncompletedOrder_GetList::commandType = 14;
        const short CSPkgTypes::CS_Order_GetDetails::commandType = 15;
        const short CSPkgTypes::CS_Order_UpdateTotal::commandType = 16;
        const short CSPkgTypes::CS_Customer_Order_Confirm::commandType = 17;
        const short CSPkgTypes::CS_Get_Payment_Platform::commandType = 18;
        const short CSPkgTypes::CS_Customer_Deliver::commandType = 19;
        const short CSPkgTypes::CS_Accountant_Receipt_Confirm::commandType = 20;
        const short CSPkgTypes::CS_Accountant_Create_Report::commandType = 21;
        const short CSPkgTypes::CS_Get_Report_Month::commandType = 22;
        const short CSPkgTypes::CS_Get_Report_Quarter::commandType = 23;
        const short CSPkgTypes::CS_Customer_Report_Confirm::commandType = 24;
        const short CSPkgTypes::CS_Accountant_Send_Back::commandType = 25;
        const short CSPkgTypes::CS_Customer_Order_Recive::commandType = 26;
        const short CSPkgTypes::CS_Customer_Order_Back::commandType = 27;
        const short CSPkgTypes::CS_Accountant_Cancel_Order::commandType = 28;
        const short CSPkgTypes::CS_Customer_Cancel_Order::commandType = 29;
        const short CSPkgTypes::CS_Accountant_GetListSortData::commandType = 30;
        const short CSPkgTypes::CS_Accountant_GetListScreenData::commandType = 31;
        const short CSPkgTypes::CS_Accountant_GetList::commandType = 32;
        const short CSPkgTypes::CS_CompeletedOrder_GetList::commandType = 33;
        const short CSPkgTypes::CS_Grade_AccountantService::commandType = 34;
        const short CSPkgTypes::CS_AccountantCredentials_Upload::commandType = 35;
        const short CSPkgTypes::CS_UnionPayTn_Get::commandType = 36;
        const short CSPkgTypes::CS_ReportFile_Upload::commandType = 37;
        const short CSPkgTypes::CS_ReportFile_Download::commandType = 38;
        const short CSPkgTypes::CS_ReportFile_Delete::commandType = 39;
        const short CSPkgTypes::CS_GetAccountantUncompletedOrderList_web::commandType = 40;
        const short CSPkgTypes::CS_AccountantElectronicBusinessCard_Get::commandType = 41;
        const short CSPkgTypes::CS_AccountanPictureDown::commandType = 42;
        const short CSPkgTypes::CS_FindReportCustom::commandType = 43;
        const short CSPkgTypes::CS_Customer_UploadElectronicBill::commandType = 44;
        const short CSPkgTypes::CS_GetElectronicBill::commandType = 45;
        const short CSPkgTypes::CS_CustomerGetOrderState::commandType = 46;
        const short CSPkgTypes::CS_ReportFile_Upload_Year::commandType = 47;
        const short CSPkgTypes::CS_ReportFile_Upload_Quarter::commandType = 48;
        const short CSPkgTypes::CS_ReportFile_Upload_Month::commandType = 49;
        const short CSPkgTypes::CS_ReportFile_Download_Year::commandType = 50;
        const short CSPkgTypes::CS_ReportFile_Download_Quarter::commandType = 51;
        const short CSPkgTypes::CS_ReportFile_Download_Month::commandType = 52;
        const short CSPkgTypes::CS_ReportFileList_Download::commandType = 53;
        const short CSPkgTypes::CS_ReportFileOrder_Download::commandType = 54;
        const short CSPkgTypes::CS_CheckAccountantInformation::commandType = 55;
        const short CSPkgTypes::CS_CheckReportFileFromID::commandType = 56;
        const short CSPkgTypes::CS_ReportFile_Find_Year::commandType = 57;
        const short CSPkgTypes::CS_ReportFile_Find_Quarter::commandType = 58;
        const short CSPkgTypes::CS_ReportFile_Find_Month::commandType = 59;
        const short CSPkgTypes::CS_DealAccountantList::commandType = 60;
        const short CSPkgTypes::CS_ChangeAccountantInformation::commandType = 61;
        const short CSPkgTypes::CS_ReturnAccountantInformation::commandType = 62;
        const short CSPkgTypes::CS_AccountantHomePage::commandType = 63;
        const short CSPkgTypes::CS_CustomerAnonymous::commandType = 64;
        const short CSPkgTypes::CS_FindAccountantCredentials::commandType = 65;
        const short CSPkgTypes::CS_AccountantFindCustomer::commandType = 66;
        const short CSPkgTypes::CS_AcountantFindCustomerDetail::commandType = 67;
        const short CSPkgTypes::CS_UserChangeIcon::commandType = 68;
        const short CSPkgTypes::CS_CustomerHomePage::commandType = 69;
        const short CSPkgTypes::CS_FindPushMessage::commandType = 70;
        const short CSPkgTypes::CS_AccountantFindDocment::commandType = 71;
        void CS_Accountant_Register::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( name, acceptanceAddress, businessAddress, phone, loginName, password, idNumber, certificateNO, longitude, latitude, nickName, gender, emmail, selfIntroduction, registrationId, dict ); 
        }

        bool CS_Accountant_Register::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( name, 0, 30 ) ) return false;
            if( !bb.Read( acceptanceAddress, 0, 300 ) ) return false;
            if( !bb.Read( businessAddress, 0, 300 ) ) return false;
            if( !bb.Read( phone, 0, 60 ) ) return false;
            if( !bb.Read( loginName, 0, 60 ) ) return false;
            if( !bb.Read( password, 0, 60 ) ) return false;
            if( !bb.Read( idNumber, 0, 54 ) ) return false;
            if( !bb.Read( certificateNO, 0, 150 ) ) return false;
            if( !bb.Read( longitude ) ) return false;
            if( !bb.Read( latitude ) ) return false;
            if( !bb.Read( nickName, 0, 60 ) ) return false;
            if( !bb.Read( gender, 0, 3 ) ) return false;
            if( !bb.Read( emmail, 0, 150 ) ) return false;
            if( !bb.Read( selfIntroduction, 0, 3000 ) ) return false;
            if( !bb.Read( registrationId, 0, 150 ) ) return false;
            if( !bb.Read( dict ) ) return false;
            return true;
        }
        void CS_Account_Register_IsExists::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( loginName ); 
        }

        bool CS_Account_Register_IsExists::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( loginName, 0, 150 ) ) return false;
            return true;
        }
        void CS_Account_Login::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( loginName, password, token, registrationId ); 
        }

        bool CS_Account_Login::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( loginName, 0, 60 ) ) return false;
            if( !bb.Read( password, 0, 60 ) ) return false;
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( registrationId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Account_GetProduct::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, id ); 
        }

        bool CS_Account_GetProduct::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( id ) ) return false;
            return true;
        }
        void CS_Product_Manage::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, productID, productname, price, industryID ); 
        }

        bool CS_Product_Manage::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( productID ) ) return false;
            if( !bb.Read( productname, 0, 150 ) ) return false;
            if( !bb.Read( price ) ) return false;
            if( !bb.Read( industryID, 0, 150 ) ) return false;
            return true;
        }
        void CS_Account_GetDetails::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, customerID, identification ); 
        }

        bool CS_Account_GetDetails::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( identification, 0, 300 ) ) return false;
            return true;
        }
        void CS_Customer_Register::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, contact, companyName, companyAdress, companyType, phone, email, loginname, password, taxQualification, registrationId ); 
        }

        bool CS_Customer_Register::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( contact, 0, 30 ) ) return false;
            if( !bb.Read( companyName, 0, 150 ) ) return false;
            if( !bb.Read( companyAdress, 0, 300 ) ) return false;
            if( !bb.Read( companyType, 0, 150 ) ) return false;
            if( !bb.Read( phone, 0, 60 ) ) return false;
            if( !bb.Read( email, 0, 150 ) ) return false;
            if( !bb.Read( loginname, 0, 60 ) ) return false;
            if( !bb.Read( password, 0, 60 ) ) return false;
            if( !bb.Read( taxQualification, 0, 150 ) ) return false;
            if( !bb.Read( registrationId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Customer_Register_IsExists::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( loginName ); 
        }

        bool CS_Customer_Register_IsExists::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( loginName, 0, 60 ) ) return false;
            return true;
        }
        void CS_Industry_AllSector::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token ); 
        }

        bool CS_Industry_AllSector::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            return true;
        }
        void CS_Customer_Login::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( loginName, password, token, registrationId ); 
        }

        bool CS_Customer_Login::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( loginName, 0, 60 ) ) return false;
            if( !bb.Read( password, 0, 60 ) ) return false;
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( registrationId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Acctountant_GetAround::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( lon, lat, radius, token ); 
        }

        bool CS_Acctountant_GetAround::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( lon ) ) return false;
            if( !bb.Read( lat ) ) return false;
            if( !bb.Read( radius ) ) return false;
            if( !bb.Read( token, 0, 150 ) ) return false;
            return true;
        }
        void CS_Order_Create::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, customerID, count, startTime, endTime, cycle, remark, product ); 
        }

        bool CS_Order_Create::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( count ) ) return false;
            if( !bb.Read( startTime ) ) return false;
            if( !bb.Read( endTime ) ) return false;
            if( !bb.Read( cycle ) ) return false;
            if( !bb.Read( remark, 0, 600 ) ) return false;
            if( !bb.Read( product, 0, 150 ) ) return false;
            return true;
        }
        void CS_Express_GetAll::WriteTo( ByteBuffer& bb ) const
        { 
        }

        bool CS_Express_GetAll::ReadFrom( ByteBuffer& bb )
        {
            return true;
        }
        void CS_UncompletedOrder_GetList::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, id, role, index, size ); 
        }

        bool CS_UncompletedOrder_GetList::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( role ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_Order_GetDetails::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, orderId ); 
        }

        bool CS_Order_GetDetails::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Order_UpdateTotal::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, orderId, total ); 
        }

        bool CS_Order_UpdateTotal::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            if( !bb.Read( total ) ) return false;
            return true;
        }
        void CS_Customer_Order_Confirm::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId ); 
        }

        bool CS_Customer_Order_Confirm::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Get_Payment_Platform::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token ); 
        }

        bool CS_Get_Payment_Platform::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            return true;
        }
        void CS_Customer_Deliver::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId, code ); 
        }

        bool CS_Customer_Deliver::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            if( !bb.Read( code, 0, 150 ) ) return false;
            return true;
        }
        void CS_Accountant_Receipt_Confirm::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, orderId ); 
        }

        bool CS_Accountant_Receipt_Confirm::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Accountant_Create_Report::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, orderId, report ); 
        }

        bool CS_Accountant_Create_Report::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            if( !bb.Read( report, 0, 600 ) ) return false;
            return true;
        }
        void CS_Get_Report_Month::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, orderId ); 
        }

        bool CS_Get_Report_Month::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Get_Report_Quarter::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerId, time ); 
        }

        bool CS_Get_Report_Quarter::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerId, 0, 150 ) ) return false;
            if( !bb.Read( time, 0, 150 ) ) return false;
            return true;
        }
        void CS_Customer_Report_Confirm::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId, result, remark ); 
        }

        bool CS_Customer_Report_Confirm::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            if( !bb.Read( result ) ) return false;
            if( !bb.Read( remark, 0, 600 ) ) return false;
            return true;
        }
        void CS_Accountant_Send_Back::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, orderId, code ); 
        }

        bool CS_Accountant_Send_Back::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            if( !bb.Read( code ) ) return false;
            return true;
        }
        void CS_Customer_Order_Recive::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId ); 
        }

        bool CS_Customer_Order_Recive::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Customer_Order_Back::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId ); 
        }

        bool CS_Customer_Order_Back::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Accountant_Cancel_Order::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID, orderId ); 
        }

        bool CS_Accountant_Cancel_Order::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Customer_Cancel_Order::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId ); 
        }

        bool CS_Customer_Cancel_Order::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_Accountant_GetListSortData::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( type, sortType ); 
        }

        bool CS_Accountant_GetListSortData::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( type ) ) return false;
            if( !bb.Read( sortType ) ) return false;
            return true;
        }
        void CS_Accountant_GetListScreenData::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( name, number ); 
        }

        bool CS_Accountant_GetListScreenData::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( name, 0, 150 ) ) return false;
            if( !bb.Read( number, 0, 50 ) ) return false;
            return true;
        }
        void CS_Accountant_GetList::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( index, size, sortData, screen ); 
        }

        bool CS_Accountant_GetList::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            if( !bb.Read( sortData ) ) return false;
            if( !bb.Read( screen ) ) return false;
            return true;
        }
        void CS_CompeletedOrder_GetList::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, id, role, index, size ); 
        }

        bool CS_CompeletedOrder_GetList::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( role ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_Grade_AccountantService::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( grade, orderId ); 
        }

        bool CS_Grade_AccountantService::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( grade ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            return true;
        }
        void CS_AccountantCredentials_Upload::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, fileName, fileContent, accountantID, credential_Type ); 
        }

        bool CS_AccountantCredentials_Upload::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( credential_Type ) ) return false;
            return true;
        }
        void CS_UnionPayTn_Get::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customerID, orderId, total ); 
        }

        bool CS_UnionPayTn_Get::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( orderId, 0, 150 ) ) return false;
            if( !bb.Read( total ) ) return false;
            return true;
        }
        void CS_ReportFile_Upload::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, fileName, fileContent, subOrderID ); 
        }

        bool CS_ReportFile_Upload::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( subOrderID, 0, 150 ) ) return false;
            return true;
        }
        void CS_ReportFile_Download::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, file_id ); 
        }

        bool CS_ReportFile_Download::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( file_id ) ) return false;
            return true;
        }
        void CS_ReportFile_Delete::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, file_id ); 
        }

        bool CS_ReportFile_Delete::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( file_id ) ) return false;
            return true;
        }
        void CS_GetAccountantUncompletedOrderList_web::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountant_id, index, size ); 
        }

        bool CS_GetAccountantUncompletedOrderList_web::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountant_id ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_AccountantElectronicBusinessCard_Get::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID ); 
        }

        bool CS_AccountantElectronicBusinessCard_Get::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            return true;
        }
        void CS_AccountanPictureDown::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantID ); 
        }

        bool CS_AccountanPictureDown::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            return true;
        }
        void CS_FindReportCustom::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year, month ); 
        }

        bool CS_FindReportCustom::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( month ) ) return false;
            return true;
        }
        void CS_Customer_UploadElectronicBill::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, fileName, fileContent, year, month ); 
        }

        bool CS_Customer_UploadElectronicBill::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( month ) ) return false;
            return true;
        }
        void CS_GetElectronicBill::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year, month ); 
        }

        bool CS_GetElectronicBill::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( month ) ) return false;
            return true;
        }
        void CS_CustomerGetOrderState::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, index, size ); 
        }

        bool CS_CustomerGetOrderState::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_ReportFile_Upload_Year::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, subOrderID, fileName, fileContent, year ); 
        }

        bool CS_ReportFile_Upload_Year::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( subOrderID, 0, 150 ) ) return false;
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( year ) ) return false;
            return true;
        }
        void CS_ReportFile_Upload_Quarter::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, subOrderID, fileName, fileContent, year, quarter ); 
        }

        bool CS_ReportFile_Upload_Quarter::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( subOrderID, 0, 150 ) ) return false;
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( quarter ) ) return false;
            return true;
        }
        void CS_ReportFile_Upload_Month::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, subOrderID, fileName, fileContent, year, month ); 
        }

        bool CS_ReportFile_Upload_Month::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( subOrderID, 0, 150 ) ) return false;
            if( !bb.Read( fileName, 0, 150 ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( month ) ) return false;
            return true;
        }
        void CS_ReportFile_Download_Year::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year ); 
        }

        bool CS_ReportFile_Download_Year::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            return true;
        }
        void CS_ReportFile_Download_Quarter::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year, quarter ); 
        }

        bool CS_ReportFile_Download_Quarter::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( quarter ) ) return false;
            return true;
        }
        void CS_ReportFile_Download_Month::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year, month ); 
        }

        bool CS_ReportFile_Download_Month::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( month ) ) return false;
            return true;
        }
        void CS_ReportFileList_Download::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, subOrderID ); 
        }

        bool CS_ReportFileList_Download::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( subOrderID, 0, 150 ) ) return false;
            return true;
        }
        void CS_ReportFileOrder_Download::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, fileId ); 
        }

        bool CS_ReportFileOrder_Download::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( fileId ) ) return false;
            return true;
        }
        void CS_CheckAccountantInformation::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantId ); 
        }

        bool CS_CheckAccountantInformation::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantId ) ) return false;
            return true;
        }
        void CS_CheckReportFileFromID::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, reportId ); 
        }

        bool CS_CheckReportFileFromID::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( reportId ) ) return false;
            return true;
        }
        void CS_ReportFile_Find_Year::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year ); 
        }

        bool CS_ReportFile_Find_Year::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            return true;
        }
        void CS_ReportFile_Find_Quarter::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year, quarter ); 
        }

        bool CS_ReportFile_Find_Quarter::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( quarter ) ) return false;
            return true;
        }
        void CS_ReportFile_Find_Month::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, year, month ); 
        }

        bool CS_ReportFile_Find_Month::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( year ) ) return false;
            if( !bb.Read( month ) ) return false;
            return true;
        }
        void CS_DealAccountantList::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, customID, index, size ); 
        }

        bool CS_DealAccountantList::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( customID ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_ChangeAccountantInformation::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, id, nickName, idNumber, certificateNum, name, acceptanceAddress, businessAddress, phone, gender, email, longitude, latitude, selfIntroduction ); 
        }

        bool CS_ChangeAccountantInformation::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( id ) ) return false;
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
            return true;
        }
        void CS_ReturnAccountantInformation::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantId ); 
        }

        bool CS_ReturnAccountantInformation::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantId ) ) return false;
            return true;
        }
        void CS_AccountantHomePage::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( token, accountantId ); 
        }

        bool CS_AccountantHomePage::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( token, 0, 150 ) ) return false;
            if( !bb.Read( accountantId ) ) return false;
            return true;
        }
        void CS_CustomerAnonymous::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( username, registrationId ); 
        }

        bool CS_CustomerAnonymous::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( username, 0, 300 ) ) return false;
            if( !bb.Read( registrationId, 0, 150 ) ) return false;
            return true;
        }
        void CS_FindAccountantCredentials::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( accountantID ); 
        }

        bool CS_FindAccountantCredentials::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( accountantID ) ) return false;
            return true;
        }
        void CS_AccountantFindCustomer::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( accountantId, index, size ); 
        }

        bool CS_AccountantFindCustomer::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( accountantId ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_AcountantFindCustomerDetail::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( customerID, accountantID ); 
        }

        bool CS_AcountantFindCustomerDetail::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( customerID ) ) return false;
            if( !bb.Read( accountantID ) ) return false;
            return true;
        }
        void CS_UserChangeIcon::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, type, fileContent ); 
        }

        bool CS_UserChangeIcon::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( type ) ) return false;
            if( !bb.Read( fileContent, 0, 3048576 ) ) return false;
            return true;
        }
        void CS_CustomerHomePage::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( customerId ); 
        }

        bool CS_CustomerHomePage::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( customerId ) ) return false;
            return true;
        }
        void CS_FindPushMessage::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( id, type, index, size ); 
        }

        bool CS_FindPushMessage::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( id ) ) return false;
            if( !bb.Read( type ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
        void CS_AccountantFindDocment::WriteTo( ByteBuffer& bb ) const
        {
            bb.WriteMulti( accountantID, index, size ); 
        }

        bool CS_AccountantFindDocment::ReadFrom( ByteBuffer& bb )
        {
            if( !bb.Read( accountantID ) ) return false;
            if( !bb.Read( index ) ) return false;
            if( !bb.Read( size ) ) return false;
            return true;
        }
}
