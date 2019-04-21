
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 创建订单
public enum SC_Order_Create_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    ExecuteError( (int)1 ),// 数据库执行错误
    AccountantRepeat( (int)2 ),// 不能在未完成之前对当前会计重复下单
    AcounttanOver( (int)3 );// 当前时间已经有会计做过账
    int value;
    SC_Order_Create_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Order_Create_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return ExecuteError;
            case 2:
                return AccountantRepeat;
            case 3:
                return AcounttanOver;
            default:
                return null;
        }
    }
};