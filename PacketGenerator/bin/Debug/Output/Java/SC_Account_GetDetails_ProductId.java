
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计主页个人信息
public class SC_Account_GetDetails_ProductId implements IBBWriter, IBBReader
{
        /*
         * 产品ID
        */
    public int productId;
        /*
         * 产品名称
        */
    public String productName ="";
        /*
         * 产品价格
        */
    public double price;
        /*
         * 行业
        */
    public String idustry ="";
    public static final short commandType = 13; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( productId );
        bb.Write( productName );
        bb.Write( price );
        bb.Write( idustry ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        productId = bb.ReadInteger();
        productName = bb.ReadString( 0,1150 );
        price = bb.ReadDouble();
        idustry = bb.ReadString( 0,900 );
    }

};