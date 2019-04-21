
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件列表(订单流程内使用)
public class SC_ReportFileList_Download_Failure implements IBBWriter, IBBReader
{
    public SC_ReportFileList_Download_Failure_Type type = SC_ReportFileList_Download_Failure_Type.ParamError;
    public static final short commandType = 120; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_ReportFileList_Download_Failure_Type.valueOf( bb.ReadInteger() );
    }

};