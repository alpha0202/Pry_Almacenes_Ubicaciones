Public Class Parametros
#Region "Variables"

    Private _Nombre As String
    Private _Tipo As SqlDbType
    Private _Valor As Object
    Private _Longitud As Int32
    Private _Direccion As ParameterDirection = ParameterDirection.Input

#End Region

#Region "Constructores"

    Public Sub New(Nombre As String, Valor As Object, Tipo As SqlDbType)
        Me._Nombre = Nombre
        Me._Valor = Valor
        Me._Tipo = Tipo
    End Sub

    Public Sub New(Nombre As String, Valor As Object, Tipo As SqlDbType, Longitud As Int32)
        Me._Nombre = Nombre
        Me._Valor = Valor
        Me._Tipo = Tipo
        Me._Longitud = Longitud
    End Sub

    Public Sub New(Nombre As String, Valor As Object, Tipo As SqlDbType, Optional Direccion As ParameterDirection = ParameterDirection.Input)
        Me._Nombre = Nombre
        Me._Valor = Valor
        Me._Tipo = Tipo
        Me._Direccion = Direccion
    End Sub

    Public Sub New(Nombre As String, Valor As Object, Tipo As SqlDbType, Longitud As Int32, Optional Direccion As ParameterDirection = ParameterDirection.Input)
        Me._Nombre = Nombre
        Me._Valor = Valor
        Me._Tipo = Tipo
        Me._Longitud = Longitud
        Me._Direccion = Direccion
    End Sub

#End Region

#Region "Propiedades"

    Public Property Nombre() As String
        Get
            Return Me._Nombre
        End Get
        Set(value As String)
            Me._Nombre = value
        End Set
    End Property

    Public Property Valor() As Object
        Get
            Return Me._Valor
        End Get
        Set(value As Object)
            Me._Valor = value
        End Set
    End Property

    Public Property Longitud() As Int32
        Get
            Return Me._Longitud
        End Get
        Set(value As Int32)
            Me._Longitud = value
        End Set
    End Property

    Public Property Tipo() As SqlDbType
        Get
            Return Me._Tipo
        End Get
        Set(value As SqlDbType)
            Me._Tipo = value
        End Set
    End Property

    Public Property Direccion() As ParameterDirection
        Get
            Return Me._Direccion
        End Get
        Set(value As ParameterDirection)
            Me._Direccion = value
        End Set
    End Property

#End Region
End Class
