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
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
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
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("A")>  _
        Public ReadOnly Property FullAccess_User() As String
            Get
                Return CType(Me("FullAccess_User"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("A")>  _
        Public ReadOnly Property FullAccess_Pass() As String
            Get
                Return CType(Me("FullAccess_Pass"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property Unit() As Integer
            Get
                Return CType(Me("Unit"),Integer)
            End Get
            Set
                Me("Unit") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public ReadOnly Property FullAccess_level() As Integer
            Get
                Return CType(Me("FullAccess_level"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration() As Integer
            Get
                Return CType(Me("level_Administration"),Integer)
            End Get
            Set
                Me("level_Administration") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement() As Integer
            Get
                Return CType(Me("level_SettingsManagement"),Integer)
            End Get
            Set
                Me("level_SettingsManagement") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_TransactionList() As Integer
            Get
                Return CType(Me("level_Administration_TransactionList"),Integer)
            End Get
            Set
                Me("level_Administration_TransactionList") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_Transporter() As Integer
            Get
                Return CType(Me("level_Administration_Transporter"),Integer)
            End Get
            Set
                Me("level_Administration_Transporter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_Product() As Integer
            Get
                Return CType(Me("level_Administration_Product"),Integer)
            End Get
            Set
                Me("level_Administration_Product") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_Vehicle() As Integer
            Get
                Return CType(Me("level_Administration_Vehicle"),Integer)
            End Get
            Set
                Me("level_Administration_Vehicle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_Operator() As Integer
            Get
                Return CType(Me("level_Administration_Operator"),Integer)
            End Get
            Set
                Me("level_Administration_Operator") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_Customer() As Integer
            Get
                Return CType(Me("level_Administration_Customer"),Integer)
            End Get
            Set
                Me("level_Administration_Customer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_General() As Integer
            Get
                Return CType(Me("level_SettingsManagement_General"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_General") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_Application() As Integer
            Get
                Return CType(Me("level_SettingsManagement_Application"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_Application") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_Reports() As Integer
            Get
                Return CType(Me("level_SettingsManagement_Reports"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_Reports") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_Security() As Integer
            Get
                Return CType(Me("level_SettingsManagement_Security"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_Security") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_Database() As Integer
            Get
                Return CType(Me("level_SettingsManagement_Database"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_Database") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_TransactionList_Create() As Integer
            Get
                Return CType(Me("level_Administration_TransactionList_Create"),Integer)
            End Get
            Set
                Me("level_Administration_TransactionList_Create") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_TransactionList_Edit() As Integer
            Get
                Return CType(Me("level_Administration_TransactionList_Edit"),Integer)
            End Get
            Set
                Me("level_Administration_TransactionList_Edit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_TransactionList_Delete() As Integer
            Get
                Return CType(Me("level_Administration_TransactionList_Delete"),Integer)
            End Get
            Set
                Me("level_Administration_TransactionList_Delete") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_TransactionList_Backup() As Integer
            Get
                Return CType(Me("level_Administration_TransactionList_Backup"),Integer)
            End Get
            Set
                Me("level_Administration_TransactionList_Backup") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_Administration_TransactionList_Restore() As Integer
            Get
                Return CType(Me("level_Administration_TransactionList_Restore"),Integer)
            End Get
            Set
                Me("level_Administration_TransactionList_Restore") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_Database_Backup() As Integer
            Get
                Return CType(Me("level_SettingsManagement_Database_Backup"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_Database_Backup") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property level_SettingsManagement_Database_Restore() As Integer
            Get
                Return CType(Me("level_SettingsManagement_Database_Restore"),Integer)
            End Get
            Set
                Me("level_SettingsManagement_Database_Restore") = value
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
        Friend ReadOnly Property Settings() As Global.JUSWB.My.MySettings
            Get
                Return Global.JUSWB.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
