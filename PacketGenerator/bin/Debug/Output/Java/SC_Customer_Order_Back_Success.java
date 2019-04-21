
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 客户退回订单至会计定价
public class SC_Customer_Order_Back_Success implements IBBWriter, IBBReader
{
    public boolean isPushSuccess;
    public static final short commandType = 61; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( isPushSuccess ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        isPushSuccess = bb.ReadBoolean();
    }

};