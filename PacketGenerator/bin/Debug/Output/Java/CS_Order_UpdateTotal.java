
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计修改订单价格
public class CS_Order_UpdateTotal implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计ID
        */
    public int accountantID;
        /*
         * 订单ID
        */
    public String orderId ="";
        /*
         * 会计输入的实际订单金额
        */
    public double total;
    public static final short commandType = 16; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID );
        bb.Write( orderId );
        bb.Write( total ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
        orderId = bb.ReadString( 0,150 );
        total = bb.ReadDouble();
    }

};