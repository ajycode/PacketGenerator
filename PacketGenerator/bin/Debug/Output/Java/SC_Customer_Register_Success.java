
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司注册
public class SC_Customer_Register_Success implements IBBWriter, IBBReader
{
        /*
         * 公司用户编号
        */
    public int id;
    public static final short commandType = 16; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
    }

};