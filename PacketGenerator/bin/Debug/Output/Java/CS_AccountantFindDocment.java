
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看文档
public class CS_AccountantFindDocment implements IBBWriter, IBBReader
{
        /*
         * 会计的ID
        */
    public int accountantID;
        /*
         * 页码（0代表第一页）
        */
    public int index;
        /*
         * 单页显示数量
        */
    public int size;
    public static final short commandType = 71; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( accountantID );
        bb.Write( index );
        bb.Write( size ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        accountantID = bb.ReadInteger();
        index = bb.ReadInteger();
        size = bb.ReadInteger();
    }

};