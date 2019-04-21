
package com.cdrdj.cspkgtypes;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import com.cdrdj.is.ByteBuffer;
import com.cdrdj.is.IBBReader;
import com.cdrdj.is.IBBWriter;

// 查询订单明细
public class SC_Order_GetDetails_Success implements IBBWriter, IBBReader
{
        /*
         * 订单编号
        */
    public String orderID ="";
        /*
         * 公司名称
        */
    public String companyName ="";
        /*
         * 公司所属行业
        */
    public String companyType ="";
        /*
         * 纳税资质
        */
    public String taxQualification ="";
        /*
         * 公司地址
        */
    public String companyAdress ="";
        /*
         * 公司联系人
        */
    public String contact ="";
        /*
         * 公司电话
        */
    public String customerPhone ="";
        /*
         * 会计姓名
        */
    public String accountantName ="";
        /*
         * 会计电话
        */
    public String accountantPhone ="";
        /*
         * 会计收件地址
        */
    public String accountantAdress ="";
        /*
         * 订单数量
        */
    public int count;
        /*
         * 订单金额
        */
    public double total;
        /*
         * 创建订单时间
        */
    public Date createTime = new Date(1,0,1,0,0,0);
        /*
         * 订单执行时间
        */
    public Date startTime = new Date(1,0,1,0,0,0);
        /*
         * 订单结束时间
        */
    public Date endTime = new Date(1,0,1,0,0,0);
        /*
         * 订单周期
        */
    public int cycle;
        /*
         * 状态码
        */
    public int stateCode;
        /*
         * 订单备注
        */
    public String remark ="";
        /*
         * 用于显示的字符串为某些字段的拼接
        */
    public String idView ="";
        /*
         * 产品列表
        */
    public String product ="";
        /*
         * 快递回执编号
        */
    public String expressNumber ="";
        /*
         * 快递客服电话
        */
    public String expressTel ="";
    public static final short commandType = 36; 

    public void WriteToBB( ByteBuffer bb )
    {
        bb.Write( orderID );
        bb.Write( companyName );
        bb.Write( companyType );
        bb.Write( taxQualification );
        bb.Write( companyAdress );
        bb.Write( contact );
        bb.Write( customerPhone );
        bb.Write( accountantName );
        bb.Write( accountantPhone );
        bb.Write( accountantAdress );
        bb.Write( count );
        bb.Write( total );
        bb.Write( createTime );
        bb.Write( startTime );
        bb.Write( endTime );
        bb.Write( cycle );
        bb.Write( stateCode );
        bb.Write( remark );
        bb.Write( idView );
        bb.Write( product );
        bb.Write( expressNumber );
        bb.Write( expressTel ); 
    }

    public void ReadFromBB( ByteBuffer bb )
    {
        orderID = bb.ReadString( 0,1150 );
        companyName = bb.ReadString( 0,1150 );
        companyType = bb.ReadString( 0,1150 );
        taxQualification = bb.ReadString( 0,1150 );
        companyAdress = bb.ReadString( 0,900 );
        contact = bb.ReadString( 0,90 );
        customerPhone = bb.ReadString( 0,60 );
        accountantName = bb.ReadString( 0,90 );
        accountantPhone = bb.ReadString( 0,60 );
        accountantAdress = bb.ReadString( 0,1150 );
        count = bb.ReadInteger();
        total = bb.ReadDouble();
        createTime = bb.ReadDate();
        startTime = bb.ReadDate();
        endTime = bb.ReadDate();
        cycle = bb.ReadInteger();
        stateCode = bb.ReadInteger();
        remark = bb.ReadString( 0,600 );
        idView = bb.ReadString( 0,1150 );
        product = bb.ReadString( 0,1150 );
        expressNumber = bb.ReadString( 0,1150 );
        expressTel = bb.ReadString( 0,1150 );
    }

};