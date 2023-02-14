Imports System.Numerics

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim date1 As Date = CDate(Me.DateTimePicker1.Value)
            Dim date2 As Date = CDate(Me.DateTimePicker2.Value)


            If date2.Year < date1.Year Then
                Me.LabelResult.Text = "Rango de fechas es invalido"


            ElseIf date2.Month > date1.Month Then
                Me.LabelResult.Text = "Rango de fechas es invalido"


            Else


                Me.LabelResult.Text = "Su edad actual es: " & CStr(date2.Year - date1.Year) & "Años y " & CStr(date2.Month - date1.Month) & "meses"


            End If





        Catch ex As Exception

            MessageBox.Show(ex.Message, "error")

        End Try
    End Sub
End Class
