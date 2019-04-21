
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 验证服务器失败
public enum SC_Anonymous_Failure_Type
{
    Failure( (int)0 );// 验证服务器失败
    int value;
    SC_Anonymous_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Anonymous_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return Failure;
            default:
                return null;
        }
    }
};