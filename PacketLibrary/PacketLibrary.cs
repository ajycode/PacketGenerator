/********************************************************/
// 关键字

// enum
// class

/********************************************************/
// 标记

// Desc( "注释" )
// Limit( [定长] | [ 最小长, 最大长 ] )
// Condation( 属性名, 值 [ , 属性名, 值 ][, ...] )

/********************************************************/
// 数据类型

// byte  
// ushort
// uint  
// ulong 
// sbyte 
// short 
// int   
// long  
// double
// float 
// bool

/********************************************************/
// 集合( 通常需要用 Limit 来限定元素个数的合法范围 )

// string
// List<V>
// Dict<K, V>

/********************************************************/
// 输出

// c++ 对应   |  c# 对应     
//------------+--------------
// byte       |  byte
// ushort     |  ushort
// uint       |  uint
// uint64     |  ulong
// sbyte      |  sbyte
// short      |  short
// int        |  int
// int64      |  long
// double     |  double
// float      |  float
// bool       |  bool
// String     |  string
// List       |  List
// Dict       |  Dictionary

namespace PacketLibrary
{

    public class List<V> { }
    public class Dict<K, V> { }

    /// <summary>
    /// 备注。可用于类/枚举 及其 成员
    /// </summary>
    public class Desc : System.Attribute
    {
        public Desc( string v ) { Value = v; }
        public string Value { get; set; }
    }

    /// <summary>
    /// 针对最外层级的 数组, byte[], string 做长度限制。单个长度值为定长
    /// </summary>
    public class Limit : System.Attribute
    {
        public Limit( int fix )
        {
            Min = fix;
            Max = fix;
        }
        public Limit( int min, int max )
        {
            if( max < min ) throw new System.Exception( "error: max < min" );
            Min = min;
            Max = max;
        }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Limits : System.Attribute
    {
        public Limits( params int[] v )
        {
            Value = v;
        }
        public int[] Value { get; set; }
    }

    /// <summary>
    /// 设置序列化条件: 须满足 某 field  等于 value ( field name, value  成对交替填写 )
    /// </summary>
    public class Condation : System.Attribute
    {
        public Condation( params object[] ps ) { Value = ps; }
        public object[] Value { get; set; }
    }

    /// <summary>
    /// 设置 field 初始值
    /// </summary>
    public class Default : System.Attribute
    {
        public Default( object v ) { Value = v; }
        public object Value { get; set; }
    }

    /// <summary>
    /// 是否创建 Get 函数
    /// </summary>
    public class Get : System.Attribute
    {
        public Get() { Value = true; }
        public Get( bool v ) { Value = v; }
        public bool Value { get; set; }
    }

    /// <summary>
    /// 是否创建 Set 函数
    /// </summary>
    public class Set : System.Attribute
    {
        public Set() { Value = true; }
        public Set( bool v ) { Value = v; }
        public bool Value { get; set; }
    }

}

