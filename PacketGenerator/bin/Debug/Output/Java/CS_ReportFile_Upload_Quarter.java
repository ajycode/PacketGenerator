
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 上传季度报表文件
public class CS_ReportFile_Upload_Quarter implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 子订单编号
        */
    public String subOrderID ="";
        /*
         * 图片名称
        */
    public String fileName ="";
        /*
         * 内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
        /*
         * 报表的年
        */
    public int year;
        /*
         * 报表的季度
        */
    public int quarter;
    public static final short commandType = 48; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( subOrderID );
        bb.Write( fileName );
        bb.Write( fileContent );
        bb.Write( year );
        bb.Write( quarter ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        subOrderID = bb.ReadString( 0,150 );
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
        year = bb.ReadInteger();
        quarter = bb.ReadInteger();
    }

};