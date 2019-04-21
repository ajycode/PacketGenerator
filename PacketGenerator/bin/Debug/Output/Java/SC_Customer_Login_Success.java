
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司登陆
public class SC_Customer_Login_Success implements IBBWriter, IBBReader
{
        /*
         * 公司用户编号
        */
    public int id;
        /*
         * 公司名字
        */
    public String name ="";
    public static final short commandType = 23; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( name ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        name = bb.ReadString( 0,150 );
    }

};