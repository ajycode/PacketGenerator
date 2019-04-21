
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计主页个人信息
public class CS_Account_GetDetails implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 会计用户编号
        */
    public int accountantID;
        /*
         * 公司ID，没有登陆的时候传-1，并传唯一标识
        */
    public int customerID;
        /*
         * 唯一标识
        */
    public String identification ="";
    public static final short commandType = 6; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( accountantID );
        bb.Write( customerID );
        bb.Write( identification ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        accountantID = bb.ReadInteger();
        customerID = bb.ReadInteger();
        identification = bb.ReadString( 0,300 );
    }

};