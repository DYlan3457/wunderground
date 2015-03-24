Public Class Form1
    Dim animallist As New ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim animalname As String = TextBox1.Text
        If animalname Is Nothing Or animalname = "" Then
            MessageBox.Show("Please enter a name")
            Return
        End If

        Dim animalhasstripes As Boolean = CheckBox1.Checked
        'custom constructor
        Dim newanimal As New animal(animalname, animalhasstripes)

        animallist.Add(newanimal)
        updatelistbox()
    End Sub

    Private Sub updatelistbox()
        ListBox1.Items.Clear()
        For Each a As Object In animallist
            ListBox1.Items.Add(a)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMoveToMars.Click

    End Sub
End Class

Class animal
    Public name As String
    Public hasstripes As Boolean
    Private Shared breathesgas As String = "Oxygen"

    Public Property name As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property stripes As Boolean
        Get
            Return hasstripes
        End Get
        Set(value As Boolean)
            hasstripes = value
        End Set
    End Property

    Public Shared Property breathes As String
        Get
            breathesgas
        End Get
        Set(value As String)
            breathesgas = value
        End Set
    End Property

    Public Sub New()
        name = "Null"
        hasstripes = False
    End Sub

    Public Sub New(n As String, s As Boolean)
        name = n
        hasstripes = s
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() as string
        If hasstripes = True Then
            Return name & " is stripey and breathes " & breathes
        Else
            Return name & " is not stripey and breathes " & breathes
        End If
    End Function
End Class
