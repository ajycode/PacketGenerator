
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 地图点击获得会计详细信息
public class SC_CheckAccountantInformation_Failure implements IBBWriter, IBBReader
{
    public SC_CheckAccountantInformation_Failure_Type type = SC_CheckAccountantInformation_Failure_Type.ParamError;
    public static final short commandType = 125; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_CheckAccountantInformation_Failure_Type.valueOf( bb.ReadInteger() );
    }

};