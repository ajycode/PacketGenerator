
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计首页
public class SC_AccountantHomePage_Success implements IBBWriter, IBBReader
{
        /*
         * 姓名
        */
    public String name ="";
        /*
         * 性别
        */
    public String gender ="";
        /*
         * 今日订单
        */
    public int todayOrderNum;
        /*
         * 今日浏览量
        */
    public int todayPageView;
        /*
         * 会计头像
        */
    public byte[ ] fileContent = new byte[ 0 ];
    public static final short commandType = 141; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( name );
        bb.Write( gender );
        bb.Write( todayOrderNum );
        bb.Write( todayPageView );
        bb.Write( fileContent ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        name = bb.ReadString( 0,60 );
        gender = bb.ReadString( 0,3 );
        todayOrderNum = bb.ReadInteger();
        todayPageView = bb.ReadInteger();
        fileContent = bb.ReadBytes( 0,3048576 );
    }

};