<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebFormsCalculator.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link rel="stylesheet" type="text/css" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator">
            <div class="display">
                <asp:TextBox ID="txtDisplay" runat="server" CssClass="display-input" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="buttons">
                <asp:Button ID="btnMC" runat="server" Text="MC" CssClass="btn btn-light" OnClick="MemoryClear" />
                <asp:Button ID="btnMR" runat="server" Text="MR" CssClass="btn btn-light" OnClick="MemoryRecall" />
                <asp:Button ID="btnMMinus" runat="server" Text="M-" CssClass="btn btn-light" OnClick="MemoryMinus" />
                <asp:Button ID="btnMPlus" runat="server" Text="M+" CssClass="btn btn-light" OnClick="MemoryPlus" />
                <asp:Button ID="btnClear" runat="server" Text="C" CssClass="btn btn-red" OnClick="ClearDisplay" />
                <asp:Button ID="btn7" runat="server" Text="7" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btn8" runat="server" Text="8" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btn9" runat="server" Text="9" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btnDivide" runat="server" Text="÷" CssClass="btn btn-gray" OnClick="Button_Click" />
                <asp:Button ID="btn4" runat="server" Text="4" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btn5" runat="server" Text="5" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btn6" runat="server" Text="6" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btnMultiply" runat="server" Text="×" CssClass="btn btn-gray" OnClick="Button_Click" />
                <asp:Button ID="btn1" runat="server" Text="1" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btn2" runat="server" Text="2" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btn3" runat="server" Text="3" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btnMinus" runat="server" Text="-" CssClass="btn btn-gray" OnClick="Button_Click" />
                <asp:Button ID="btn0" runat="server" Text="0" CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btnDecimal" runat="server" Text="." CssClass="btn btn-light" OnClick="Button_Click" />
                <asp:Button ID="btnEquals" runat="server" Text="=" CssClass="btn btn-blue" OnClick="Evaluate" />
                <asp:Button ID="btnPlus" runat="server" Text="+" CssClass="btn btn-gray" OnClick="Button_Click" />
            </div>
        </div>
    </form>
</body>
</html>
