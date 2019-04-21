
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计判断登陆名是否存在
public class CS_Account_Register_IsExists implements IBBWriter, IBBReader
{
        /*
         * 登录名
        */
    public String loginName ="";
    public static final short commandType = 2; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( loginName ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        loginName = bb.ReadString( 0,150 );
    }

};