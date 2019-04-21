
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载会计图片
public class CS_AccountanPictureDown implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计ID
        */
    public int accountantID;
    public static final short commandType = 42; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
    }

};