
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询未完成订单列表
public class SC_UncompletedOrder_GetList_Data implements IBBWriter, IBBReader
{
        /*
         * 订单ID
        */
    public String orderId ="";
        /*
         * 公司名称
        */
    public String name ="";
        /*
         * 订单创建时间
        */
    public Date orderDate = new Date(1,0,1,0,0,0);
        /*
         * 订单当前状态
        */
    public int stateCode;
        /*
         * 订单价格
        */
    public double total;
        /*
         * 用户看见的订单ID号
        */
    public String idView ="";
        /*
         * 子订单SubOrder表自带的自增字段用于排序
        */
    public int number;
    public static final short commandType = 34; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( orderId );
        bb.Write( name );
        bb.Write( orderDate );
        bb.Write( stateCode );
        bb.Write( total );
        bb.Write( idView );
        bb.Write( number ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        orderId = bb.ReadString( 0,1150 );
        name = bb.ReadString( 0,1150 );
        orderDate = bb.ReadDate();
        stateCode = bb.ReadInteger();
        total = bb.ReadDouble();
        idView = bb.ReadString( 0,1150 );
        number = bb.ReadInteger();
    }

};