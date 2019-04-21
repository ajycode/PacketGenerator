
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 创建订单
public class SC_Order_Create_Failure implements IBBWriter, IBBReader
{
    public SC_Order_Create_Failure_Type type = SC_Order_Create_Failure_Type.ParamError;
    public static final short commandType = 29; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Order_Create_Failure_Type.valueOf( bb.ReadInteger() );
    }

};