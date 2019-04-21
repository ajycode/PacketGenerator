
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计返还资料
public class SC_Accountant_Send_Back_Success implements IBBWriter, IBBReader
{
    public boolean isPushSuccess;
    public static final short commandType = 57; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( isPushSuccess ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        isPushSuccess = bb.ReadBoolean();
    }

};