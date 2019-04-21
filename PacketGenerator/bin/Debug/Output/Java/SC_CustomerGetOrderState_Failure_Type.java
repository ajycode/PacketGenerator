
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 公司查询所有订单的进度
public enum SC_CustomerGetOrderState_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 );// 业务逻辑执行失败
    int value;
    SC_CustomerGetOrderState_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_CustomerGetOrderState_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return BusinessLogicExcuteFailed;
            default:
                return null;
        }
    }
};