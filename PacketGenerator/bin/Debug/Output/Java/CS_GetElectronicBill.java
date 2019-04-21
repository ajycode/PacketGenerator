
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获得公司电子财务信息
public class CS_GetElectronicBill implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 公司ID
        */
    public int customID;
        /*
         * 报表的年
        */
    public int year;
        /*
         * 报表的月
        */
    public int month;
    public static final short commandType = 45; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customID );
        bb.Write( year );
        bb.Write( month ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customID = bb.ReadInteger();
        year = bb.ReadInteger();
        month = bb.ReadInteger();
    }

};