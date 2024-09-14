<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Online_Grocery.View.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

<div class="container-fluid">
      <div class="row">
          <div class="col-md-4"></div>
          <div class="col-md-8">
              <br />
              <img src="../../Asset/images/vegeterian_food.jpg" width="10%" height="auto" style="margin-left:100px"/>
              <h4 class="text-danger" style="margin-left:70px">Manage Categories</h4>
          </div>
      </div>
      <div class="row">
          <div class="col-md-4">
            <h2 class="text-danger">Category Details</h2>
             <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Category Name</label>
            <input type="text" class="form-control" id="CatNameTb" runat="server">
             </div>
            <div class="mb-3">
          <label for="exampleInputEmail1" class="form-label">Category Remarks</label>
          <input type="text" class="form-control" id="CatRemarkTb" runat="server">
         </div>
           
        <br /> 
         <asp:Label ID="ErrorMsg" runat="server" ForeColor="Red"></asp:Label>
         <br />

        <asp:Button  class="btn btn-danger"  text="  Edit  " runat="server" ID="Editbtn" OnClick="Editbtn_Click" /> 
        <asp:Button  class="btn btn-danger"  text="  Save  " runat="server" ID="Savebtn" OnClick="Savebtn_Click" /> 
        <asp:Button  class="btn btn-danger"  text="  Delete  " runat="server" ID="Deletebtn" OnClick="Deletebtn_Click" /> 
          </div>
          <div class="col-md-8">
               <asp:GridView runat="server" class="table table-hover"  ID="CategoryGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CategoryGv_SelectedIndexChanged">

               </asp:GridView>
          </div>
      </div>
    </div>

</asp:Content>
