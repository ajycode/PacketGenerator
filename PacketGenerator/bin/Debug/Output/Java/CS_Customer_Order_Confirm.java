
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 客户确认订单
public class CS_Customer_Order_Confirm implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 客户ID
        */
    public int customerID;
        /*
         * 订单ID
        */
    public String orderId ="";
    public static final short commandType = 17; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customerID );
        bb.Write( orderId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customerID = bb.ReadInteger();
        orderId = bb.ReadString( 0,150 );
    }

};