
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计注册
public class CS_Accountant_Register implements IBBWriter, IBBReader
{
        /*
         * 真实姓名
        */
    public String name ="";
        /*
         * 收件地址
        */
    public String acceptanceAddress ="";
        /*
         * 办公地址
        */
    public String businessAddress ="";
        /*
         * 联系电话
        */
    public String phone ="";
        /*
         * 登录名
        */
    public String loginName ="";
        /*
         * 密码
        */
    public String password ="";
        /*
         * 身份证号
        */
    public String idNumber ="";
        /*
         * 证书编号（会计资格证）
        */
    public String certificateNO ="";
        /*
         *  经度（办公地址）
        */
    public double longitude;
        /*
         * 纬度（办公地址）
        */
    public double latitude;
        /*
         * 昵称
        */
    public String nickName ="";
        /*
         * 性别(请传：男或女)
        */
    public String gender ="";
        /*
         * 电子邮件
        */
    public String emmail ="";
        /*
         * 自我介绍
        */
    public String selfIntroduction ="";
        /*
         * 极光推送标识
        */
    public String registrationId ="";
    public Dict<Integer,CS_Account_Register_IsExists> dict = new Dict<Integer,CS_Account_Register_IsExists>();
    public static final short commandType = 1; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( name );
        bb.Write( acceptanceAddress );
        bb.Write( businessAddress );
        bb.Write( phone );
        bb.Write( loginName );
        bb.Write( password );
        bb.Write( idNumber );
        bb.Write( certificateNO );
        bb.Write( longitude );
        bb.Write( latitude );
        bb.Write( nickName );
        bb.Write( gender );
        bb.Write( emmail );
        bb.Write( selfIntroduction );
        bb.Write( registrationId );
        bb.WriteListInteger( dict ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        name = bb.ReadString( 0,30 );
        acceptanceAddress = bb.ReadString( 0,300 );
        businessAddress = bb.ReadString( 0,300 );
        phone = bb.ReadString( 0,60 );
        loginName = bb.ReadString( 0,60 );
        password = bb.ReadString( 0,60 );
        idNumber = bb.ReadString( 0,54 );
        certificateNO = bb.ReadString( 0,150 );
        longitude = bb.ReadDouble();
        latitude = bb.ReadDouble();
        nickName = bb.ReadString( 0,60 );
        gender = bb.ReadString( 0,3 );
        emmail = bb.ReadString( 0,150 );
        selfIntroduction = bb.ReadString( 0,3000 );
        registrationId = bb.ReadString( 0,150 );
        dict = bb.ReadListInteger(0,0 );
    }

};