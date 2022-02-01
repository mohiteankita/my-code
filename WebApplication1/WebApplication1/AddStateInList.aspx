<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddStateInList.aspx.vb" Inherits="WebApplication1.AddStateInList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function addState() {
            var course = document.getElementById("course");
            var sname = window.prompt("Enter course");
            var option = document.createElement("option");
            option.text = sname;
            course.add(option);
        }
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
       
        <select name="courses" id="course">
        <option>Select</option>
        <option>Bsc Mathematics</option>
        <option>Bsc Computer Science</option>
        <option>Bsc Physics</option>
        <option>Bsc Statistics</option>
    </select>
    <input type="button" id="btn" value="Add State" onclick="addState()"/>
    </form>
</body>
</html>
