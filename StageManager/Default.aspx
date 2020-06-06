<%@ Page Title="Accueil" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="StageManager._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="text-5xl font-extrabold">Internship Notebook</h1>

    <h1 class="font-semibold text-4xl">Consider me as your college journal</h1>
    <h1 class="font-semibold text-4xl text-teal-500">Write your reports, share your experiences & keep fun memories</h1>

    <p class="my-5 font-semibold">
        Here is a place when you can keep your really hardwork when you were in internship.
        I mean all the brain teasing, the errors, the bugs & the syntax errors. <br />
        Not only that, you can keep your notes here also
    </p>

    <div class="my-10">
        <a href="users/login.aspx" class="hover:text-white hover:no-underline text-3xl rounded-lg shadow-lg px-10 py-5 bg-teal-500 mr-5 text-white">Sign in</a>
        <a href="users/register.aspx" class="text-teal-500 hover:no-underline text-3xl rounded-lg shadow-lg px-10 py-5 bg-white">Join us!</a>
    </div>

</asp:Content>
