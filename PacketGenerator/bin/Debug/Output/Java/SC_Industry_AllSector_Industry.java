
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取全部行业分类
public class SC_Industry_AllSector_Industry implements IBBWriter, IBBReader
{
        /*
         * 行业编号
        */
    public int id;
        /*
         * 行业名称
        */
    public String name ="";
    public static final short commandType = 21; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( name ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        name = bb.ReadString( 0,1150 );
    }

};