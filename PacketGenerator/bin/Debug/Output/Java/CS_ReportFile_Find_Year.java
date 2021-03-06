﻿
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查看年度报表文件
public class CS_ReportFile_Find_Year implements IBBWriter, IBBReader
{
        /*
         * 令牌
        */
    public String token ="";
        /*
         * 公司ID
        */
    public int customID;
        /*
         * 报表的年
        */
    public int year;
    public static final short commandType = 57; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( token );
        bb.Write( customID );
        bb.Write( year ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        token = bb.ReadString( 0,150 );
        customID = bb.ReadInteger();
        year = bb.ReadInteger();
    }

};