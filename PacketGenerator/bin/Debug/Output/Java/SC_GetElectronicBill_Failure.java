
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获得公司电子财务信息
public class SC_GetElectronicBill_Failure implements IBBWriter, IBBReader
{
    public SC_GetElectronicBill_Failure_Type type = SC_GetElectronicBill_Failure_Type.ParamError;
    public static final short commandType = 102; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_GetElectronicBill_Failure_Type.valueOf( bb.ReadInteger() );
    }

};