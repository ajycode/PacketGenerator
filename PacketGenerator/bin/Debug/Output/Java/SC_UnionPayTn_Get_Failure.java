
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 银联支付获取交易流水号
public class SC_UnionPayTn_Get_Failure implements IBBWriter, IBBReader
{
    public SC_UnionPayTn_Get_Failure_Type type = SC_UnionPayTn_Get_Failure_Type.ParamError;
    public static final short commandType = 78; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_UnionPayTn_Get_Failure_Type.valueOf( bb.ReadInteger() );
    }

};