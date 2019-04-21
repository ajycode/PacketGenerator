
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计更新或添加个人受理业务
public class SC_Product_Manage_Success implements IBBWriter, IBBReader
{
    public static final short commandType = 11; 

    public void WriteToBB( ByteBuffer bb )
    { 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
    }

};