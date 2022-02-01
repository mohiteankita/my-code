

<!DOCTYPE html>

<head>
    <title></title>
    <link href="CSSStyleRegiForm.css" rel="stylesheet"/>
    <script type="text/javascript" src="MyJsSheet.js"></script>
</head>
<body>
    <form id="form1" runat="server">
            <h1 class="headRegi">Registration Form</h1>
            <table class="table1">
                <tr>
                    <th><label  for="uname">User Name*: </label></th>
                    <td><input type="text" id="uname" name="uname"/><span id="userMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th><label for="pass">Password*: </label></th>
                    <td><input type="password" id="pass" name="pass" /><span id="passMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th><label for="confirmpass">Confirm Password*:</label></th>
                    <td><input type="password" id="confirmpass" name="confirmpass"/><span id="confirmMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th><label for="fname">First Name*:</label></th>
                    <td><input type="text" id="fname" name="fname" onkeypress="return OnlyAlphabetAllow(event);"/><span id="fnameMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th><label for="lname">Last Name: </label></th>
                    <td><input type="text" id="lname" name="lname"/><span id="lnameMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th><label for="birthdate">DOB: </label></th>
                    <td><input type="datetime-local" id="birthdate" name="birthdate"/></td>
                </tr>

                <tr>
                    <th><label for="email">Email: </label></th>
                    <td><input type="email" id="emailadd" name="email"/><span id="emailMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th><label>Address*:</label></th>
                    <td><textarea id="add" cols="20" rows="5"></textarea><span id="addMsg" style="color:red"></span></td>
                </tr>

                <tr>
                    <th>Gender*: </th>
                    <td><input type="radio" name="gender" value="male"/>Male <input type="radio" name="gender" value="female"/>Female<span id="genderMsg" style="color:red;"></span></td>
                </tr>

                <tr>
                    <th>Educational Qualification: </th>
                    <td><select name="courses">
                        <option>Select</option>
                        <option>Bsc Mathematics</option>
                        <option>Bsc Computer Science</option>
                        <option>Bsc Physics</option>
                        <option>Bsc Statistics</option>
                        </select></td>
                </tr>
 
                 <tr>
                    <th>Attach Resume: </th>
                    <td><input type="file" id="filename" accept="application/pdf,application/doc" /></td>
                </tr>

                 <tr>
                    <td><input type="submit" value="Submit" class="submitbtn" onclick="validation();"/></td>
                    <td><input type="reset" value="Reset" class="submitbtn"/></td>
                </tr>
            </table>
    </form>
</body>
</html>

