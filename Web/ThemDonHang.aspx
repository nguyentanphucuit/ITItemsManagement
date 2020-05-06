<%@ Page Language="C#" MasterPageFile="~/mainphu.master" AutoEventWireup="true" CodeFile="ThemDonHang.aspx.cs" Inherits="ThemDonHang" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView ID="gridgiohang" runat="server" AutoGenerateColumns="False" DataKeyNames="IdSanPham" OnRowDataBound="gridgiohang_RowDataBound" Width="530px">
        <Columns>            
            <asp:TemplateField HeaderText="T&#234;n Sản Phẩm">
                <ItemTemplate>
                    <asp:Label ID="lblTenSanPham" runat="server" Text='<%# Eval("TenSanPham") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    <asp:Label ID="lblSoLuong" runat="server" Text='<%# Eval("SoLuong") %>'></asp:Label>&nbsp;
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Center" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đơn Gi&#225;">
                <ItemTemplate>
                    <asp:Label ID="lblDonGia" runat="server" Text='<%# Eval("GiaSanPham") %>'></asp:Label>
               
                </ItemTemplate>
                <HeaderStyle BackColor="#E0E0E0" BorderColor="#404040" ForeColor="Maroon" HorizontalAlign="Center"
                    VerticalAlign="Middle" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle ForeColor="#404040" HorizontalAlign="Right" VerticalAlign="Middle" BorderColor="#404040" BorderStyle="Solid" BorderWidth="1px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Th&#224;nh Tiền">
                <ItemTemplate>
                    <asp:Label ID="lblThanhTien" runat="server" Text='<%# Eval("ThanhTien","{0} VND") %>'></asp:Label>
                
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
    <asp:ImageButton ID="ImageButtonTieptucmuahang" runat="server" ImageUrl="~/images/button_tiepmua.jpg" OnClick="ImageButtonTieptucmuahang_Click" />
    <asp:ImageButton ID="ImageButtonTaovaguidonhang" runat="server" ImageUrl="~/images/button_guidonhang.jpg" OnClick="ImageButtonTaovaguidonhang_Click" />
</asp:Content>

