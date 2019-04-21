
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取某会计未完成订单列表(web版)
public class SC_GetAccountantUncompletedOrderList_web_Data implements IBBWriter, IBBReader
{
        /*
         * 订单id
        */
    public String orderID ="";
        /*
         * 公司ID
        */
    public int customerID;
        /*
         * 公司名字
        */
    public String companyName ="";
        /*
         * 订单创建时间
        */
    public Date orderDate = new Date(1,0,1,0,0,0);
        /*
         * 订单开始时间
        */
    public Date orderStartDate = new Date(1,0,1,0,0,0);
        /*
         * 订单状态
        */
    public int stateCode;
        /*
         * 订单价格
        */
    public double total;
        /*
         * 用户看的见得订单号
        */
    public String iDView ="";
        /*
         * 订单自增号
        */
    public int number;
        /*
         * 文件信息列表
        */
    public List<SC_GetAccountantUncompletedOrderList_web_file_info> file_info_list = new ArrayList<SC_GetAccountantUncompletedOrderList_web_file_info>();
    public static final short commandType = 87; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( orderID );
        bb.Write( customerID );
        bb.Write( companyName );
        bb.Write( orderDate );
        bb.Write( orderStartDate );
        bb.Write( stateCode );
        bb.Write( total );
        bb.Write( iDView );
        bb.Write( number );
        bb.WriteListClass( file_info_list ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        orderID = bb.ReadString( 0,50 );
        customerID = bb.ReadInteger();
        companyName = bb.ReadString( 0,50 );
        orderDate = bb.ReadDate();
        orderStartDate = bb.ReadDate();
        stateCode = bb.ReadInteger();
        total = bb.ReadDouble();
        iDView = bb.ReadString( 0,0 );
        number = bb.ReadInteger();
        file_info_list = bb.ReadListClass( SC_GetAccountantUncompletedOrderList_web_file_info.class ,0,0 );
    }

};