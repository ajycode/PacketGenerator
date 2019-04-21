
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 修改会计个人资料
public class SC_ChangeAccountantInformation_Success implements IBBWriter, IBBReader
{
    public static final short commandType = 137; 

    public void WriteToBB( ByteBuffer bb )
    { 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
    }

};