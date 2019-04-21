
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查看推送消息
public class CS_FindPushMessage implements IBBWriter, IBBReader
{
        /*
         * 用户ID
        */
    public int id;
        /*
         * 用户类型true为公司，false为会计
        */
    public boolean type;
        /*
         * 页码（0代表第一页）
        */
    public int index;
        /*
         * 单页显示数量
        */
    public int size;
    public static final short commandType = 70; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( type );
        bb.Write( index );
        bb.Write( size ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        type = bb.ReadBoolean();
        index = bb.ReadInteger();
        size = bb.ReadInteger();
    }

};