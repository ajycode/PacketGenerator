﻿
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计返还资料
public class SC_Accountant_Send_Back_Failure implements IBBWriter, IBBReader
{
    public SC_Accountant_Send_Back_Failure_Type type = SC_Accountant_Send_Back_Failure_Type.ParamError;
    public static final short commandType = 58; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( type.value ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        type = SC_Accountant_Send_Back_Failure_Type.valueOf( bb.ReadInteger() );
    }

};