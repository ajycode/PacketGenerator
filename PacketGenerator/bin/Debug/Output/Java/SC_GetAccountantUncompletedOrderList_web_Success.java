
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取某会计未完成订单列表(web版)
public class SC_GetAccountantUncompletedOrderList_web_Success implements IBBWriter, IBBReader
{
    public List<SC_GetAccountantUncompletedOrderList_web_Data> data = new ArrayList<SC_GetAccountantUncompletedOrderList_web_Data>();
    public static final short commandType = 85; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_GetAccountantUncompletedOrderList_web_Data.class ,0,0 );
    }

};