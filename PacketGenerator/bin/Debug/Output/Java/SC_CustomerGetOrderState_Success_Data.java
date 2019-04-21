
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司查询所有订单的进度
public class SC_CustomerGetOrderState_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 下哪个月单时间
        */
    public Date startTime = new Date(1,0,1,0,0,0);
        /*
         * 订单IdView编号
        */
    public String idView ="";
        /*
         * 订单状态
        */
    public int stateCode;
    public static final short commandType = 103; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( startTime );
        bb.Write( idView );
        bb.Write( stateCode ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        startTime = bb.ReadDate();
        idView = bb.ReadString( 0,150 );
        stateCode = bb.ReadInteger();
    }

};