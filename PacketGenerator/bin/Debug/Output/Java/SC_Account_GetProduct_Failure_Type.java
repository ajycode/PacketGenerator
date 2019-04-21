﻿
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计获取本人受理业务
public enum SC_Account_GetProduct_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    ExecuteError( (int)1 );// 数据库执行错误
    int value;
    SC_Account_GetProduct_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Account_GetProduct_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return ExecuteError;
            default:
                return null;
        }
    }
};