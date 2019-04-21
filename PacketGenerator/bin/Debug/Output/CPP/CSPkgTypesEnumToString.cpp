
#include "EnumToString.h"
char const* const EnumToString::Get( CSPkgTypes::CS_Accountant_GetListSortData_Type e )
{
    switch(e)
    {
        case CSPkgTypes::CS_Accountant_GetListSortData_Type::SortDefault: 
            return "CS_Accountant_GetListSortData_Type::SortDefault 默认方式";
        case CSPkgTypes::CS_Accountant_GetListSortData_Type::SortGrade: 
            return "CS_Accountant_GetListSortData_Type::SortGrade 评分";
        case CSPkgTypes::CS_Accountant_GetListSortData_Type::ServeCount: 
            return "CS_Accountant_GetListSortData_Type::ServeCount 服务次数";
    }
}
char const* const EnumToString::GetShow( CSPkgTypes::CS_Accountant_GetListSortData_Type e )
{
    switch(e)
    {
        case CSPkgTypes::CS_Accountant_GetListSortData_Type::SortDefault: 
            return "默认方式";
        case CSPkgTypes::CS_Accountant_GetListSortData_Type::SortGrade: 
            return "评分";
        case CSPkgTypes::CS_Accountant_GetListSortData_Type::ServeCount: 
            return "服务次数";
    }
}