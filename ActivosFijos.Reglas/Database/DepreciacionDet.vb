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


#Region "DepreciacionDet"
Partial Public Class DepreciacionDet
  Inherits _Database

  Private mParame_FrecuenciaDepreciacion As Integer = 0

  Private mPardet_FrecuenciaDepreciacion As Integer = 0

  Private mParame_TipoDepreciacion As Integer = 0

  Private mPardet_TipoDepreciacion As Integer = 0

  Private mDeprec_Codigo As String = ""

  Private mActivo_Codigo As Integer = 0

  Private mActVal_Secuencia As Integer = 0

  Private mDeprec_Valor As Decimal = 0

  Private mDeprec_CtaActivoFijo As String = ""

  Private mDeprec_CtaCentroCosto As String = ""

  Private mDeprec_CtaGasto As String = ""

  Private mDeprec_Ubicacion As String = ""

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Parame_FrecuenciaDepreciacion() As Integer
    Get
      Return Me.mParame_FrecuenciaDepreciacion
    End Get
    Set(value As Integer)
      Me.mParame_FrecuenciaDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_FrecuenciaDepreciacion() As Integer
    Get
      Return Me.mPardet_FrecuenciaDepreciacion
    End Get
    Set(value As Integer)
      Me.mPardet_FrecuenciaDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_Codigo() As String
    Get
      Return Me.mDeprec_Codigo
    End Get
    Set(value As String)
      Me.mDeprec_Codigo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Activo_Codigo() As Integer
    Get
      Return Me.mActivo_Codigo
    End Get
    Set(value As Integer)
      Me.mActivo_Codigo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoDepreciacion() As Integer
    Get
      Return Me.mParame_TipoDepreciacion
    End Get
    Set(value As Integer)
      Me.mParame_TipoDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoDepreciacion() As Integer
    Get
      Return Me.mPardet_TipoDepreciacion
    End Get
    Set(value As Integer)
      Me.mPardet_TipoDepreciacion = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_Secuencia() As Integer
    Get
      Return Me.mActVal_Secuencia
    End Get
    Set(value As Integer)
      Me.mActVal_Secuencia = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_Valor() As Decimal
    Get
      Return Me.mDeprec_Valor
    End Get
    Set(value As Decimal)
      Me.mDeprec_Valor = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_CtaActivoFijo() As String
    Get
      Return Me.mDeprec_CtaActivoFijo
    End Get
    Set(value As String)
      Me.mDeprec_CtaActivoFijo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_CtaCentroCosto() As String
    Get
      Return Me.mDeprec_CtaCentroCosto
    End Get
    Set(value As String)
      Me.mDeprec_CtaCentroCosto = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_CtaGasto() As String
    Get
      Return Me.mDeprec_CtaGasto
    End Get
    Set(value As String)
      Me.mDeprec_CtaGasto = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Deprec_Ubicacion() As String
    Get
      Return Me.mDeprec_Ubicacion
    End Get
    Set(value As String)
      Me.mDeprec_Ubicacion = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region