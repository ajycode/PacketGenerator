
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计电子名片
public class SC_AccountantElectronicBusinessCard_Get_Success implements IBBWriter, IBBReader
{
        /*
         * 完成订单数
        */
    public int completedOrder;
        /*
         * 会计名字
        */
    public String name ="";
        /*
         * 会计排名
        */
    public int rank;
    public static final short commandType = 89; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( completedOrder );
        bb.Write( name );
        bb.Write( rank ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        completedOrder = bb.ReadInteger();
        name = bb.ReadString( 0,90 );
        rank = bb.ReadInteger();
    }

};