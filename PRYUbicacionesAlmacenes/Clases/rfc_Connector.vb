Imports SAP.Middleware.Connector
Public Class rfc_Connector
    Implements IDestinationConfiguration
    Public Event ConfigurationChanged As RfcDestinationManager.ConfigurationChangeHandler Implements IDestinationConfiguration.ConfigurationChanged

    Public Function GetParameters(destinationName As String) As RfcConfigParameters Implements IDestinationConfiguration.GetParameters
        Dim parms As RfcConfigParameters = New RfcConfigParameters()
        parms.Add(RfcConfigParameters.AppServerHost, "10.253.2.27")
        parms.Add(RfcConfigParameters.SystemNumber, "00")
        parms.Add(RfcConfigParameters.SystemID, "A4D")
        parms.Add(RfcConfigParameters.User, "INTEGRADOR")
        parms.Add(RfcConfigParameters.Password, "Inicio.2023$")
        parms.Add(RfcConfigParameters.Client, "330")
        parms.Add(RfcConfigParameters.SAPRouter, "/H/179.50.79.116")
        parms.Add(RfcConfigParameters.Language, "ES")
        parms.Add(RfcConfigParameters.Name, "SE37")
        parms.Add(RfcConfigParameters.ConnectionIdleTimeout, "600")
        parms.Add(RfcConfigParameters.PoolSize, "10")
        parms.Add(RfcConfigParameters.MessageServerHost, "10.253.2.27")
        Return parms
    End Function

    Public Function ChangeEventsSupported() As Boolean Implements IDestinationConfiguration.ChangeEventsSupported
        Return False
    End Function
End Class
