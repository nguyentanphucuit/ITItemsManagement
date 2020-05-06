<%@ Page Language="C#" MasterPageFile="~/mainphu.master" AutoEventWireup="true" CodeFile="GioHang.aspx.cs" Inherits="GioHang" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<asp:Label ID="lblThongBao" runat="server" Text=""></asp:Label><br />
<asp:GridView ID="gridgiohang" runat="server" AutoGenerateColumns="False" DataKeyNames="IDgiohang" OnRowDataBound="gridgiohang_RowDataBound" Width="530px">
    
        <Columns>
            <asp:TemplateField HeaderText="X&#243;a">
                <ItemTemplate>
                    <asp:CheckBox ID="checkboxDelete" runat="server" />
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle BackColor="White" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sản Phẩm">
                <ItemTemplate>
                <%# Eval("TenSanPham") %>
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    <asp:TextBox ID="textQuantity" runat="server" Text='<%# Eval("SoLuong") %>' Width="93px"></asp:TextBox>
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đơn Gi&#225;">
                <ItemTemplate>
                <%# Eval("GiaSanPham")%>
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Right" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Th&#224;nh Tiền">
                <ItemTemplate>
                <%# Eval("ThanhTien","{0:###,###,###} VND")%>
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Right" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Tổng tiền:" Font-Bold="True" ForeColor="#330000"></asp:Label>
    <asp:Label ID="lblTotal" runat="server" ForeColor="#330000"></asp:Label><br />
    <br />
    <asp:ImageButton ID="ImageButtontieptucmuahang" runat="server" ImageUrl="~/images/button_tiepmua.jpg" OnClick="ImageButtontieptucmuahang_Click" />
    <asp:ImageButton ID="ImageButtoncapnhatthaydoi" runat="server" ImageUrl="~/images/button_capnhat.jpg" OnClick="ImageButtoncapnhatthaydoi_Click" />
    <asp:ImageButton ID="ImageButtonXacnhanthanhtoan" runat="server" ImageUrl="~/images/button_thanhtoan.jpg" OnClick="ImageButtonXacnhanthanhtoan_Click" />
</asp:Content>

