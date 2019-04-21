
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询季度报表
public class SC_Get_Report_Quarter_Failure implements IBBWriter, IBBReader
{
    public SC_Get_Report_Quarter_Failure_Type type = SC_Get_Report_Quarter_Failure_Type.ParamError;
    public static final short commandType = 54; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Get_Report_Quarter_Failure_Type.valueOf( bb.ReadInteger() );
    }

};