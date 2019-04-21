
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取全部行业分类
public class CS_Industry_AllSector implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
    public static final short commandType = 9; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
    }

};