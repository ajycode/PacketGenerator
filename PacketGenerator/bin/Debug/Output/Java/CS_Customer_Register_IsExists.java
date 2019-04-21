
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司注册用户名检测
public class CS_Customer_Register_IsExists implements IBBWriter, IBBReader
{
        /*
         * 登录名
        */
    public String loginName ="";
    public static final short commandType = 8; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( loginName ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        loginName = bb.ReadString( 0,60 );
    }

};