using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IBufferReader
{
    void ReaderFromBuffer( ByteBuffer tb );
}

public interface IBufferWrite
{
    void WriteToBuffer( ByteBuffer tb );
}

public class ByteBuffer
{
    public byte[] buf;

    public int offset ;

    public int dataLen;
    public ByteBuffer( int capacity )
    {
        Assign( new byte[ capacity ], 0 );
    }

    public ByteBuffer() : this( 1024 ) { }


    public ByteBuffer( byte[] _buf, int _dataLen )
    {
        Assign( _buf, _dataLen );
    }

    public ByteBuffer( byte[] _buf )
    {
        Assign( _buf );
    }

    public void Assign( byte[] _buf, int _dataLen )
    {

        offset = 0;
        buf = _buf;
        dataLen = _dataLen;
    }

    public void Assign( byte[] _buf )
    {
        Assign( _buf, 0 );
    }
    public void Clear()
    {
        dataLen = offset = 0;
    }

    public bool Empty()
    {
        return dataLen == 0;
    }

    public bool Full()
    {
        return dataLen == offset;
    }

    public void Collapse()
    {
        Array.Resize(ref buf, dataLen );
    }
    public void Reserve( int capacity )
    {
        if( capacity <= buf.Length )
        {
            return;
        }
        byte[] newbuf = new byte[ capacity * 2];
        Array.Copy( buf, 0, newbuf, 0, dataLen );
        buf = newbuf;
    }

    public byte IndexAt( int idx )
    {

        return buf[ idx ];
    }

    public void Write( byte v )
    {
        Reserve( dataLen + 1 );
        buf[ dataLen ] = v;
        dataLen++;
    }

    public void Write( List<byte> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }

