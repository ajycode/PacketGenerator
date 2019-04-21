
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获得订单下有哪些报表
public class CS_ReportFileList_Download implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 子订单编号
        */
    public String subOrderID ="";
    public static final short commandType = 53; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( subOrderID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        subOrderID = bb.ReadString( 0,150 );
    }

};