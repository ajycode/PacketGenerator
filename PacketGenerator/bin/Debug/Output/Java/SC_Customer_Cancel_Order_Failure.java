
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 客户取消订单
public class SC_Customer_Cancel_Order_Failure implements IBBWriter, IBBReader
{
    public SC_Customer_Cancel_Order_Failure_Type type = SC_Customer_Cancel_Order_Failure_Type.ParamError;
    public static final short commandType = 66; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Customer_Cancel_Order_Failure_Type.valueOf( bb.ReadInteger() );
    }

};