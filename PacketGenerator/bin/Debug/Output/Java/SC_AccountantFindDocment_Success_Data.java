
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看文档
public class SC_AccountantFindDocment_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 公司名称
        */
    public String customerName ="";
        /*
         * 报表类型
        */
    public int typeId;
        /*
         * 年
        */
    public int year;
        /*
         * 季度
        */
    public int quarter;
        /*
         * 月
        */
    public int month;
        /*
         * 文件ID
        */
    public int fileId;
    public static final short commandType = 161; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( customerName );
        bb.Write( typeId );
        bb.Write( year );
        bb.Write( quarter );
        bb.Write( month );
        bb.Write( fileId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        customerName = bb.ReadString( 0,300 );
        typeId = bb.ReadInteger();
        year = bb.ReadInteger();
        quarter = bb.ReadInteger();
        month = bb.ReadInteger();
        fileId = bb.ReadInteger();
    }

};