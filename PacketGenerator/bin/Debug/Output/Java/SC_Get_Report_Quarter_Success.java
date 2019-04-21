
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询季度报表
public class SC_Get_Report_Quarter_Success implements IBBWriter, IBBReader
{
        /*
         * 订单编号
        */
    public double national_tax_total;
        /*
         * 订单编号
        */
    public double land_tax_total;
        /*
         * 订单编号
        */
    public double non_tax_income_total;
        /*
         * 订单编号
        */
    public String national_tax ="";
        /*
         * 订单编号
        */
    public String land_tax ="";
    public static final short commandType = 53; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( national_tax_total );
        bb.Write( land_tax_total );
        bb.Write( non_tax_income_total );
        bb.Write( national_tax );
        bb.Write( land_tax ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        national_tax_total = bb.ReadDouble();
        land_tax_total = bb.ReadDouble();
        non_tax_income_total = bb.ReadDouble();
        national_tax = bb.ReadString( 0,900 );
        land_tax = bb.ReadString( 0,11500 );
    }

};