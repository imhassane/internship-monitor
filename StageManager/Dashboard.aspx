<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.vb" Inherits="StageManager.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <% If Not Session("NumberInternships") Then %>
       <div>
            <p class="text-center font-semibold text-gray-700 text-2xl">You haven't added any intership yet</p>
            <p class="mt-5 text-center">
                <a href="internships/new" class="hover:no-underline hover:text-white text-white bg-teal-500 py-4 px-10 rounded-lg shadow font-semibold text-2xl">
                    Add a new internship
                </a>
            </p>
       </div>
    <% End If %>

</asp:Content>
