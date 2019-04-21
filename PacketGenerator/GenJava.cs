using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketGenerator
{
    class GenJava
    {

        public static string Gen( Template t, string outDir, string pn )
        {
            #region 生成 PkgTypes.java
            outDir = Path.Combine(outDir, "Java");
            if (!Directory.Exists(outDir))
            {
                try
                {
                    Directory.CreateDirectory(outDir);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            _pn = pn;
            var ns = pn + "PkgTypes";
            var ms = pn + "Handler";
            ConvertNamespace( t, ns );

            var sb = new StringBuilder();




            // 生成所有枚举
            foreach( var e in t.Enums )
            {
                sb.Clear();
                sb.Append( @"
package com.cdrdj.cspkgtypes;" + @"
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;
" );
                sb.Append( @"" );
                if( !string.IsNullOrWhiteSpace( e.Desc ) )
                {
                    sb.Append( @"
// " + e.Desc );
                }
                sb.Append( @"
public enum " + e.Name + @"
{" );
                for( int i = 0; i < e.Fields.Count; i++ )
                {
                    var ef = e.Fields[i];
                    sb.Append( @"
    " + ef.Name + "( (" + GetEnumTypeKeyword( e ) + ")" + ef.Value + " )" );
                    if( i != e.Fields.Count - 1 )
                    {
                        sb.Append( @"," );
                    }
                    else
                    {
                        sb.Append( @";" );
                    }
                    if( !string.IsNullOrWhiteSpace( ef.Desc ) )
                    {
                        sb.Append( "// " + ef.Desc );
                    }
                }
                sb.Append( @"
    " + GetEnumTypeKeyword( e ) + @" value;" );
                sb.Append( @"
    " + e.Name + @"( " + GetEnumTypeKeyword( e ) + @" v )
    {
        this.value = v;
    }" );
                sb.Append( @"
    public static " + e.Name + @" valueOf( int v )
    {   
        switch( v )
        {" );
                for( int i = 0; i < e.Fields.Count; i++ )
                {
                    var ef = e.Fields[i];
                    sb.Append( @"
            case " + ef.Value + @":
                return " + ef.Name + ";" );
                }
                sb.Append( @"
            default:
                return null;
        }
    }" );
                sb.Append( @"
};" );
                try
                {
                    //sb.WriteToFile( Path.Combine( @"D:\erdj_project_shengcheng\java", e.Name + ".java" ) );
                    var outFile = Path.Combine(outDir, e.Name + ".java");
                    sb.WriteToFile(outFile);
                }
                catch( Exception ex )
                {
                    return ex.Message;
                }
            }

            Dictionary<int, string> dc = new Dictionary<int, string>();
            int cmdId = 0;
            // 生成类声明


            foreach( var c in t.Classes )
            {
                sb.Clear();
                sb.Append( @"
package com.cdrdj.cspkgtypes;" + @"
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;
" );
                cmdId++;
                sb.Append( @"" );
                if( !string.IsNullOrWhiteSpace( c.Desc ) )
                {
                    sb.Append( @"
// " + c.Desc );
                }

                sb.Append( @"
public class " + c.Name + @" implements IBBWriter, IBBReader
{" );
                // 生成类成员
                foreach( var f in c.Fields )
                {
                    //maomao
                    var tn =  GetTypeKeyword( f.Declare );
                    sb.Append( (f.Desc == "" ? "" : GetComment( f.Desc, 8 )) + @"
    public " + tn + " " + f.Name.ToFirstLower() );
                    if( f.Declare.DataType == DataTypes.Custom && f.Declare.Class != null && !f.Declare.Class.IsEnum )
                    {
                        sb.Append( @" = new " + tn + "()" );
                    }
                    else if( f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "DateTime" )
                    {
                        sb.Append( @" = new " + tn+ "(1,0,1,0,0,0)" );
                    }
                    else if( f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "String" )
                    {
                        sb.Append( @" =""""" );
                    }
                    else if( f.Declare.DataType == DataTypes.Generic )
                    {
                        sb.Append( @" = new " + tn.Replace( "List<", "ArrayList<" ) + "()" );
                    }
                    else if( f.Declare.DataType == DataTypes.Custom && f.Declare.Class != null && f.Declare.Class.IsEnum )
                    {
                        var myEnum =  (Enum)f.Declare.Class;
                        sb.Append( @" = " + GetEnumFristString( myEnum ) );
                    }
                    else if( f.Declare.DataType == DataTypes.Array )
                    {
                        sb.Append( @" = new byte[ 0 ]" );
                    }

                    sb.Append( ";" );
                }
                dc.Add( cmdId, c.Name );
                //if( c.Fields.Count > 0 )

                //{
                // 生成静态直写函数
                sb.Append( @"
    public static final short commandType = " + cmdId + @"; 
" );


                //if( c.Fields.Count == 0 ) continue;
                // 生成 ByteBuffer 接口函数的定义
                // todo: namespace support
                //short cmdId = " + cmdId + @";
                sb.Append( @"
    public void WriteToBB( ByteBuffer bb )
    {" );
                if( c.Fields.Count != 0 )
                {

                    for( int i = 0; i < c.Fields.Count; ++i )
                    {
                        sb.Append( @"
        bb." );
                        var f = c.Fields[ i ];
                        sb.Append( GetWriteTypeBuffer( f.Declare ) );
                        sb.Append( "( " );
                        sb.Append( f.Name );
                        if( f.Declare.Class != null && f.Declare.Class.IsEnum )
                        {
                            sb.Append( @".value" );
                        }
                        sb.Append( @" );" );
                    }

                }
                sb.Append( @" 
    }

    public void ReadFromBB( ByteBuffer bb )
    {" );

                for( int i = 0; i < c.Fields.Count; ++i )
                {
                    bool flag = false;
                    sb.Append( @"
        " );
                    var f = c.Fields[ i ];
                    sb.Append( f.Name );
                    sb.Append( " = " );
                    if( f.Declare.Class != null && f.Declare.Class.IsEnum )
                    {
                        var ooxx =  (Enum)f.Declare.Class;
                        sb.Append( ooxx.Name + ".valueOf( " );
                        flag = true;
                    }
                    sb.Append( "bb." );
                    sb.Append( GetReadTypeBuffer( f.Declare ) );
                    sb.Append( @"(" );
                    if( f.Declare.Childs.Count > 0 && f.Declare.Childs[ 0 ].DataType == DataTypes.Custom )
                    {
                        sb.Append( " " + GetBufferString( f.Declare.Childs[ 0 ] ) + ".class " );
                    }
                    else if( f.Declare.DataType == DataTypes.Custom && f.Declare.Class != null && !f.Declare.Class.IsEnum )
                    {
                        sb.Append( " " + GetBufferString( f.Declare ) + ".class " );
                    }
                    if( f.Declare.DataType == DataTypes.Generic )
                    {
                        if( f.Declare.Childs.Count > 0 && f.Declare.Childs[ 0 ].DataType == DataTypes.Custom )
                        {
                            sb.Append( @"," );
                        }

                        sb.Append( f.Declare.MinLen + @"," + f.Declare.MaxLen + " " );
                    }
                    else if(( f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "String" )||f.Declare.DataType == DataTypes.Array)
                    {
                        sb.Append( @" " + f.Declare.MinLen + @"," + f.Declare.MaxLen + @" " );
                    }
                    if( flag )
                    {
                        sb.Append( @") " );
                    }
                    sb.Append( @");" );

                }
                sb.Append( @"
    }
" );
                sb.Append( @"
};" );
                try
                {
                    //sb.WriteToFile( Path.Combine( @"D:\erdj_project_shengcheng\java", c.Name + ".java" ) );
                    var outFile = Path.Combine(outDir, c.Name + ".java");
                    sb.WriteToFile(outFile);
                }
                catch( Exception ex )
                {
                    return ex.Message;
                }
            }



            #endregion

            #region 生成 Rotate.java
            sb.Clear();
            sb.Append( @"
short cmdID = bb.ReadShort();
switch( cmdID )
{" );
            foreach( var dcItem in dc )
            {
                sb.Append( @"
    case " + dcItem.Key + @" :
        {
            " + dcItem.Value + @" myItem = null;
            try
            {
                myItem = bb.ReadClass( " + dcItem.Value + @".class );
            }
            catch
            {
                System.out.println( ""ByteBuff Error"" );
            }

            // code here

            break;
        }" );
            }

            sb.Append( @"
    default:
        break;
}" );
            try
            {
                //sb.WriteToFile( Path.Combine( @"D:\erdj_project_shengcheng\java", "RotateJava.txt" ) );
                var outFile = Path.Combine(outDir, "RotateJava.txt");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            #endregion


            #region 生成 EnumToString.java
            sb.Clear();
            sb.Append( @"
public class EnumToString
{" );
            foreach( var e in t.Enums )
            {
                sb.Append( @"
    public static string Get("+e.Name+@" e )
    {
        switch(e)
        {" );
                foreach( var ee in e.Fields )
                {
                    sb.Append( @"
            case " + e.Name + "." + ee.Name + @": 
                return """ + e.Name + "." + ee.Name+" "+ee.Desc+@""";" );
                                        
                }
                sb.Append( @"
        }
    }" );
            }
            sb.Append( @"
}" );
            try
            {
                //sb.WriteToFile( Path.Combine( @"D:\svn\xieyi\java", "EnumToString.java" ) );
                var outFile = Path.Combine(outDir, "EnumToString.java");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            #endregion
            //System.Diagnostics.Process.Start( "explorer.exe", outDir );
            return "";
        }
        private static String ChangeTypes( String valueString )
        {
            //valueString = valueString.Split( ':' )[ valueString.Split( ':' ).Length - 1 ];
            valueString = valueString.Replace( "string", "xxx::String" );
            valueString = valueString.Replace( "String", "xxx::String" );
            valueString = valueString.Replace( "List", "xxx::List" );
            return valueString;
        }

        public static string ToFieldName( string s )
        {
            if( s.Length <= 1 ) return "_" + s.ToLower();
            return "_" + s.Substring( 0, 1 ).ToLower() + s.Substring( 1 );
        }



        // 项目名上下文，省掉下面的传参了
        public static string _pn;


        // 把 Namespace 啥中间的 . 转为 ::
        public static void ConvertNamespace( Template t, string baseNS = "" )
        {
            foreach( var c in t.Classes )
            {
                /*if (c.Namespace == "") c.Namespace = "::" + baseNS;
                else */
                c.Namespace = c.Namespace.Replace( ".", "::" );
                foreach( var f in c.Fields )
                {
                    if( f.Declare.Namespace == "" ) continue;
                    if( f.Declare.Namespace == "System" )
                    {
                        f.Declare.Namespace = "";
                    }
                    else
                    {
                        f.Declare.Namespace = (baseNS == "" ? "" : ("::" + baseNS + "::")) + f.Declare.Namespace.Replace( ".", "::" );
                    }
                }
            }
        }


        /// <summary>
        /// 成员数据类型 全是简单数据类型, 或由 简单数据类型组成的类( 这个和 c++ 的 std::is_pod 不一样，没那么严格 ) 
        /// </summary>
        public static bool IsPod( Class c )
        {
            foreach( var f in c.Fields )
            {
                if( f.Declare.Name == "String" )
                    return false;
                if( f.Declare.DataType == DataTypes.Generic ) return false;
                if( f.Declare.DataType == DataTypes.BuiltIn ) continue;
                if( f.Declare.DataType == DataTypes.Custom )
                {
                    if( f.Declare.Class == null )
                    {
                        throw new Exception( "should not be null" );
                    }
                    if( f.Declare.Class != null && f.Declare.Class.IsEnum ) continue;
                    if( !IsPod( (Class)f.Declare.Class ) ) return false;
                }
            }
            return true;
        }


        public static bool IsSimpleType( ClassField f )
        {
            if( f.Declare.DataType != DataTypes.BuiltIn ) return false;
            if( f.Declare.Name == "String" )
            {
                return false;
            }
            if( f.Declare.Class != null && f.Declare.Class.IsEnum ) return true;
            switch( f.Declare.Name )
            {
                case "Byte":
                case "UInt16":
                case "UInt32":
                case "UInt64":
                case "SByte":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Double":
                case "Single":
                case "Boolean":
                    return true;
            }
            return false;
        }

        public static string GetDefaultValueByType( ClassField f )
        {
            if( f.Declare.DataType != DataTypes.BuiltIn )
            {
                return "";
            }
            switch( f.Declare.Name )
            {
                case "Byte":
                case "UInt16":
                case "UInt32":
                case "UInt64":
                case "SByte":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Double":
                case "Single": return "0";
                case "Boolean": return "false";
                case "String": return "";
                default:
                    if( f.Declare.Class != null && f.Declare.Class.IsEnum )
                    {
                        return f.Declare.Name + "." + ((Enum)f.Declare.Class).Fields.First().Name;
                    }
                    return "";
            }
        }

        public static string GetComment( string s, int space )
        {
            if( s.Trim() == "" ) return "";
            var sps = new string( ' ', space );
            return "\r\n" +
    sps + @"/*
" + sps + @" * " + s + @"
" + sps + @"*/";
        }

        public static string GetTypeKeyword( Declare d )
        {
            string rtv = " ";
            if( d.DataType == DataTypes.Array )
            {
                rtv = GetTypeKeyword( d.Childs[ 0 ] ) + "[ ]";
            }
            else if( d.DataType == DataTypes.BuiltIn )
            {
                switch( d.Name )
                {
                    case "Byte": rtv = "byte"; break;
                    case "SByte": rtv = "byte"; break;
                    case "UInt16": rtv = "short"; break;
                    case "Int16": rtv = "short"; break;
                    case "UInt32": rtv = "int"; break;
                    case "Int32": rtv = "int"; break;
                    case "UInt64": rtv = "long"; break;
                    case "Int64": rtv = "long"; break;
                    case "Double": rtv = "double"; break;
                    case "Single": rtv = "float"; break;
                    case "Boolean": rtv = "boolean"; break;
                    case "String": rtv = "String"; break;
                    case "DateTime": rtv = "Date"; break;
                    // case "List<int>": rtv = "xxx::List<int>"; break;
                    default:
                        rtv = d.Name;
                        break;
                }

            }

            else if( d.DataType == DataTypes.Custom )
            {
                rtv = d.Name;
            }
            else
            {
                rtv = d.Name + "<";
                for( int i = 0; i < d.Childs.Count; ++i )
                {
                    if( i > 0 ) rtv += ",";
                    var xxx1 = d.Childs[ i ];
                    if( xxx1.DataType == DataTypes.BuiltIn )
                    {
                        switch( xxx1.Name )
                        {
                            case "Byte": rtv += "Byte"; break;
                            case "SByte": rtv += "Byte"; break;
                            case "UInt16": rtv += "Short"; break;
                            case "Int16": rtv += "Short"; break;
                            case "UInt32": rtv += "Integer"; break;
                            case "Int32": rtv += "Integer"; break;
                            case "UInt64": rtv += "Long"; break;
                            case "Int64": rtv += "Long"; break;
                            case "Double": rtv += "Double"; break;
                            case "Single": rtv += "Float"; break;
                            case "Boolean": rtv += "Boolean"; break;
                            case "String": rtv += "String"; break;
                            case "DateTime": rtv += "Date"; break;
                            // case "List<int>": rtv = "xxx::List<int>"; break;
                            default:
                                rtv += xxx1.Name;
                                break;
                        }
                    }
                    else if( xxx1.DataType == DataTypes.Custom )
                    {
                        rtv += xxx1.Name;
                    }
                }
                rtv += ">";

            }
            return rtv;
        }

        // todo: 将类型声明尾部的 1组或多组 [???] 分离并返回
        public static KeyValuePair<string, string> SplitTypeKeyword( string k, Declare d )
        {
            int n = 0;
            while( d.DataType == DataTypes.Array )
            {
                n += 2 + d.MinLen.ToString().Length;
                d = d.Childs[ 0 ];
            }
            return new KeyValuePair<string, string>( k.Substring( 0, k.Length - n ), k.Substring( k.Length - n, n ) );
        }


        public static string GetEnumTypeKeyword( Enum e )
        {
            switch( e.Type )
            {
                case "Byte": return "byte";
                case "SByte": return "sbyte";
                case "UInt16": return "ushort";
                case "Int16": return "short";
                case "UInt32": return "uint";
                case "Int32": return "int";
                case "UInt64": return "ulong";
                case "Int64": return "long";
            }
            throw new Exception( "unsupported data type" );
        }

        public static string GetWriteTypeBuffer( Declare d )
        {
            string rtv = " ";
            if( d.DataType == DataTypes.BuiltIn )
            {

                rtv = "Write";
                return rtv;
            }
            else if( d.DataType == DataTypes.Custom )
            {
                if( d.Class != null && d.Class.IsEnum )
                {
                    rtv = "Write";
                    return rtv;
                }
                else
                {
                    rtv = "Write";
                    return rtv;
                }

            }
            else if( d.DataType == DataTypes.Generic )
            {
                var xxx = d.Childs[0];
                if( xxx.DataType == DataTypes.BuiltIn )
                {
                    switch( xxx.Name )
                    {
                        case "Byte": rtv = "WriteListByte"; break;
                        case "Int16": rtv = "WriteListShort"; break;
                        case "Int32": rtv = "WriteListInteger"; break;
                        case "Int64": rtv = "WriteListLong"; break;
                        case "Char": rtv = "WriteListCharacter"; break;
                        case "Double": rtv = "WriteListDouble"; break;
                        case "Single": rtv = "WriteListFloat"; break;
                        case "Boolean": rtv = "WriteListBoolean"; break;
                        case "DateTime": rtv = "WriteListDate"; break;
                        case "String": rtv = "WriteListString"; break;

                    }
                }
                else if( xxx.DataType == DataTypes.Custom )
                {
                    rtv = "WriteListClass";
                }



            }
            else if( d.DataType == DataTypes.Array )
            {

                rtv = "Write";
                return rtv;
            }
            return rtv;
        }

        public static string GetReadTypeBuffer( Declare d )
        {
            string rtv = " ";
            if( d.DataType == DataTypes.BuiltIn )
            {
                switch( d.Name )
                {

                    case "Byte": rtv = "ReadByte"; break;
                    case "Int16": rtv = "ReadShort"; break;
                    case "Int32": rtv = "ReadInteger"; break;
                    case "Int64": rtv = "ReadLong"; break;
                    case "Char": rtv = "ReadCharacter"; break;
                    case "Double": rtv = "ReadDouble"; break;
                    case "Single": rtv = "ReadFloat"; break;
                    case "Boolean": rtv = "ReadBoolean"; break;
                    case "DateTime": rtv = "ReadDate"; break;
                    case "String": rtv = "ReadString"; break;
                    default:
                        rtv = d.Name;
                        break;
                }

            }
            else if( d.DataType == DataTypes.Custom )
            {
                if( d.Class != null && d.Class.IsEnum )
                {
                    switch( GetEnumTypeKeyword( (Enum)d.Class ) )
                    {
                        case "byte": rtv = "ReadByte"; break;
                        case "sbyte": rtv = "ReadByte"; break;
                        case "ushort": rtv = "ReadShort"; break;
                        case "short": rtv = "ReadShort"; break;
                        case "uint": rtv = "ReadInteger"; break;
                        case "int": rtv = "ReadInteger"; break;
                        case "ulong": rtv = "ReadLong"; break;
                        case "long": rtv = "ReadLong"; break;

                    }

                    return rtv;
                }
                else
                {
                    rtv = "ReadClass";
                    return rtv;
                }

            }
            else if( d.DataType == DataTypes.Generic )
            {

                switch( GetReadTypeBuffer( d.Childs[ 0 ] ) )
                {
                    case "ReadByte": rtv = "ReadListByte"; break;
                    case "ReadShort": rtv = "ReadListShort"; break;
                    case "ReadInteger": rtv = "ReadListInteger"; break;
                    case "ReadLong": rtv = "ReadListLong"; break;
                    case "ReadCharacter": rtv = "ReadListCharacter"; break;
                    case "ReadDouble": rtv = "ReadListDouble"; break;
                    case "ReadFloat": rtv = "ReadListFloat"; break;
                    case "ReadBoolean": rtv = "ReadListBoolean"; break;
                    case "ReadDate": rtv = "ReadListDate"; break;
                    case "ReadString": rtv = "ReadListString"; break;
                    case "ReadClass": rtv = "ReadListClass"; break;
                }


            }
            else if(d.DataType == DataTypes.Array)
            {
                rtv = "ReadBytes";
            }
            return rtv;
        }

        public static string GetBufferString( Declare d )
        {
            string rtv = " ";
            if( d.DataType == DataTypes.BuiltIn )
            {
                switch( d.Name )
                {
                    case "Byte": rtv = "byte"; break;
                    case "SByte": rtv = "sbyte"; break;
                    case "UInt16": rtv = "ushort"; break;
                    case "Int16": rtv = "short"; break;
                    case "UInt32": rtv = "uint"; break;
                    case "Int32": rtv = "int"; break;
                    case "UInt64": rtv = "uint64"; break;
                    case "Int64": rtv = "int64"; break;
                    case "Double": rtv = "double"; break;
                    case "Single": rtv = "float"; break;
                    case "Boolean": rtv = "bool"; break;
                    case "String": rtv = "string"; break;
                    // case "List<int>": rtv = "xxx::List<int>"; break;
                    default:
                        rtv = d.Name;
                        break;
                }
            }

            else if( d.DataType == DataTypes.Custom )
            {
                rtv = d.Name;
            }

            return rtv;
        }

        public static string GetEnumFristString( Enum myEnum )
        {
            string rtv = "";
            rtv += myEnum.Name;
            rtv += ".";
            rtv += myEnum.Fields[ 0 ].Name;

            return rtv;
        }




    }
}
