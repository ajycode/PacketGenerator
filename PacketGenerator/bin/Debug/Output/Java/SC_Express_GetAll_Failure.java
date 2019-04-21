
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询全部快递服务
public class SC_Express_GetAll_Failure implements IBBWriter, IBBReader
{
    public SC_Express_GetAll_Failure_Type type = SC_Express_GetAll_Failure_Type.ExecuteError;
    public static final short commandType = 32; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Express_GetAll_Failure_Type.valueOf( bb.ReadInteger() );
    }

};