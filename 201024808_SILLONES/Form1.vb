Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If
        If (indice < 8) Then
            nventa(indice) = txtnum.Text
            tipotela(indice) = ComboBox1.SelectedItem
            tamaño(indice) = ComboBox2.SelectedItem

            Select Case tamaño(indice)
                Case "SOFÁ"
                    Select Case tipotela(indice)
                        Case "CUERO"
                            manoobra(indice) = manoobrasofa
                            preciocosto(indice) = 8 * cuero + manoobra(indice)
                        Case "CUERINA"
                            manoobra(indice) = manoobrasofa
                            preciocosto(indice) = 8 * cuerina + manoobra(indice)
                    End Select


                Case "INDIVIDUAL"
                    Select Case tipotela(indice)
                        Case "CUERO"
                            manoobra(indice) = manoobraindiv
                            preciocosto(indice) = 3.5 * cuero + manoobra(indice)
                        Case "CUERINA"
                            manoobra(indice) = manoobraindiv
                            preciocosto(indice) = 3.5 * cuerina + manoobra(indice)
                    End Select

                Case "DOBLE"
                    Select Case tipotela(indice)
                        Case "CUERO"
                            manoobra(indice) = manoobradoble
                            preciocosto(indice) = 6 * cuero + manoobra(indice)
                        Case "CUERINA"
                            manoobra(indice) = manoobradoble
                            preciocosto(indice) = 6 * cuerina + manoobra(indice)
                    End Select
            End Select
            precioventa(indice) = preciocosto(indice) * 0.65 + preciocosto(indice)


            DataGridView1.Rows.Add(nventa(indice), tamaño(indice), tipotela(indice), manoobra(indice), preciocosto(indice), precioventa(indice))
            indice = indice + 1


        Else
            MsgBox("LLego al limite")





        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        txtnum.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
End Class
