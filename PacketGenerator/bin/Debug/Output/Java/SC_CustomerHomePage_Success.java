
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司主页
public class SC_CustomerHomePage_Success implements IBBWriter, IBBReader
{
        /*
         * 公司名称
        */
    public String customerName ="";
        /*
         * 公司头像
        */
    public byte[ ] fileContent = new byte[ 0 ];
    public static final short commandType = 156; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( customerName );
        bb.Write( fileContent ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        customerName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
    }

};