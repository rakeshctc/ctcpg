<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="July13.aspx.cs" Inherits="CTC_Final.Certificates.CTJuly132014.July13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">




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
                url: "CTJuly132014.csv",
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

            backgroundImage.src = "CTJuly132014.png";

            function DrawScreen() {
                context.drawImage(backgroundImage, 0, 0);
            }

            function DrawText() {
                context.fillStyle = "#fff";
                context.font = "25px sans-serif";
                context.textBaseline = 'top';
                //Name
                context.fillText(tempArray[0][1], 275, 340);
                //swim	
                context.fillText(tempArray[0][2], 200, 600);
                //cycle
                context.fillText(tempArray[0][3], 388, 600);
                //run
                context.fillText(tempArray[0][4], 575, 600);

                context.fillStyle = "#A0A0A2";
                context.font = "20px sans-serif";
                context.textBaseline = 'top';

                //Total time
                context.fillText("in " + tempArray[0][5] + " Hrs ", 460, 500);
                //Category
                context.fillText("under " + tempArray[0][6] + " category ", 210, 500);
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
    <form id="formJuly13" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <%-- <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>--%>
                    <a class="navbar-brand">
                        <%-- <img id="imgLogo" src="Images/Chennai_Trekking_Club.jpg" style="height: 35px; width: 35px; margin-top: -7px;" />
                        Chennai Trekking Club</a>--%>
                        <img id="imgLogo" src="../../Images/123.png" style="height: 50px; width: 100px;" />
                        Chennai Trekking Club</a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <ul class="nav navbar-nav  text-right">
                            <li><a href="#"></a>
                            </li>
                            <li><a href="#"></a>
                            </li>
                            <li><a href="#"></a>
                            </li>
                            <li><a href="#"></a>
                            </li>

                            <li><a href="Default.aspx">Home</a>
                            </li>

                            <li><a href="eCertificate.aspx" target="_blank">Certificate</a>
                            </li>

                            <li><a href="FAQ.aspx" target="_blank">FAQ</a>
                            </li>
                            <li><a href="TermsandConditions.aspx" target="_blank">Terms & Condition</a>
                            </li>
                            <li><a href="Support.aspx" target="_blank">Support</a>
                            </li>
                            <%--<li><a href="Login.aspx" target="_blank">Log-In   </a>
                            </li>--%>
                        </ul>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>

        <div>
            <center>
     <h1 class="demo-section-title">Chennai Trekking Club Chennai Triathlon July 13, 2014</h1>
      <p>Supported only in Chrome and Mozilla Firefox browsers</p>
      <p><input type="text" value="" placeholder="Your BIB" id="bib" class="form-control" /><input type="button" onclick="formSubmit()" value="Submit" class="submit-btn btn btn-block btn-lg btn-primary" /></p>
      <a id="download" class="btn btn-block btn-lg btn-danger" style="display:none;">Download Certificate</a>
      <canvas id="canvas" width="798" height="855" style="display:none;"></canvas>
</center>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <!-- /footer container -->
        <footer id="footer">
            <div class="container text-center" style="text-align: center; width: 100%">
                <asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="window.open('TermsandConditions.aspx'); " ForeColor="Black" Target="_blank">Terms</asp:LinkButton>
                |
                <asp:LinkButton ID="LinkButton3" runat="server" OnClientClick="window.open('aboutUs.aspx'); " ForeColor="Black" Target="_blank">About Us</asp:LinkButton>
                <br />
                <br />
                <p class="text-muted">Developed by Ittitudeworks.com</p>
            </div>
        </footer>
    </form>
</body>
</html>
