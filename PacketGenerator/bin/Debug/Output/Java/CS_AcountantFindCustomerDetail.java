
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的某个公司明细
public class CS_AcountantFindCustomerDetail implements IBBWriter, IBBReader
{
        /*
         * 公司ID
        */
    public int customerID;
        /*
         * 会计ID
        */
    public int accountantID;
    public static final short commandType = 67; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( customerID );
        bb.Write( accountantID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        customerID = bb.ReadInteger();
        accountantID = bb.ReadInteger();
    }

};