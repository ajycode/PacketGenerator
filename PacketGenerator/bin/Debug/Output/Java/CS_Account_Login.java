
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计登陆
public class CS_Account_Login implements IBBWriter, IBBReader
{
        /*
         * 登录名
        */
    public String loginName ="";
        /*
         * 密码
        */
    public String password ="";
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 极光推送标识
        */
    public String registrationId ="";
    public static final short commandType = 3; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( loginName );
        bb.Write( password );
        bb.Write( token );
        bb.Write( registrationId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        loginName = bb.ReadString( 0,60 );
        password = bb.ReadString( 0,60 );
        token = bb.ReadString( 0,150 );
        registrationId = bb.ReadString( 0,150 );
    }

};