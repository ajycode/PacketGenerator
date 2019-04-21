
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司匿名登录
public class CS_CustomerAnonymous implements IBBWriter, IBBReader
{
        /*
         * 用户名
        */
    public String username ="";
        /*
         * 极光推送标识
        */
    public String registrationId ="";
    public static final short commandType = 64; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( username );
        bb.Write( registrationId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        username = bb.ReadString( 0,300 );
        registrationId = bb.ReadString( 0,150 );
    }

};