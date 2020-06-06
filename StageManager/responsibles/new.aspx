<%@ Page Title="New responsible" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="new.aspx.vb" Inherits="StageManager._new1" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

    <div class="my-5 md:flex md:justify-between">
        <div class="my-5 flex-1">
            <label class="block">First Name</label>
            <asp:TextBox runat="server" ID="NameTextBox"
                CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded"
            />
            <asp:Label runat="server" ID="FirstNameError" Text="The first name is required" CssClass="block font-medium text-red-400" />
        </div>
        <div class="my-5 flex-1">
            <label class="block">Last Name</label>
            <asp:TextBox runat="server" ID="LastNameTextBox"
                CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded"
            />
            <asp:Label runat="server" ID="LastNameError" Text="The last name is required" CssClass="block font-medium text-red-400" />
        </div>
    </div>

    <div class="my-5 md:flex md:justify-between">
        <div class="my-5 flex-1">
            <label class="block">Phone Number</label>
            <asp:TextBox runat="server" ID="PhoneNumberTextBox"
                CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded"
            />
            <asp:Label runat="server" ID="PhoneNumberError" Text="The phone number is not valid" CssClass="block font-medium text-red-400" />
        </div>
        <div class="my-5 flex-1">
            <label class="block">Email Address</label>
            <asp:TextBox runat="server" ID="EmailTextBox"
                CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded"
             />
            <asp:Label runat="server" ID="EmailError" Text="The email address is not valid" CssClass="block font-medium text-red-400" />
        </div>
    </div>

    <div class="my-5">
        <label class="block">Linkedin Username</label>
        <asp:TextBox runat="server" ID="LinkedinTextBox"
            CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded"
         />
        <p class="text-teal-500 font-light my-2">This field will for professional contacts</p>
    </div>

    <div class="my-5">
        <label class="block">Company's Name</label>
        <asp:TextBox runat="server" ID="CompanyTextBox"
            CssClass="w-full border hover:border-gray-300 hover:bg-white bg-gray-200 font-semibold py-4 px-8 rounded"
        />
        <asp:Label runat="server" ID="CompanyError" Text="The company's name is required" CssClass="block font-medium text-red-400" />
    </div>

    <div class="my-5">
        <asp:Button runat="server" ID="Submit" Text="Add the responsible" CssClass="text-white bg-teal-500 py-4 px-10 rounded-lg shadow font-semibold text-2xl" />
    </div>

</asp:Content>
