Module ModuleEvents
    Public Delegate Sub knowAnswer(ByVal sende As Object, e As AnswerEventArgs)
    Public Class AnswerEventArgs
        Inherits EventArgs
        Public Ans As Integer
        Public VariableChanged As Boolean
    End Class
    Public Class myCalcClass
        Public Event myEventOnSum(ByVal sende As Object, e As AnswerEventArgs)
        Private _inputGreaterThan100 As Boolean = False
        Public Property inputGreaterThan100() As Boolean
            Get
                Return _inputGreaterThan100
            End Get
            Set(ByVal value As Boolean)
                _inputGreaterThan100 = value
                Dim e As New AnswerEventArgs
                e.variableChanged = True
                RaiseEvent myEventOnSum(Me, e)
            End Set
        End Property
        Sub doSum(x As Integer, y As Integer)
            Dim e As New AnswerEventArgs
            e.ans = x + 1
            RaiseEvent myEventOnSum(Me, e)

            If x > 100 Then Me._inputGreaterThan100 = True
        End Sub
    End Class




    Public Sub main_sub()
        Dim xObj As New myCalcClass
        AddHandler xObj.myEventOnSum, AddressOf xObj_myEventOnSum
        xObj.doSum(5, 7)


    End Sub
    Sub xObj_myEventOnSum(ByVal sender As Object, e As AnswerEventArgs)
        MsgBox("Event x_myEventOnSum just occured, ans is " & e.Ans.ToString & "variable state is :" & e.VariableChanged)  '
        'you can assess the properties and methods of the sender e.g
        ' sender.inputGreaterThan100
    End Sub
End Module
