<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing inputs</title>
    <style type="text/css">
        .col {
            width: 253px;
        }
        .col-sm-12 {
            width: 165px;
        }
        .container {
            height: 163px;
        }
        </style>
</head>
<body style="height: 485px; margin-bottom: 27px; width: 1164px;">
    

    <form id="form1" runat="server">
                Here you can test out the Order.
                <br />
                <br /> 
       <div class="container">
               <div class="col-lg-6 col-md-6 col-sm-12" style="float:left; text-align:right; line-height:21px" >
                   <p style="height: 164px; margin-top:0">
                   OrderID:<br />
                   StaffID:<br />
                   CustomerID:<br />
                   Total Price:<br />
                   Delivery Address:<br />
                   Date Ordered: <br />
                   Paid?
                       </p>
                   </div>
                <div class="col-lg-6 col-md-6 col-sm-12" style="vertical-align:central;">
                    <p style="width: 627px; height: 205px;">
                <asp:TextBox ID="intOrderID" runat="server" Width="50px" ></asp:TextBox>
                <asp:Button ID="Find" runat="server" OnClick="FindOrder_Click" Text="Find" /><br />
                <asp:TextBox ID="intStaffID" runat="server" Width="50px"></asp:TextBox><br />
                <asp:TextBox ID="intCustomerID" runat="server" Width="50px"></asp:TextBox><br />
                <asp:TextBox ID="floatPrice" runat="server" Width="50px"></asp:TextBox><br />
                <asp:TextBox ID="stringAddress" runat="server" Width="200px"></asp:TextBox><br />
                <asp:TextBox ID="dateOrdered" runat="server" Width="200px"></asp:TextBox><br />
                <asp:CheckBox ID="boolPaid" runat="server" />
                        </p>
            </div>
           </div>
                   
                <div style="margin-left: 120px">
                    <asp:Button ID="orderOK" runat="server" OnClick="btnOK_Click" Text="OK-ORDER" />
                </div>
                   
                <p>Here you can test out the OrderLine.</p>
           <br />
                    <div class="container" >
 <div class="col-lg-6 col-md-6 col-sm-12" style="float:left; text-align:right; line-height:21px; vertical-align:central" >
                   <p style="margin-top:0;">
                   OrderLineID:<br />
                   OrderID:<br />
                   ProductID:<br />
                   SelectionDescription:<br />
                   Quantity:<br />
                  
                       </p>
                   </div>
                <div class="col-lg-6 col-md-6 col-sm-12" style="width:500px">
                    <p style="width: 717px;">
                    
                <asp:TextBox ID="intOrderLine" runat="server" Width="50px"></asp:TextBox>
                <asp:Button ID="OrderLineFind" runat="server" OnClick="FindOrderLine_Click" Text="Find" /><br />
                <asp:TextBox ID="OrderIDFind" runat="server" Width="50px"></asp:TextBox><br />
                <asp:TextBox ID="ProductIDFind" runat="server" Width="50px"></asp:TextBox><br />
                <asp:TextBox ID="SelectionDescriptionFind" runat="server" Width="150px"></asp:TextBox><br />
                <asp:DropDownList ID="QuantityList" runat="server" >
                <asp:ListItem Value="1"></asp:ListItem>
                <asp:ListItem Value="2"></asp:ListItem>
                <asp:ListItem Value="3"></asp:ListItem>
                </asp:DropDownList>
                        </p>
            </div>
           </div>
          
               
                <div style="margin-left: 120px">
                    <asp:Button ID="Button1" runat="server" OnClick="btnOKOrderLine_Click" Text="OK - ORDERLINE" />
                    <br />
                </div>
          
               
<asp:Button ID="btnAddOrder" runat="server" OnClick="btnOK_Click" Text="Add Order" Width="89px" />
        
       
<asp:Button ID="Line" runat="server" OnClick="btnOK_Click" Text="Add Order Line" Width="89px" />
        
       
            <p id="errorShow">
                <asp:Label ID="Label2" runat="server" Text="No error"></asp:Label>
        
         </p>
           
    </form>
</body>
</html>
