'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5446
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Infoware.Reglas
Imports System
Imports System.Xml
Imports System.Xml.Serialization


#Region "TransaccionActivo"
Partial Public Class TransaccionActivo
  Inherits _Database

  Private mTransa_Codigo As Integer = 0

  Private mUsuari_Codigo As String = ""

  Private mTransa_Observacion As String = ""

  Private mTransa_Fecha As DateTime = Now

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Transa_Codigo() As Integer
    Get
      Return Me.mTransa_Codigo
    End Get
    Set(value As Integer)
      Me.mTransa_Codigo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Usuari_Codigo() As String
    Get
      Return Me.mUsuari_Codigo
    End Get
    Set(value As String)
      Me.mUsuari_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Transa_Observacion() As String
    Get
      Return Me.mTransa_Observacion
    End Get
    Set(value As String)
      Me.mTransa_Observacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Transa_Fecha() As DateTime
    Get
      Return Me.mTransa_Fecha
    End Get
    Set(value As DateTime)
      Me.mTransa_Fecha = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
