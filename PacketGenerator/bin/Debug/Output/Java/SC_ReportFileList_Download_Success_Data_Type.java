
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件列表(订单流程内使用)
public enum SC_ReportFileList_Download_Success_Data_Type
{
    Month( (int)0 ),// 月报表
    Quarter( (int)1 ),// 季度报表
    Year( (int)2 );// 年报表
    int value;
    SC_ReportFileList_Download_Success_Data_Type( int v )
    {
        this.value = v;
    }
    public static SC_ReportFileList_Download_Success_Data_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return Month;
            case 1:
                return Quarter;
            case 2:
                return Year;
            default:
                return null;
        }
    }
};