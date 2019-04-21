
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件(订单流程内使用)
public class SC_ReportFileOrder_Download_Success implements IBBWriter, IBBReader
{
        /*
         * 图片名称
        */
    public String fileName ="";
        /*
         * 内容
        */
    public byte[ ] fileContent = new byte[ 0 ];
        /*
         * 报表类型1->年度报表,2->季度报表,3->月度报表
        */
    public int fileType;
    public static final short commandType = 121; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( fileName );
        bb.Write( fileContent );
        bb.Write( fileType ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
        fileType = bb.ReadInteger();
    }

};