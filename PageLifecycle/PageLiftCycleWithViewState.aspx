﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageLiftCycleWithViewState.aspx.cs" Inherits="PageLiftCycleWithViewState" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
