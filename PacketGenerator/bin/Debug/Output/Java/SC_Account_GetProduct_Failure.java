
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计获取本人受理业务
public class SC_Account_GetProduct_Failure implements IBBWriter, IBBReader
{
    public SC_Account_GetProduct_Failure_Type type = SC_Account_GetProduct_Failure_Type.ParamError;
    public static final short commandType = 10; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Account_GetProduct_Failure_Type.valueOf( bb.ReadInteger() );
    }

};