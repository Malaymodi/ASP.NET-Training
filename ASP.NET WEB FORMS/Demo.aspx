<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="ASP.NET_WEB_FORMS.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:Label ID="lblfname" runat="server" Text="Enter First Name" BackColor="#CCFFFF" BorderWidth="1px" Width="120px"></asp:Label>
            <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="Please Enter First Name"></asp:RequiredFieldValidator>
        </div>

        <br />
        <div align="center">

            <asp:Label ID="lbllname" runat="server" BackColor="#CCFFFF" BorderWidth="1px" Text="Enter Last Name" Width="120px"></asp:Label>
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" ErrorMessage="Please Enter Last Name"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        <div align="center">
            <asp:Label ID="lblemail" runat="server" BackColor="#CCFFFF" BorderWidth="1px" Text="Enter Email" Width="120px"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter Email"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>

        <!-- <div align ="center">
            <asp:Label ID="lblpass" runat="server" Text="Enter Password" BackColor="#CCFFFF" BorderWidth="1px" Width="120px"></asp:Label>
            <input id="txtpass" type="password" />
            <br />
            <br />
        </div>

        <div align ="center">
            <asp:Label ID="lblcpass" runat="server" Text="Confirm Password" BackColor="#CCFFFF" BorderWidth="1px" Width="120px"></asp:Label>
            <input id="txtcpass" type="password" />
            <br />
            <br />
            <br />
        </div>-->

        <div align="center">

            <asp:ListBox ID="lbcity" runat="server">
                <asp:ListItem>Ahmedabad</asp:ListItem>
                <asp:ListItem>Baroda</asp:ListItem>
                <asp:ListItem>Rajkot</asp:ListItem>
                <asp:ListItem>Surat</asp:ListItem>
            </asp:ListBox>

        </div>
        <div align="center">


            <asp:RadioButton ID="rbmale" runat="server" Text="Male" />
            <asp:RadioButton ID="rbfemale" runat="server" Text="Female" />

        </div>
        <div align="center">
            <asp:CheckBox ID="cbcsharp" runat="server" Text="C#" />
            <br />
            <asp:CheckBox ID="cbjava" runat="server" Text="JAVA" />
            <br />
            <asp:CheckBox ID="cbpython" runat="server" Text="PYTHON" />
            <br />
            <asp:CheckBox ID="cbphp" runat="server" Text="PHP" />
        </div>
        <div align="center">

            <asp:HyperLink ID="hl" runat="server" NavigateUrl="https://www.brainvire.com/">HyperLink</asp:HyperLink>

        </div>
         <div align="center">
             <p>Upload File<asp:FileUpload ID="FileUpload1" runat="server" />
             </p>  
            

        </div>
        <div align="center">
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
        </div>
        <div align="center">
            <h1>Your Details Are</h1>
        </div>
        <div align="center">
            <asp:Label ID="dispfname" runat="server" Text="Label"></asp:Label>
        </div>
        <div align="center">
            <asp:Label ID="displname" runat="server" Text="Label"></asp:Label>
        </div>
        <div align="center">
            <asp:Label ID="dispemail" runat="server" Text="Label"></asp:Label>
        </div>
        <div align="center">
            <asp:Label ID="dispcity" runat="server" Text="Label"></asp:Label>
        </div>
        <div align="center">
            <asp:Label ID="dispgender" runat="server" Text="Label"></asp:Label>
        </div>
        <div align="center">
            <asp:Label ID="dispskill" runat="server" Text="Label"></asp:Label>
            
        </div>
        <div align="center">
            <asp:Label ID="filestatus" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
