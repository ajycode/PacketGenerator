
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计列表
public class CS_Accountant_GetListScreenData implements IBBWriter, IBBReader
{
        /*
         * 字段名
        */
    public String name ="";
        /*
         * 值
        */
    public String number ="";
    public static final short commandType = 31; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( name );
        bb.Write( number ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        name = bb.ReadString( 0,150 );
        number = bb.ReadString( 0,50 );
    }

};