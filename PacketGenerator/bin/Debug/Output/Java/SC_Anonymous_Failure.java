
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 验证服务器失败
public class SC_Anonymous_Failure implements IBBWriter, IBBReader
{
    public SC_Anonymous_Failure_Type type = SC_Anonymous_Failure_Type.Failure;
    public static final short commandType = 145; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Anonymous_Failure_Type.valueOf( bb.ReadInteger() );
    }

};