
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取某会计未完成订单列表(web版)
public class CS_GetAccountantUncompletedOrderList_web implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计id
        */
    public int accountant_id;
        /*
         * 页码(0代表第一页)
        */
    public int index;
        /*
         * 单页显示数量
        */
    public int size;
    public static final short commandType = 40; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountant_id );
        bb.Write( index );
        bb.Write( size ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountant_id = bb.ReadInteger();
        index = bb.ReadInteger();
        size = bb.ReadInteger();
    }

};