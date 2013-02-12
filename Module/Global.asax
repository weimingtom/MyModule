<%@ Application Language="C#" %>
<%@ Import Namespace="MyModule" %>

<script runat="server">

    protected void MyModule_OnMyEvent(Object src, EventArgs e)
    {
        Context.Response.Write("Hola desde MyModule_OnMyEvent llamado desde Global.asax.<br>");
    }
       
</script>
