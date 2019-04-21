
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 通过报表文件ID查看文件
public class SC_CheckReportFileFromID_Success implements IBBWriter, IBBReader
{
        /*
         * url地址
        */
    public String name ="";
    public static final short commandType = 126; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( name ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        name = bb.ReadString( 0,2000 );
    }

};