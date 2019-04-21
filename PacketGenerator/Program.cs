using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace PacketGenerator
{
    public static class Program
    {

        static void Main( string[] args )
        {
            //ByteBufferTest.Test();

            //var outputDirPath = @"..\Output";
            var outputDirPath = System.IO.Path.Combine(Application.StartupPath, "Output");

            foreach ( var dll in Directory.GetFiles( Application.StartupPath, "PacketTemplate_*.dll" ) )
            {
                var asm = Assembly.LoadFile(dll);
                var template = TemplateScaner.GetTemplate( asm );
                var dllName = new FileInfo(dll).Name;
                dllName = dllName.Substring( 0, dllName.LastIndexOf( '.' ) );

                var rtv1 = GenJava.Gen(template, outputDirPath, dllName.Substring( "PacketTemplate_".Length ) );
                var rtv2 = GenCS.Gen(template, outputDirPath, dllName.Substring( "PacketTemplate_".Length ) );
                var rtv3 = GenCPP.Gen(template, outputDirPath, dllName.Substring( "PacketTemplate_".Length ) );
            }

            System.Diagnostics.Process.Start("explorer.exe", outputDirPath);
        }
    }
}
