
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获取会计主页个人信息
public enum SC_Account_GetDetails_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    ExecuteError( (int)1 ),// 数据库执行错误
    NotFound( (int)2 );// 未查找到
    int value;
    SC_Account_GetDetails_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Account_GetDetails_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return ExecuteError;
            case 2:
                return NotFound;
            default:
                return null;
        }
    }
};