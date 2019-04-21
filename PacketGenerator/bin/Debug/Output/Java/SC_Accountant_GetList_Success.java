
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计列表
public class SC_Accountant_GetList_Success implements IBBWriter, IBBReader
{
    public List<SC_Accountant_GetList_Data> data = new ArrayList<SC_Accountant_GetList_Data>();
    public static final short commandType = 67; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_Accountant_GetList_Data.class ,0,0 );
    }

};