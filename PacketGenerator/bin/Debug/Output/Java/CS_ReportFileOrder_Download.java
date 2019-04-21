
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件(订单流程内使用)
public class CS_ReportFileOrder_Download implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 报表文件的ID
        */
    public int fileId;
    public static final short commandType = 54; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( fileId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        fileId = bb.ReadInteger();
    }

};