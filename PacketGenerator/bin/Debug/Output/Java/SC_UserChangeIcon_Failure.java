
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 更换头像
public class SC_UserChangeIcon_Failure implements IBBWriter, IBBReader
{
    public SC_UserChangeIcon_Failure_Type type = SC_UserChangeIcon_Failure_Type.ParamError;
    public static final short commandType = 155; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_UserChangeIcon_Failure_Type.valueOf( bb.ReadInteger() );
    }

};