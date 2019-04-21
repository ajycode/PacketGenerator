
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件列表(订单流程内使用)
public class SC_ReportFileList_Download_Success implements IBBWriter, IBBReader
{
    public List<SC_ReportFileList_Download_Success_Data> data = new ArrayList<SC_ReportFileList_Download_Success_Data>();
    public static final short commandType = 119; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_ReportFileList_Download_Success_Data.class ,0,0 );
    }

};