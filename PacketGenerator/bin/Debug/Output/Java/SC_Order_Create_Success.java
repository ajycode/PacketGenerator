
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 创建订单
public class SC_Order_Create_Success implements IBBWriter, IBBReader
{
    public boolean isPushSuccess;
    public static final short commandType = 28; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( isPushSuccess ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        isPushSuccess = bb.ReadBoolean();
    }

};