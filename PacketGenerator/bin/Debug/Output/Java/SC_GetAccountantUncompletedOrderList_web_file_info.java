
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取某会计未完成订单列表(web版)
public class SC_GetAccountantUncompletedOrderList_web_file_info implements IBBWriter, IBBReader
{
    public int file_id;
    public String file_name ="";
    public static final short commandType = 86; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( file_id );
        bb.Write( file_name ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        file_id = bb.ReadInteger();
        file_name = bb.ReadString( 0,0 );
    }

};