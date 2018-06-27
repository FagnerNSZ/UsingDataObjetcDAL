<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="scriptManager" runat="server">
    </asp:ScriptManager>
    <h2>
        Welcome to ASP.NET!
    </h2>
    <asp:UpdatePanel ID="up" runat="server">
        <ContentTemplate>
            <asp:DetailsView ID="details" runat="server" AllowPaging="True" AutoGenerateRows="False"
                DataKeyNames="CdCategoria" DataSourceID="ObjectDataSource1">
                <Fields>
                    <asp:BoundField DataField="CdCategoria" HeaderText="CdCategoria" InsertVisible="False"
                        ReadOnly="True" SortExpression="CdCategoria" />
                    <asp:BoundField DataField="NmCategoria" HeaderText="NmCategoria" SortExpression="NmCategoria" />
                    <asp:BoundField DataField="DsCategoria" HeaderText="DsCategoria" SortExpression="DsCategoria" />
                    <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Teste.Entity.EntityCategoria"
                InsertMethod="Incluir" SelectMethod="Listar"
                TypeName="Teste.BLL.BLLCategoria" UpdateMethod="Atualizar"></asp:ObjectDataSource>
            <asp:GridView ID="grid" runat="server" AutoGenerateColumns="False" DataKeyNames="CdCategoria"
                DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="CdCategoria" HeaderText="CdCategoria" InsertVisible="False"
                        ReadOnly="True" SortExpression="CdCategoria" />
                    <asp:BoundField DataField="NmCategoria" HeaderText="NmCategoria" SortExpression="NmCategoria" />
                    <asp:BoundField DataField="DsCategoria" HeaderText="DsCategoria" SortExpression="DsCategoria" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
