
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计上传报表文件
public class CS_ReportFile_Upload implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 文件名
        */
    public String fileName ="";
        /*
         * 文件内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
        /*
         * 子订单编号
        */
    public String subOrderID ="";
    public static final short commandType = 37; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( fileName );
        bb.Write( fileContent );
        bb.Write( subOrderID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
        subOrderID = bb.ReadString( 0,150 );
    }

};