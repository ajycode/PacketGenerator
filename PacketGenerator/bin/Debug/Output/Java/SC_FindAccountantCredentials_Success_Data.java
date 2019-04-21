
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查看会计证件照片
public class SC_FindAccountantCredentials_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 文件名
        */
    public String fileName ="";
        /*
         * 文件类型
        */
    public int fileType;
        /*
         * 内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
    public static final short commandType = 146; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( fileName );
        bb.Write( fileType );
        bb.Write( fileContent ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        fileName = bb.ReadString( 0,800 );
        fileType = bb.ReadInteger();
        fileContent = bb.ReadBytes( 0,3048576 );
    }

};