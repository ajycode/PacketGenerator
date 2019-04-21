
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查看月度报表文件
public class SC_ReportFile_Find_Month_Success implements IBBWriter, IBBReader
{
        /*
         * 报表文件id
        */
    public int fileID;
    public static final short commandType = 132; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( fileID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        fileID = bb.ReadInteger();
    }

};