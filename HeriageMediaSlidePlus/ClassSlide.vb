
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient

Public Class ClassSlide
    Public Delegate Sub OnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs)
    Public Event myEventOnPropertyChanged(ByVal sende As Object, e As ClassAnswerEventArgs) 'support for events

    Private backgrounImageFileNameValue As String
    Private _previewImageFileName As String
    Private slideStrValue As String
    Private fontValue As New Font("Arial", 50, FontStyle.Bold)
    Private songValue As String()
    Private songfileNameValue As String
    Private _bibleVersion As String
    Private _NetConneced As Boolean
    Private _bibleBook As String
    Private _bibleChapter As String
    Private _bibleVerse As String
    Private _prevBibleBook As String
    Private _prevBibleChapter As String
    Private _prevBibleVerse As String
    Private _prevBibleVersion As String
    Private _bibleChaptersAbbr As String() = {"Gen", "Exo", "Lev", "Num", "Deu", "Jos", "Jud", "Rut", "1 Sam", "2 Sam", "1 Kin", "2 Kin", "1 Chr", "2 Chr", "Ezr", "Neh", "Est", "Job", "Psa", "Pro", "Ecc", "Son", "Isa", "Jer", "Lam", "Eze", "Dan", "Hos", "Joe", "Amo", "Oba", "Jon", "Mic", "Nah", "Hab", "Zep", "Hag", "Zec", "Mal", "Mat", "Mar", "Luk", "Joh", "Act", "Rom", "1 Cor", "2 Cor", "Gal", "Eph", "Phi", "Col", "1 The", "2 The", "1 Tim", "2 Tim", "Tit", "Phi", "Heb", "Jam", "1 Pet", "2 Pet", "1 Joh", "2 Joh", "3 Joh", "Jude", "Rev"}
    Private _bibleChaptersFull As String() = {"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "Song of Songs", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter", "2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation"}
    Private _bibleMaxChapter As Integer() = {50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22}
    Private _bibleMaxVerse As Integer() = {67, 51, 59, 89, 68, 63, 57, 23, 58, 51, 66, 44, 81, 42, 70, 73, 32, 41, 176, 36, 29, 17, 38, 64, 66, 63, 49, 23, 32, 27, 21, 17, 20, 19, 20, 20, 23, 23, 18, 75, 72, 80, 71, 60, 39, 58, 33, 31, 33, 30, 29, 28, 18, 25, 26, 16, 25, 40, 27, 25, 22, 29, 13, 14, 25, 29}
    Private _bibleMaxVersesPerChapter As Integer() = {31, 25, 24, 26, 32, 22, 24, 22, 29, 32, 32, 20, 18, 24, 21, 16, 27, 33, 38, 18, 34, 24, 20, 67, 34, 35, 46, 22, 35, 43, 55, 32, 20, 31, 29, 43, 36, 30, 23, 23, 57, 38, 34, 34, 28, 34, 31, 22, 33, 26, 22, 25, 22, 31, 23, 30, 25, 32, 35, 29, 10, 51, 22, 31, 27, 36, 16, 27, 25, 26, 36, 31, 33, 18, 40, 37, 21, 43, 46, 38, 18, 35, 23, 35, 35, 38, 29, 31, 43, 38, 17, 16, 17, 35, 19, 30, 38, 36, 24, 20, 47, 8, 59, 57, 33, 34, 16, 30, 37, 27, 24, 33, 44, 23, 55, 46, 34, 54, 34, 51, 49, 31, 27, 89, 26, 23, 36, 35, 16, 33, 45, 41, 50, 13, 32, 22, 29, 35, 41, 30, 25, 18, 65, 23, 31, 40, 16, 54, 42, 56, 29, 34, 13, 46, 37, 29, 49, 33, 25, 26, 20, 29, 22, 32, 32, 18, 29, 23, 22, 20, 22, 21, 20, 23, 30, 25, 22, 19, 19, 26, 68, 29, 20, 30, 52, 29, 12, 18,
                                                      24, 17, 24, 15, 27, 26, 35, 27, 43, 23, 24, 33, 15, 63, 10, 18, 28, 51, 9, 45, 34, 16, 33, 36, 23, 31, 24, 31, 40, 25, 35, 57, 18, 40, 15, 25, 20, 20, 31, 13, 31, 30, 48, 25, 22, 23, 18, 22, 28, 36, 21, 22, 12, 21, 17, 22, 27, 27, 15, 25, 23, 52, 35, 23, 58, 30, 24, 42, 15, 23, 29, 22, 44, 25, 12, 25, 11, 31, 13, 27, 32, 39, 12, 25, 23, 29, 18, 13, 19, 27, 31, 39, 33, 37, 23, 29, 33, 43, 26, 22, 51, 39, 25, 53, 46, 28, 34, 18, 38, 51, 66, 28, 29, 43, 33, 34, 31, 34, 34, 24, 46, 21, 43, 29, 53, 18, 25, 27, 44, 27, 33, 20, 29, 37, 36, 21, 21, 25, 29, 38, 20, 41, 37, 37, 21, 26, 20, 37, 20, 30, 54, 55, 24, 43, 26, 81, 40, 40, 44, 14, 47, 40, 14, 17, 29, 43, 27, 17, 19, 8, 30, 19, 32, 31, 31, 32, 34, 21, 30, 17, 18, 17, 22, 14, 42, 22, 18, 31,
                                                      19, 23, 16, 22, 15, 19, 14, 19, 34, 11, 37, 20, 12, 21, 27, 28, 23, 9, 27, 36, 27, 21, 33, 25, 33, 27, 23, 11, 70, 13, 24, 17, 22, 28, 36, 15, 44, 11, 20, 32, 23, 19, 19, 73, 18, 38, 39, 36, 47, 31, 22, 23, 15, 17, 14, 14, 10, 17, 32, 3, 22, 13, 26, 21, 27, 30, 21, 22, 35, 22, 20, 25, 28, 22, 35, 22, 16, 21, 29, 29, 34, 30, 17, 25, 6, 14, 23, 28, 25, 31, 40, 22, 33, 37, 16, 33, 24, 41, 30, 24, 34, 17, 6, 12, 8, 8, 12, 10, 17, 9, 20, 18, 7, 8, 6, 7, 5, 11, 15, 50, 14, 9, 13, 31, 6, 10, 22, 12, 14, 9, 11, 12, 24, 11, 22, 22, 28, 12, 40, 22, 13, 17, 13, 11, 5, 26, 17, 11, 9, 14, 20, 23, 19, 9, 6, 7, 23, 13, 11, 11, 17, 12, 8, 12, 11, 10, 13, 20, 7, 35, 36, 5, 24, 20, 28, 23, 10, 12, 20, 72, 13, 19, 16, 8, 18, 12, 13, 17, 7, 18, 52, 17, 16, 15,
                                                      5, 23, 11, 13, 12, 9, 9, 5, 8, 28, 22, 35, 45, 48, 43, 13, 31, 7, 10, 10, 9, 8, 18, 19, 2, 29, 176, 7, 8, 9, 4, 8, 5, 6, 5, 6, 8, 8, 3, 18, 3, 3, 21, 26, 9, 8, 24, 13, 10, 7, 12, 15, 21, 10, 20, 14, 9, 6, 33, 22, 35, 27, 23, 35, 27, 36, 18, 32, 31, 28, 25, 35, 33, 33, 28, 24, 29, 30, 31, 29, 35, 34, 28, 28, 27, 28, 27, 33, 31, 18, 26, 22, 16, 20, 12, 29, 17, 18, 20, 10, 14, 17, 17, 11, 16, 16, 13, 13, 14, 31, 22, 26, 6, 30, 13, 25, 22, 21, 34, 16, 6, 22, 32, 9, 14, 14, 7, 25, 6, 17, 25, 18, 23, 12, 21, 13, 29, 24, 33, 9, 20, 24, 17, 10, 22, 38, 22, 8, 31, 29, 25, 28, 28, 25, 13, 15, 22, 26, 11, 23, 15, 12, 17, 13, 12, 21, 14, 21, 22, 11, 12, 19, 12, 25, 24, 19, 37, 25, 31, 31, 30, 34, 22, 26, 25, 23, 17, 27, 22, 21, 21, 27, 23, 15, 18, 14,
                                                      30, 40, 10, 38, 24, 22, 17, 32, 24, 40, 44, 26, 22, 19, 32, 21, 28, 18, 16, 18, 22, 13, 30, 5, 28, 7, 47, 39, 46, 64, 34, 22, 22, 66, 22, 22, 28, 10, 27, 17, 17, 14, 27, 18, 11, 22, 25, 28, 23, 23, 8, 63, 24, 32, 14, 49, 32, 31, 49, 27, 17, 21, 36, 26, 21, 26, 18, 32, 33, 31, 15, 38, 28, 23, 29, 49, 26, 20, 27, 31, 25, 24, 23, 35, 21, 49, 30, 37, 31, 28, 28, 27, 27, 21, 45, 13, 11, 23, 5, 19, 15, 11, 16, 14, 17, 15, 12, 14, 16, 9, 20, 32, 21, 15, 16, 15, 13, 27, 14, 17, 14, 15, 21, 17, 10, 10, 11, 16, 13, 12, 13, 15, 16, 20, 15, 13, 19, 17, 20, 19, 18, 15, 20, 15, 23, 21, 13, 10, 14, 11, 15, 14, 23, 17, 12, 17, 14, 9, 21, 14, 17, 18, 6, 25, 23, 17, 25, 48, 34, 29, 34, 38, 42, 30, 50, 58, 36, 39, 28, 27, 35, 30, 34, 46, 46, 39, 51, 46, 75,
                                                      66, 20, 45, 28, 35, 41, 43, 56, 37, 38, 50, 52, 33, 44, 37, 72, 47, 20, 80, 52, 38, 44, 39, 49, 50, 56, 62, 42, 54, 59, 35, 35, 32, 31, 37, 43, 48, 47, 38, 71, 56, 53, 51, 25, 36, 54, 47, 71, 53, 59, 41, 42, 57, 50, 38, 31, 27, 33, 26, 40, 42, 31, 25, 26, 47, 26, 37, 42, 15, 60, 40, 43, 48, 30, 25, 52, 28, 41, 40, 34, 28, 41, 38, 40, 30, 35, 27, 27, 32, 44, 31, 32, 29, 31, 25, 21, 23, 25, 39, 33, 21, 36, 21, 14, 23, 33, 27, 31, 16, 23, 21, 13, 20, 40, 13, 27, 33, 34, 31, 13, 40, 58, 24, 24, 17, 18, 18, 21, 18, 16, 24, 15, 18, 33, 21, 14, 24, 21, 29, 31, 26, 18, 23, 22, 21, 32, 33, 24, 30, 30, 21, 23, 29, 23, 25, 18, 10, 20, 13, 18, 28, 12, 17, 18, 20, 15, 16, 16, 25, 21, 18, 26, 17, 22, 16, 15, 15, 25, 14, 18, 19, 16, 14, 20, 28, 13, 28,
                                                      39, 40, 29, 25, 27, 26, 18, 17, 20, 25, 25, 22, 19, 14, 21, 22, 18, 10, 29, 24, 21, 21, 13, 14, 25, 20, 29, 22, 11, 14, 17, 17, 13, 21, 11, 19, 17, 18, 20, 8, 21, 18, 24, 21, 15, 27, 21}
    Private _bibleCummSumOfChapters As Integer() = {50, 90, 117, 153, 187, 211, 232, 236, 267, 291, 313, 338, 367, 403, 413, 426, 436, 478, 628, 659, 671, 679, 745, 797, 802, 850, 862, 876, 879, 888, 889, 893, 900, 903, 906, 909, 911, 925, 929, 957, 973, 997, 1018, 1046, 1062, 1078, 1091, 1097, 1103, 1107, 1111, 1116, 1119, 1125, 1129, 1132, 1133, 1146, 1151, 1156, 1159, 1164, 1165, 1166, 1167, 1189}

    Private _bibleText As String
    Private _bibleRef As String
    Private _settings As Dictionary(Of String, String)

    Private _useImageForLowerThird As Boolean = False
    'When set to true, the equivalengt listbox content is a scripture (e.g ListboxMain is a scripture
    'This will be examined by the ClassHeritageGraphics class (wm Object)
    'its value will determine if .bibleRef will be preinted or not
    Private _scriptureStateNavDriMain As Boolean() = {False, False, True} 'navigator=false, driver=false, main=true

    Private _searchResultsBible As biblePassage()
    Private _searchResultsSong As biblePassage()
    Private _songTitle As String = ""
    Private _songAuthour As String = ""
    Private _backgroundImage As Image = Nothing

    Public Property backgroundImage() As Image
        Get
            Return _backgroundImage
        End Get
        Set(ByVal value As Image)
            _backgroundImage = value
        End Set
    End Property
    Public Property songTitle() As String
        Get
            Return _songTitle
        End Get
        Set(ByVal value As String)
            _songTitle = value
        End Set
    End Property
    Public Property songAuthour() As String
        Get
            Return _songAuthour
        End Get
        Set(ByVal value As String)
            _songAuthour = value
        End Set
    End Property

    Public Property searchResultsSong() As biblePassage()
        Get
            Return _searchResultsSong
        End Get
        Set(ByVal value As biblePassage())
            _searchResultsSong = value
        End Set
    End Property

    Public Property searchResultsBible() As biblePassage()
        Get
            Return _searchResultsBible
        End Get
        Set(ByVal value As biblePassage())
            _searchResultsBible = value
        End Set
    End Property
    Public Property prevBibleVersion() As String
        Get
            Return _prevBibleVersion
        End Get
        Set(ByVal value As String)
            _prevBibleVersion = value
        End Set
    End Property

    Public Property prevBibleBook() As String
        Get
            Return _prevBibleBook
        End Get
        Set(ByVal value As String)
            _prevBibleBook = value
        End Set
    End Property
    Public Property prevBibleChapter() As String
        Get
            Return _prevBibleChapter
        End Get
        Set(ByVal value As String)
            _prevBibleChapter = value
        End Set
    End Property
    Public Property prevBibleVerse() As String
        Get
            Return _prevBibleVerse
        End Get
        Set(ByVal value As String)
            _prevBibleVerse = value
        End Set
    End Property
    'hold state values for listboxes Navigator, Driver and Main
    'if true then the content of the listbox is a scripture
    Public Property scriptureStateNavDriMain() As Boolean()
        Get
            Return _scriptureStateNavDriMain
        End Get
        Set(ByVal value As Boolean())
            _scriptureStateNavDriMain = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e)
        End Set
    End Property

    Public Property slideIsScripture() As Boolean     'Raises an event
        Get
            Return _slideIsScripture
        End Get
        Set(ByVal value As Boolean)
            _slideIsScripture = value
            Dim e As New ClassAnswerEventArgs
            e.VariableChanged = True
            e.Ans = -1
            RaiseEvent myEventOnPropertyChanged(Me, e)
        End Set
    End Property

    Public ReadOnly Property bibleMaxChapter() As Integer()
        Get
            Return _bibleMaxChapter
        End Get
    End Property
    Public ReadOnly Property bibleCummSumOfChapters() As Integer()
        Get
            Return _bibleCummSumOfChapters
        End Get
    End Property
    Public ReadOnly Property bibleMaxVersesPerChapter() As Integer()
        Get
            Return _bibleMaxVersesPerChapter
        End Get
    End Property

    Public ReadOnly Property bibleChaptersAbbr() As String()
        Get
            Return _bibleChaptersAbbr
        End Get
    End Property
    Public ReadOnly Property bibleChaptersFull() As String()
        Get
            Return _bibleChaptersFull
        End Get
    End Property

    Public Property useImageForLowerThird() As Boolean
        Get
            Return _useImageForLowerThird
        End Get
        Set(ByVal value As Boolean)
            _useImageForLowerThird = value
        End Set
    End Property
    Private _slideIsScripture As Boolean = True






    Public Property settings() As Dictionary(Of String, String)
        Get
            Return _settings
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _settings = value
        End Set
    End Property

    Public Property bibleRef() As String
        Get
            Return _bibleRef
        End Get
        Set(ByVal value As String)
            _bibleRef = value
        End Set
    End Property

    Public Property bibleText() As String
        Get
            Return _bibleText
        End Get
        Set(ByVal value As String)
            _bibleText = value
        End Set
    End Property
    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property
    Public Function getMaxChapter(dBook As Integer) As Integer
        Return _bibleMaxChapter(dBook - 1)
    End Function
    Public Function getMaxVerse(dBook As Integer) As Integer
        Return _bibleMaxVerse(dBook - 1)
    End Function

    Public Property previewImageFileName() As String
        Get
            Return _previewImageFileName
        End Get
        Set(ByVal value As String)
            _previewImageFileName = value
        End Set
    End Property
    Public Property bibleVerse() As String
        Get
            Return _bibleVerse
        End Get
        Set(ByVal value As String)
            _bibleVerse = value
        End Set
    End Property
    Public Property bibleChapter() As String
        Get
            Return _bibleChapter
        End Get
        Set(ByVal value As String)
            _bibleChapter = value
        End Set
    End Property
    Public Property bibleBook() As String
        Get
            Return _bibleBook
        End Get
        Set(ByVal value As String)
            _bibleBook = value
        End Set
    End Property
    Public Property NetConneced() As Boolean
        Get
            Return _NetConneced
        End Get
        Set(ByVal value As Boolean)
            _NetConneced = value
        End Set
    End Property
    Public Property bibleVersion() As String
        Get
            Return _bibleVersion
        End Get
        Set(ByVal value As String)
            _bibleVersion = value
        End Set
    End Property



    Public Property backgrounImageFileName() As String
        Get
            Return backgrounImageFileNameValue
        End Get
        Set(ByVal value As String)
            backgrounImageFileNameValue = value
        End Set
    End Property

    Public Property song() As String()
        Get
            Return songValue
        End Get
        Set(ByVal value As String())
            songValue = value
        End Set
    End Property

    Public Property songfileName() As String
        Get
            Return songfileNameValue
        End Get
        Set(ByVal value As String)
            songfileNameValue = value
        End Set
    End Property
    Public Property font() As Font
        Get
            Return fontValue
        End Get
        Set(ByVal value As Font)
            fontValue = value
        End Set
    End Property

    Public Sub New()
        Try
            Me._bibleVersion = "KJV"
            Me.fontValue = New Font("Arial", 50, FontStyle.Bold)
            'USER_DIRECTORY
            Me._previewImageFileName = USER_DIRECTORY & "\images\thumbnails\hd-01.jpg"
            Me._bibleVerse = "1"
            Me._bibleChapter = "1"
            Me._bibleBook = "Genesis"
            Me._bibleRef = "Genesis 1:1"
            Me.bibleText = "In the beginning God created the heaven and the earth."
            Me._prevBibleVerse = "1"
            Me._prevBibleChapter = "1"
            Me._prevBibleBook = "Genesis"
            Me._prevBibleVersion = "KJV"
            Me.song = {}
            'load defaults
            Me.backgrounImageFileNameValue = USER_DIRECTORY & "\images\hd-01.jpg"
            Me.slideStrValue = "In the begining God created the heaven and the earth."
            Me.settings = getSettings(True)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub
    Public Property slideStr() As String
        Get
            Return slideStrValue
        End Get
        Set(ByVal value As String)
            slideStrValue = value
        End Set
    End Property

    Declare Function Win32MessageBox Lib "user32.dll" Alias "MessageBox" (ByVal hWnd As Integer, ByVal txt As String, ByVal caption As String, ByVal type As Integer) As Integer

    Public Sub combolist(ByVal this_sql As String, ByVal this_value As String, ByVal this_member As String, ByVal this_cbo As ListBox)
        Try
            Dim oConn As OleDbConnection = Me.getConn(, True)
            Dim oad As New OleDbDataAdapter(this_sql, oConn)
            Dim ds As New DataSet
            Dim strtmp As String = this_cbo.Text.ToString : this_cbo.Text = String.Empty
            oad.Fill(ds)

            With this_cbo
                .DataSource = ds.Tables(0)
                .ValueMember = this_value
                .DisplayMember = this_member
            End With

            this_sql = Nothing
            this_value = Nothing
            this_member = Nothing
            ds = Nothing
            oad = Nothing

            oConn.Close()
            oConn.Dispose()
            oConn = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub


    Function getSettings(Optional useDefault As Boolean = False) As Dictionary(Of String, String)
        Try
            Dim tmp As New Dictionary(Of String, String)
            If useDefault = True Then
                tmp.Add("mode", "driver")
                tmp.Add("fontSize", "50")
                tmp.Add("fontFamily", "Arial")
                tmp.Add("max_Char", "160")
                tmp.Add("charPerLine", "30")
                tmp.Add("maxLine", "7")
                tmp.Add("foreColor", "-256") 'yellow in argb
                tmp.Add("shadowColor", "-16777216") 'black in argb
                tmp.Add("backgroundImage", "")
                tmp.Add("position", "full")
                tmp.Add("resolutionW", "1366")
                tmp.Add("resolutionH", "768")
                tmp.Add("ip", "127.0.0.1")
                tmp.Add("font", "Arial, 50.25pt, style=Bold") 'TODO: store FONT like this
                tmp.Add("color", "255, 255 ,0")

                tmp.Add("displayOption", "4")
                tmp.Add("resolutionProjectorW", "1724")
                tmp.Add("resolutionProjectorH", "1293")


            Else
                tmp = Me._settings
            End If
            Return tmp
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getBackgroundImage() As Image
        Try
            Dim fileExists As Boolean
            fileExists = My.Computer.FileSystem.FileExists(Me.backgrounImageFileName)
            If fileExists Then
                Return Image.FromFile(Me.backgrounImageFileName)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getbibleChaptersFull() As String()
        Return _bibleChaptersFull
    End Function
    'Adds \ by default
    Function Array2sTR(s As String(), Optional removeSlash As Boolean = False, Optional addCrLf As Boolean = False) As String
        Try
            Dim tmpStr As String = ""

            For i = 0 To s.Length - 1
                If removeSlash = True Then
                    tmpStr = tmpStr & s(i) & " "
                ElseIf addCrLf = True Then
                    tmpStr = tmpStr & s(i) & vbCrLf
                Else

                    tmpStr = tmpStr & s(i) & "\"
                End If

            Next
            Return tmpStr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function str2Array(s As String) As String()
        Try
            Dim tmpStr As String() = {""}


            tmpStr = s.Split("\n")
            'tmpStr = s.Substring(0, 0)
            Return tmpStr
            tmpStr = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getConn(Optional bibleVersion As String = "KJV", Optional IsSong As Boolean = False) As OleDb.OleDbConnection
        'TODO: connection management
        'conn.dispose etc
        Try
            Dim connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bibles\" & bibleVersion & ".mdb"
            If IsSong = True Then connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & USER_DIRECTORY & "\db\db.mdb"
            Return New OleDb.OleDbConnection(connStr)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Structure biblePassage
        Dim ref As String
        Dim passage As String
    End Structure
    Function getFromDBSong(str As String) As String

        'SELECT SONG.SONGID, SONG.TITLE_1, SONG.LYRICS
        'FROM SONG
        'WHERE (((SONG.TITLE_1)="A New Commandment"));
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(, True)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Just one value
            cmd.CommandText = "SELECT SONG.SONGID, SONG.TITLE_1, SONG.LYRICS "
            cmd.CommandText = cmd.CommandText & "FROM SONG "
            cmd.CommandText = cmd.CommandText & "WHERE (SONG.TITLE_1 = @TITLE);"
            cmd.Connection = conn

            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim titleParam As New OleDbParameter("@TITLE", str)
            cmd.Parameters.Add(titleParam)

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then

                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4"
                Dim noRecords As Integer = reader.FieldCount
                Dim songTitle As String = ""



                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        songTitle = (CStr(reader.GetValue(2))) 'get the lyrics
                        iCount = iCount + 1
                    End While
                End Using
                Return songTitle
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try


        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getFromDBSongs(str As String) As String()
        'SELECT SONG.TITLE_1, SONG.LYRICS
        'FROM SONG
        'WHERE (((SONG.TITLE_1) Like "*Commandment*"));
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(, True)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Just one value
            cmd.CommandText = "SELECT SONG.SONGID, SONG.TITLE_1, SONG.LYRICS "
            cmd.CommandText = cmd.CommandText & "FROM SONG "
            cmd.CommandText = cmd.CommandText & "WHERE (SONG.LYRICS Like @LYRICS);"
            cmd.Connection = conn


            ' Create a SqlParameter for each parameter in the stored procedure.

            Dim lyricsParam As New OleDbParameter("@LYRICS", str)
            cmd.Parameters.Add(lyricsParam)

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then

                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4"
                Dim noRecords As Integer = reader.FieldCount
                Dim songTitle As String()
                Dim songTitleList As New List(Of String)


                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        songTitleList.Add(CStr(reader.GetValue(1)))
                        iCount = iCount + 1
                    End While
                    songTitle = songTitleList.ToArray


                End Using
                Return songTitle
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()

                End If
            End Try


        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getFromDBMaxVerses(book As String, chp As String, Optional ver As String = "KJV") As Integer

        'BOOK	CHAPTER	MaxOfVERSE
        '1	        1	    31
        'SELECT BIBLE.BOOK, BIBLE.CHAPTER, Max(BIBLE.VERSE) AS MaxOfVERSE
        'FROM BIBLE
        'GROUP BY BIBLE.BOOK, BIBLE.CHAPTER
        'HAVING (((BIBLE.BOOK)>0 And (BIBLE.BOOK)=1) AND ((BIBLE.CHAPTER)=1));
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(ver)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Just one value
            cmd.CommandText = "SELECT BIBLE.BOOK, BIBLE.CHAPTER, Max(BIBLE.VERSE) AS MaxOfVERSE "
            cmd.CommandText = cmd.CommandText & "FROM BIBLE "
            cmd.CommandText = cmd.CommandText & "GROUP BY BIBLE.BOOK, BIBLE.CHAPTER "
            cmd.CommandText = cmd.CommandText & "HAVING (((BIBLE.BOOK)>0 And (BIBLE.BOOK)=" & book2Num(book) & ") AND ((BIBLE.CHAPTER)=" & chp & "));"


            cmd.Connection = conn

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then

                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4"
                Dim noRecords As Integer = reader.FieldCount
                Dim maxVerse As Integer = 0
                'Dim ddd As ListControl

                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        maxVerse = reader.GetValue(2)
                        iCount = iCount + 1
                    End While
                    If iCount > 1 Then maxVerse = 0 ' there was an error

                End Using
                Return maxVerse
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()

                End If
            End Try

        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getFromDBSongsDataset() As DataSet
        Try
            Dim strSQL As String = "SELECT * FROM  SONG"
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL
            cmd.Connection = Me.getConn(, True)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "SONG")
            ' dgw.DataSource = myDataSet.Tables("SONG").DefaultView
            Return myDataSet
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getUniqueID(table As String) As Integer
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(, True)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Just one value
            cmd.CommandText = "SELECT  Max(SONG.SONGID) AS MaxID "
            cmd.CommandText = cmd.CommandText & "FROM SONG;"
            cmd.Connection = conn

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open() 'TODO: throws excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()
                Dim noRecords As Integer = reader.FieldCount
                Dim maxID As Integer = 0
                'Dim ddd As ListControl

                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        maxID = reader.GetValue(0)
                        iCount = iCount + 1
                    End While
                    If iCount > 1 Then maxID = -1 ' there was an error

                End Using
                Return maxID + 1
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()

                End If
            End Try
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function insertIntoDBSong(dTitle As String, dLyrics As String, dAuthour As String) As Boolean
        Try
            Dim strSQL As String = "INSERT INTO SONG (SONGID, TITLE_1, LYRICS, WRITER) "
            'strSQL = strSQL & "VALUES ('985', 'My Title', 'My lyrics', 'My Authour');"
            strSQL = strSQL & "VALUES (@SONGID, @TITLE_1, @LYRICS, @WRITER);"
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSQL ' "SELECT CustomerID, CompanyName FROM Customers WHERE CompanyName LIKE @companyName"
            cmd.Connection = Me.getConn(, True)
            ' Create a SqlParameter for each parameter in the stored procedure.
            Dim idParam As New OleDbParameter("@SONGID", getUniqueID("SONG").ToString)
            Dim titleParam As New OleDbParameter("@TITLE_1", dTitle) ' "a%")
            Dim lyricsParam As New OleDbParameter("@LYRICS", dLyrics)
            Dim authourParam As New OleDbParameter("@WRITER", dAuthour)

            cmd.Parameters.Add(idParam)
            cmd.Parameters.Add(titleParam)
            cmd.Parameters.Add(lyricsParam)
            cmd.Parameters.Add(authourParam)


            'Access workable prototypes
            'UPDATE SONG SET SONG.TITLE_1 = "jsh", SONG.WRITER = "kjs", SONG.LYRICS = "jsakjjk"
            'WHERE (((SONG.SONGID)=984));

            'UPDATE SONG SET SONG.TITLE_1 = "jsh", SONG.WRITER = "kjs", SONG.LYRICS = "jsakjjk"
            'WHERE (((SONG.TITLE_1)="A new Commandment"));
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open() 'TODO: throews excepion if mdb file no found
            End If
            cmd.ExecuteNonQuery()

            cmd.Connection.Close()
            cmd.Connection.Dispose()
            cmd.Dispose()

            Return True
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getFromDBbiblePassage(book As String, chp As String, Optional ver As String = "KJV") As biblePassage()
        Try
            Dim dQuery = ""
            Dim conn As OleDb.OleDbConnection
            conn = Me.getConn(ver)
            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Genesis 1 (ALL VERSES)
            cmd.CommandText = "SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE "
            cmd.CommandText = cmd.CommandText & "FROM BIBLE "
            cmd.CommandText = cmd.CommandText & "WHERE (((BIBLE.BOOK)=" & book & ") AND "
            cmd.CommandText = cmd.CommandText & "((BIBLE.CHAPTER)=" & chp & "))"

            cmd.Connection = conn
            'TODO: Create a Parameter for each parameter in the stored procedure.
            Dim bibleBookParam As New OleDbParameter("bibleBook", "1")
            cmd.Parameters.Add(bibleBookParam)

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open() 'TODO: throews excepion if mdb file no found
                End If
                reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4, 1 peter etc"
                Dim noRecords As Integer = reader.FieldCount
                Dim dBiblePassage(400) As biblePassage
                'Dim ddd As ListControl

                Dim iCount As Integer = 0
                Using reader
                    While reader.Read
                        Console.WriteLine(reader.GetValue(0))
                        dBiblePassage(iCount).ref = num2Book(book) & " " & chp & ":" & (iCount + 1).ToString
                        dBiblePassage(iCount).passage = reader.GetValue(0)
                        iCount = iCount + 1
                    End While
                    ReDim Preserve dBiblePassage(0 To iCount - 1)
                End Using
                Return dBiblePassage
            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

        'Genesis 1:1
        'SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE
        'FROM BIBLE
        'WHERE (((BIBLE.BOOK)=1) AND ((BIBLE.CHAPTER)=1) AND ((BIBLE.VERSE)=1));

        'ESHB -KingJames


        'BOOK	CHAPTER	VERSE	BIBLETEXT
        '0	0	0	King James Version
        '0	0	1	KJV
        '0	0	2	English
        '0	0	3	King James Version  - Public Domain
        '...
        '
        'BOOK	CHAPTER	VERSE	BIBLETEXT
        '0	0	4	This King James Version of the Bible was placed in the Public Domain (no copyright) on 1st September 2004 by Wai Kuen Mo of www.EasiSlides.com and is formatted to be used with the EasiSlides software. The limits of liability for using this Bible is contained in the End User Licence Agreement in the EasiSlides Software which can be downloaded from the website www.EasiSlides.com.
        '0	10	1	Genesis
        '0	10	2	Exodus
        'BOOK	CHAPTER	VERSE	BIBLETEXT
        '1	1	1	In the beginning God created the heaven and the earth.
        '1	1	2	"""And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters."""

        'Genesis 1:1
        'cmd.CommandText = "SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE "
        'cmd.CommandText = cmd.CommandText & "FROM BIBLE "
        'cmd.CommandText = cmd.CommandText & "WHERE (((BIBLE.BOOK)=1) AND "
        'cmd.CommandText = cmd.CommandText & "((BIBLE.CHAPTER)=1) AND "
        'cmd.CommandText = cmd.CommandText & "((BIBLE.VERSE)=1))"

    End Function
    Function searchDBbiblePassage(str As String, bookStart As String, bookEnd As String, Optional ver As String = "KJV") As biblePassage()
        Dim conn As OleDb.OleDbConnection
        Dim previousConnectionState As ConnectionState
        Try
            conn = Me.getConn(ver)
            previousConnectionState = conn.State
        Catch
        End Try


        Try
            Dim dQuery = ""


            Dim cmd As New OleDbCommand
            cmd.CommandType = CommandType.Text

            'Genesis 1 (ALL VERSES)
            cmd.CommandText = "SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE "
            cmd.CommandText = cmd.CommandText & "FROM BIBLE "
            cmd.CommandText = cmd.CommandText & "WHERE (((BIBLE.BIBLETEXT) like @STR) And "
            cmd.CommandText = cmd.CommandText & "(BIBLE.BOOK)>=" & prevObjSlide.book2Num(bookStart) & " And (BIBLE.CHAPTER)<=" & prevObjSlide.book2Num(bookEnd) & ");"
            'WHERE (((BIBLE.BOOK)>=1 And (BIBLE.BOOK)<=44) AND ((BIBLE.BIBLETEXT) Like "*In the beginning*"));
            ''TIP: Problem with OLEDB and Access. canot use Like  in query 
            ''FIXED: use % wildcard instead of *
            Dim strParam As New OleDbParameter("@STR", "%" & str & "%")
            cmd.Parameters.Add(strParam)

            cmd.Connection = conn



            Dim reader As OleDbDataReader
            If conn.State = ConnectionState.Closed Then
                conn.Open() 'TODO: throews excepion if mdb file no found
            End If
            reader = cmd.ExecuteReader()    'TODO: Error "1 Joh 2:4, 1 peter etc"
            Dim noRecords As Integer = reader.RecordsAffected
            Dim dBiblePassage(400) As biblePassage
            'Dim ddd As ListControl

            Dim iCount As Integer = 0
            Using reader
                While reader.Read
                    Console.WriteLine(reader.GetValue(0))
                    dBiblePassage(iCount).ref = num2Book(reader.GetValue(1)) & " " & reader.GetValue(2) & ":" & reader.GetValue(3)
                    dBiblePassage(iCount).passage = reader.GetValue(0)

                    If iCount >= 30 Then Exit While
                    iCount = iCount + 1
                End While
                ReDim Preserve dBiblePassage(0 To iCount - 1)
            End Using
            Return dBiblePassage

        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Function
    ''' <summary> searches for text and returns full scrpture with ref and  verse as string()</summary>
    Function searchForBiblePassagesWithRef(str As String, bookStart As String, bookEnd As String, Optional ver As String = "KJV") As String()
        Try
            Dim dpassage As biblePassage()
            dpassage = searchDBbiblePassage(str, bookStart, bookEnd, ver)
            Dim dpassageStr(0 To dpassage.Length - 1) As String
            For i = 0 To dpassage.Length - 1
                dpassageStr(i) = dpassage(i).ref & " " & dpassage(i).passage '"Genesis 1:1 In the beginning God created...."
            Next
            'store the book  and chapter
            Return dpassageStr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    ''' <summary> reurns full scrpture with ref and  verse as string()</summary>
    Function getBiblePassagesWithRef(book As String, chapter As String, Optional ver As String = "KJV") As String()
        Try
            Dim dpassage As biblePassage()
            dpassage = getFromDBbiblePassage(book, chapter, ver)
            Dim dpassageStr(0 To dpassage.Length - 1) As String
            For i = 0 To dpassage.Length - 1
                dpassageStr(i) = dpassage(i).ref & " " & dpassage(i).passage '"Genesis 1:1 In the beginning God created...."
            Next
            'store the book  and chapter
            Return dpassageStr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    ''' <summary> reurns full scrpture with ref and  verse as string()</summary>
    Function getBiblePassages(book As String, chapter As String, Optional ver As String = "KJV") As String()
        Try
            Dim dpassage As biblePassage()
            dpassage = getFromDBbiblePassage(book, chapter, ver)
            Dim dpassageStr(0 To dpassage.Length - 1) As String
            For i = 0 To dpassage.Length - 1
                dpassageStr(i) = dpassage(i).passage '"Genesis 1:1 In the beginning God created...."
            Next
            'store the book  and chapter
            Return dpassageStr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    ''' <summary> reurns full scrpture with ref and  verse as string in a 2D array()</summary>
    Function getBiblePassages2DArray(book As String, chapter As String, Optional ver As String = "KJV") As String(,)
        Try
            Dim dpassage As biblePassage()
            dpassage = getFromDBbiblePassage(book, chapter, ver)
            Dim dpassageStr(0 To 1, 0 To dpassage.Length - 1) As String
            For i = 0 To dpassage.Length - 1
                dpassageStr(1, i) = dpassage(i).passage '"In the beginning God created...."
                dpassageStr(0, i) = dpassage(i).ref & " (" & ver & ")" '"Genesis 1:1 
            Next
            'store the book  and chapter

            Return dpassageStr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Public Function loadAllBibleVersions() As String()
        Try
            Dim fileExists As Boolean
            Dim filename As String = Nothing
            Dim dVerStr(0 To 500) As String
            Dim iCount As Integer = 0
            For Each file In FileSystem.GetFiles(My.Application.Info.DirectoryPath & "\bibles\") 'leave this in program files so its readonly
                filename = file
                fileExists = My.Computer.FileSystem.FileExists(file)
                If fileExists Then
                    dVerStr(iCount) = System.IO.Path.GetFileNameWithoutExtension(file)
                    iCount = iCount + 1
                End If
            Next
            ReDim Preserve dVerStr(0 To iCount - 1)
            Return dVerStr
            dVerStr = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function TestgetBiblePassages() As biblePassage()
        Try
            Dim dpassage As biblePassage() = {}
            dpassage(0).ref = "Genesis 1:1"
            dpassage(0).passage = "In the beginning God created...."
            dpassage(1).ref = "Genesis 1:1"
            dpassage(1).passage = "In the beginning God created...."
            Return dpassage
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getPassagesFromBiblePassage(dBiblePassage As biblePassage()) As String()
        Try
            Dim dpassage As String() = {}
            For i = 0 To dBiblePassage.Length - 1
                dpassage(i) = dBiblePassage(i).passage
            Next

            Return dpassage
            dpassage = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function getRefFromBiblePassage(dBiblePassage As biblePassage()) As String()
        Try
            Dim ref As String() = {}
            For i = 0 To dBiblePassage.Length - 1
                ref(i) = dBiblePassage(i).ref
            Next

            Return ref
            ref = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function bookFromRef(dRef As String) As String
        Try
            Dim bits As String()
            Dim chars As Char() = {" ", ":"}
            bits = dRef.Split(chars)
            Return bits(0)
            bits = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function bookNumFromRef(dRef As String) As String
        Try
            Dim bits As String()
            Dim chars As Char() = {" ", ":"}
            bits = dRef.Split(chars)

            'now get number
            Dim bookNum As String = Nothing
            For i = 0 To _bibleChaptersAbbr.Length - 1
                If _bibleChaptersAbbr(i).ToUpper = bits(0).ToUpper Or _bibleChaptersFull(i).ToUpper = bits(0).ToUpper Then
                    bookNum = (i + 1).ToString
                    Exit For
                End If
            Next
            Return bookNum
            bookNum = Nothing
            bits = Nothing

            bits = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Function chapterFromRef(dRef As String) As String
        Try
            Dim bits As String()
            Dim chars As Char() = {" ", ":"}
            bits = dRef.Split(chars)
            Return bits(1)
            bits = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function verseFromRef(dRef As String) As String
        Try
            Dim bits As String()
            Dim chars As Char() = {" ", ":"}
            bits = dRef.Split(chars)
            Return bits(2)
            bits = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function book2Num(book As String) As String 'Gen=1,Exo=2,Lev=3
        ' TODO: Method 1 database query
        'method 2 hard coded
        Try
            Dim bookNum As String
            'If book = "Gen" Or book = "Genesis" Then
            '    bookNum = "1"
            'ElseIf book = "Exo" Or book = "Exodus" Then
            '    bookNum = "2"
            'Else
            '    bookNum = "1"
            'End If
            ' Return bookNum

            'method 3 array
            For i = 0 To _bibleChaptersAbbr.Length - 1
                If _bibleChaptersAbbr(i).ToUpper = book.ToUpper Or _bibleChaptersFull(i).ToUpper = book.ToUpper Then
                    bookNum = (i + 1).ToString
                    Exit For
                End If
            Next
            Return bookNum
            bookNum = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Function num2Book(bookNum As String, Optional abbr As Boolean = False) As String 'Gen=1,Exo=2,Lev=3
        ' TODO: Method 1 database query
        'method 2 hard coded
        Try
            Dim book As String
            Select Case bookNum
                Case "1"
                    book = "Gen"
                Case "2"
                    book = "Exo"
                Case "3"
                    book = "Lev"
                Case "4"
                    book = "Num"
                Case Else
                    book = "Gen"
            End Select
            'Return book

            'method 3 array
            If abbr = True Then
                book = _bibleChaptersAbbr(CInt(bookNum) - 1)
            Else
                book = _bibleChaptersFull(CInt(bookNum) - 1)
            End If
            Return book
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    '' ''/* Although having written that, why not write the necessary extension methods. 
    '' ''Okay, you talked me into it...

    '' ''   Firstly, my own version of Split that takes a function that has to decide whether the specified
    '' '' character should split the string: */


    ' ''<Extension()>
    ' ''Public Shared Iterator Function Split(ByVal str As String, ByVal controller As Func(Of Char, Boolean)) As IEnumerable(Of String)
    ' ''    Dim nextPiece As Integer = 0

    ' ''    For c As Integer = 0 To str.Length - 1

    ' ''        If controller(str(c)) Then
    ' ''            Yield str.Substring(nextPiece, c - nextPiece)
    ' ''            nextPiece = c + 1
    ' ''        End If
    ' ''    Next

    ' ''    Yield str.Substring(nextPiece)
    ' ''End Function
    '' '' /* It may yield some empty strings depending on the situation, but maybe that information will be useful in other cases, 
    '' ''so I don't remove the empty entries in this function.

    '' ''   Secondly (and more mundanely) a little helper that will trim a matching pair of quotes from the start and end of a string. 
    '' ''It's more fussy than the standard Trim method - it will only trim one character from each end, and it will not trim from just one end: */


    ' ''<Extension()>
    ' ''Public Shared Function TrimMatchingQuotes(ByVal input As String, ByVal quote As Char) As String
    ' ''    If (input.Length >= 2) AndAlso (input(0) = quote) AndAlso (input(input.Length - 1) = quote) Then Return input.Substring(1, input.Length - 2)
    ' ''    Return input
    ' ''End Function

    ' ''Public Shared Sub Test(ByVal cmdLine As String, ParamArray args As String())
    ' ''    Dim split As String() = SplitCommandLine(cmdLine).ToArray()
    ' ''    Debug.Assert(split.Length = args.Length)

    ' ''    For n As Integer = 0 To split.Length - 1
    ' ''        Debug.Assert(split(n) = args(n))
    ' ''    Next
    ' ''End Sub

End Class
