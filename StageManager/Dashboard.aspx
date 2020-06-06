<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.vb" Inherits="StageManager.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <% If Not Session("NumberInternships") Then %>
       <div>
            <p class="text-center font-semibold text-gray-700 text-2xl">You haven't added any intership yet</p>
            <p class="mt-5 text-center">
                <a href="internships/new.aspx" class="px-10 py-4 bg-teal-500 text-white font-semibold">Add a new internship</a>
            </p>
       </div>
    <% End If %>

</asp:Content>
