
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计上传证件照片
public class SC_AccountantCredentials_Upload_Success implements IBBWriter, IBBReader
{
    public static final short commandType = 75; 

    public void WriteToBB( ByteBuffer bb )
    { 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
    }

};