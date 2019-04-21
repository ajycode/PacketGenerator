
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司查询月度报表
public class SC_FindReportCustom_Success implements IBBWriter, IBBReader
{
    public List<SC_FindReportCustom_Success_Data> data = new ArrayList<SC_FindReportCustom_Success_Data>();
    public static final short commandType = 96; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_FindReportCustom_Success_Data.class ,0,0 );
    }

};