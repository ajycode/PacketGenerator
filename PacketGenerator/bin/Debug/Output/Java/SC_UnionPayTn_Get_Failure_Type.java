﻿
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 银联支付获取交易流水号
public enum SC_UnionPayTn_Get_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 ),// 业务逻辑执行失败
    NotFindOrder( (int)2 );// 未找到该订单
    int value;
    SC_UnionPayTn_Get_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_UnionPayTn_Get_Failure_Type valueOf( int v )
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