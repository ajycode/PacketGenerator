
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 删除报表文件
public class CS_ReportFile_Delete implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 文件id
        */
    public int file_id;
    public static final short commandType = 39; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( file_id ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        file_id = bb.ReadInteger();
    }

};