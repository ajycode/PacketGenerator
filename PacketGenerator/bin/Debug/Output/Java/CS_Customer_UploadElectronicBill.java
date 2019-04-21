
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司上传电子财务信息
public class CS_Customer_UploadElectronicBill implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 公司ID
        */
    public int customID;
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
         * 报表的月
        */
    public int month;
    public static final short commandType = 44; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customID );
        bb.Write( fileName );
        bb.Write( fileContent );
        bb.Write( year );
        bb.Write( month ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customID = bb.ReadInteger();
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
        year = bb.ReadInteger();
        month = bb.ReadInteger();
    }

};