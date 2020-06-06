<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="New.aspx.vb" Inherits="StageManager._New" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="my-5">
        <label class="block">Company Name</label>
        <asp:TextBox runat="server" ID="NameTextBox" CssClass=" bg-gray-200 font-semibold py-4 px-8 rounded border-2" />
        <asp:Label runat="server" ID="NameError" Text="The company's name is required" CssClass="block font-medium text-red-400" />
    </div>

    <asp:Button runat="server" ID="Submit" Text="Add the company" CssClass="block my-5 bg-teal-500 py-4 px-5 font-bold" />

</asp:Content>
