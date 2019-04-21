
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的某个公司明细
public class SC_AcountantFindCustomerDetail_Failure implements IBBWriter, IBBReader
{
    public SC_AcountantFindCustomerDetail_Failure_Type type = SC_AcountantFindCustomerDetail_Failure_Type.ParamError;
    public static final short commandType = 153; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_AcountantFindCustomerDetail_Failure_Type.valueOf( bb.ReadInteger() );
    }

};