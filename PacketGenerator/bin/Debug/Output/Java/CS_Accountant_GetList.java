
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计列表
public class CS_Accountant_GetList implements IBBWriter, IBBReader
{
        /*
         * 页码（0代表第一页）
        */
    public int index;
        /*
         * 单页显示数量
        */
    public int size;
        /*
         * 排序方式
        */
    public CS_Accountant_GetListSortData sortData = new CS_Accountant_GetListSortData();
        /*
         * 筛选方式
        */
    public CS_Accountant_GetListScreenData screen = new CS_Accountant_GetListScreenData();
    public static final short commandType = 32; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( index );
        bb.Write( size );
        bb.Write( sortData );
        bb.Write( screen ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        index = bb.ReadInteger();
        size = bb.ReadInteger();
        sortData = bb.ReadClass( CS_Accountant_GetListSortData.class );
        screen = bb.ReadClass( CS_Accountant_GetListScreenData.class );
    }

};