
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载会计图片
public class SC_AccountanPictureDown_Success implements IBBWriter, IBBReader
{
    public List<SC_AccountanPictureDown_Success_Data> data = new ArrayList<SC_AccountanPictureDown_Success_Data>();
    public static final short commandType = 93; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        data = bb.ReadListClass( SC_AccountanPictureDown_Success_Data.class ,0,0 );
    }

};