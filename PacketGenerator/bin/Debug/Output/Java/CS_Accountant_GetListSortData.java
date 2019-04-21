
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计列表
public class CS_Accountant_GetListSortData implements IBBWriter, IBBReader
{
        /*
         * 排序的字段名
        */
    public CS_Accountant_GetListSortData_Type type = CS_Accountant_GetListSortData_Type.SortDefault;
        /*
         * true大到小,false小到大
        */
    public boolean sortType;
    public static final short commandType = 30; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value );
        bb.Write( sortType ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = CS_Accountant_GetListSortData_Type.valueOf( bb.ReadByte() );
        sortType = bb.ReadBoolean();
    }

};