
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司匿名登录
public class SC_CustomerAnonymous_Success implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 公司ID
        */
    public int id;
    public static final short commandType = 143; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( id ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        id = bb.ReadInteger();
    }

};