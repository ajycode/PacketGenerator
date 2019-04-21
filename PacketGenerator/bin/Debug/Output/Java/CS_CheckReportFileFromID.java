
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 通过报表文件ID查看文件
public class CS_CheckReportFileFromID implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 报表文件ID
        */
    public int reportId;
    public static final short commandType = 56; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( reportId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        reportId = bb.ReadInteger();
    }

};