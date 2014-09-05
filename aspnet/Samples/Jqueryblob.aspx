<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jqueryblob.aspx.cs" Inherits="aspnet.Samples.Jqueryblob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.8.2.min.js"></script>
    <script type="text/javascript">

        $(function () {
            $('#fileInput').change(function () {
             
                var requestHeaders = {
                    "x-ms-blob-type": "BlockBlob",
                }
                var file = ($('#fileInput'))[0].files[0];

                var uri = "https://jamborstorage.blob.core.windows.net/sascontainer?sv=2014-02-14&sr=c&sig=HaD3DPQYd%2FQMJnuvYRafx0NuQQWSm0ZelODLxbyjEWI%3D&se=2014-09-03T09%3A43%3A28Z&sp=wl";
                var reader = new FileReader()
                var text = '';
                reader.readAsArrayBuffer(file);
                reader.onload = function (evt) {

                    if (evt.target.readyState == FileReader.DONE) {

                        var requestData = new Uint8Array(evt.target.result);

                        $.ajax({
                            url: uri,
                            type: "PUT",
                            //data: requestData,
                            //beforeSend: function (xhr) {
                            //    xhr.setRequestHeader('x-ms-blob-type', 'BlockBlob');
                            //    xhr.setRequestHeader('Content-Length', requestData.length);
                            //},
                            data: 'Hello, World!',
                            headers: {'Content-Type': 'text/html'},
                            //processData: false,

                            success: function (data, status) {
                                alert('successful');
                            },
                            error: function (xhr, desc, err) {
                                alert('error');
                            }

                        })
                    }
                }

              
            })
        })

      
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="fileInput" type="file" />
    </div>
    </form>
</body>
</html>
