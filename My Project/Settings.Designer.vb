﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportDateType() As String
            Get
                Return CType(Me("TurtleTagReportDateType"),String)
            End Get
            Set
                Me("TurtleTagReportDateType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportIncludeRelinquishedTurtles() As String
            Get
                Return CType(Me("TurtleTagReportIncludeRelinquishedTurtles"),String)
            End Get
            Set
                Me("TurtleTagReportIncludeRelinquishedTurtles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportDateFrom() As String
            Get
                Return CType(Me("TurtleTagReportDateFrom"),String)
            End Get
            Set
                Me("TurtleTagReportDateFrom") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportDateThru() As String
            Get
                Return CType(Me("TurtleTagReportDateThru"),String)
            End Get
            Set
                Me("TurtleTagReportDateThru") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportPit() As String
            Get
                Return CType(Me("TurtleTagReportPit"),String)
            End Get
            Set
                Me("TurtleTagReportPit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportLff() As String
            Get
                Return CType(Me("TurtleTagReportLff"),String)
            End Get
            Set
                Me("TurtleTagReportLff") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportRff() As String
            Get
                Return CType(Me("TurtleTagReportRff"),String)
            End Get
            Set
                Me("TurtleTagReportRff") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportLrf() As String
            Get
                Return CType(Me("TurtleTagReportLrf"),String)
            End Get
            Set
                Me("TurtleTagReportLrf") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportRrf() As String
            Get
                Return CType(Me("TurtleTagReportRrf"),String)
            End Get
            Set
                Me("TurtleTagReportRrf") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property MainShowInactiveTurtles() As Boolean
            Get
                Return CType(Me("MainShowInactiveTurtles"),Boolean)
            End Get
            Set
                Me("MainShowInactiveTurtles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property HoldingIncludeAnomalies() As Boolean
            Get
                Return CType(Me("HoldingIncludeAnomalies"),Boolean)
            End Get
            Set
                Me("HoldingIncludeAnomalies") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property HoldingIncludeAcquiredFrom() As Boolean
            Get
                Return CType(Me("HoldingIncludeAcquiredFrom"),Boolean)
            End Get
            Set
                Me("HoldingIncludeAcquiredFrom") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property HoldingIncludeTurtleName() As Boolean
            Get
                Return CType(Me("HoldingIncludeTurtleName"),Boolean)
            End Get
            Set
                Me("HoldingIncludeTurtleName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property HoldingGroupTankBy() As String
            Get
                Return CType(Me("HoldingGroupTankBy"),String)
            End Get
            Set
                Me("HoldingGroupTankBy") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property MainFormLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("MainFormLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("MainFormLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property MainFormSize() As Global.System.Drawing.Size
            Get
                Return CType(Me("MainFormSize"),Global.System.Drawing.Size)
            End Get
            Set
                Me("MainFormSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property FirstRun() As Boolean
            Get
                Return CType(Me("FirstRun"),Boolean)
            End Get
            Set
                Me("FirstRun") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TaggingDataAdditionalRemarks() As Boolean
            Get
                Return CType(Me("TaggingDataAdditionalRemarks"),Boolean)
            End Get
            Set
                Me("TaggingDataAdditionalRemarks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TaggingDataPopulateFacilityField() As Boolean
            Get
                Return CType(Me("TaggingDataPopulateFacilityField"),Boolean)
            End Get
            Set
                Me("TaggingDataPopulateFacilityField") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("R")>  _
        Public Property TaggingDataMorphometrics() As String
            Get
                Return CType(Me("TaggingDataMorphometrics"),String)
            End Get
            Set
                Me("TaggingDataMorphometrics") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property TurtleTagReportIncludeStrandingIdNumber() As String
            Get
                Return CType(Me("TurtleTagReportIncludeStrandingIdNumber"),String)
            End Get
            Set
                Me("TurtleTagReportIncludeStrandingIdNumber") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TaggingDataPrintSidOnForm() As Boolean
            Get
                Return CType(Me("TaggingDataPrintSidOnForm"),Boolean)
            End Get
            Set
                Me("TaggingDataPrintSidOnForm") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TurtleGeek.Roster.My.MySettings
            Get
                Return Global.TurtleGeek.Roster.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace