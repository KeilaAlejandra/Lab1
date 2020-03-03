<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> VISTA DEL CONTROLADOR DE VIDEOS </title>
</head>
<body>
    <h1>LISTA DE VIDEOS</h1>
    Hay<%:((System.Data.DataTable)ViewData["DataVideo"]).Rows.Count%>Video
    <hr />
    <%foreach (System.Data.DataRow Video
          in ((System.Data.DataTable)ViewData["DataVideo"]).Rows)
      {%> 
    <p> <%:Video["Titulo"].ToString()%></p>
    <iframe width="560" height="315" src="<%:Video["urll"].ToString() %>" 
    frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope;
    picture-in-picture" allowfullscreen></iframe>
    <%
      } %>

</body>
</html>
