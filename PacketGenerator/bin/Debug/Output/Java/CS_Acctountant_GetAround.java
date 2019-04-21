
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询附近会计
public class CS_Acctountant_GetAround implements IBBWriter, IBBReader
{
        /*
         * 经度
        */
    public double lon;
        /*
         * 纬度
        */
    public double lat;
        /*
         * 半径（米
        */
    public int radius;
        /*
         * 令牌
        */
    public String token ="";
    public static final short commandType = 11; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( lon );
        bb.Write( lat );
        bb.Write( radius );
        bb.Write( token ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        lon = bb.ReadDouble();
        lat = bb.ReadDouble();
        radius = bb.ReadInteger();
        token = bb.ReadString( 0,150 );
    }

};