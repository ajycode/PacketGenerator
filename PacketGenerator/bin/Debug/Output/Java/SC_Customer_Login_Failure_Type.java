
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司登陆
public enum SC_Customer_Login_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    ExecuteError( (int)1 ),// 数据库执行错误
    UsernameOrPasswordError( (int)2 ),// 用户名或密码错误
    AccountNumberLocked( (int)3 );// 账号被锁定
    int value;
    SC_Customer_Login_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Customer_Login_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return ExecuteError;
            case 2:
                return UsernameOrPasswordError;
            case 3:
                return AccountNumberLocked;
            default:
                return null;
        }
    }
};