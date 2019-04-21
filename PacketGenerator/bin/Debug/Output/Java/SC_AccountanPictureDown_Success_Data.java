
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载会计图片
public class SC_AccountanPictureDown_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 图片内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
        /*
         * 图片类型的名称
        */
    public String picName ="";
    public static final short commandType = 92; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( fileContent );
        bb.Write( picName ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        fileContent = bb.ReadBytes( 0,3048576 );
        picName = bb.ReadString( 0,150 );
    }

};