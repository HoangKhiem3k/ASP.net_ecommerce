<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUSER.master" AutoEventWireup="true" CodeFile="pageCHITIETSANPHAM.aspx.cs" Inherits="pageCHITIETSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
           <img src='IMAGES\<%# Eval("Hinh") %>' width="70%" height="220%" />
            <br>
            Tên sách: <%# Eval("TenSach") %>
            <BR>
            Nhà xuất bản: <%# Eval("NhaXB") %>
            <BR>
             <%# Eval("MoTa") %>
            <BR>
            Giá: <%# Eval("DonGia") %>
        </ItemTemplate>
    </asp:Repeater>
    
</asp:Content>

