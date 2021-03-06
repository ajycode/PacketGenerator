﻿
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 下载报表文件(订单流程内使用)
public enum SC_ReportFileOrder_Download_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 ),// 业务逻辑执行失败
    NotFindFile( (int)2 );// 没有找到该文件
    int value;
    SC_ReportFileOrder_Download_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_ReportFileOrder_Download_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return BusinessLogicExcuteFailed;
            case 2:
                return NotFindFile;
            default:
                return null;
        }
    }
};