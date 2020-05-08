Public Class FormFonts

    Dim pfc As System.Drawing.Text.PrivateFontCollection
    Dim ifc As System.Drawing.Text.InstalledFontCollection

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pfc = New System.Drawing.Text.PrivateFontCollection()
        ifc = New System.Drawing.Text.InstalledFontCollection()

        LoadPrivateFonts({My.Resources.AndroidClock, My.Resources.CutiveMono})
    End Sub

    ''' <summary>Loads the private fonts.</summary>
    ''' <param name="fonts">The fonts to be loaded into the private font collection.</param>
    Private Sub LoadPrivateFonts(ByVal fonts As IEnumerable(Of Byte()))
        For Each resFont In fonts
            pfc.AddMemoryFont(Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement(resFont, 0), resFont.Length)
        Next
    End Sub

    ''' <summary>Gets the FontFamily whose name matches the one specified.</summary>
    ''' <param name="fontName">Name of the FontFamily to be returned.</param>
    ''' <param name="defaultFamily">
    ''' Optional. The default font family to be returned if the specified font is not found
    ''' </param>
    Private Function GetFontFamily(ByVal fontName As String, Optional ByVal defaultFamily As FontFamily = Nothing) As FontFamily
        If String.IsNullOrEmpty(fontName) Then
            Throw New ArgumentNullException("fontName", "The name of the font cannont be null.")
        End If

        Dim foundFonts = From font In ifc.Families.Union(pfc.Families) Where font.Name.ToLower() = fontName.ToLower()

        If foundFonts.Any() Then
            Return foundFonts.First()
        Else
            Return If(defaultFamily, FontFamily.GenericSansSerif)
        End If
    End Function

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'free the resources used by the font collections
        pfc.Dispose()
        ifc.Dispose()
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g = e.Graphics

        Using br As Brush = Brushes.Black
            'g.DrawString("ABCDEF1234567890 Series 60 ZDigi", New Font(GetFontFamily("Series 60 ZDigi"), 18), br, New Point(20, 20))
            'g.DrawString(("ABCDEFGHIJKLMNOP"), (New Font(GetFontFamily("Times New Roman"), 18)), br, (New Point(20, 100)))
            'g.DrawString("ABCDEFGHIJKLMNOP Monotype Corsiva", New Font(GetFontFamily("Monotype Corsiva"), 18), br, New Point(20, 200))

            If cmbFont.SelectedText.Length > 1 Then
                ' g.DrawString("ABCDEFGHIJKLMNOP SELECED FON PAGE", New Font(cmbFont.SelectedText, 18), br, New Point(20, 300))
                ' g.DrawString("ABCDEFGHIJKLMNOP SELECED FON PAGE", New Font(cmbFont.SelectedText, 18), br, New Point(20, 400))
            End If
        End Using
    End Sub

    Private Sub FormFonts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParentMain
        For Each font As FontFamily In FontFamily.Families
            cmbFont.Items.Add(font.Name)
        Next font
        cmbFont.SelectedItem = cmbFont.Items(0)
    End Sub

    Private Sub cmbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFont.SelectedIndexChanged

    End Sub
End Class