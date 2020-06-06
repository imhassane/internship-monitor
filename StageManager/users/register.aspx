<%@ Page Title="Create a new account" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="register.aspx.vb" Inherits="StageManager.register" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <div class="md:w-1/2 m-auto py-10 px-5 md:px-10">
        <h1 class="font-semibold text-2xl">Create a new account</h1>
        <hr />

        <asp:Label runat="server" ID="ErrorSubmit"
            CssClass="block my-10 py-5 px-5 text-red-500 w-full bg-red-300 border-l-4 border-red-500 font-semibold rounded"
            Text="Sorry! We are unable to add your account for now :\" Visible="False"
        />

        <div class="my-3">
            <label class="block">Enter your email address</label>
            <asp:TextBox runat="server" ID="EmailTextBox" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
            <asp:Label runat="server" ID="ErrorEmail" Visible="false" CssClass="block text-red-400 text-light" Text="The email address is not valid" />
        </div>
        <div class="my-3 flex-1 px-1">
            <label class="block">Enter your password</label>
            <asp:TextBox runat="server" ID="PasswordTextBox" TextMode="Password" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
            <asp:Label runat="server" ID="HelpPassword" CssClass="block my-4 text-teal-500" Text="The password should contains at least 8 characters" />
            <asp:Label runat="server" ID="ErrorPassword" Visible="false" CssClass="block text-red-400 text-light" Text="The password is not valid" />
        </div>
        <div class="my-3 flex-1 px-1">
            <label class="block">Repeat your password</label>
            <asp:TextBox runat="server" ID="RepeatTextBox" TextMode="Password" CssClass="w-full bg-gray-300 font-semibold rounded-md py-3 px-3" />
            <asp:Label runat="server" ID="ErrorRepeat" Visible="false" CssClass="block text-red-400 text-light" Text="The passwords does not correspond" />
        </div>
        <div class="my-3">
            <asp:Button runat="server" ID="SubmitButton"
                Text="Create your account" CssClass="border rounded-lg shadow-lg py-3 px-3"
                OnClick="SubmitButton_Click"
            />
        </div>
        <p class="my-5">
            <a href="login.aspx" class="no-underline">Sign in</a>
        </p>
    </div>

</asp:Content>
