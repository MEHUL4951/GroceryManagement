<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Online_Grocery.View.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

<div class="container-fluid">
      <div class="row">
          <div class="col-md-4"></div>
          <div class="col-md-8">
              <br />
              <img src="../../Asset/images/vegeterian_food.jpg" width="10%" height="auto" style="margin-left:100px"/>
              <h4 class="text-danger" style="margin-left:70px">Manage Product</h4>
          </div>
      </div>
      <div class="row">
          <div class="col-md-4">
            <h2 class="text-danger">Product Details</h2>
             <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Product Name</label>
            <input type="text" class="form-control" id="PnameTb" runat="server" >
             </div>
            <div class="mb-3">
          <label for="CategoryCb" class="form-label">Product Category</label>
           <asp:DropDownList ID="CategoryCb" CssClass="form-control" runat="server"></asp:DropDownList>
         </div>
             <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Product Price</label>
            <input type="number" class="form-control" id="PriceTb" runat="server">
            </div>
           <div class="mb-3">
         <label for="exampleInputEmail1" class="form-label">Product Quantity</label>
        <input type="number" class="form-control" id="ProdQtyTb" runat="server">
       </div>
       <div class="mb-3">
       <label for="exampleInputEmail1" class="form-label">Expiry Date</label>
       <input type="date" class="form-control" id="ExpDate" runat="server">
        </div>
          <asp:Label ID="ErrorMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
        
        <asp:Button  class="btn btn-danger"  text="  Edit  " runat="server" ID="EditBtn" OnClick="EditBtn_Click" /> 
        <asp:Button  class="btn btn-danger"  text="  Save  " runat="server" ID="SaveBtn" OnClick="SaveBtn_Click" /> 
        <asp:Button  class="btn btn-danger"  text="  Delete  " runat="server" ID="DeleteBtn" OnClick="DeleteBtn_Click" /> 
          </div>
          <div class="col-md-8">
             <asp:GridView runat="server" class="table table-hover"  ID="ProductGv" AutoGenerateSelectButton="True"  OnSelectedIndexChanged="ProductGv_SelectedIndexChanged">

             </asp:GridView>
          </div>
      </div>
    </div>

</asp:Content>