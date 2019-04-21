
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 删除报表文件
public class SC_ReportFile_Delete_Failure implements IBBWriter, IBBReader
{
    public SC_ReportFile_Delete_Failure_Type type = SC_ReportFile_Delete_Failure_Type.ParamError;
    public static final short commandType = 84; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_ReportFile_Delete_Failure_Type.valueOf( bb.ReadInteger() );
    }

};