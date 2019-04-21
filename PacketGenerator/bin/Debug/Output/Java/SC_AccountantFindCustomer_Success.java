
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的公司
public class SC_AccountantFindCustomer_Success implements IBBWriter, IBBReader
{
    public List<SC_AccountantFindCustomer_Success_Data> data = new ArrayList<SC_AccountantFindCustomer_Success_Data>();
    public static final short commandType = 150; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_AccountantFindCustomer_Success_Data.class ,0,0 );
    }

};