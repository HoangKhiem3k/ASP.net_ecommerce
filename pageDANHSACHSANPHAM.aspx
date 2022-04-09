<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUSER.master" AutoEventWireup="true" CodeFile="pageDANHSACHSANPHAM.aspx.cs" Inherits="pageDANHSACHSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <%# Eval("TenSach") %><br>

            <a href='pageCHITIETSANPHAM.aspx?IDSP=<%# Eval("MaSach") %>'>
            <img src='IMAGES\<%# Eval("Hinh") %>' width="60%" height="90%" />
              </a> 
            <br>
            Gía: <%# Eval("DonGia") %>
        </ItemTemplate>
</asp:DataList>
</asp:Content>

