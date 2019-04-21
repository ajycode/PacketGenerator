
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取全部行业分类
public class SC_Industry_AllSector_Failure implements IBBWriter, IBBReader
{
    public SC_Industry_AllSector_Failure_Type type = SC_Industry_AllSector_Failure_Type.ParamError;
    public static final short commandType = 22; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Industry_AllSector_Failure_Type.valueOf( bb.ReadInteger() );
    }

};