
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询未完成订单列表
public class CS_UncompletedOrder_GetList implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计/客户ID
        */
    public int id;
        /*
         * 角色(0表示会计，1表示客户)
        */
    public int role;
        /*
         * 页码(0代表第一页)
        */
    public int index;
        /*
         * 单页显示数量
        */
    public int size;
    public static final short commandType = 14; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( id );
        bb.Write( role );
        bb.Write( index );
        bb.Write( size ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        id = bb.ReadInteger();
        role = bb.ReadInteger();
        index = bb.ReadInteger();
        size = bb.ReadInteger();
    }

};