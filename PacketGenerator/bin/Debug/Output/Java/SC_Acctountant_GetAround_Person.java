
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询附近会计
public class SC_Acctountant_GetAround_Person implements IBBWriter, IBBReader
{
        /*
         * 会计用户编号
        */
    public int id;
        /*
         * 会计名字
        */
    public String name ="";
        /*
         * 用户认证
        */
    public String accountantAuth ="";
        /*
         * 个人简介
        */
    public String introduction ="";
        /*
         * 服务次数
        */
    public int completeCount;
        /*
         * 好评度
        */
    public double grade;
        /*
         * 经度
        */
    public double longitude;
        /*
         * 纬度
        */
    public double latitude;
    public static final short commandType = 26; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( name );
        bb.Write( accountantAuth );
        bb.Write( introduction );
        bb.Write( completeCount );
        bb.Write( grade );
        bb.Write( longitude );
        bb.Write( latitude ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        name = bb.ReadString( 0,90 );
        accountantAuth = bb.ReadString( 0,150 );
        introduction = bb.ReadString( 0,3000 );
        completeCount = bb.ReadInteger();
        grade = bb.ReadDouble();
        longitude = bb.ReadDouble();
        latitude = bb.ReadDouble();
    }

};