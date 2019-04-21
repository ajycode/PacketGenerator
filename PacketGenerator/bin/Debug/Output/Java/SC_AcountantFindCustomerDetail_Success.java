
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的某个公司明细
public class SC_AcountantFindCustomerDetail_Success implements IBBWriter, IBBReader
{
        /*
         * 公司名称
        */
    public String customerName ="";
        /*
         * 公司地址
        */
    public String customerAddress ="";
        /*
         * 公司类型
        */
    public String customerType ="";
        /*
         * 公司邮件地址
        */
    public String customerEmail ="";
        /*
         * 公司纳税资质
        */
    public String customerQualification ="";
        /*
         * 合作次数
        */
    public int count;
    public static final short commandType = 152; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( customerName );
        bb.Write( customerAddress );
        bb.Write( customerType );
        bb.Write( customerEmail );
        bb.Write( customerQualification );
        bb.Write( count ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        customerName = bb.ReadString( 0,150 );
        customerAddress = bb.ReadString( 0,300 );
        customerType = bb.ReadString( 0,150 );
        customerEmail = bb.ReadString( 0,150 );
        customerQualification = bb.ReadString( 0,150 );
        count = bb.ReadInteger();
    }

};