
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 创建订单
public class CS_Order_Create implements IBBWriter, IBBReader
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
         * 客户ID
        */
    public int customerID;
        /*
         * 数量
        */
    public int count;
        /*
         * 开始执行日期
        */
    public Date startTime = new Date(1,0,1,0,0,0);
        /*
         * 订单结束日期
        */
    public Date endTime = new Date(1,0,1,0,0,0);
        /*
         * 订单周期,（默认赋值1）
        */
    public int cycle;
        /*
         * 订单备注
        */
    public String remark ="";
        /*
         * 产品明细
        */
    public String product ="";
    public static final short commandType = 12; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID );
        bb.Write( customerID );
        bb.Write( count );
        bb.Write( startTime );
        bb.Write( endTime );
        bb.Write( cycle );
        bb.Write( remark );
        bb.Write( product ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
        customerID = bb.ReadInteger();
        count = bb.ReadInteger();
        startTime = bb.ReadDate();
        endTime = bb.ReadDate();
        cycle = bb.ReadInteger();
        remark = bb.ReadString( 0,600 );
        product = bb.ReadString( 0,150 );
    }

};