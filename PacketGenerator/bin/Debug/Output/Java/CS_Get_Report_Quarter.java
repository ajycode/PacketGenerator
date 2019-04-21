
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询季度报表
public class CS_Get_Report_Quarter implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 订单编号
        */
    public String customerId ="";
        /*
         * “-”前代表年份, ”-”后代表季度（传1到4）
        */
    public String time ="";
    public static final short commandType = 23; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customerId );
        bb.Write( time ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customerId = bb.ReadString( 0,150 );
        time = bb.ReadString( 0,150 );
    }

};