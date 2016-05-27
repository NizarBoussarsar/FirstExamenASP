<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEntrepreneur.aspx.cs" Inherits="FirstExamenASP.GUI.AddEntrepreneur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
        <InsertItemTemplate>
            CIN:
            <asp:TextBox ID="CINTextBox" runat="server" Text='<%# Bind("CIN") %>' />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="CINTextBox" ErrorMessage="Vérifier votre CIN" MaximumValue="99999999" MinimumValue="10000000" ValidationGroup="VG1"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CINTextBox" ErrorMessage="Vous devez insérer votre CIN" ValidationGroup="VG1"></asp:RequiredFieldValidator>
            <br />
            Nom:
            <asp:TextBox ID="NomTextBox" runat="server" Text='<%# Bind("Nom") %>' />
            <br />
            Prenom:
            <asp:TextBox ID="PrenomTextBox" runat="server" Text='<%# Bind("Prenom") %>' />
            <br />
            Adresse:
            <asp:TextBox ID="AdresseTextBox" runat="server" Text='<%# Bind("Adresse") %>' />
            <br />
            Telephone:
            <asp:TextBox ID="TelephoneTextBox" runat="server" Text='<%# Bind("Telephone") %>' />
            <br />
            Email:
            <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Vérifier votre adresse email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="VG1"></asp:RegularExpressionValidator>
            <br />
<%--            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />--%>
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" Text="Insert" OnClick="Button1_Click" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            CIN:
            <asp:Label ID="CINLabel" runat="server" Text='<%# Bind("CIN") %>' />
            <br />
            Nom:
            <asp:Label ID="NomLabel" runat="server" Text='<%# Bind("Nom") %>' />
            <br />
            Prenom:
            <asp:Label ID="PrenomLabel" runat="server" Text='<%# Bind("Prenom") %>' />
            <br />
            Adresse:
            <asp:Label ID="AdresseLabel" runat="server" Text='<%# Bind("Adresse") %>' />
            <br />
            Telephone:
            <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Bind("Telephone") %>' />
            <br />
            Email:
            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
            <br />
            <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />

        </ItemTemplate>
    </asp:FormView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FirstExamenASP.Domain.Entities.Entrepreneur" InsertMethod="AddEntrepreneur" SelectMethod="GetEntrepreneurs" TypeName="FirstExamenASP.Service.MyService"></asp:ObjectDataSource>

</asp:Content>
