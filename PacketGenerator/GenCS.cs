using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PacketGenerator
{
    public static class GenCS
    {
        public static string Gen( Template t, string outDir, string pn )
        {
            #region 生成 PkgTypes.cs
            outDir = Path.Combine(outDir, "CS");
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
            sb.Append( @"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;" );



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
    public enum  " + e.Name + @" : " + GetEnumTypeKeyword( e ) + @"
    {" );
                foreach( var ef in e.Fields )
                {
                    if( !string.IsNullOrWhiteSpace( ef.Desc ) )
                    {
                        sb.Append( @"
        /// <summary>
        /// " + ef.Desc + @"
        /// </summary> " );
                    }
                    sb.Append( @"
        " + ef.Name + " = " + ef.Value + ", " );

                }
                sb.Append( @"
    };" );
            }

            sb.Append( @"
}
" );
            Dictionary<int, string> dc = new Dictionary<int, string>();
            Dictionary<int, Class> dcDesc = new Dictionary<int, Class>();
            int cmdId = 0;
            // 生成类声明
            sb.Append( @"
// struct declares
namespace " + pn + @"PkgTypes
{" );

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
    public class " + c.Name + @" : IBBWriter, IBBReader 
    {" );
                // 生成类成员
                foreach( var f in c.Fields )
                {
                    var tn = GetTypeKeyword( f.Declare );
                    sb.Append( (f.Desc == "" ? "" : GetComment( f.Desc, 8 )) + @"
        " + "public " + tn + " " + f.Name.ToFirstLower() );
                    if( f.Declare.DataType == DataTypes.Generic || (f.Declare.DataType == DataTypes.Custom && f.Declare.Class != null && !f.Declare.Class.IsEnum) )
                    {
                        sb.Append( @" = new " + tn + "()" );
                    }
                    else if( f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "DateTime" )
                    {
                        sb.Append( @" = new " + tn + "(1991,1,1,0,0,0)" );
                    }
                    else if( f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "String" )
                    {
                        sb.Append( @" = """"" );
                    }
                    else if(f.Declare.DataType == DataTypes.Array)
                    {
                        sb.Append( @" = new byte[0]" );
                    }
                    sb.Append( ";" );
                }
                dc.Add( cmdId, pn + @"PkgTypes." + c.Name );
                dcDesc.Add( cmdId, c );
                // dcDesc.Add( cmdId, pn + @"PkgTypes." + c.Name+@"( "+c.Desc+@" )" );
                //if( c.Fields.Count > 0 )

                //{
                // 生成静态直写函数
                sb.Append( @"
        public const short commandType = " + cmdId + @"; 
" );


                //if( c.Fields.Count == 0 ) continue;
                // 生成 ByteBuffer 接口函数的定义
                // todo: namespace support
                //short cmdId = " + cmdId + @";
                sb.Append( @"
        public void WriteToBuffer( ByteBuffer bb )
        {" );
                if( c.Fields.Count != 0 )
                {

                    for( int i = 0; i < c.Fields.Count; ++i )
                    {
                        sb.Append( @"
            bb.Write( " );
                        var f = c.Fields[ i ];
                        if( f.Declare.Class != null && f.Declare.Class.IsEnum )
                        {
                            sb.Append( @"(int)" );
                        }
                        sb.Append( f.Name );
                        sb.Append( @" );" );
                    }

                }
                sb.Append( @" 
        }

        public void ReaderFromBuffer( ByteBuffer bb )
        {" );

                for( int i = 0; i < c.Fields.Count; ++i )
                {
                    sb.Append( @"
             " );
                    var f = c.Fields[ i ];
                    if( !(f.Declare.DataType == DataTypes.Generic) && !(f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "String") )
                    {
                        if( (f.Declare.DataType != DataTypes.Array)&&(f.Declare.MaxLen != 0) )
                        {
                            throw new ArgumentOutOfRangeException( "不是字符串和容器类型不能填写大小" ); // throw  
                        }
                    }
                    sb.Append( f.Name );
                    if( f.Declare.Class != null && f.Declare.Class.IsEnum )
                    {
                        sb.Append( @" = (" + GetTypeKeyword( f.Declare ) + @") bb." );
                    }
                    else
                    {
                        sb.Append( " = bb." );
                    }

                    sb.Append( GetTypeBuffer( f.Declare ) );
                    if( f.Declare.Childs.Count > 0 && f.Declare.Childs[ 0 ].DataType == DataTypes.Custom )
                    {
                        sb.Append( @"<" + GetBufferString( f.Declare.Childs[ 0 ] ) + @">" );
                    }
                    else if( f.Declare.DataType == DataTypes.Custom && f.Declare.Class != null && !f.Declare.Class.IsEnum )
                    {
                        sb.Append( @"<" + GetBufferString( f.Declare ) + @">" );
                    }
                    if( f.Declare.DataType==DataTypes.Array||f.Declare.DataType == DataTypes.Generic || (f.Declare.DataType == DataTypes.BuiltIn && f.Declare.Name == "String") )
                    {
                        sb.Append( @"( " + f.Declare.MinLen + @"," + f.Declare.MaxLen + @" );" );
                    }
                    else
                    {
                        sb.Append( @"();" );
                    }
                }
                sb.Append( @"
        }
" );
                sb.Append( @"
    };" );
            }

            sb.Append( @"
}" );


            try
            {
                var outFile = Path.Combine(outDir, ns + ".cs");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            #endregion

            #region 生成 Rotate.cs
            sb.Clear();
            sb.Append( @"
var sb = new StringBuilder();
short pkgId = bb.ReadShort();
switch( pkgId )
{" );
            foreach( var dcItem in dcDesc )
            {
                sb.Append( @"
    case " + AddNameSpaceString( pn, dcItem.Value.Name ) + @".commandType :
        {
            " + AddNameSpaceString( pn, dcItem.Value.Name ) + @" myItem = null;
            try
            {
                myItem =  bb.Read<" + AddNameSpaceString( pn, dcItem.Value.Name ) + @">();
            }
            catch
            {
                Console.Write( ""ByteBuff Error"" );
            }
            // code here
            string endString = JsonConvert.SerializeObject(myItem);" );
                if( pn == "CS" )
                {
                    sb.Append( @"
            sb.Append(""客服端发送类型为:"");" );
                }
                else if( pn == "SC" )
                {
                    sb.Append( @"
            sb.Append(""服务器返回类型为:"");" );
                }

                sb.Append( @"
            sb.Append(""" + dcItem.Value.Name + @"\n"");" );
                if( pn == "CS" )
                {
                    sb.Append( @"
            sb.Append(""客服端发送数据为:"");" );
                }
                else if( pn == "SC" )
                {
                    sb.Append( @"
            sb.Append(""服务器返回数据为:"");" );
                }
                sb.Append( @"
            sb.Append(endString);" );
                sb.Append( @"
            sb.Append(""(  " + dcItem.Value.Desc + @"  )"");" );
                sb.Append( @"
            sb.Append(""\n"");
            break;
         
        }" );
            }

            sb.Append( @"
    default:
            sb.Append(""no commandType""+ pkgId);
        break;
}
 bb.offset = 0;
 return sb.ToString();
" );
            try
            {
                var outFile = Path.Combine(outDir, ns + "Rotate.txt");
                sb.WriteToFile(outFile);
            }
            catch( Exception ex )
            {
                return ex.Message;
            }

            #endregion


            if( pn != "SC" ) return "";
            #region 生成 WriteCommandType
            sb.Clear();
            sb.Append( @"
static class ByteBufferExt
{" );
            foreach( var c in t.Classes )
            {
                sb.Append( @"
    public static void WriteCommand(this ByteBuffer bb," + pn + @"PkgTypes." + c.Name + @" v)
    {
        bb.Write( " + pn + @"PkgTypes." + c.Name + @".commandType );
        bb.Write( v );
    } " );

            }
            sb.Append( @"
}" );
            try
            {
                var outFile = Path.Combine(outDir, ns + "WriteCommandType.cs");
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
            valueString = valueString.Replace( "Dict", "Dictionary" );
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
            string rtv = " ";
            if( d.DataType == DataTypes.Array )
            {
                rtv = GetTypeKeyword( d.Childs[ 0 ] ) + "[]";
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
                    case "String": rtv = "string"; break;
                    // case "List<int>": rtv = "xxx::List<int>"; break;
                    default:
                        rtv = (d.Namespace != "" ? (d.Namespace + ".") : "") + d.Name;
                        break;
                }

            }

            else if( d.DataType == DataTypes.Custom )
            {
                rtv = (d.Namespace != "" ? d.Namespace : (_pn + "PkgTypes")) + "." + d.Name;
            }
            else
            {
                rtv = ChangeTypes(d.Name) + "<";
                for( int i = 0; i < d.Childs.Count; ++i )
                {
                    if( i > 0 ) rtv += ", ";
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


        public static string GetTypeBuffer( Declare d )
        {
            string rtv = " ";
            if( d.DataType == DataTypes.BuiltIn )
            {
                switch( d.Name )
                {

                    case "Byte": rtv = "ReadByte"; break;
                    case "Int16": rtv = "ReadShort"; break;
                    case "Int32": rtv = "ReadInt"; break;
                    case "Int64": rtv = "ReadLong"; break;
                    case "Char": rtv = "ReadChar"; break;
                    case "Double": rtv = "ReadDouble"; break;
                    case "Single": rtv = "ReadFloat"; break;
                    case "Boolean": rtv = "ReadBoolean"; break;
                    case "DateTime": rtv = "ReadDate"; break;
                    case "String": rtv = "ReadString"; break;
                    default:
                        rtv = (d.Namespace != "" ? (d.Namespace + ".") : "") + d.Name;
                        break;
                }
            }
            else if( d.DataType == DataTypes.Custom )
            {
                if( d.Class != null && d.Class.IsEnum )
                {
                    rtv = "ReadInt";
                    return rtv;
                }
                else
                {
                    rtv = "Read";
                    return rtv;
                }
            }
            else if( d.DataType == DataTypes.Generic )
            {
                if (d.Name == "List")
                {
                    switch (GetTypeBuffer(d.Childs[0]))
                    {
                        case "ReadByte": rtv = "ReadListByte"; break;
                        case "ReadShort": rtv = "ReadListShort"; break;
                        case "ReadInt": rtv = "ReadListInt"; break;
                        case "ReadLong": rtv = "ReadListLong"; break;
                        case "ReadChar": rtv = "ReadListChar"; break;
                        case "ReadDouble": rtv = "ReadListDouble"; break;
                        case "ReadFloat": rtv = "ReadListFloat"; break;
                        case "ReadBoolean": rtv = "ReadListBool"; break;
                        case "ReadDate": rtv = "ReadListDate"; break;
                        case "ReadString": rtv = "ReadListString"; break;
                        case "Read": rtv = "ReadListObject"; break;
                    }
                }
                else
                {
                    rtv = "ReadDict";
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
                        rtv = (d.Namespace != "" ? (d.Namespace + ".") : "") + d.Name;
                        break;
                }
            }

            else if( d.DataType == DataTypes.Custom )
            {
                rtv = (d.Namespace != "" ? d.Namespace : ("" + _pn + "PkgTypes")) + "." + d.Name;
            }

            return rtv;
        }

        public static string AddNameSpaceString( string namespaceName, string tt )
        {
            return namespaceName + "PkgTypes." + tt;
        }
    }
}
