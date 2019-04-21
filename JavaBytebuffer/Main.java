import java.util.ArrayList;
import java.util.List;

public class Main
{
	// todo: class impl interface  serial
	
	public static void main(String[] args)
	{
//		ByteBuffer bb = new ByteBuffer();
//		bb.WriteLength( 0xff );
//		int len = bb.ReadLength();
//		System.out.println( len );
		
//		ByteBuffer bb = new ByteBuffer();
//		bb.Write( true );
//		bb.Write( false );
//		bb.Write( 0xffffffff );		// int
//		bb.Write( (short)0xffff );
//		bb.Write( (byte)0xff );
//		bb.Write( 0xffffffffffffffffL );
//		bb.Write( 1.234f );
//		bb.Write( 1.2345678d );
//		bb.Write( 'x' );
//		bb.Write( "asdfqxxxxwer" );
//		bb.Write( new java.util.Date() );
//		
//		//bb.Write( true );	// byte[]
//		
//		System.out.println( bb.ReadBoolean() );
//		System.out.println( bb.ReadBoolean() );
//		System.out.println( bb.ReadInt() );
//		System.out.println( bb.ReadShort() );
//		System.out.println( bb.ReadByte() );
//		System.out.println( bb.ReadLong() );
//		System.out.println( bb.ReadFloat() );
//		System.out.println( bb.ReadDouble() );
//		System.out.println( bb.ReadChar() );
//		System.out.println( bb.ReadString() );
//		System.out.println( bb.ReadDate() );
		
		
		Foo f = new Foo();
		f.id = 1;
		f.name = "asdf";
		f.bars = new ArrayList<Bar>();
		f.numbers = new ArrayList<Float>();
		
		f.bar = new Bar();
		f.bar.id = 2;
		f.bar.name = "bar";
		
		f.bars.add( f.bar );
		f.bars.add( f.bar );
		
		f.numbers.add( 123f );
		f.numbers.add( 123f );
		f.numbers.add( 123f );
		
		ByteBuffer bb = new ByteBuffer();
		bb.Write( f );
		
		Foo f2 = bb.ReadClass( Foo.class );
		System.out.println( f2.id );
	}
}

interface IBBWriter
{
	public void WriteToBB( ByteBuffer bb );
}
interface IBBReader
{
	public void ReadFromBB( ByteBuffer bb );
}

class Foo implements IBBWriter, IBBReader
{
	public int id;
	public String name;
	public Bar bar;
	public List<Bar> bars;
	public List<Float> numbers;
	
	@Override
	public void WriteToBB( ByteBuffer bb )
	{
		bb.Write( id );
		bb.Write( name );
		bb.Write( bar );
		bb.WriteListClass( bars );
		bb.WriteListFloat( numbers );
	}

	@Override
	public void ReadFromBB(ByteBuffer bb)
	{
		id = bb.ReadInteger();
		name = bb.ReadString();
		bar = bb.ReadClass( Bar.class );
		bars = bb.ReadListClass( Bar.class );
		numbers = bb.ReadListFloat();
	}
}

class Bar implements IBBWriter, IBBReader
{
	public int id;
	public String name;
	
	@Override
	public void WriteToBB( ByteBuffer bb )
	{
		bb.Write( id );
		bb.Write( name );
	}

	@Override
	public void ReadFromBB(ByteBuffer bb)
	{
		id = bb.ReadInteger();
		name = bb.ReadString();
	}
}

