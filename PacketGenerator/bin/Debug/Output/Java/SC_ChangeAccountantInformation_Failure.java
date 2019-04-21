
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 修改会计个人资料
public class SC_ChangeAccountantInformation_Failure implements IBBWriter, IBBReader
{
    public SC_ChangeAccountantInformation_Failure_Type type = SC_ChangeAccountantInformation_Failure_Type.ParamError;
    public static final short commandType = 138; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_ChangeAccountantInformation_Failure_Type.valueOf( bb.ReadInteger() );
    }

};