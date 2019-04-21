
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司主页
public class CS_CustomerHomePage implements IBBWriter, IBBReader
{
        /*
         * 公司编号
        */
    public int customerId;
    public static final short commandType = 69; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( customerId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        customerId = bb.ReadInteger();
    }

};