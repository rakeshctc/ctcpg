﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ecertificte_CT.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chennai Triathlon e-Certificate</title>

    <script src="jquery.min.js"></script>
    <link href="flat-ui.css" rel="stylesheet" />
    <link href="demo.css" rel="stylesheet" />

    <script type="text/javascript">
        $(document).ready(function () {
            $.ajax({
                type: "GET",
                url: "CTC_Tri_Dec_15_2013.csv",
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

            backgroundImage.src = "CTC_Tri_Dec_15_2013.png";

            function DrawScreen() {
                context.drawImage(backgroundImage, 0, 0);
            }

            function DrawText() {
                context.fillStyle = "#fff";
                context.font = "25px sans-serif";
                context.textBaseline = 'top';
                //Name
                context.fillText(tempArray[0][1], 255, 340);
                //swim	
                context.fillText(tempArray[0][2], 180, 600);
                //cycle
                context.fillText(tempArray[0][3], 360, 600);
                //run
                context.fillText(tempArray[0][4], 540, 600);

                context.fillStyle = "#A0A0A2";
                context.font = "20px sans-serif";
                context.textBaseline = 'top';

                //Total time
                //context.fillText("in "+tempArray[0][5]+" Hrs ",450, 500 );
                //Category
                context.fillText("under " + tempArray[0][5] + " category ", 210, 500);
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
    


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
     <h1 class="demo-section-title">Chennai Trekking Club Triathlon Mar 29, 2014</h1>
      <p>Supported only in Chrome and Mozilla Firefox browsers</p>
      <p><input type="text" value="" placeholder="Your BIB" id="bib" class="form-control" /><input type="button" onclick="formSubmit()" value="Submit" class="submit-btn btn btn-block btn-lg btn-primary" /></p>
      <a id="download" class="btn btn-block btn-lg btn-danger" style="display:none;">Download Certificate</a>
      <canvas id="canvas" width="798" height="855" style="display:none;"></canvas>
</center>
        </div>
    </form>
</body>
</html>
