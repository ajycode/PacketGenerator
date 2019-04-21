
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取全部行业分类
public class SC_Industry_AllSector_Success implements IBBWriter, IBBReader
{
    public List<SC_Industry_AllSector_Industry> industrys = new ArrayList<SC_Industry_AllSector_Industry>();
    public static final short commandType = 20; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( industrys ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        industrys = bb.ReadListClass( SC_Industry_AllSector_Industry.class ,0,0 );
    }

};