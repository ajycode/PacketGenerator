
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计列表
public enum CS_Accountant_GetListSortData_Type
{
    SortDefault( (int)0 ),// 默认方式
    SortGrade( (int)1 ),// 评分
    ServeCount( (int)2 );// 服务次数
    int value;
    CS_Accountant_GetListSortData_Type( int v )
    {
        this.value = v;
    }
    public static CS_Accountant_GetListSortData_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return SortDefault;
            case 1:
                return SortGrade;
            case 2:
                return ServeCount;
            default:
                return null;
        }
    }
};