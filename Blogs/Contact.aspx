<%@ Page Title="Follow Me" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Blogs.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
          <div class="container">
            <div class="row" style="background: white;opacity: 0.8;">
                <div class="col-md-6 col-md-offset-3 clean-superblock" id="contact">
                    <h2>Follow Me</h2>
                    
                    <form action="#" method="get" accept-charset="utf-8" class="contact-form">
                        <input type="text" name="name" id="contact-name" placeholder="Name" class="form-control input-lg">
                        <input type="email" name="email" id="contact-email" placeholder="Email" class="form-control input-lg">
                        <textarea rows="10" name="message" id="contact-body" placeholder="Your Message" class="form-control input-lg"></textarea>
                        <div class="buttons clearfix">
                            <button type="submit" class="btn btn-xlarge btn-clean-one">Submitaa</button>
                        </div>                    
                    </form>
                </div>
            </div>        
        </div>
</asp:Content>
