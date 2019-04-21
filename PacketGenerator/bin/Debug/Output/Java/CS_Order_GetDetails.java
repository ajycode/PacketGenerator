
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询订单明细
public class CS_Order_GetDetails implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 订单ID
        */
    public String orderId ="";
    public static final short commandType = 15; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( orderId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        orderId = bb.ReadString( 0,150 );
    }

};