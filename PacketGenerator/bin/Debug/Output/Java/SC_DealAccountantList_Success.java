
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 交易过的会计列表
public class SC_DealAccountantList_Success implements IBBWriter, IBBReader
{
    public List<SC_DealAccountantList_Data> data = new ArrayList<SC_DealAccountantList_Data>();
    public static final short commandType = 134; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_DealAccountantList_Data.class ,0,0 );
    }

};