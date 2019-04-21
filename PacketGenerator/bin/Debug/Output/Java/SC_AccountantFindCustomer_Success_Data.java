
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的公司
public class SC_AccountantFindCustomer_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 公司名称
        */
    public String customerName ="";
        /*
         * 纳税资质
        */
    public String taxQualification ="";
        /*
         * 公司ID
        */
    public int customerID;
    public static final short commandType = 149; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( customerName );
        bb.Write( taxQualification );
        bb.Write( customerID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        customerName = bb.ReadString( 0,150 );
        taxQualification = bb.ReadString( 0,150 );
        customerID = bb.ReadInteger();
    }

};