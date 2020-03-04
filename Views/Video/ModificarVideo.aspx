<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> ModificarVideo </title>
</head>
<body>
  
    <form action="/Video/ModificarVideo" method="post">
    <fieldset>
    <legend> Modificar Datos del Video </legend>

    <label for="idVideo">idVideo:</label>
    <input type="text" name="idVideo" />

    <label for="Titulo">Titulo:</label>
    <input type="text" name="Titulo" />

    <label for="numRepro">Num.Reproducciones:</label>
    <input type="text" name="numRepro" />

    <label for="urll">Url:</label>
    <input type="text" name="urll" />

    <input type="submit" value= "Modificar" />

    </fieldset>
    </form>
</body>
</html>
