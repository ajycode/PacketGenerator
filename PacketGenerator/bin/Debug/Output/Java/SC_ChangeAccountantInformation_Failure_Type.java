
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 修改会计个人资料
public enum SC_ChangeAccountantInformation_Failure_Type
{
    ParamError( (int)0 ),// 参数错误
    BusinessLogicExcuteFailed( (int)1 ),// 业务逻辑执行失败
    NotChangeEverything( (int)2 ),// 有未完成的订单是所有信息都不能修改
    NotFindAcountant( (int)3 ),// 没有这个用户
    NotChangeNum( (int)4 );// 正在审核或者审核通过后不能再修改身份证号码和会计从业证号码
    int value;
    SC_ChangeAccountantInformation_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_ChangeAccountantInformation_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return ParamError;
            case 1:
                return BusinessLogicExcuteFailed;
            case 2:
                return NotChangeEverything;
            case 3:
                return NotFindAcountant;
            case 4:
                return NotChangeNum;
            default:
                return null;
        }
    }
};