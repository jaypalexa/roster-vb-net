Option Explicit On
Option Strict On
Option Compare Text

Public Class LatLonMapForm

    Private moLatLonMapItems As LatLonMapItems = Nothing
    Private mdStartingLatitudeDecimalDegrees As Double = 0
    Private mdStartingLongitudeDecimalDegrees As Double = 0

    Public Sub New(ByVal oLatLonMapItems As LatLonMapItems, ByVal oFormIcon As System.Drawing.Icon, Optional ByVal sApplicationProductName As String = "", Optional ByVal dStartingLatitudeDecimalDegrees As Double = 0, Optional ByVal dStartingLongitudeDecimalDegrees As Double = 0)

        '----------------------------------------------------------------
        '-- the very first thing we must do is call the base class constructor
        '----------------------------------------------------------------
        MyBase.New()

        '----------------------------------------------------------------
        '-- this call is required by the Windows Form Designer
        '----------------------------------------------------------------
        InitializeComponent()

        '*** ASSERTIONS ***
        'If (oLatLonMapItems Is Nothing) OrElse (oLatLonMapItems.Count = 0) Then
        '    Throw New ArgumentNullException("oLatLonMapItems", "Must have at least one latitude/longitude point to map.")
        'End If
        If (oLatLonMapItems Is Nothing) Then
            oLatLonMapItems = New LatLonMapItems()
        End If
        '*** ASSERTIONS ***

        Me.Icon = oFormIcon

        If Not String.IsNullOrEmpty(sApplicationProductName) Then
            Me.Text = sApplicationProductName & " - Latitude/Longitude Map"
        Else
            Me.Text = "Latitude/Longitude Map"
        End If

        moLatLonMapItems = oLatLonMapItems

        mdStartingLatitudeDecimalDegrees = dStartingLatitudeDecimalDegrees
        mdStartingLongitudeDecimalDegrees = dStartingLongitudeDecimalDegrees

    End Sub

    Private Sub LatLonMapForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '*** ASSERTIONS ***
        'If (moLatLonMapItems Is Nothing) OrElse (moLatLonMapItems.Count = 0) Then
        '    Me.Close()
        '    Exit Sub
        '    'Throw New ArgumentNullException("oLatLonMapItems", "Must have at least one latitude/longitude point to map.")
        'End If
        '*** ASSERTIONS ***

        Dim sb As New System.Text.StringBuilder()

        '----------------------------------------------------------------
        '-- if we were not passed in a center point, 
        '-- create the map and center it at the first point (if any)
        '----------------------------------------------------------------
        If (mdStartingLatitudeDecimalDegrees = 0) AndAlso (mdStartingLongitudeDecimalDegrees = 0) AndAlso (moLatLonMapItems.Count > 0) Then
            If (0 <= moLatLonMapItems(0).LatitudeDecimalDegrees) AndAlso (moLatLonMapItems(0).LatitudeDecimalDegrees <= 90) _
            AndAlso (-180 <= moLatLonMapItems(0).LongitudeDecimalDegrees) AndAlso (moLatLonMapItems(0).LongitudeDecimalDegrees <= 180) Then
                mdStartingLatitudeDecimalDegrees = moLatLonMapItems(0).LatitudeDecimalDegrees
                mdStartingLongitudeDecimalDegrees = moLatLonMapItems(0).LongitudeDecimalDegrees
            Else
                mdStartingLatitudeDecimalDegrees = 0
                mdStartingLongitudeDecimalDegrees = 0
            End If
        End If

        ''----------------------------------------------------------------
        ''-- map via GOOGLE
        ''----------------------------------------------------------------
        'sb.Append("http://maps.google.com/maps?q=")
        'If Not String.IsNullOrEmpty(msLatitudeDecimalDegrees) Then
        '    sb.Append(msLatitudeDecimalDegrees & ",")
        'End If
        'If Not String.IsNullOrEmpty(msLongitudeDecimalDegrees) Then
        '    sb.Append(msLongitudeDecimalDegrees)
        'End If
        'If Not String.IsNullOrEmpty(msFieldNumber) Then
        '    sb.Append("+" & "(" & msFieldNumber & ")")
        'End If
        'sb.Append("&z=9&t=h&ie=UTF8&iwloc=A&om=0")
        'Me.webWebBrowser.Navigate(sb.ToString())

        '----------------------------------------------------------------
        '-- map via WINDOWS LIVE SEARCH
        '----------------------------------------------------------------
        sb.Append("<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">")
        sb.Append("<html>")
        sb.Append("<head>")
        sb.Append("<title>Stranded Turtle Map</title>")
        sb.Append("<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"">")
        sb.Append("<script type=""text/javascript"" src=""http://dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6""></script>")
        sb.Append("<script type=""text/javascript"">")
        sb.Append("var map = null;")
        sb.Append("var shapeLayer = new VEShapeLayer();")
        sb.Append("var shapes = new Array();")
        sb.Append("function GetMap()")
        sb.Append("{")
        sb.Append("map = new VEMap('myMap');")

        sb.Append("map.LoadMap(new VELatLong(" & Convert.ToString(mdStartingLatitudeDecimalDegrees) & "," & Convert.ToString(mdStartingLongitudeDecimalDegrees) & "), 9, VEMapStyle.Hybrid, false);")
        sb.Append("map.AddShapeLayer(shapeLayer);")

        For Each oLatLonMapItem As LatLonMapItem In moLatLonMapItems

            If (0 <= oLatLonMapItem.LatitudeDecimalDegrees) AndAlso (oLatLonMapItem.LatitudeDecimalDegrees <= 90) _
            AndAlso (-180 <= oLatLonMapItem.LongitudeDecimalDegrees) AndAlso (oLatLonMapItem.LongitudeDecimalDegrees <= 180) Then

                sb.Append("shape = new VEShape(VEShapeType.Pushpin, new VELatLong(" & String.Format("{0:##.0000}", oLatLonMapItem.LatitudeDecimalDegrees) & "," & String.Format("{0:##.0000}", oLatLonMapItem.LongitudeDecimalDegrees) & "));")

                If Not String.IsNullOrEmpty(oLatLonMapItem.Title) Then
                    sb.Append("shape.SetTitle('" & oLatLonMapItem.Title.Replace("'", "\'") & "');")
                Else
                    sb.Append("shape.SetTitle('Latitude:  " & String.Format("{0:##.0000}", oLatLonMapItem.LatitudeDecimalDegrees) & "<br>Longitude:  " & String.Format("{0:##.0000}", oLatLonMapItem.LongitudeDecimalDegrees) & "');")
                End If

                If Not String.IsNullOrEmpty(oLatLonMapItem.Description) Then
                    sb.Append("shape.SetDescription('" & oLatLonMapItem.Description.Replace("'", "\'") & "');")
                End If

                sb.Append("shapes.push(shape);")

            End If

        Next

        sb.Append("shapeLayer.AddShape(shapes);")
        sb.Append("}")
        sb.Append("</script>")
        sb.Append("</head>")
        sb.Append("<body onload=""GetMap();"">")
        sb.Append("<div id='myMap' style=""position:absolute; top:0; left:0; width:" & (Me.webWebBrowser.Width - 20).ToString & "px; height:" & (Me.webWebBrowser.Height - 10).ToString & "px;""></div>")
        sb.Append("</body>")
        sb.Append("</html>")

        Me.webWebBrowser.DocumentText = sb.ToString()

    End Sub

    Private Sub LatLonMapForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        '----------------------------------------------------------------
        '-- if the <ESCAPE> key was been pressed, 
        '-- react as if the Cancel button was pressed
        '----------------------------------------------------------------
        If (e.KeyCode = Keys.Escape) Then

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        End If

    End Sub

    Private Sub webWebBrowser_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles webWebBrowser.StatusTextChanged
        Me.lblStatus.Text = Me.webWebBrowser.StatusText
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Me.webWebBrowser.ShowPrintPreviewDialog()

    End Sub

End Class