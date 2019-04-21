
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计获取本人受理业务
public class SC_Account_GetProduct_Success implements IBBWriter, IBBReader
{
    public List<SC_Account_GetProduct_Product> products = new ArrayList<SC_Account_GetProduct_Product>();
    public List<SC_Account_GetProduct_Industry> industrys = new ArrayList<SC_Account_GetProduct_Industry>();
    public static final short commandType = 7; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.WriteListClass( products );
        bb.WriteListClass( industrys ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        products = bb.ReadListClass( SC_Account_GetProduct_Product.class ,0,0 );
        industrys = bb.ReadListClass( SC_Account_GetProduct_Industry.class ,0,0 );
    }

};