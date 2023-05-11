Imports SAP.Middleware.Connector

Public Class GlobalData


    Public Shared Function generateDataTable(ByVal dt As DataTable, ByVal rfcTable As IRfcTable) As DataTable
        For Each row As IRfcStructure In rfcTable
            Dim newRow As DataRow = dt.NewRow()

            For element As Integer = 0 To rfcTable.ElementCount - 1
                Dim metadata As RfcElementMetadata = rfcTable.GetElementMetadata(element)
                Dim nrow = newRow(element)
                Dim rrow = row.GetString(metadata.Name)
                newRow(element) = row.GetString(metadata.Name)
            Next

            dt.Rows.Add(newRow)
        Next

        Return dt
    End Function

End Class
