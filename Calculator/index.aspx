<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Calculator.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Basic calculator</title>
    <link href="CalculatorStyles.css" rel="stylesheet" />
    <script>
        function isvalidnum(evt) {
            var charcode = (evt.which) ? evt.which : event.keycode;
            if ((charcode != 46 && charcode > 31) && (charcode < 48 || charcode > 57))
            {
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr class="heading">
                    <td class="auto-style1">Calculator</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtInput1" runat="server" placeholder="Input1" onkeypress="return isvalidnum(event)" MaxLength="5"></asp:TextBox><br />
                        <asp:TextBox ID="txtInput2" runat="server" placeholder="Input2" onkeypress="return isvalidnum(event)" MaxLength="5"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnDiv" CssClass="btns" runat="server" Text="/" OnClick="btnDiv_Click" />
                        <asp:Button ID="btnMul" CssClass="btns" runat="server" Text="*" OnClick="btnMul_Click" />
                        <asp:Button ID="btnAdd" CssClass="btns" runat="server" Text="+" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnSub" CssClass="btns" runat="server" Text="-" OnClick="btnSub_Click" />
                        <br />
                        <asp:Button ID="btnClear" CssClass="btns" runat="server" Text="Clear" style="width:172px;height:30px" OnClick="btnClear_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
