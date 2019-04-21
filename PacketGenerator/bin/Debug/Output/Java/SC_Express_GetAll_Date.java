
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询全部快递服务
public class SC_Express_GetAll_Date implements IBBWriter, IBBReader
{
        /*
         * 快递平台ID
        */
    public int productId;
        /*
         * 快递平台名称
        */
    public String productName ="";
        /*
         * 快递价格
        */
    public double price;
    public static final short commandType = 31; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( productId );
        bb.Write( productName );
        bb.Write( price ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        productId = bb.ReadInteger();
        productName = bb.ReadString( 0,1150 );
        price = bb.ReadDouble();
    }

};