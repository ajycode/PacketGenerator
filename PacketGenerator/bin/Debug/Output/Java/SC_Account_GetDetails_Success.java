
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计主页个人信息
public class SC_Account_GetDetails_Success implements IBBWriter, IBBReader
{
        /*
         * 会计编号
        */
    public int id;
        /*
         * 昵称
        */
    public String nickName ="";
        /*
         * 身份证号码
        */
    public String idNumber ="";
        /*
         * 会计从业资格编号
        */
    public String certificateNum ="";
        /*
         * 会计审核状态
        */
    public String state ="";
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
         * 性别(请传：男或女)
        */
    public String gender ="";
        /*
         * 电子邮件
        */
    public String email ="";
        /*
         * 头像地址
        */
    public String headShot ="";
        /*
         *  经度（办公地址）
        */
    public double longitude;
        /*
         * 纬度（办公地址）
        */
    public double latitude;
        /*
         * 自我介绍
        */
    public String selfIntroduction ="";
    public SC_Account_GetDetails_ProductId product = new SC_Account_GetDetails_ProductId();
    public static final short commandType = 14; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( id );
        bb.Write( nickName );
        bb.Write( idNumber );
        bb.Write( certificateNum );
        bb.Write( state );
        bb.Write( name );
        bb.Write( acceptanceAddress );
        bb.Write( businessAddress );
        bb.Write( phone );
        bb.Write( gender );
        bb.Write( email );
        bb.Write( headShot );
        bb.Write( longitude );
        bb.Write( latitude );
        bb.Write( selfIntroduction );
        bb.Write( product ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        id = bb.ReadInteger();
        nickName = bb.ReadString( 0,0 );
        idNumber = bb.ReadString( 0,0 );
        certificateNum = bb.ReadString( 0,0 );
        state = bb.ReadString( 0,0 );
        name = bb.ReadString( 0,90 );
        acceptanceAddress = bb.ReadString( 0,900 );
        businessAddress = bb.ReadString( 0,900 );
        phone = bb.ReadString( 0,60 );
        gender = bb.ReadString( 0,3 );
        email = bb.ReadString( 0,1150 );
        headShot = bb.ReadString( 0,900 );
        longitude = bb.ReadDouble();
        latitude = bb.ReadDouble();
        selfIntroduction = bb.ReadString( 0,11500 );
        product = bb.ReadClass( SC_Account_GetDetails_ProductId.class );
    }

};