    public void Write( short v )
    {
        Reserve( dataLen + 2 );
        buf[ dataLen ] = (byte)(v & 0xff);
        buf[ dataLen + 1 ] = (byte)((v & 0xff00) >> 8);
        dataLen += 2;
    }
    public void Write( List<short> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( int v )
    {
        Reserve( dataLen + 4 );
        buf[ dataLen ] = (byte)(v & 0xff);
        buf[ dataLen + 1 ] = (byte)((v & 0xff00) >> 8);
        buf[ dataLen + 2 ] = (byte)((v & 0xff0000) >> 16);
        buf[ dataLen + 3 ] = (byte)((v & 0xff000000) >> 24);
        dataLen += 4;
    }
    public void Write( List<int> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( long v )
    {
        Reserve( dataLen + 8 );
        buf[ dataLen + 0 ] = (byte)v;
        buf[ dataLen + 1 ] = (byte)(v >> 8);
        buf[ dataLen + 2 ] = (byte)(v >> 16);
        buf[ dataLen + 3 ] = (byte)(v >> 24);
        buf[ dataLen + 4 ] = (byte)(v >> 32);
        buf[ dataLen + 5 ] = (byte)(v >> 40);
        buf[ dataLen + 6 ] = (byte)(v >> 48);
        buf[ dataLen + 7 ] = (byte)(v >> 56);
        dataLen += 8;


    }
    public void Write( List<long> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( char v )
    {
        Reserve( dataLen + 2 );
        buf[ dataLen ] = (byte)(v);
        buf[ dataLen + 1 ] = (byte)(v >> 8);
        dataLen += 2;
    }
    public void Write( List<char> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( float v )
    {
        var _buf = BitConverter.GetBytes(v);
        Reserve( dataLen + 4 );
        Array.Copy( _buf, 0, buf, dataLen, 4 );
        dataLen += 4;
    }
    public void Write( List<float> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( double v )
    {
        var _buf = BitConverter.GetBytes(v);
        Reserve( dataLen + 8 );
        Array.Copy( _buf, 0, buf, dataLen, 8 );
        dataLen += 8;
    }
    public void Write( List<double> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( bool v )
    {
        Reserve( dataLen + 1 );
        buf[ dataLen ] = (v ? (byte)1 : (byte)0);
        dataLen++;
    }
    public void Write( List<bool> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( string v )
    {
        byte[] myByte = System.Text.Encoding.UTF8.GetBytes ( v );
        int vLength = myByte.Length;
        WriteLength( vLength );
        Reserve( dataLen + vLength );
        Array.Copy( myByte, 0, buf, dataLen, vLength );
        dataLen += vLength;
    }
    public void Write( List<string> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }
    public void Write( DateTime v )
    {
        Reserve( dataLen + 8 );
        short year = (short)v.Year;
        buf[ dataLen + 0 ] = (byte)year;
        buf[ dataLen + 1 ] = (byte)(year >> 8);
        buf[ dataLen + 2 ] = (byte)v.Month;
        buf[ dataLen + 3 ] = (byte)v.Day;
        buf[ dataLen + 4 ] = (byte)v.Hour;
        buf[ dataLen + 5 ] = (byte)v.Minute;
        buf[ dataLen + 6 ] = (byte)v.Second;
        dataLen += 7;

    }
    public void Write( List<DateTime> v )
    {
        if( v == null ) throw new Exception( "list error" );
        WriteLength( v.Count );
        foreach( var o in v )
        {
            Write( o );
        }
    }

    public void Write<T>( T v ) where T : IBufferWrite
    {
        v.WriteToBuffer( this );
    }


    public void Write<T>( List<T> list ) where T : IBufferWrite
    {
        if( list == null ) throw new Exception( "list error" );
        WriteLength( list.Count );
        foreach( var o in list )
        {
            Write( o );
        }
    }







    /*
    //   read template
    */
    public void Read<T>( List<T> list,int minLen=0,int maxLen=0) where T : IBufferReader, new()
    {
        int len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        list.Clear();
        for( int i = 0; i < len; i++ )
        {
            list.Add( Read<T>() );
        }
    }

    public T Read<T>() where T : IBufferReader, new()
    {
        var rtv = new T();
        rtv.ReaderFromBuffer( this );
        return rtv;
    }

    public void Read<T>( T v ) where T : IBufferReader
    {
        v.ReaderFromBuffer( this );
    }

    public List<T> ReadListObject<T>( int minLen = 0, int maxLen = 0 ) where T : IBufferReader, new()
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        List<T> rtv = new List<T>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( Read<T>() );
        }
        return rtv;
    }

    /*
    //   read byte
    */
    public void Read( out byte v )
    {
        v = buf[ offset++ ];
    }
    public void Read( List<byte> v , int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadByte() );
        }
    }
    public List<byte> ReadListByte( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        List<byte> rtv = new List<byte>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadByte() );
        }
        return rtv;
    }
    public byte ReadByte()
    {
        return buf[ offset++ ];
    }


    /*
    //   read short
    */

    public void Read( out short v )
    {
        v = (short)((0xff & buf[ offset ]) | (0xff00 & (buf[ offset + 1 ] << 8)));
        offset += 2;
    }
    public void Read( List<short> v, int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadShort() );
        }
    }
    public List<short> ReadListShort( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<short>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadShort() );
        }
        return rtv;
    }
    public short ReadShort()
    {
        var n =(short)((0xff & buf[ offset ]) | (0xff00 & (buf[ offset+1 ] << 8)));
        offset += 2;
        return n;
    }


    /*
    //   read int
    */

    public void Read( out int v )
    {
        v = (buf[ offset ] | (buf[ offset + 1 ] << 8) | (buf[ offset + 2 ] << 16) | (buf[ offset + 3 ] << 24));
        offset += 4;
    }
    public void Read( List<int> v, int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadInt() );
        }
    }
    public List<int> ReadListInt( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<int>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadInt() );
        }
        return rtv;
    }
    public int ReadInt()
    {
        int n = ( buf[offset] |  (buf[offset+1] << 8) | (buf[offset+2] << 16) | (buf[offset+3] << 24));
        offset += 4;
        return n;
    }


    /*
    //   read long
    */

    public void Read( out long v )
    {
        v = ((long)buf[ offset ]) | (((long)buf[ offset + 1 ] << 8)) | (((long)buf[ offset + 2 ] << 16)) | (((long)buf[ offset + 3 ] << 24))
         | (((long)buf[ offset + 4 ] << 32)) | (((long)buf[ offset + 5 ] << 40)) | (((long)buf[ offset + 6 ] << 48)) | (((long)buf[ offset + 7 ] << 56));
        offset += 8;
    }
    public void Read( List<long> v , int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadLong() );
        }
    }
    public List<long> ReadListLong( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<long>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadLong() );
        }
        return rtv;
    }
    public long ReadLong()
    {
        long n =  ( (long)buf[offset ]) | ( ((long)buf[offset+1 ] << 8)) | (((long)buf[ offset +2 ] << 16)) | ( ((long)buf[ offset+ 3 ] << 24))
             | ( ((long)buf[offset+ 4 ] << 32)) | (((long)buf[offset+ 5 ] << 40)) | (((long)buf[offset+ 6 ] << 48)) | ( ((long)buf[offset+ 7 ] << 56));
        offset += 8;
        return n;
    }



    /*
    //   read char
    */
    public void Read( out char v )
    {
        v = (char)((buf[ offset ]) | ((buf[ offset + 1 ] << 8)));
        offset += 2;
    }
    public void Read( List<char> v , int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadChar() );
        }
    }
    public List<char> ReadListChar( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<char>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadChar() );
        }
        return rtv;
    }
    public char ReadChar()
    {
        var n = (char)(( buf[offset]) | ( (buf[ offset+ 1 ] << 8)));
        offset += 2;
        return n;

    }


    /*
    //   read float
    */

    public void Read( out float v )
    {
        v = BitConverter.ToSingle( buf, offset );
        offset += 4;
    }
    public void Read( List<float> v, int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadFloat() );
        }
    }
    public List<float> ReadListFloat( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<float>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadFloat() );
        }
        return rtv;
    }
    public float ReadFloat()
    {
        var n = BitConverter.ToSingle(buf,offset);
        offset += 4;
        return n;
    }



    /*
    //   read double
    */

    public void Read( out double v )
    {
        v = BitConverter.ToDouble( buf, offset );
        offset += 8;
    }

    public void Read( List<double> v , int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadDouble() );
        }
    }
    public List<double> ReadListDouble( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<double>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadDouble() );
        }
        return rtv;
    }
    public double ReadDouble()
    {
        var n = BitConverter.ToDouble(buf,offset);
        offset += 8;
        return n;
    }


    /*
    //   read bool
    */


    public void Read( out bool v )
    {
        v = buf[ offset ] == 1;
        offset += 1;
    }

    public void Read( List<bool> v , int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadBoolean() );
        }
    }
    public List<bool> ReadListBool( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<bool>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadBoolean() );
        }
        return rtv;
    }
    public bool ReadBoolean()
    {
        var n = BitConverter.ToBoolean(buf,offset);
        offset += 1;
        return n;
    }


    /*
    //   read string
    */

    public void Read( out string v, int minLen = 0, int maxLen = 0 )
    {
        int len = ReadLength();
        if ( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v = System.Text.Encoding.UTF8.GetString( buf, offset, len );
        offset += len;
    }

    public void Read( List<string> v, int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadString() );
        }
    }
    public List<string> ReadListString( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<string>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadString() );
        }
        return rtv;
    }
    public string ReadString( int minLen = 0, int maxLen = 0 )
    {
        int len =  ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var n = System.Text.Encoding.UTF8.GetString(buf,offset,len);
        offset += len;
        return n;
    }




    /*
    //   read datetime
    */

    public void Read( out DateTime v )
    {
        if( offset + 7 > dataLen )
        {
            throw new Exception( "out of range" );
        }
        short years = ReadShort();
        int mouths = (int)buf[offset];
        int days = (int)buf[offset+1];
        int hours = (int)buf[offset+2];
        int minutes = (int)buf[offset+3];
        int seconds = (int)buf[offset+4];
        v = new DateTime( years, mouths, days, hours, minutes, seconds );
        offset += 5;
    }
    public void Read( List<DateTime> v, int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        v.Clear();
        for( int i = 0; i < len; i++ )
        {
            v.Add( ReadDate() );
        }
    }
    public List<DateTime> ReadListDate( int minLen = 0, int maxLen = 0 )
    {
        var len = ReadLength();
        if( len < minLen || (maxLen > 0 && len > maxLen) ) throw new Exception( " length too long" );
        var rtv = new List<DateTime>(len);
        for( int i = 0; i < len; i++ )
        {
            rtv.Add( ReadDate() );
        }
        return rtv;
    }
    public DateTime ReadDate()
    {
        short years = ReadShort();
        int mouths = (int)buf[offset];
        int days = (int)buf[offset+1];
        int hours = (int)buf[offset+2];
        int minutes = (int)buf[offset+3];
        int seconds = (int)buf[offset+4];
        offset += 5;
        return new DateTime( years, mouths, days, hours, minutes, seconds );
    }

    public int ReadLength()
    {
        if( offset >= dataLen ) throw new Exception();
        int idx5 = offset + 5;
        int lshift = 0;
        int v = 0;
        do
        {
            int b7 =  buf[ offset++ ] ;
            if( b7 > 0x7F )
            {
                if( offset == idx5 ) throw new Exception();
                if( offset >= dataLen ) throw new Exception();
                v |= (b7 & 0x7F) << lshift;
                lshift += 7;
                continue;
            }
            else
            {
                if( offset == idx5 && b7 > 15 ) throw new Exception();
                else v |= (b7 << lshift);
            }
            break;
        } while( true );
        return v;
    }

    public void WriteLength( int v )
    {
        do
        {
            byte b7 = (byte)v;
            v >>= 7;
            if( v > 0 )
            {
                buf[ dataLen++ ] = (byte)(b7 | 0x80);
                continue;
            }
            buf[ dataLen++ ] = b7;
            break;
        } while( true );
    }



}

