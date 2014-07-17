<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="data.aspx.cs" Inherits="CTC_Final.Certificates.data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chennai Triathlon e-Certificate</title>

    <script src="jquery.min.js"></script>
    <link href="flat-ui.css" rel="stylesheet" />
    <link href="demo.css" rel="stylesheet" />
    <%-- <link href="../../Layout/bootstrap.min.css" rel="stylesheet" />
     <link href="Layout/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Layout/custom.css" rel="stylesheet" />
    <script src="../../Layout/jquery.min.js"></script>
    <script src="../../Layout/bootstrap.min.js"></script>--%>

    <script type="text/javascript">
        $(document).ready(function () {
            $.ajax({
                type: "GET",
                url: "CTJuly122014.csv",
                dataType: "text",
                success: function (data) {
                    data = processData(data);
                }
            });

        });

        var data = [];
        var lines = [];
        var tempArray = [];
        var output;
        var searchValue;

        function processData(allText) {
            var allTextLines = allText.split(/\r\n|\n/);
            var headers = allTextLines[0].split(',');
            for (var i = 1; i < allTextLines.length; i++) {
                var data = allTextLines[i].split(',');
                if (data.length == headers.length) {
                    var tarr = [];
                    for (var j = 0; j < headers.length; j++) {
                        tarr.push(data[j]);
                    }
                    lines.push(tarr);
                }
            }
        }



        function formSubmit() {
            var value = document.getElementById('bib').value;
            value = value.toUpperCase();
            searchData(lines, value);
            function searchData(data, search) {
                for (i = 0; i < 600; i++) {
                    var pos = $.inArray(search, data[i]);
                    if (pos !== -1) { tempArray.push(data[i]); }
                }
                return tempArray[0][0];

            }

            var c = document.getElementById('canvas');
            var context = c.getContext('2d');
            var backgroundImage = new Image();
            context.clearRect(0, 0, c.width, c.height);
            backgroundImage.onload = function () {
                DrawScreen();
                DrawText();
            };

            backgroundImage.src = "CTJuly122014.png";

            function DrawScreen() {
                context.drawImage(backgroundImage, 0, 0);
            }

            function DrawText() {
                context.fillStyle = "#fff";
                context.font = "25px sans-serif";
                context.textBaseline = 'top';

                var total = document.getElementById("<%= hfTotal.ClientID %>").value;
                var name = document.getElementById("<%= hfName.ClientID %>").value;
                var swim = document.getElementById("<%= hfSwim.ClientID %>").value;
                var cycle = document.getElementById("<%= hfCycle.ClientID %>").value;
                var run = document.getElementById("<%= hfRun.ClientID %>").value;
                var category = document.getElementById("<%= hfCategory.ClientID %>").value;

                //Name
                alert(name);
                context.fillText(name, 275, 340);
                //swim	
                context.fillText(swim, 200, 600);
                //cycle
                context.fillText(cycle, 388, 600);
                //run
                context.fillText(run, 575, 600);

                context.fillStyle = "#A0A0A2";
                context.font = "20px sans-serif";
                context.textBaseline = 'top';

                //Total time
                context.fillText("in " + total + " Hrs ", 450, 500);
                //Category
                alert(category);
                context.fillText("under " + category + " category ", 210, 500);
            }

            var canvasTag = document.getElementById("canvas");
            var data = canvasTag.toDataURL("image/png");
            canvasTag.style.display = "block";

            document.getElementById('download').style.display = "inline-block";


            document.getElementById('download').addEventListener('click', function () {
                downloadCanvas(this, 'canvas', 'ChennaiTrailMarathon' + tempArray[0][0] + '.png');
            }, false);

            function downloadCanvas(link, canvasId, filename) {
                link.href = document.getElementById(canvasId).toDataURL();
                link.download = filename;
            }
        }

    </script>



    <style type="text/css">
        .navbar-inverse {
            background-color: #34495e;
            border-color: #080808;
        }

            .navbar-inverse .navbar-brand {
                color: #fff;
            }

            .navbar-inverse .navbar-nav > li > a {
                color: #fff;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<asp:Label ID="lbldata" runat="server" ></asp:Label>--%>
            <asp:HiddenField ID="hfName" runat="server" />
            <asp:HiddenField ID="hfSwim" runat="server" />
            <asp:HiddenField ID="hfCycle" runat="server" />
            <asp:HiddenField ID="hfRun" runat="server" />
            <asp:HiddenField ID="hfTotal" runat="server" />
            <asp:HiddenField ID="hfCategory" runat="server" />
            <div>
                 <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" OnClientClick="formSubmit()" class="submit-btn btn btn-block btn-lg btn-primary"  />
                <center>
     <h1 class="demo-section-title">Chennai Trekking Club Chennai Triathlon July 12, 2014</h1>
      <p>Supported only in Chrome and Mozilla Firefox browsers</p>
      <p>
          <%--<input type="text" value="" placeholder="Your BIB" id="bib" class="form-control" />--%>
          <asp:TextBox placeholder="Your BIB" ID="txtbib" class="form-control" runat="server"></asp:TextBox>
          
         
          
          <%--<input type="button" onclick="formSubmit()" value="Submit" class="submit-btn btn btn-block btn-lg btn-primary" />--%></p>
      <a id="download" class="btn btn-block btn-lg btn-danger" style="display:none;">Download Certificate</a>
      <canvas id="canvas" width="798" height="855" style="display:none;"></canvas>
</center>
            </div>

        </div>
    </form>
</body>
</html>
