
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询全部快递服务
public class SC_Express_GetAll_Success implements IBBWriter, IBBReader
{
    public List<SC_Express_GetAll_Date> person = new ArrayList<SC_Express_GetAll_Date>();
    public static final short commandType = 30; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( person ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        person = bb.ReadListClass( SC_Express_GetAll_Date.class ,0,0 );
    }

};