﻿<%@ Page Title="Access to your account" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.vb" Inherits="StageManager.login" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <div class="md:w-1/2 m-auto bg-white rounded-lg shadow-lg py-10 px-5 md:px-10">
        <h1 class="font-semibold text-2xl">Access to your account</h1>
        <hr />
        <div class="my-3">
            <label class="block">Enter your email address</label>
            <asp:TextBox runat="server" ID="EmailBox" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
        </div>
        <div class="my-3">
            <label class="block">Enter your password</label>
            <asp:TextBox runat="server" ID="PasswordBox" TextMode="Password" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
        </div>
        <div class="my-3">
            <asp:Button runat="server" ID="SubmitButton" Text="Log in" CssClass="border rounded-lg shadow-lg py-3 px-3" />
        </div>
        <p class="my-5">
            <a href="register.aspx" class="no-underline">Get a new account</a>
        </p>
    </div>

</asp:Content>