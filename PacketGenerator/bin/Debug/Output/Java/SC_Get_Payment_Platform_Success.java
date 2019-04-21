
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取支付平台列表
public class SC_Get_Payment_Platform_Success implements IBBWriter, IBBReader
{
    public List<SC_Get_Payment_Platform_Data> data = new ArrayList<SC_Get_Payment_Platform_Data>();
    public static final short commandType = 42; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_Get_Payment_Platform_Data.class ,0,0 );
    }

};