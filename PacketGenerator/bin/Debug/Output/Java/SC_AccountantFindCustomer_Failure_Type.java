﻿
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 会计查看交易过的公司
public enum SC_AccountantFindCustomer_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 );// 业务逻辑执行失败
    int value;
    SC_AccountantFindCustomer_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_AccountantFindCustomer_Failure_Type valueOf( int v )
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