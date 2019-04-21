
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司注册用户名检测
public class SC_Customer_Register_IsExists_Success implements IBBWriter, IBBReader
{
    public static final short commandType = 18; 

    public void WriteToBB( ByteBuffer bb )
    { 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
    }

};