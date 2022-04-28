<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseView.aspx.cs" Inherits="TicketBooking.DatabaseView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#CCFFFF" BorderStyle="Solid" DataSourceID="ticketorder" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" style="margin-right: 74px; margin-top: 7px" Width="1048px">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Full_Name" HeaderText="Full_Name" SortExpression="Full_Name" />
                    <asp:BoundField DataField="From_City" HeaderText="From_City" SortExpression="From_City" />
                    <asp:BoundField DataField="Single_Lady" HeaderText="Single_Lady" SortExpression="Single_Lady" />
                    <asp:BoundField DataField="From_Date" HeaderText="From_Date" SortExpression="From_Date" />
                    <asp:BoundField DataField="Number_of_Tickets" HeaderText="Number_of_Tickets" SortExpression="Number_of_Tickets" />
                    <asp:BoundField DataField="To_Date" HeaderText="To_Date" SortExpression="To_Date" />
                    <asp:BoundField DataField="Insurance_Opt" HeaderText="Insurance_Opt" SortExpression="Insurance_Opt" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="To_City" HeaderText="To_City" SortExpression="To_City" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                </Columns>
                <EditRowStyle BackColor="Black" BorderStyle="Solid" />
                <EmptyDataRowStyle BorderStyle="Solid" />
                <PagerStyle BorderStyle="Solid" />
            </asp:GridView>
            <asp:SqlDataSource ID="ticketorder" runat="server" ConnectionString="<%$ ConnectionStrings:mydbConnectionString %>" SelectCommand="SELECT [Full_Name], [From_City], [Single_Lady], [From_Date], [Number_of_Tickets], [To_Date], [Insurance_Opt], [Email], [To_City], [Address] FROM [ticketorder]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" Width="156px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Delete" Width="161px" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
