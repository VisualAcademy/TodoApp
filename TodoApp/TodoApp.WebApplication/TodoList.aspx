<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TodoList.aspx.cs" Inherits="TodoApp.WebApplication.TodoList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>할 일 목록</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>할 일 목록</h1>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
