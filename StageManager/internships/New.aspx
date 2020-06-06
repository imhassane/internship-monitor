<%@ Page Title="New internship" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="New.aspx.vb" Inherits="StageManager._New2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="my-5">
        <label class="block">Internship Name</label>
        <asp:TextBox runat="server" ID="NameTextBox" CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded" />
        <asp:Label runat="server" ID="NameError" Text="The internship's name is required" CssClass="block font-medium text-red-400" />
    </div>

    <div class="my-5">
        <label class="block">Company's Name</label>
        <asp:TextBox runat="server" ID="TextBox1" CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded" />
        <asp:Label runat="server" ID="CompanyError" Text="The company's name is required" CssClass="block font-medium text-red-400" />
    </div>

    <div class="my-5">
        <asp:Button runat="server" ID="Submit" Text="Add the internship" CssClass="text-white bg-teal-500 py-4 px-10 rounded-lg shadow font-semibold text-2xl" />
    </div>

</asp:Content>
