
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计接收资料确认
public class SC_Accountant_Receipt_Confirm_Failure implements IBBWriter, IBBReader
{
    public SC_Accountant_Receipt_Confirm_Failure_Type type = SC_Accountant_Receipt_Confirm_Failure_Type.ParamError;
    public static final short commandType = 48; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Accountant_Receipt_Confirm_Failure_Type.valueOf( bb.ReadInteger() );
    }

};