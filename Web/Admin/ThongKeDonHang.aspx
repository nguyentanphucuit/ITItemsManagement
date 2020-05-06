<%@ Page Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="ThongKeDonHang.aspx.cs" Inherits="Admin_ThongKeDonHang" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView ID="gridTatCaDonHang" runat="server" AutoGenerateColumns="False" Width="820px">
       <Columns>
<asp:TemplateField HeaderText="ID Giao dịch">
<ItemTemplate>
<a href="ChiTietDonHang.aspx?IDgiaodich=<%# Eval("IDgiaodich")
%>&IDdonhang=<%# Eval("IDdonhang") %>&Email=<%# Eval("Email") %>"><%#
Eval("IDgiaodich") %></a>
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
<asp:TemplateField HeaderText="Họ v&#224; t&#234;n">
<ItemTemplate>
<%# Eval("Hoten") %> <br />
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
<asp:TemplateField HeaderText="Địa chỉ">
<ItemTemplate>
<%# Eval("Diachi") %> <br />
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
<asp:TemplateField HeaderText="Email">
<ItemTemplate>
<%# Eval("Email") %>
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
<asp:TemplateField HeaderText="Số điện thoại">
<ItemTemplate>
<%# Eval("Sodienthoai") %>
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
<asp:TemplateField HeaderText="Ng&#224;y tạo đơn h&#224;ng">
<ItemTemplate>
<%# Eval("Ngaytaodonhang","{0: dd/MM/yyyy}") %>
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
<asp:TemplateField HeaderText="T&#236;nh trạng đơn h&#224;ng">
<ItemTemplate>
<%# Eval("TenTinhtrangdonhang") %>
</ItemTemplate>
    <HeaderStyle BackColor="#E0E0E0" ForeColor="Maroon" />
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
</asp:TemplateField>
</Columns>
    </asp:GridView>
</asp:Content>

