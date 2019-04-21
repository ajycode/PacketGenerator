
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计获取本人受理业务
public class SC_Account_GetProduct_Product implements IBBWriter, IBBReader
{
        /*
         * 产品ID
        */
    public int productID;
        /*
         * 产品名称
        */
    public String productname ="";
        /*
         * 用户ID
        */
    public int accountantID;
        /*
         * 创建时间
        */
    public Date createtime = new Date(1,0,1,0,0,0);
        /*
         * 价格
        */
    public double price;
        /*
         * 擅长领域的ID集合
        */
    public List<Integer> industryID = new ArrayList<Integer>();
    public String description ="";
    public static final short commandType = 8; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( productID );
        bb.Write( productname );
        bb.Write( accountantID );
        bb.Write( createtime );
        bb.Write( price );
        bb.WriteListInteger( industryID );
        bb.Write( description ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        productID = bb.ReadInteger();
        productname = bb.ReadString( 0,1150 );
        accountantID = bb.ReadInteger();
        createtime = bb.ReadDate();
        price = bb.ReadDouble();
        industryID = bb.ReadListInteger(0,0 );
        description = bb.ReadString( 0,600 );
    }

};