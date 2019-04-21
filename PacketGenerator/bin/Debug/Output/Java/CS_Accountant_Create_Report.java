
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计填写报表
public class CS_Accountant_Create_Report implements IBBWriter, IBBReader
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
         * 订单编号
        */
    public String orderId ="";
        /*
         * 报表内容
        */
    public String report ="";
    public static final short commandType = 21; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID );
        bb.Write( orderId );
        bb.Write( report ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
        orderId = bb.ReadString( 0,150 );
        report = bb.ReadString( 0,600 );
    }

};