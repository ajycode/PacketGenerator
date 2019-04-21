
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 上传年度报表文件
public class CS_ReportFile_Upload_Year implements IBBWriter, IBBReader
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
         * excel名称
        */
    public String fileName ="";
        /*
         * excel内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
        /*
         * 报表的年
        */
    public int year;
    public static final short commandType = 47; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( subOrderID );
        bb.Write( fileName );
        bb.Write( fileContent );
        bb.Write( year ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        subOrderID = bb.ReadString( 0,150 );
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
        year = bb.ReadInteger();
    }

};