<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OnlyNumberAllow.aspx.vb" Inherits="WebApplication1.OnlyNumberAllow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        function OnlyNumberKeys(evt)
        {
            var asciicode = (evt.which) ? evt.which : evt.keyCode;
            if (asciicode > 31 && (asciicode < 48 || asciicode > 57))
                return false;
            else
                return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <input type="text" onkeypress="return OnlyNumberKeys(event);"/>
    </form>
</body>
</html>
