<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Sellers.aspx.cs" Inherits="Online_Grocery.View.Admin.Sellers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

<div class="container-fluid">
      <div class="row">
          <div class="col-md-4"></div>
          <div class="col-md-8">
              <br />
              <img src="../../Asset/images/vegeterian_food.jpg" width="10%" height="auto" style="margin-left:100px"/>
              <h4 class="text-danger" style="margin-left:70px">Manage Seller</h4>
          </div>
      </div>
      <div class="row">
          <div class="col-md-4">
            <h2 class="text-danger">Seller Details</h2>
             <div class="mb-3">
            <label for="SNameTb" class="form-label">Seller Name</label>
            <input type="text" class="form-control" id="SNameTb" runat="server">
             </div>
            <div class="mb-3">
          <label for="SEmailTb" class="form-label">Seller Email</label>
          <input type="email" class="form-control" id="SEmailTb" runat="server">
         </div>
             <div class="mb-3">
            <label for="SPassTb" class="form-label">Seller Password</label>
            <input type="text" class="form-control" id="SellerPassTb" runat="server">
            </div>
           <div class="mb-3">
         <label for="SPhoneTb" class="form-label">Seller Phone</label>
        <input type="number" class="form-control" id="SellerPhoneTb"  runat="server">
       </div>
       <div class="mb-3">
       <label for="SAddress" class="form-label">Seller Address</label>
        <input type="text" class="form-control" id="SellerAddressTb"  runat="server">
     
        </div>

        <asp:Label ID="ErrorMsg" runat="server" ForeColor="Red"></asp:Label>
        <br/><br />
        <asp:Button  class="btn btn-danger"  text="  Edit  " runat="server" ID="Editbtn" OnClick="Editbtn_Click" /> 
        <asp:Button  class="btn btn-danger"  text="  Save  " runat="server" ID="Savebtn" OnClick="Savebtn_Click" /> 
        <asp:Button  class="btn btn-danger"  text="  Delete  " runat="server" ID="Deletebtn" OnClick="Deletebtn_Click" /> 
          </div>
          <div class="col-md-8">
             <asp:GridView runat="server" class="table table-hover"  ID="SellerGv" AutoGenerateSelectButton="True" OnSelectedIndexChanged="SellerGv_SelectedIndexChanged">

             </asp:GridView>

          </div>
      </div>
    </div>


</asp:Content>

