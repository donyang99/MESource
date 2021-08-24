<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrackIn.aspx.cs" Inherits="mesWebClient.RunTime.TrackIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 237px;
        }
        .style2
        {
            height: 20px;
            margin-left: 120px;
        }
        .style3
        {
            width: 91px;
        }
        .style4
        {
            height: 20px;
            width: 91px;
            margin-left: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%; height: 423px;">
            <tr>
                <td class="style1">
                    <div style="height: 508px; width: 283px">
                        <asp:Label ID="lotInformation" runat="server" Text="lotInformation" 
                            BackColor="#3333CC" ForeColor="White"></asp:Label>
                        <table style="width:100%;">
                            <tr>
                                <td class="style3">
                                    <asp:Label ID="lotId" runat="server" Text="LotId"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtLotId" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:Label ID="status" runat="server" Text="Status"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtStatus" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="quantity" runat="server" Text="Quantity"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtQuantity" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="unit" runat="server" Text="Unit"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtUnit" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="lotType" runat="server" Text="LotType"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtLotType" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="product" runat="server" Text="Product"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtProduct" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="step" runat="server" Text="Step"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtStep" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="order" runat="server" Text="Order"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtOrder" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style4">
                                    <asp:Label ID="fab" runat="server" Text="fab"></asp:Label>
                                </td>
                                <td class="style2">
                                    <asp:TextBox ID="txtFab" runat="server" Enabled="False" Width="166px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <asp:HiddenField ID="prevEqpId" runat="server" />
                    </div>
                </td>
                <td>
                    <div style="height: 508px; width: auto">
                        <asp:Label ID="workingInstruction" runat="server" Text="WorkingInstruction"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtWorkingInstruction" runat="server" Height="51px" 
                            ReadOnly="True" TextMode="MultiLine" Width="466px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="eqpEquipmentList" runat="server" Text="EqpList"></asp:Label>
        <asp:GridView ID="gridEquipments" runat="server" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="選擇" />
                <asp:BoundField DataField="name" HeaderText="Equipment" />
                <asp:BoundField DataField="state" HeaderText="state" />
                <asp:BoundField DataField="type" HeaderText="EquipmentType" />
                <asp:BoundField DataField="lotId" HeaderText="lotId" />
                <asp:BoundField DataField="recipe" HeaderText="recipe" />
            </Columns>
            <SelectedRowStyle BackColor="Yellow" />
        </asp:GridView>
                        <br />
                        <asp:Label ID="comments" runat="server" Text="Comments"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtComments" runat="server" Height="51px" TextMode="MultiLine" 
                            Width="466px"></asp:TextBox>
                        <br />
                        <asp:Button ID="buttonOK" runat="server" onclick="buttonOK_Click" Text="OK" />
                        <br />
                        <asp:Label ID="lblInfo" runat="server" Text="Label" Visible="False"></asp:Label>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
