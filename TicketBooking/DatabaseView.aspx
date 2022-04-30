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
            <asp:Button ID="Button1" runat="server" Text="Update" Width="156px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Delete" Width="161px" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" Width="242px"></asp:TextBox>
            <br />
            <br />
            From City&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>San Jose</asp:ListItem>
                <asp:ListItem>San Francisco</asp:ListItem>
                <asp:ListItem>Santa Clara</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Single Lady&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br />
            <br />
            From Date&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox2" runat="server" Width="224px"></asp:TextBox>
            <br />
            <br />
            Number of Tickets&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="174px"></asp:TextBox>
            <br />
            <br />
            Mobile Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="175px"></asp:TextBox>
            <br />
            <br />
            Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="167px"></asp:TextBox>
            <br />
            <br />
            To Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Height="19px" Width="174px"></asp:TextBox>
            <br />
            <br />
            Insurance Opt&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:CheckBox ID="CheckBox2" runat="server" />
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Width="166px"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
