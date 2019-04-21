
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计注册成功
public class SC_Accountant_Register_Success implements IBBWriter, IBBReader
{
        /*
         * 会计用户编号
        */
    public int id;
        /*
         * 用户的名字
        */
    public String name ="";
        /*
         * 头像的地址
        */
    public String headIcon ="";
    public static final short commandType = 1; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( name );
        bb.Write( headIcon ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        name = bb.ReadString( 0,90 );
        headIcon = bb.ReadString( 0,600 );
    }

};