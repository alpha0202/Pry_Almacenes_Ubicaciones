Imports Newtonsoft.Json

Public Class ConfigBodega

    <JsonProperty(PropertyName:="columnas")>
    Public Columnas As List(Of String) = New List(Of String)

    <JsonProperty(PropertyName:="filas")>
    Public Filas As Integer = -1

    <JsonProperty(PropertyName:="celdas")>
    Public Celdas As List(Of Celda) = New List(Of Celda)

End Class

Public Class Celda

    <JsonProperty(PropertyName:="columna")>
    Public Columna As String = -1

    <JsonProperty(PropertyName:="fila")>
    Public Fila As Integer = -1

    <JsonProperty(PropertyName:="cantidad_posiciones")>
    Public CantidadPosiciones As Integer = -1

    <JsonProperty(PropertyName:="posiciones")>
    Public Posiciones As List(Of Posicion) = New List(Of Posicion)

End Class

Public Class Posicion

    <JsonProperty(PropertyName:="nombre")>
    Public Nombre As String = -1

    <JsonProperty(PropertyName:="orden")>
    Public Orden As Integer = -1

End Class

