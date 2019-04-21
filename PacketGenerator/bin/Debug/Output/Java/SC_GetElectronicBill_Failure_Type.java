
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 获得公司电子财务信息
public enum SC_GetElectronicBill_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 ),// 业务逻辑执行失败
    NotFindOrder( (int)2 );// 不存在该客户
    int value;
    SC_GetElectronicBill_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_GetElectronicBill_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return BusinessLogicExcuteFailed;
            case 2:
                return NotFindOrder;
            default:
                return null;
        }
    }
};