
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件列表(订单流程内使用)
public class SC_ReportFileList_Download_Success_Data implements IBBWriter, IBBReader
{
    public SC_ReportFileList_Download_Success_Data_Type dataType = SC_ReportFileList_Download_Success_Data_Type.Month;
    public int number;
    public static final short commandType = 118; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( dataType.value );
        bb.Write( number ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        dataType = SC_ReportFileList_Download_Success_Data_Type.valueOf( bb.ReadInteger() );
        number = bb.ReadInteger();
    }

};