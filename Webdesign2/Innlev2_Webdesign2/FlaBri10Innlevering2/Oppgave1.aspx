<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Oppgave1.aspx.cs" Inherits="Oppgave1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oppgave 1</title>

<script type="text/javascript">
<!--
function VisSkjulPanel(pnlBilder) {
    if (document.getElementById('pnlBilder').style.display == "none") {
        Vis();
    }
    else if (document.getElementById('pnlBilder').style.display == "block") {
        Skjul();
    }
}

function Skjul() {
    document.getElementById('pnlBilder').style.display = "none";
    btnVisSkjul.value = "Vis!";
    btnVisSkjul.onClick = Vis();
}

function Vis() {
    document.getElementById('pnlBilder').style.display = "block";
    btnVisSkjul.value = "Skjul!"
    btnVisskjul.onClick = Skjul();
}
//-->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" id="btnVisSkjul" value="Vis!" onclick="VisSkjulPanel()"/>
        
        <asp:Panel ID="pnlBilder" runat="server">    
            <img src="Bilder/Koala.jpg" alt="koala" />
            <img src="Bilder/Lighthouse.jpg" alt="hus" />
            <img src="Bilder/Penguins.jpg" alt="pingvin" />
            <img src="Bilder/Tulips.jpg" alt="tulipan" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
