
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件
public class SC_ReportFile_Download_Success implements IBBWriter, IBBReader
{
        /*
         * 文件内容,必须base64编码
        */
    public byte[ ] fileContent = new byte[ 0 ];
    public static final short commandType = 81; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( fileContent ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        fileContent = bb.ReadBytes( 0,3048576 );
    }

};