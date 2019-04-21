
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计修改订单价格
public class SC_Order_UpdateTotal_Failure implements IBBWriter, IBBReader
{
    public SC_Order_UpdateTotal_Failure_Type type = SC_Order_UpdateTotal_Failure_Type.ParamError;
    public static final short commandType = 39; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Order_UpdateTotal_Failure_Type.valueOf( bb.ReadInteger() );
    }

};