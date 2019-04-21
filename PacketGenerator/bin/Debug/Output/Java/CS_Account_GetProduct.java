
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计获取本人受理业务
public class CS_Account_GetProduct implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计编号
        */
    public int id;
    public static final short commandType = 4; 

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