Public Class frmclientes

    Dim abm As String ' variable que indicar al boton guardar si es insert o update


   

    Private Sub frmclientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JH2DataSet.obra' table. You can move, or remove it, as needed.
        Me.ObraTableAdapter.Fill(Me.JH2DataSet.obra)
        'TODO: This line of code loads data into the 'JH2DataSet.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.JH2DataSet.cliente)

    End Sub



    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim x As Control

        For Each x In Me.Controls
            If TypeOf x Is System.Windows.Forms.TextBox Then
                x.Enabled = True
                x.Text = ""
            End If

        Next
        btnGuardar.Enabled = True
        NombreTextBox.Focus()
        btnborrar.Enabled = False
        btneditar.Enabled = False


        abm = "agregar"

    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim x As Control


        If ClienteDataGridView.RowCount = 0 Then
            MsgBox("No existen Clientes para Editar")
            Exit Sub
        End If


        For Each x In Me.Controls
            If TypeOf x Is System.Windows.Forms.TextBox Then
                x.Enabled = True
            End If
        Next

        btnAgregar.Enabled = False
        btnborrar.Enabled = False



        btnGuardar.Enabled = True
        ClienteDataGridView.Enabled = False

        NombreTextBox.Focus()

        abm = "editar"
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim x As Control

        If abm = "agregar" Then
            ClienteTableAdapter.InsertQuery(NombreTextBox.Text, ApellidoTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text)
        End If

        If abm = "editar" Then
            ClienteTableAdapter.UpdateQuery(NombreTextBox.Text, ApellidoTextBox.Text, DireccionTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, Val(IdclienteTextBox.Text))
        End If

        For Each x In Me.Controls
            If TypeOf x Is System.Windows.Forms.TextBox Then
                x.Text = ""
                x.Enabled = False
            End If
        Next

        btnAgregar.Enabled = True
        btneditar.Enabled = True
        btnborrar.Enabled = True
        btnGuardar.Enabled = False
        ClienteDataGridView.Enabled = True

        ClienteTableAdapter.Fill(JH2DataSet.cliente)


    End Sub
    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        If ClienteDataGridView.RowCount = 0 Then
            MsgBox("No existen Clientes para Borrar")
            Exit Sub
        End If

        If ObraDataGridView.RowCount > 0 Then
            MsgBox("No se puede borrar este cliente mientras este asociado a una obra")
            Exit Sub
        End If
        If MsgBox("Esta a punto de Borrar este cliente", MsgBoxStyle.YesNo, "Borrar") = 6 Then
            ClienteTableAdapter.DeleteQuery(Val(IdclienteTextBox.Text))
            ClienteTableAdapter.Fill(JH2DataSet.cliente)
            MsgBox("Cliente Borrado", MsgBoxStyle.Information)

        End If
    End Sub




    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        worksheet = workbook.Sheets("Hoja1")
        worksheet = workbook.ActiveSheet
        'Aca se agregan las cabeceras de nuestro datagrid.

        For i As Integer = 1 To Me.ClienteDataGridView.Columns.Count
            worksheet.Cells(1, i) = Me.ClienteDataGridView.Columns(i - 1).HeaderText
        Next

        'Aca se ingresa el detalle recorrera la tabla celda por celda

        For i As Integer = 0 To Me.ClienteDataGridView.Rows.Count - 1
            For j As Integer = 0 To Me.ClienteDataGridView.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = Me.ClienteDataGridView.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Aca le damos el formato a nuestro excel

        worksheet.Rows.Item(1).Font.Bold = 1
        worksheet.Rows.Item(1).HorizontalAlignment = 3
        worksheet.Columns.AutoFit()
        worksheet.Columns.HorizontalAlignment = 2

        app.Visible = True
        app = Nothing
        workbook = Nothing
        worksheet = Nothing
        FileClose(1)
        GC.Collect()
    End Sub


End Class