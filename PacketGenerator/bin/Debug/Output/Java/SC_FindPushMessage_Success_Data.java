
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查看推送消息
public class SC_FindPushMessage_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 推送内容
        */
    public String pushHint ="";
        /*
         * 公司地址
        */
    public Date pushTime = new Date(1,0,1,0,0,0);
    public static final short commandType = 158; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( pushHint );
        bb.Write( pushTime ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        pushHint = bb.ReadString( 0,150 );
        pushTime = bb.ReadDate();
    }

};