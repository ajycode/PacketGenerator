
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计上传证件照片
public class CS_AccountantCredentials_Upload implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 证件照片文件名
        */
    public String fileName ="";
        /*
         * 证件照片内容,必须base64编码
        */
    public byte[ ] fileContent = new byte[ 0 ];
        /*
         * 会计ID
        */
    public int accountantID;
        /*
         * 证件类型
        */
    public int credential_Type;
    public static final short commandType = 35; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( fileName );
        bb.Write( fileContent );
        bb.Write( accountantID );
        bb.Write( credential_Type ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        fileName = bb.ReadString( 0,150 );
        fileContent = bb.ReadBytes( 0,3048576 );
        accountantID = bb.ReadInteger();
        credential_Type = bb.ReadInteger();
    }

};