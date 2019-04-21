
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 银联支付获取交易流水号
public class CS_UnionPayTn_Get implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 客户 ID
        */
    public int customerID;
        /*
         * 订单编号
        */
    public String orderId ="";
        /*
         * 支付金额
        */
    public double total;
    public static final short commandType = 36; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customerID );
        bb.Write( orderId );
        bb.Write( total ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customerID = bb.ReadInteger();
        orderId = bb.ReadString( 0,150 );
        total = bb.ReadDouble();
    }

};