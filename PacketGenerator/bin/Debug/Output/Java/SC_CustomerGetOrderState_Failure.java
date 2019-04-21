
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司查询所有订单的进度
public class SC_CustomerGetOrderState_Failure implements IBBWriter, IBBReader
{
    public SC_CustomerGetOrderState_Failure_Type type = SC_CustomerGetOrderState_Failure_Type.ParamError;
    public static final short commandType = 105; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_CustomerGetOrderState_Failure_Type.valueOf( bb.ReadInteger() );
    }

};