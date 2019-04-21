
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 客户对会计服务评分
public class CS_Grade_AccountantService implements IBBWriter, IBBReader
{
        /*
         * 客户对会计服务评分
        */
    public double grade;
        /*
         * 订单ID
        */
    public String orderId ="";
    public static final short commandType = 34; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( grade );
        bb.Write( orderId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        grade = bb.ReadDouble();
        orderId = bb.ReadString( 0,150 );
    }

};