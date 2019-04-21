
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司上传电子财务信息
public class SC_Customer_UploadElectronicBill_Failure implements IBBWriter, IBBReader
{
    public SC_Customer_UploadElectronicBill_Failure_Type type = SC_Customer_UploadElectronicBill_Failure_Type.ParamError;
    public static final short commandType = 99; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Customer_UploadElectronicBill_Failure_Type.valueOf( bb.ReadInteger() );
    }

};