
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看文档
public enum SC_AccountantFindDocment_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 ),// 业务逻辑执行失败
    NotFindAccountant( (int)2 );// 没有这个会计
    int value;
    SC_AccountantFindDocment_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_AccountantFindDocment_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return BusinessLogicExcuteFailed;
            case 2:
                return NotFindAccountant;
            default:
                return null;
        }
    }
};