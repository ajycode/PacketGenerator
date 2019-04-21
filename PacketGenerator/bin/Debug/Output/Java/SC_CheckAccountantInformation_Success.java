
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 地图点击获得会计详细信息
public class SC_CheckAccountantInformation_Success implements IBBWriter, IBBReader
{
        /*
         * 姓名
        */
    public String name ="";
        /*
         * 性别
        */
    public String gender ="";
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
         * 擅长领域
        */
    public List<Integer> industryID = new ArrayList<Integer>();
        /*
         * 专业证书
        */
    public List<SC_CheckAccountantInformation_Success_Data> data = new ArrayList<SC_CheckAccountantInformation_Success_Data>();
    public static final short commandType = 124; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( name );
        bb.Write( gender );
        bb.Write( accountantAuth );
        bb.Write( introduction );
        bb.Write( completeCount );
        bb.Write( grade );
        bb.WriteListInteger( industryID );
        bb.WriteListClass( data ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        name = bb.ReadString( 0,150 );
        gender = bb.ReadString( 0,10 );
        accountantAuth = bb.ReadString( 0,150 );
        introduction = bb.ReadString( 0,3000 );
        completeCount = bb.ReadInteger();
        grade = bb.ReadDouble();
        industryID = bb.ReadListInteger(0,0 );
        data = bb.ReadListClass( SC_CheckAccountantInformation_Success_Data.class ,0,0 );
    }

};