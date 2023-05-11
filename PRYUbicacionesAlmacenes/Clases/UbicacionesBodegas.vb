Imports Newtonsoft.Json

Public Class UbicacionesBodegas

    '<JsonProperty(PropertyName:="columnas")>
    'Public Columnas As List(Of String) = New List(Of String)
    <JsonProperty(PropertyName:="columnas")>
    Public Columnas As List(Of Columna) = New List(Of Columna)

    '<JsonProperty(PropertyName:="filas")>
    'Public Filas As Filas

    '<JsonProperty(PropertyName:="celdas")>
    'Public Celdas As List(Of Celdas) = New List(Of Celdas)


End Class


Public Class Celdas

    <JsonProperty(PropertyName:="columna")>
    Public Property Columna As String

    <JsonProperty(PropertyName:="fila")>
    Public Property Fila As Integer

    <JsonProperty(PropertyName:="cantidad_posiciones")>
    Public CantidadPosiciones As Integer

    <JsonProperty(PropertyName:="posiciones")>
    Public Posiciones As List(Of Posiciones) = New List(Of Posiciones)

End Class




Public Class Posiciones


    <JsonProperty(PropertyName:="columna")>
    Public Property Columna As String

    <JsonProperty(PropertyName:="fila")>
    Public Property Fila As Integer

    <JsonProperty(PropertyName:="orden")>
    Public Property Orden As Integer = -1

    <JsonProperty(PropertyName:="nombre")>
    Public Property Nombre As String = -1

    <JsonProperty(PropertyName:="descripcion")>
    Public Property Descripcion As String = -1

    <JsonProperty(PropertyName:="co")>
    Public Property Co As String = -1


End Class



Public Class Filas

    <JsonProperty(PropertyName:="filas")>
    Public Filas As Integer = -1
End Class

Public Class Columna

    <JsonProperty(PropertyName:="columnas")>
    Public Property Columnas As String
End Class