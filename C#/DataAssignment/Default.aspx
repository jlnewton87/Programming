<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="content/style/site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="title_bar">
            <h1 style="display:inline;">iKick</h1>&nbsp;&nbsp;<h3 style="display:inline;">Virtual Karate Studio</h3>
        </div>
        <div id="content">
            <p>
                <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="400px" 
                    AllowPaging="True" 
                    AutoGenerateRows="False" BackColor="White" BorderColor="#999999" 
                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                    DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" />
                        <asp:BoundField DataField="Time" DataFormatString="{0:t}" HeaderText="Time" 
                            SortExpression="Time" />
                        <asp:BoundField DataField="Instructor_Id" HeaderText="Instructor_Id" 
                            SortExpression="Instructor_Id" />
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                            ShowInsertButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                </asp:DetailsView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT * FROM [Schedule]"
                    UpdateCommand="UPDATE [Schedule] SET [Day] = @Day, [Time] = @Time, [Instructor_Id] = @Instructor_Id WHERE [ID] = @original_ID AND [Day] = @original_Day AND [Time] = @original_Time AND [Instructor_Id] = @original_Instructor_Id"
                    DeleteCommand="DELETE FROM [Schedule] WHERE [ID] = @original_ID AND [Day] = @original_Day AND [Time] = @original_Time AND [Instructor_Id] = @original_Instructor_Id"
                    
                    InsertCommand="INSERT INTO [Schedule] ([ID], [Day], [Time], [Instructor_Id]) VALUES (@ID, @Day, @Time, @Instructor_Id)" 
                    ConflictDetection="CompareAllValues" 
                    OldValuesParameterFormatString="original_{0}">
                    <DeleteParameters>
                        <asp:Parameter Name="original_ID" Type="Int32" />
                        <asp:Parameter Name="original_Day" Type="Int16" />
                        <asp:Parameter Name="original_Time" Type="DateTime" />
                        <asp:Parameter Name="original_Instructor_Id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="ID" Type="Int32" />
                        <asp:Parameter Name="Day" Type="Int16" />
                        <asp:Parameter Name="Time" Type="DateTime" />
                        <asp:Parameter Name="Instructor_Id" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Day" Type="Int16" />
                        <asp:Parameter Name="Time" Type="DateTime" />
                        <asp:Parameter Name="Instructor_Id" Type="Int32" />
                        <asp:Parameter Name="original_ID" Type="Int32" />
                        <asp:Parameter Name="original_Day" Type="Int16" />
                        <asp:Parameter Name="original_Time" Type="DateTime" />
                        <asp:Parameter Name="original_Instructor_Id" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </p>
            <p>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
                    CellPadding="3" DataSourceID="SqlDataSource1" ForeColor="Black" 
                    GridLines="Vertical" Width="400px">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="Day" HeaderText="Day" SortExpression="Day" />
                        <asp:BoundField DataField="Time" DataFormatString="{0:t}" HeaderText="Time" 
                            SortExpression="Time" />
                        <asp:BoundField DataField="Instructor_Id" HeaderText="Instructor_Id" 
                            SortExpression="Instructor_Id" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </p>
        </div>
    </div>
    </form>
</body>
</html>
