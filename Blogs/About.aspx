<%@ Page Title="简介" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Blogs.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container about">
        <h1>Hello, My name is <span class="about-bold">John Doe</span></h1>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Repellendus inventore magni ratione perferendis ex molestiae cum reiciendis perspiciatis consequuntur, nihil ducimus corrupti! Ipsum nesciunt ipsa nobis obcaecati labore, rem recusandae?</p>
        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Qui quo sint asperiores, ut doloremque eum commodi, odit nisi sed repellendus earum recusandae pariatur consectetur minus rerum, magni dolores officiis magnam.</p>
        <a href="WorkEvent.html" target="_blank">工作经历</a>
        <div class="about-button">
            <a class="btn btn-xlarge btn-clean-one" href="/contact">Contact Me</a>
        </div>
        <hr>        
    </div>
</asp:Content>
