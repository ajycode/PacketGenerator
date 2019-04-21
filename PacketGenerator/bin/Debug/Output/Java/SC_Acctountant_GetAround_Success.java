
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询附近会计
public class SC_Acctountant_GetAround_Success implements IBBWriter, IBBReader
{
    public List<SC_Acctountant_GetAround_Person> person = new ArrayList<SC_Acctountant_GetAround_Person>();
    public static final short commandType = 25; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( person ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        person = bb.ReadListClass( SC_Acctountant_GetAround_Person.class ,0,0 );
    }

};