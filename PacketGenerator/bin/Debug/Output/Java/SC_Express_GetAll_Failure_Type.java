
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询全部快递服务
public enum SC_Express_GetAll_Failure_Type
{
    ExecuteError( (int)0 );// 数据库执行错误
    int value;
    SC_Express_GetAll_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Express_GetAll_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ExecuteError;
            default:
                return null;
        }
    }
};