
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司匿名登录
public class SC_CustomerAnonymous_Failure implements IBBWriter, IBBReader
{
    public SC_CustomerAnonymous_Failure_Type type = SC_CustomerAnonymous_Failure_Type.ParamError;
    public static final short commandType = 144; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_CustomerAnonymous_Failure_Type.valueOf( bb.ReadInteger() );
    }

};