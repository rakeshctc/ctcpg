<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetCertificate.aspx.cs" Inherits="CTC_Final.Certificates.Test.GetCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chennai Triathlon e-Certificate</title>

    <meta property='og:title' content='Chennai Triathlon' />

    <meta property='og:type' content='article' />

    <meta property='og:image' content='http://www.chennaitrekkingclubevents.org/Certificates/test/GetCertificate.aspx?abc=B7394F0C-828D-41D5-9E1C-EF50A1C67F83' />

    <meta property='og:url' content='http://www.chennaitrekkers.org' />

    <meta property='og:description' content='Chennai Triathlon' />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>

    <script type="text/javascript">var switchTo5x = true;</script>
    <script type="text/javascript" src="http://w.sharethis.com/button/buttons.js"></script>
    <script type="text/javascript">stLight.options({ publisher: "10341a17-131b-4e9f-be6c-ec6069b8cf66", doNotHash: false, doNotCopy: false, hashAddressBar: false });</script>

    <link href="flat-ui.css" rel="stylesheet" />
    <link href="demo.css" rel="stylesheet" />

    <script type="text/javascript">
        var data = [];
        var lines = [];
        var tempArray = [];
        var output;
        var searchValue;

        function formSubmit() {

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
                context.fillText("under " + category + " category ", 210, 500);
                var canvasTag = document.getElementById("canvas");
                var data = canvasTag.toDataURL("image/png");
                canvasTag.style.display = "block";

                document.getElementById('download').style.display = "inline-block";

                downloadCanvas(this, 'canvas', 'ChennaiTrailMarathon.png');
            }

           


            document.getElementById('download').addEventListener('click', function () {
                

            }, false);

            function downloadCanvas(link, canvasId, filename) {
                link.href = document.getElementById(canvasId).toDataURL();
                link.download = filename;
            }
        }

    </script>


</head>
<body onload="formSubmit();">
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfName" runat="server" />
            <asp:HiddenField ID="hfSwim" runat="server" />
            <asp:HiddenField ID="hfCycle" runat="server" />
            <asp:HiddenField ID="hfRun" runat="server" />
            <asp:HiddenField ID="hfTotal" runat="server" />
            <asp:HiddenField ID="hfCategory" runat="server" />
            <div>
                <center>
     <h1 class="demo-section-title">Chennai Trekking Club Chennai Triathlon July 12, 2014</h1>
      <p>Supported only in Chrome and Mozilla Firefox browsers</p>
      <p>
      <a id="download" class="btn btn-block btn-lg btn-danger" style="display:none;">Download Certificate</a>
      <canvas id="canvas" width="798" height="855" style="display:none;"></canvas>
          <span class='st_facebook_large' displayText='Facebook'></span>
<span class='st_googleplus_large' displayText='Google +'></span>
<span class='st_twitter_large' displayText='Tweet'></span>
<span class='st_linkedin_large' displayText='LinkedIn'></span>
<span class='st_pinterest_large' displayText='Pinterest'></span>
<span class='st_email_large' displayText='Email'></span>
</center>
            </div>

        </div>
    </form>
</body>
</html>
