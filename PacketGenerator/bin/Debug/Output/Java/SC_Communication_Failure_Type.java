
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 通信错误
public enum SC_Communication_Failure_Type
{
    SerializeError( (int)0 );// 序列化错误
    int value;
    SC_Communication_Failure_Type( int v )
    {
        this.value = v;
    }
    public static SC_Communication_Failure_Type valueOf( int v )
    {   
        switch( v )
        {
            case 0:
                return SerializeError;
            default:
                return null;
        }
    }
};