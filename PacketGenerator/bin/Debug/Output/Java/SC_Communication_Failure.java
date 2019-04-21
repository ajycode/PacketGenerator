
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 通信错误
public class SC_Communication_Failure implements IBBWriter, IBBReader
{
    public SC_Communication_Failure_Type type = SC_Communication_Failure_Type.SerializeError;
    public static final short commandType = 91; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Communication_Failure_Type.valueOf( bb.ReadInteger() );
    }

};