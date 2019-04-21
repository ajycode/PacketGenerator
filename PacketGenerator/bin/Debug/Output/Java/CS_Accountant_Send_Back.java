
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计返还资料
public class CS_Accountant_Send_Back implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计 ID
        */
    public int accountantID;
        /*
         * 订单编号
        */
    public String orderId ="";
        /*
         * 审批结果
        */
    public String code ="";
    public static final short commandType = 25; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID );
        bb.Write( orderId );
        bb.Write( code ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
        orderId = bb.ReadString( 0,150 );
        code = bb.ReadString( 0,0 );
    }

};