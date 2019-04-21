
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计列表
public class SC_Accountant_GetList_Data implements IBBWriter, IBBReader
{
        /*
         * 编号
        */
    public int id;
        /*
         * 名字
        */
    public String name ="";
        /*
         * 电话号码
        */
    public String phone ="";
        /*
         * 头像
        */
    public String headShot ="";
        /*
         * 完成订单数量
        */
    public int completedorder;
        /*
         * 行业
        */
    public String industry ="";
        /*
         * 产品名称
        */
    public String productname ="";
        /*
         * 产品ID
        */
    public int productID;
        /*
         * 价格
        */
    public double price;
    public static final short commandType = 68; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( name );
        bb.Write( phone );
        bb.Write( headShot );
        bb.Write( completedorder );
        bb.Write( industry );
        bb.Write( productname );
        bb.Write( productID );
        bb.Write( price ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        name = bb.ReadString( 0,90 );
        phone = bb.ReadString( 0,60 );
        headShot = bb.ReadString( 0,900 );
        completedorder = bb.ReadInteger();
        industry = bb.ReadString( 0,1150 );
        productname = bb.ReadString( 0,1150 );
        productID = bb.ReadInteger();
        price = bb.ReadDouble();
    }

};