
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计更新或添加个人受理业务
public class CS_Product_Manage implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计用户编号
        */
    public int accountantID;
        /*
         * 业务产品编号
        */
    public int productID;
        /*
         * 业务产品名称
        */
    public String productname ="";
        /*
         * 业务产品价格
        */
    public double price;
        /*
         * 擅长行业领域ID,最多2个ID，以,分割
        */
    public String industryID ="";
    public static final short commandType = 5; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID );
        bb.Write( productID );
        bb.Write( productname );
        bb.Write( price );
        bb.Write( industryID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
        productID = bb.ReadInteger();
        productname = bb.ReadString( 0,150 );
        price = bb.ReadDouble();
        industryID = bb.ReadString( 0,150 );
    }

};