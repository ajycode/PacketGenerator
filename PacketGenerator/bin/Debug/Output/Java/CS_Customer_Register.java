
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司注册
public class CS_Customer_Register implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 联系人
        */
    public String contact ="";
        /*
         * 公司名称
        */
    public String companyName ="";
        /*
         * 公司地址
        */
    public String companyAdress ="";
        /*
         * 公司类型
        */
    public String companyType ="";
        /*
         * 联系电话
        */
    public String phone ="";
        /*
         * 邮件
        */
    public String email ="";
        /*
         * 登陆名
        */
    public String loginname ="";
        /*
         * 密码
        */
    public String password ="";
        /*
         * 纳税资质
        */
    public String taxQualification ="";
        /*
         * 极光推送标识
        */
    public String registrationId ="";
    public static final short commandType = 7; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( contact );
        bb.Write( companyName );
        bb.Write( companyAdress );
        bb.Write( companyType );
        bb.Write( phone );
        bb.Write( email );
        bb.Write( loginname );
        bb.Write( password );
        bb.Write( taxQualification );
        bb.Write( registrationId ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        contact = bb.ReadString( 0,30 );
        companyName = bb.ReadString( 0,150 );
        companyAdress = bb.ReadString( 0,300 );
        companyType = bb.ReadString( 0,150 );
        phone = bb.ReadString( 0,60 );
        email = bb.ReadString( 0,150 );
        loginname = bb.ReadString( 0,60 );
        password = bb.ReadString( 0,60 );
        taxQualification = bb.ReadString( 0,150 );
        registrationId = bb.ReadString( 0,150 );
    }

};