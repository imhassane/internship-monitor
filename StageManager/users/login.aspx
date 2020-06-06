<%@ Page Title="Access to your account" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.vb" Inherits="StageManager.login" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <div class="md:w-1/2 m-auto bg-white rounded-lg shadow-lg py-10 px-5 md:px-10">
        <h1 class="font-semibold text-2xl">Access to your account</h1>
        <hr />

        <asp:Label runat="server" ID="ErrorSubmit"
            CssClass="block my-10 py-5 px-5 text-red-500 w-full bg-red-300 border-l-4 border-red-500 font-semibold rounded"
            Text="Sorry! An error occurred :\" Visible="False"
        />

        <div class="my-3">
            <label class="block">Enter your email address</label>
            <asp:TextBox runat="server" ID="EmailTextBox" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
            <asp:Label runat="server" ID="ErrorEmail" Visible="false" CssClass="block text-red-400 text-light" Text="The email address is not valid" />
        </div>
        <div class="my-3">
            <label class="block">Enter your password</label>
            <asp:TextBox runat="server" ID="PasswordTextBox" TextMode="Password" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
            <asp:Label runat="server" ID="ErrorPassword" Visible="false" CssClass="block text-red-400 text-light" Text="The password is not valid" />
        </div>
        <div class="my-3">
            <asp:Button runat="server" ID="SubmitButton" OnClick="SubmitButton_Click" Text="Log in" CssClass="border rounded-lg shadow-lg py-3 px-3" />
        </div>
        <p class="my-5">
            <a href="register.aspx" class="no-underline">Get a new account</a>
        </p>
    </div>

</asp:Content>
