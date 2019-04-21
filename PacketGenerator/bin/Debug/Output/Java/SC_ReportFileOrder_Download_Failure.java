
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件(订单流程内使用)
public class SC_ReportFileOrder_Download_Failure implements IBBWriter, IBBReader
{
    public SC_ReportFileOrder_Download_Failure_Type type = SC_ReportFileOrder_Download_Failure_Type.ParamError;
    public static final short commandType = 122; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_ReportFileOrder_Download_Failure_Type.valueOf( bb.ReadInteger() );
    }

};