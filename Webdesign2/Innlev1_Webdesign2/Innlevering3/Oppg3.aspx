<%-- Innlevering 3 Webdesign 1 kodet av Britt-Heidi Fladby-Flabri10 --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Oppg3.aspx.cs" Inherits="Oppg3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Oppg3StyleSheet.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="header"><h1>
            <a href="Oppg3.aspx">Mine bilder</a></h1></div>
        
        <div id="knapper">
            <asp:Button ID="btnKatter" runat="server" Text="Vis katter" OnClick="VisKattebilder"/>
            <asp:Button ID="btnHunder" runat="server" Text="Vis hunder" OnClick="VisHundebilder" />
        </div>
       
        <div id="bildeserie">
            <asp:Literal ID="litBildeserie" runat="server"/>
        </div>
    </div>
    </form>
</body>
</html>
