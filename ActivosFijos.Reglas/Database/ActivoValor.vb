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


#Region "ActivoValor"
Partial Public Class ActivoValor
  Inherits _Database

  Private mActivo_Codigo As Integer = 0

  Private mParame_TipoDepreciacion As Integer = 0

  Private mPardet_TipoDepreciacion As Integer = 0

  Private mActVal_Secuencia As Integer = 0

  Private mParame_TipoValoracion As Integer = 0

  Private mPardet_TipoValoracion As Integer = 0

  Private mActVal_Costo As Decimal = 0

  Private mActVal_Salvamento As Decimal = 0

  Private mActVal_PeriodosDepreciables As Integer = 0

  Private mActVal_FechaValoracion As Date = Now.Date

  Private mEntida_Perito As Integer = 0

  Private mActVal_Activo As Boolean = True

  Private mActCom_Secuencia As Integer = 0

  Private mParame_FrecuenciaDepreciacion As Integer = 0

  Private mPardet_FrecuenciaDepreciacion As Integer = 0

  Private mActVal_ValorErogacion As Decimal = 0

  Public Sub New()
    MyBase.New()
  End Sub

  <XmlAttribute()> _
  Public Overridable Property Activo_Codigo() As Integer
    Get
      Return Me.mActivo_Codigo
    End Get
    Set(value As Integer)
      Me.mActivo_Codigo = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoDepreciacion() As Integer
    Get
      Return Me.mParame_TipoDepreciacion
    End Get
    Set(value As Integer)
      Me.mParame_TipoDepreciacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoDepreciacion() As Integer
    Get
      Return Me.mPardet_TipoDepreciacion
    End Get
    Set(value As Integer)
      Me.mPardet_TipoDepreciacion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_Secuencia() As Integer
    Get
      Return Me.mActVal_Secuencia
    End Get
    Set(value As Integer)
      Me.mActVal_Secuencia = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Parame_TipoValoracion() As Integer
    Get
      Return Me.mParame_TipoValoracion
    End Get
    Set(value As Integer)
      Me.mParame_TipoValoracion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Pardet_TipoValoracion() As Integer
    Get
      Return Me.mPardet_TipoValoracion
    End Get
    Set(value As Integer)
      Me.mPardet_TipoValoracion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_Costo() As Decimal
    Get
      Return Me.mActVal_Costo
    End Get
    Set(value As Decimal)
      Me.mActVal_Costo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_Salvamento() As Decimal
    Get
      Return Me.mActVal_Salvamento
    End Get
    Set(value As Decimal)
      Me.mActVal_Salvamento = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_PeriodosDepreciables() As Integer
    Get
      Return Me.mActVal_PeriodosDepreciables
    End Get
    Set(value As Integer)
      Me.mActVal_PeriodosDepreciables = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_FechaValoracion() As Date
    Get
      Return Me.mActVal_FechaValoracion
    End Get
    Set(value As Date)
      Me.mActVal_FechaValoracion = value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property Entida_Perito() As Integer
    Get
      Return Me.mEntida_Perito
    End Get
    Set(value As Integer)
      Me.mEntida_Perito = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActVal_Activo() As Boolean
    Get
      Return Me.mActVal_Activo
    End Get
    Set(value As Boolean)
      Me.mActVal_Activo = Value
      EsModificado = True
    End Set
  End Property

  <XmlAttribute()> _
  Public Overridable Property ActCom_Secuencia() As Integer
    Get
      Return Me.mActCom_Secuencia
    End Get
    Set(value As Integer)
      Me.mActCom_Secuencia = Value
      EsModificado = True
    End Set
  End Property

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
  Public Overridable Property ActVal_ValorErogacion As Decimal
    Get
      Return mActVal_ValorErogacion
    End Get
    Set(value As Decimal)
      mActVal_ValorErogacion = value
      EsModificado = True
    End Set
  End Property
End Class
#End Region
