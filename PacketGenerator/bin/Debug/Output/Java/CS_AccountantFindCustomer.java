
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的公司
public class CS_AccountantFindCustomer implements IBBWriter, IBBReader
{
        /*
         * 会计编号
        */
    public int accountantId;
        /*
         * 页码（0代表第一页）
        */
    public int index;
        /*
         * 单页显示数量
        */
    public int size;
    public static final short commandType = 66; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( accountantId );
        bb.Write( index );
        bb.Write( size ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        accountantId = bb.ReadInteger();
        index = bb.ReadInteger();
        size = bb.ReadInteger();
    }

};