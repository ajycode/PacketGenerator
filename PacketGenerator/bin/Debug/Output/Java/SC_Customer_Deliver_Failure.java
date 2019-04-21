
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 客户寄送资料
public class SC_Customer_Deliver_Failure implements IBBWriter, IBBReader
{
    public SC_Customer_Deliver_Failure_Type type = SC_Customer_Deliver_Failure_Type.ParamError;
    public static final short commandType = 46; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Customer_Deliver_Failure_Type.valueOf( bb.ReadInteger() );
    }

};