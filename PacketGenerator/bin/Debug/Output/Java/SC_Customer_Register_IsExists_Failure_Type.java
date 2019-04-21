
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司注册用户名检测
public enum SC_Customer_Register_IsExists_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    ExecuteError( (int)1 ),// 数据库执行错误
    UserNameExist( (int)2 );// 用户名已存在
    int value;
    SC_Customer_Register_IsExists_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Customer_Register_IsExists_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return ExecuteError;
            case 2:
                return UserNameExist;
            default:
                return null;
        }
    }
};