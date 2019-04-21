
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 地图点击获得会计详细信息
public class SC_CheckAccountantInformation_Success_Data implements IBBWriter, IBBReader
{
        /*
         * 证书名称
        */
    public String credentialName ="";
        /*
         * 证书是否经过认证
        */
    public boolean isAuth;
    public static final short commandType = 123; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( credentialName );
        bb.Write( isAuth ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        credentialName = bb.ReadString( 0,150 );
        isAuth = bb.ReadBoolean();
    }

};