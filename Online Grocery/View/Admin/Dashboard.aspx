<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Online_Grocery.View.Admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
<!-- <h1>Dashboard</h1> -->

<div class="container-fluid">
    <div class="row" style="height:80px">
      <div class="col-md-3"></div>
      <div class="col-md-8">
          <div class="row">
              <div class="col-1"><img  src="../../Asset/images/dashboard_layout.jpg" height="50px" width="50px" style="margin-top:4px" class="rounded"/></div>
              <div class="col-8"><h2 class="text-danger">Glocery  DashBoard</h2></div>
               
          </div>
      </div>
        <div class="cl-md-1"></div>
    </div>
     <div class="row">
          <div class="col-1">.</div>
          <div class="col-10">
              <div class="row">        
                  <div class="col-md-3 bg-danger rounded">
                      <div class="row">
                             <div class="col-md-2"></div>
                             <div class="col-md-10">
                             <h3 class="text-white">Products</h3>
                             <h1 class="text-white" id="PnumTb" runat="server">Num</h1>
                             </div>
                          </div>
                      </div>
                   <div class="col-md-1 bg-light">
                         
                    </div>
                    
                  <div class="col-md-3 bg-warning rounded">
                      <div class="row">
                         <div class="col-md-2"></div>
                        <div class="col-md-10">
                        <h3 class="text-white">Catrgories</h3>
                        <h1 class="text-white" id="CatNumTb" runat="server">Num</h1>
                   </div>
                  </div>
               </div>

                  <div class="col-md-1 bg-light">
                    
                  </div>

                  <div class="col-md-3 bg-primary rounded">
                     <div class="row">
                        <div class="col-md-2"></div>
                          <div class="col-md-10">
                          <h3 class="text-white">Finance</h3>
                          <h1 class="text-white" id="FinanceTb" runat="server">Num</h1>
                       </div>
                     </div>
                 </div>

                  <div class="col-md-1 bg-light">
                     
                  </div>
              </div>
          </div>
         <div class="col-1">.</div>
     </div>
       
      <div class="row mb-5 mt-5"></div>
     <div class="row">
     <div class="col-1"></div>
     <div class="col-10">
         <div class="row"> 
             <div class="col">
                   <div class="mb-2" style="width:200px">
            <asp:DropDownList ID="SellerCb" CssClass="form-control" runat="server" OnSelectedIndexChanged="SellerCb_SelectedIndexChanged"></asp:DropDownList>
                   </div>
             </div>
             </div>
             <div class="col"></div>
             <div class="col"></div>
             <div class="row">
             <div class="col-md-3 bg-info rounded">
                 <div class="row">
                        <div class="col-md-2"></div>
                        <div class="col-md-10">
                        <h5 class="text-white">Categories Amount</h5>
                        <h1 class="text-white" id="CatAmountTb" runat="server">Num</h1>
                        </div>
                     </div>
                 </div>
              <div class="col-md-1 bg-light">
                    
               </div>
               
             <div class="col-md-3 bg-secondary rounded">
                 <div class="row">
                    <div class="col-md-2"></div>
                   <div class="col-md-10">
                   <h3 class="text-white">Total Sell</h3>
                   <h1 class="text-white" id="TotalSellTb" runat="server">Num</h1>
              </div>
             </div>
          </div>

             <div class="col-md-1 bg-light">
               
             </div>

             <div class="col-md-3 bg-danger rounded">
                <div class="row">
                   <div class="col-md-2"></div>
                     <div class="col-md-10">
                     <h3 class="text-white">Seller</h3>
                     <h1 class="text-white" id="SelNumTb" runat="server">Num</h1>
                  </div>
                </div>
            </div>

             <div class="col-md-1 bg-light">
                
             </div>
         </div>
     </div>
    <div class="col-1">.</div>
</div>
                   <asp:Label ID="lbl" runat="server"></asp:Label>

     <div class="row">
        <div class="col-4"></div>
         <div class="col-4">
             <img src="../../Asset/images/Grocery.png" height="250px" style="margin-top:10px; margin-left:50px"/>
         </div>

         <div class="col-4">
             <br />
             <br />

         </div>
     </div>

</div>
</asp:Content>
