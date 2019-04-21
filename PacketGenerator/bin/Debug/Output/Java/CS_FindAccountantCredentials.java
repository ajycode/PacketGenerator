
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查看会计证件照片
public class CS_FindAccountantCredentials implements IBBWriter, IBBReader
{
        /*
         * 会计ID
        */
    public int accountantID;
    public static final short commandType = 65; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( accountantID ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        accountantID = bb.ReadInteger();
    }

};