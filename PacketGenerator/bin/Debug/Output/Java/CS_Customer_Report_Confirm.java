
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 客户对报表审核
public class CS_Customer_Report_Confirm implements IBBWriter, IBBReader
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
         * 审批结果
        */
    public boolean result;
        /*
         * 备注
        */
    public String remark ="";
    public static final short commandType = 24; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customerID );
        bb.Write( orderId );
        bb.Write( result );
        bb.Write( remark ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customerID = bb.ReadInteger();
        orderId = bb.ReadString( 0,150 );
        result = bb.ReadBoolean();
        remark = bb.ReadString( 0,600 );
    }

};