<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StepTxn.aspx.cs" Inherits="mesWebClient.StepTxn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 46px;
            text-align: right;
        }
        .style2
        {
            width: 119px;
        }
        .style3
        {
            width: 35px;
            text-align: right;
        }
        .style4
        {
            width: 130px;
        }
        .style5
        {
            width: 78px;
            text-align: right;
        }
        .style6
        {
            width: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1">
    
        <asp:Label ID="fab" runat="server" Text="Fab" style="text-align: right"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtFab" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style3">
        <asp:Label ID="step" runat="server" Text="Step"></asp:Label>
                </td>
                <td class="style4">
                    <asp:TextBox ID="txtStep" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style5">
        <asp:Label ID="Equipment" runat="server" Text="Equipment"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtEquipment" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    &nbsp;<a href=Index.aspx>回站點選擇</a></td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Label ID="WaitTrackIn" runat="server" Text="等待進機"></asp:Label>
    
        <br />
        <asp:GridView ID="gridWaitForTrackIn" runat="server" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="選擇" />
                <asp:BoundField DataField="name" HeaderText="LotId" >
                <HeaderStyle Wrap="False" />
                <ItemStyle Wrap="False" />
                </asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="status" />
                <asp:BoundField DataField="processingStatus" HeaderText="processingStatus" />
                <asp:BoundField DataField="quantity" HeaderText="quantity" />
                <asp:BoundField DataField="unit" HeaderText="unit" />
                <asp:BoundField DataField="lotType" HeaderText="lotType" />
                <asp:BoundField DataField="carrierId" HeaderText="carrierId" />
                <asp:BoundField DataField="productId" HeaderText="productId" />
                <asp:BoundField DataField="stepId" HeaderText="stepId" />
                <asp:BoundField DataField="equipmentId" HeaderText="equipmentId" />
                <asp:BoundField DataField="orderId" HeaderText="orderId" />
                <asp:BoundField DataField="customerId" HeaderText="customerId" />
            </Columns>
            <SelectedRowStyle BackColor="Yellow" />
        </asp:GridView>
        <br />
        <asp:Button ID="trackIn" runat="server" onclick="trackIn_Click" Text="OK" 
            Width="111px" />
        <br />
        <hr />
        <br />
        等待出機<br />
        <asp:GridView ID="gridWaitForTrackOut" runat="server" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="選擇" />
                <asp:BoundField DataField="name" HeaderText="LotId" >
                <HeaderStyle Wrap="False" />
                <ItemStyle Wrap="False" />
                </asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="status" />
                <asp:BoundField DataField="processingStatus" HeaderText="processingStatus" />
                <asp:BoundField DataField="quantity" HeaderText="quantity" />
                <asp:BoundField DataField="unit" HeaderText="unit" />
                <asp:BoundField DataField="lotType" HeaderText="lotType" />
                <asp:BoundField DataField="carrierId" HeaderText="carrierId" />
                <asp:BoundField DataField="productId" HeaderText="productId" />
                <asp:BoundField DataField="stepId" HeaderText="stepId" />
                <asp:BoundField DataField="equipmentId" HeaderText="equipmentId" />
                <asp:BoundField DataField="orderId" HeaderText="orderId" />
                <asp:BoundField DataField="customerId" HeaderText="customerId" />
            </Columns>
            <SelectedRowStyle BackColor="Yellow" />
        </asp:GridView>
    
    </div>
    <p>
        <asp:Button ID="trackOut" runat="server" onclick="trackOut_Click" Text="OK" 
            Width="111px" />
        </p>
        <hr />
        <asp:GridView ID="gridWaitForMoveOut" runat="server" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="選擇" />
                <asp:BoundField DataField="name" HeaderText="LotId" >
                <HeaderStyle Wrap="False" />
                <ItemStyle Wrap="False" />
                </asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="status" />
                <asp:BoundField DataField="processingStatus" HeaderText="processingStatus" />
                <asp:BoundField DataField="quantity" HeaderText="quantity" />
                <asp:BoundField DataField="unit" HeaderText="unit" />
                <asp:BoundField DataField="lotType" HeaderText="lotType" />
                <asp:BoundField DataField="carrierId" HeaderText="carrierId" />
                <asp:BoundField DataField="productId" HeaderText="productId" />
                <asp:BoundField DataField="stepId" HeaderText="stepId" />
                <asp:BoundField DataField="equipmentId" HeaderText="equipmentId" />
                <asp:BoundField DataField="orderId" HeaderText="orderId" />
                <asp:BoundField DataField="customerId" HeaderText="customerId" />
            </Columns>
            <SelectedRowStyle BackColor="Yellow" />
        </asp:GridView>
    
    <p>
        <asp:Button ID="OutStepCheck" runat="server" onclick="moveOut_Click" Text="OK" 
            Width="111px" />
        </p>
    </form>
</body>
</html>
