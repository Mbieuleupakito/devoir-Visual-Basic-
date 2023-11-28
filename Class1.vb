Public Class Emprunt

    Public labelnomlecteur As String
    Public labelcodeouvrage As String
    Public labelouvrage As String

    Public labeltitre As String
    Public labeldateemprunt
    Public labelnombre As String


    Public Function valider() As Boolean
        Dim state As Boolean = True

        If Not IsNumeric(Me.labelcodeouvrage) Then
            state = False
        End If

        If Me.labelnomlecteur.Length > 50 Then
            state = False
        End If

        If Not IsNumeric(Me.labelnombre) Then
            state = False
        Else
            If Me.labelnombre <= 100 And Me.labelnombre >= 5000 Then
                state = False
            End If
        End If
        If Me.labelouvrage.Length > 50 Then
            state = False
        End If


        Return state
    End Function
End Class
