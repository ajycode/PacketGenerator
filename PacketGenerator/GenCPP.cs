using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PacketGenerator
{
    public static class GenCPP
    {
        public static string Gen( Template t, string outDir, string pn )
        {
            #region 生成 PkgTypes.h
            outDir = Path.Combine(outDir, "CPP");
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
            sb.Append( @"#ifndef __" + pn.ToUpper() + @"PkgTypes_H__
#define __" + pn.ToUpper() + @"PkgTypes_H__

#include ""xxlib.h""
" );

            // 生成类预声明
            sb.Append( @"
// predeclares
namespace " + pn + @"PkgTypes
{" );
            foreach( var c in t.Classes )
            {
                sb.Append( @"
    struct " + c.Name + @";" );
            }

            sb.Append( @"
}
" );


            // 生成所有枚举
            sb.Append( @"
// enums
namespace " + pn + @"PkgTypes
{" );
            foreach( var e in t.Enums )
            {
                sb.Append( @"" );
                if( !string.IsNullOrWhiteSpace( e.Desc ) )
                {
                    sb.Append( @"
    // " + e.Desc );
                }
                sb.Append( @"
    enum class " + e.Name + @" : " + GetEnumTypeKeyword( e ) + @"
    {" );
                foreach( var ef in e.Fields )
                {
                    sb.Append( @"
        " + ef.Name + " = " + ef.Value + ", " );
                    if( !string.IsNullOrWhiteSpace( ef.Desc ) )
                    {
                        sb.Append( "// " + ef.Desc );
                    }
                }
                sb.Append( @"
    };" );
            }

            sb.Append( @"
}
" );
            Dictionary<int, string> dc = new Dictionary<int, string>();
            // 生成类声明
            sb.Append( @"
// struct declares
namespace " + pn + @"PkgTypes
{" );
            int  cmdId = 0;
            foreach( var c in t.Classes )
            {
                cmdId++;
                sb.Append( @"" );
                if( !string.IsNullOrWhiteSpace( c.Desc ) )
                {
                    sb.Append( @"
    // " + c.Desc );
                }

                sb.Append( @"
    struct " + c.Name + @" : xxlib::Memmoveable
    {" );
                sb.Append( @"
        " + c.Name + @"(){}" );
                // 生成类成员
                foreach( var f in c.Fields )
                {
                    //maomao
                    var tn =  GetTypeKeyword( f.Declare );

                    sb.Append( (f.Desc == "" ? "" : GetComment( f.Desc, 8 )) + @"
        " + tn + " " + f.Name.ToFirstLower() );
                    sb.Append( (GetDefaultValueByType( f ) != "") ? (" = " + GetDefaultValueByType( f )) : "" );
                    sb.Append( " ;" );
                }
                dc.Add( cmdId, pn + @"PkgTypes::" + c.Name );
                //if( c.Fields.Count > 0 )

                //{
                // 生成静态直写函数
                sb.Append( @"
        const static short commandType; 
" );
                // 生成 ByteBuffer 接口函数
                sb.Append( @"
        // interface for ByteBuffer
        void WriteTo( xxlib::ByteBuffer& bb ) const;
        bool ReadFrom( xxlib::ByteBuffer& bb );" );
                //}
                sb.Append( @"
    };" );
            }

            sb.Append( @"
}
#endif
" );


            try
            {
                var outFile = Path.Combine(outDir, ns + ".h");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }

            #endregion

            #region 生成PkgTypes.cpp
            sb.Clear();
            sb.Append( @"
#include """ + ns + @".h""
using namespace xxlib;
namespace " + pn + @"PkgTypes
{" );
            foreach( var dcItem in dc )
            {
                sb.Append( @"
        const short " + dcItem.Value + @"::commandType = " + dcItem.Key + ";" );
            }
            // cmdId = 0;
            foreach( var c in t.Classes )
            {
                cmdId++;
                //if( c.Fields.Count == 0 ) continue;
                // 生成 ByteBuffer 接口函数的定义
                // todo: namespace support
                //short cmdId = " + cmdId + @";
                sb.Append( @"
        void " + c.Name + @"::WriteTo( ByteBuffer& bb ) const
        {" );
                if( c.Fields.Count != 0 )
                {
                    sb.Append( @"
            bb.WriteMulti( " );
                    for( int i = 0; i < c.Fields.Count; ++i )
                    {
                        if( i != 0 )
                            sb.Append( ", " );
                        var f = c.Fields[ i ];
                        sb.Append( f.Name );
                    }
                    sb.Append( @" );" );
                }
                sb.Append( @" 
        }

        bool " + c.Name + @"::ReadFrom( ByteBuffer& bb )
        {" );
                if( c.Fields.Count != 0 )
                {
                    for( int i = 0; i < c.Fields.Count; ++i )
                    {
                        sb.Append( @"
            if( !bb.Read( " );
                        var f = c.Fields[ i ];

                        sb.Append( f.Name );
                        if( f.Declare.MaxLen > 0 )
                        {
                            sb.Append( @", " + f.Declare.MinLen + ", " + f.Declare.MaxLen );
                        }
                        sb.Append( @" ) ) return false;" );

                    }

                }
                sb.Append( @"
            return true;" );
                sb.Append( @"
        }" );
            }
            sb.Append( @"
}
" );
            try
            {
                var outFile = Path.Combine(outDir, ns + ".cpp");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            #endregion

            #region 生成 Rotate.txt
            sb.Clear();
            sb.Append( @"
short cmdID=-1; 
bb.Read(cmdID);
switch( cmdID )
{" );
            foreach( var dcItem in dc )
            {
                sb.Append( @"
    case " + dcItem.Key + @" :
        {
            " + dcItem.Value + @" myItem;
            auto v= bb.Read( myItem );
            if(!v)
            {
                cout<<""ByteBuffer error""<<endl;
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
                var outFile = Path.Combine(outDir, ns + "RotateCpp.txt");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            #endregion


            #region 生成 EnumToString.h
            sb.Clear();
            sb.Append( @"
#include ""SCPkgTypes.h""

class EnumToString
{
public:" );
            foreach( var e in t.Enums )
            {
                sb.Append( @"
    static char const* const Get( " + pn + @"PkgTypes::" + e.Name + @" e );
    static char const* const GetShow( " + pn + @"PkgTypes::" + e.Name + @" e );" );
            }
            sb.Append( @"
};" );
            try
            {
                var outFile = Path.Combine(outDir, ns + "EnumToString.h");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            #endregion


            #region 生成 EnumToString.cpp
            sb.Clear();
            sb.Append( @"
#include ""EnumToString.h""" );

            foreach( var e in t.Enums )
            {
                sb.Append( @"
char const* const EnumToString::Get( " + pn + @"PkgTypes::" + e.Name + @" e )
{
    switch(e)
    {" );
                foreach( var ee in e.Fields )
                {
                    sb.Append( @"
        case " + pn + @"PkgTypes::" + e.Name + "::" + ee.Name + @": 
            return """ + e.Name + "::" + ee.Name + " " + ee.Desc + @""";" );

                }
                sb.Append( @"
    }
}" );

                sb.Append( @"
char const* const EnumToString::GetShow( " + pn + @"PkgTypes::" + e.Name + @" e )
{
    switch(e)
    {" );
                foreach( var ee in e.Fields )
                {
                    sb.Append( @"
        case " + pn + @"PkgTypes::" + e.Name + "::" + ee.Name + @": 
            return """ + ee.Desc + @""";" );

                }
                sb.Append( @"
    }
}" );
            }

            try
            {
                var outFile = Path.Combine(outDir, ns + "EnumToString.cpp");
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
            valueString = valueString.Replace( "string", "xxlib::String" );
            valueString = valueString.Replace( "String", "xxlib::String" );
            valueString = valueString.Replace( "List", "xxlib::List" );
            valueString = valueString.Replace( "Dict", "xxlib::Dict");
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
                        return (f.Declare.Namespace != "" ? f.Declare.Namespace : _pn) + "." + f.Declare.Name + "." + ((Enum)f.Declare.Class).Fields.First().Name;
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
            string rtv = "";
            if( d.DataType == DataTypes.Array )
            {
                rtv = "xxlib::ByteBuffer";
            }
            else if( d.DataType == DataTypes.BuiltIn )
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
                    case "String": rtv = "xxlib::String"; break;
                    case "DateTime": rtv = "xxlib::SimpleDate"; break;
                    // case "List<int>": rtv = "xxlib::List<int>"; break;
                    default:
                        rtv = (d.Namespace != "" ? (d.Namespace + "::") : "") + d.Name;
                        break;
                }

            }
            else if( d.DataType == DataTypes.Custom )
            {
                rtv = (d.Namespace != "" ? d.Namespace : ("::" + _pn + "PkgTypes")) + "::" + d.Name;
            }
            else
            {
                rtv = ChangeTypes( d.Name ) + "<";
                for( int i = 0; i < d.Childs.Count; ++i )
                {
                    if( i > 0 ) rtv += ",";
                    rtv += GetTypeKeyword( d.Childs[ i ] );
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
                case "Byte": return "uint8";
                case "SByte": return "int8";
                case "UInt16": return "uint16";
                case "Int16": return "int16";
                case "UInt32": return "uint";
                case "Int32": return "int";
                case "UInt64": return "uint64";
                case "Int64": return "int64";
            }
            throw new Exception( "unsupported data type" );
        }
    }
}
