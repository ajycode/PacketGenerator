
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 删除报表文件
public class SC_ReportFile_Delete_Success implements IBBWriter, IBBReader
{
    public static final short commandType = 83; 

    public void WriteToBB( ByteBuffer bb )
    { 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
    }

};