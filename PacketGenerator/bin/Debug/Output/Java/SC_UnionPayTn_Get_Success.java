
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 银联支付获取交易流水号
public class SC_UnionPayTn_Get_Success implements IBBWriter, IBBReader
{
        /*
         * 流水号
        */
    public String tn ="";
    public static final short commandType = 77; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( tn ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        tn = bb.ReadString( 0,1150 );
    }

};