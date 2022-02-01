<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HTMLPageJs.aspx.vb" Inherits="WebApplication1.HTMLPageJs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="JavaScriptFile1.js"></script>
    <style>
        .btnstyle1
        {
            background-color : red;
        }

        .btnstyle2
        {
            background-color : green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <p id="paratext">JavaScript Code Hide and Display</p>

        <button type="button" onclick="showText();">Show Text</button>
        <button type="button" onclick="hideText();">Hide Text</button><br /><br />

        <!--Change button color-->
        <button type="button" class="btnstyle1" onclick="changeBtn();">Button1</button>
        <button type="button" class="btnstyle1">Button1</button>
        <button type="button" class="btnstyle2">Button1</button>
    </form>
</body>
</html>
