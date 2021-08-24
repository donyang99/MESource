<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="mesWebClient.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 155px;
        }
        .style4
        {
            width: 67px;
            text-align: right;
        }
        .style5
        {
            width: 38px;
            text-align: right;
        }
        .style6
        {
            width: 159px;
        }
        .style7
        {
            width: 75px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style4">
    
        <asp:Label ID="fab" runat="server" Text="Fab" style="text-align: right"></asp:Label>
                </td>
                <td class="style2">
        <asp:DropDownList ID="cboFab" runat="server" AutoPostBack="True" 
            onselectedindexchanged="cboFab_SelectedIndexChanged" Width="154px">
        </asp:DropDownList>
                </td>
                <td class="style5">
        <asp:Label ID="step" runat="server" Text="Step"></asp:Label>
                </td>
                <td class="style6">
        <asp:DropDownList ID="cboStep" runat="server" Width="154px" AutoPostBack="True" 
                        onselectedindexchanged="cboStep_SelectedIndexChanged">
        </asp:DropDownList>
                </td>
                <td class="style7">
        <asp:Label ID="Equipment" runat="server" Text="Equipment"></asp:Label>
                </td>
                <td>
        <asp:DropDownList ID="cboEquipment" runat="server" Width="154px">
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
        <asp:Label ID="language" runat="server" Text="Language"></asp:Label>
                </td>
                <td class="style2">
        <asp:DropDownList ID="cboLanguage" runat="server" AutoPostBack="True" 
            onselectedindexchanged="cboLanguage_SelectedIndexChanged" Width="154px">
        </asp:DropDownList>
    
                </td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    <asp:Button ID="buttonOK" runat="server" onclick="buttonOK_Click" 
                        style="margin-left: 0px" Text="OK" />
                </td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
