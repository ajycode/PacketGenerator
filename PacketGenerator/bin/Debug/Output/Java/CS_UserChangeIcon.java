
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 用户更换头像
public class CS_UserChangeIcon implements IBBWriter, IBBReader
{
        /*
         * ID
        */
    public int id;
        /*
         * 类型true代表公司，false代表会计
        */
    public boolean type;
        /*
         * 头像
        */
    public byte[ ] fileContent = new byte[ 0 ];
    public static final short commandType = 68; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( type );
        bb.Write( fileContent ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        type = bb.ReadBoolean();
        fileContent = bb.ReadBytes( 0,3048576 );
    }

};