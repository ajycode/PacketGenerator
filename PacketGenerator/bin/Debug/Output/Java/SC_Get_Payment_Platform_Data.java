
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取支付平台列表
public class SC_Get_Payment_Platform_Data implements IBBWriter, IBBReader
{
        /*
         * 支付平台编号
        */
    public int id;
        /*
         * 支付平台名称
        */
    public String name ="";
    public static final short commandType = 43; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( name ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        name = bb.ReadString( 0,1150 );
    }

};