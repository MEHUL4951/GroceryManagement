<%@ Page Title="" Language="C#" MasterPageFile="~/View/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="Online_Grocery.View.Seller.Billing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script type="text/javascript">
    function PrintPanel(){
          var PGrid = document.getElementById('<%=BillGV.ClientID %>');
          PGrid.border = 0;
          var Pwin  = window.open('','PrintGrid','left=100,top=100,width=1024,height=768,tollbar=0,scrollbars=1,status = 0 , resizeable = 1');
          Pwin.document.write(PGrid.outerHTML);
          Pwin.document.close();
          Pwin.focus();
          Pwin.print();
          Pwin.close();
       }
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

    <div class="container-fluid">
        <div class="container">
            <div class="row">
                <div class="col-md-5">
                    <div class="row">
                        <div class="col">
                            <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Product Name</label>
                                <input type="text" class="form-control" id="PnameTb" runat="server" required="required" />
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Product Price</label>
                                <input type="text" class="form-control" id="PrPrice" runat="server" required="required"/>
                            </div>
                            <div class="mb-3">
                                <label for="exampleInputEmail1" class="form-label">Product Qty</label>
                                <input type="text" class="form-control" id="PrQty" runat="server" required="required" />
                            </div>
                        </div>

                        <div class="col">
                            <img src="../../Asset/images/check_dollar.jpg" height="100px" width="130px" /><br />
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="ErrorMsg" runat="server" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:Button class="btn btn-warning" Text="Add To Bill" runat="server" ID="AddToBillBtn" OnClick="AddToBillBtn_Click" />
                            <asp:Button class="btn btn-danger" Text="Reset" runat="server" ID="ResetBtn" />
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col">
                            <asp:GridView runat="server" class="table table-hover" ID="ProductGv" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ProductGv_SelectedIndexChanged">
                            </asp:GridView>
                        </div>
                    </div>
                </div>
                <div class="col-md-7">
                    <div class="row">
                        <div class="col-3"></div>
                        <div class="col">
                            <h1 class="text-warning pl-2">Client Billing</h1>
                        </div>
                    </div>
                     <div class="row">
                         <asp:GridView ID="BillGV" runat="server" class="table">

                         </asp:GridView>
                     </div>
                    <div class="row">
                        <div></div>
                        <div class="col"><h3 class="text-danger" id="GridTotTb" runat="server"></h3></div>
                        <div>
                         <asp:Button class="btn btn-warning btn-block text-white" Text="Print Bill" runat="server" ID="PrintBtn"  OnClientClick="PrintPanel()" OnClick="PrintBtn_Click"/>
                        </div>
                    </div>
                </div>
                 

            </div>
         </div>
    </div>
</asp:Content>
