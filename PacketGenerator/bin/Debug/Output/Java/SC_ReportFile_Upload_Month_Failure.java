
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 上传月度报表文件
public class SC_ReportFile_Upload_Month_Failure implements IBBWriter, IBBReader
{
    public SC_ReportFile_Upload_Month_Failure_Type type = SC_ReportFile_Upload_Month_Failure_Type.ParamError;
    public static final short commandType = 111; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_ReportFile_Upload_Month_Failure_Type.valueOf( bb.ReadInteger() );
    }

};