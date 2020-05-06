<%@ Page Language="C#" MasterPageFile="~/Admin/admin.master" AutoEventWireup="true" CodeFile="DangNhapAdmin.aspx.cs" Inherits="Admin_DangNhapAdmin1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 820px">
        <tr>
            <td colspan="2" style="font-size: 20pt; color: #990000; font-style: normal; text-align: center">
                ĐĂNG NHẬP QUYỀN QUẢN TRỊ WEBSITE</td>
        </tr>
        <tr>
            <td style="width: 200px; height: 26px">
                Tên đăng nhập</td>
            <td style="width: 520px; height: 26px">
                <asp:TextBox ID="textUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textUsername"
                    ErrorMessage="Tên đăng nhập không được rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 200px">
                Mật khẩu</td>
            <td style="width: 520px">
                <asp:TextBox ID="textMatKhau" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textMatKhau"
                    ErrorMessage="Mật khẩu không được rỗng"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 200px">
            </td>
            <td style="width: 520px">
                <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng Nhập" />
                <asp:Label ID="labelMessage" runat="server"></asp:Label></td>
        </tr>
    </table>
</asp:Content>

