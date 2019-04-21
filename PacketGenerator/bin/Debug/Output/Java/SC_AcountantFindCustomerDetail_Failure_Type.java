
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的某个公司明细
public enum SC_AcountantFindCustomerDetail_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 ),// 业务逻辑执行失败
    NotFindOrder( (int)2 ),// 未找到该订单
    NotFindCustomer( (int)3 );// 未找到改公司
    int value;
    SC_AcountantFindCustomerDetail_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_AcountantFindCustomerDetail_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return BusinessLogicExcuteFailed;
            case 2:
                return NotFindOrder;
            case 3:
                return NotFindCustomer;
            default:
                return null;
        }
    }
};