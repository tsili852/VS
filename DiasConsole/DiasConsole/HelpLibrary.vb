Module HelpLibrary
    'http://www.vbforums.com/showthread.php?682082-Understanding-Multi-Threading-in-VB-Net
    Public Class ThreadExtensions
        Private args() As Object
        Private DelegateToInvoke As [Delegate]

        Public Shared Function QueueUserWorkItem(ByVal method As [Delegate], ByVal ParamArray args() As Object) As Boolean
            Return Threading.ThreadPool.QueueUserWorkItem(AddressOf ProperDelegate, New ThreadExtensions With {.args = args, .DelegateToInvoke = method})
        End Function

        Private Shared Sub ProperDelegate(ByVal state As Object)
            Dim sd As ThreadExtensions = DirectCast(state, ThreadExtensions)

            sd.DelegateToInvoke.DynamicInvoke(sd.args)
        End Sub

        Public Shared Sub ScSend(ByVal sc As Threading.SynchronizationContext, ByVal del As [Delegate], ByVal ParamArray args() As Object)
            sc.Send(New Threading.SendOrPostCallback(AddressOf ProperDelegate), New ThreadExtensions With {.args = args, .DelegateToInvoke = del})
        End Sub
    End Class

    Public Class CountChangedEventArgs
        Inherits EventArgs

        Private _CurrentCount As Integer
        Private _Max As Integer

        Public Sub New(ByVal cc As Integer, ByVal max As Integer)
            _CurrentCount = cc
            _Max = max
        End Sub
        Public ReadOnly Property CurrentCount() As Integer
            Get
                Return _CurrentCount
            End Get
        End Property
        Public ReadOnly Property Max() As Integer
            Get
                Return _Max
            End Get
        End Property
    End Class

    Public Class CountCompletedEventArgs
        Inherits EventArgs
        Private _message As String

        Public Sub New(ByVal msg As String)
            _message = msg
        End Sub
        Public ReadOnly Property Message() As String
            Get
                Return _message
            End Get
        End Property

    End Class

    Public Class Counter
        Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current

        Public Sub CountAsync(ByVal Max As Integer)
            ThreadExtensions.QueueUserWorkItem(New Func(Of Integer, String)(AddressOf Count), Max)
        End Sub

        Public Function Count(ByVal Max As Integer) As String
            Dim startTime As DateTime = DateTime.Now
            Dim e As CountChangedEventArgs
            Dim msg As String

            For i = 1 To Max
                e = New CountChangedEventArgs(i, Max)

                If context Is Nothing Then
                    OnCountChanged(e)
                Else
                    ThreadExtensions.ScSend(context, New Action(Of CountChangedEventArgs)(AddressOf OnCountChanged), e)
                End If

                Threading.Thread.Sleep(200)
            Next

            msg = "Count took : " + (DateTime.Now - startTime).ToString

            If context Is Nothing Then
                OnCountCompleted(New CountCompletedEventArgs(msg))
            Else
                ThreadExtensions.ScSend(context, New Action(Of CountCompletedEventArgs)(AddressOf OnCountCompleted), New CountCompletedEventArgs(msg))
            End If

            Return msg
        End Function

        Public Event CountChanged As EventHandler(Of CountChangedEventArgs)
        Protected Overridable Sub OnCountChanged(ByVal e As CountChangedEventArgs)
            RaiseEvent CountChanged(Me, e)
        End Sub

        Public Event CountCompleted As EventHandler(Of CountCompletedEventArgs)
        Protected Overridable Sub OnCountCompleted(ByVal e As CountCompletedEventArgs)
            RaiseEvent CountCompleted(Me, e)
        End Sub
    End Class
End Module
