
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获得公司电子财务信息
public class SC_GetElectronicBill_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 图片名称
        */
    public String fileName ="";
        /*
         * 内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
    public static final short commandType = 100; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( fileName );
        bb.Write( fileContent ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
    }

};