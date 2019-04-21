
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询已完成订单列表
public class SC_CompeletedOrder_GetList_Success implements IBBWriter, IBBReader
{
    public List<SC_CompeletedOrder_GetList_Data> data = new ArrayList<SC_CompeletedOrder_GetList_Data>();
    public static final short commandType = 70; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_CompeletedOrder_GetList_Data.class ,0,0 );
    }

};