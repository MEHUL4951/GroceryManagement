<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Online_Grocery.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
      <link  rel="stylesheet" href="../Asset/Lib/Bootstrap/css/bootstrap.min.css"/>
</head>
<body>
   
    <form id="form1" runat="server">
   
    <div class="container-fluid">
         <div class="row" style="height:150px"></div>
          <div class="row">
               <div class="col-md-4"></div>
              <div class="col-md-2">
                 <img src="../Asset/images/Grocery.png" class="img-fluid" style="width:350px;height:330px"/>
              </div>
               <div class="col-md-4">
                   <h1 class="text-danger">Sign Up</h1>
                
  <div class="mb-3">
    <label for="EmailID" class="form-label">Email address</label>
    <input type="email" class="form-control" id="EmailId" runat="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="UserPasswordTb" class="form-label">Password</label>
    <input type="password" class="form-control" id="UserPasswordTb" runat="server" required="required"/>
  </div>
 <div class="mb-3 form-check">  
     <asp:RadioButton ID="SellerRadio" runat="server" GroupName="Role" Text="Seller" />
     <asp:RadioButton ID="AdminRadio" runat="server" GroupName="Role" Text="Admin" Checked="true" />
</div>

<div class="mb-3 d-grid"></div>
                 
    <asp:Label ID="infomsg" runat="server" CssClass="text-danger"></asp:Label>
    <br />
   <asp:Button  class="btn btn-danger btn-block"  text="  Login  " runat="server" ID="loginbtn" OnClick="loginbtn_Click"/> 

  </div>

       </div>
     </div>
   
    </form>
</body>
</html>
