<%@ Page Title="Domiciles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Domiciles.aspx.cs" Inherits="FirstExamenASP.GUI.Domiciles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label style="font-size:xx-large" ID="Label1" runat="server" Text="Domiciles"></asp:Label>
    <br />
    <asp:Label style="font-size:medium" ID="Label2" runat="server" Text="Afficher les domiciles qui ont au maximum ce prix:"></asp:Label>
    &nbsp;
    <asp:TextBox ID="Prix" runat="server"></asp:TextBox>

    <%-- ki yebda 3ana affichage 3adi men ghir action fel Code Behind nekhdmou bel DataSource --%>
    <%-- ki yebda l'affichage mte3na paramétré kima notre cas nahiw el DataSource w nzidou SelectMethod --%>
    <%-- najmou fel service nekhdmou méthode paramétré w lors de la création d'un DataSource on spécifie chnoua el paramétre hédhéka et ça marche --%>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" SelectMethod="GetDomicilesSurfaceOrPrice">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Surface" HeaderText="Surface" SortExpression="Surface" />
            <asp:BoundField DataField="NbrePiece" HeaderText="NbrePiece" SortExpression="NbrePiece" />
            <asp:BoundField DataField="Prix" HeaderText="Prix" SortExpression="Prix" />
            <asp:BoundField DataField="Residence.Entrepreneur.Prenom" HeaderText="Entrepreneur" SortExpression="IdResidence.IdEntrepreneur.Prenom" />
        </Columns>
    </asp:GridView>

    <br />
    <asp:FormView ID="FormView1" runat="server">
    </asp:FormView>

</asp:Content>
