Imports DevExpress.Xpo

Namespace Salling.Interface

    Public Interface IPlugin
        ReadOnly Property PluginGroup As String
        ReadOnly Property PluginID As String
        ReadOnly Property PluginName As String
        ReadOnly Property PluginDescription As String
        ReadOnly Property PluginVersion As String
        ReadOnly Property Permissions As List(Of KeyValuePair(Of ArrayList, ArrayList))
        Sub Initialize()

        'Function BeforeLoad(e As BeforeLoadArgs) As Boolean

        'Sub AfterLoad(e As BaseArgs)

        'Sub AfterLogin(e As AfterLoginArgs)

        'Function BeforeUnload(e As BaseArgs) As Boolean

        'Sub AfterUnload(e As BaseArgs)

        'Function BeforeUninstall(e As BaseArgs) As Boolean

        'Sub AfterUninstall(e As BaseArgs)

        'Sub UpdateLicenseStatus(e As LicenseStatusArgs)

        'Sub GetLicenseStatus(e As LicenseStatusArgs)

        'Function SaveLicenseKey(e As LicenseStatusArgs, licenseKey As String) As Boolean

        'Function IsCertified() As Boolean

    End Interface

    'Public Enum LicenseControlType
    '    LicenseCode
    '    Dongle
    'End Enum

    'Public Enum LicenseStatus
    '    NotAvailable
    '    Unregistered
    '    PermanentLicense
    '    TemporaryLicense
    '    Free
    '    [Custom]
    'End Enum

    'Public Class LicenseStatusArgs
    '    Inherits BaseArgs
    '    Private myLicenseStatus As LicenseStatus = LicenseStatus.Unregistered
    '    Private myExpiryDate As DateTime = DateTime.MinValue
    '    Private myCustomLicenseStatus As String = "Custom"

    '    Public Property LicenseStatus() As LicenseStatus
    '        Get
    '            Return Me.myLicenseStatus
    '        End Get
    '        Set(value As LicenseStatus)
    '            Me.myLicenseStatus = value
    '        End Set
    '    End Property

    '    Public Property ExpiryDate() As DateTime
    '        Get
    '            Return Me.myExpiryDate
    '        End Get
    '        Set(value As DateTime)
    '            Me.myExpiryDate = value
    '        End Set
    '    End Property

    '    Public Property CustomLicenseStatus() As String
    '        Get
    '            Return Me.myCustomLicenseStatus
    '        End Get
    '        Set(value As String)
    '            Me.myCustomLicenseStatus = value
    '        End Set
    '    End Property

    '    Public Sub New(uow As UnitOfWork, guid As Guid, plugInFolder As String, companyName As String, address1 As String, lcType As LicenseControlType, dgSerialNumber As Byte())
    '        MyBase.New(uow, guid, plugInFolder, companyName, address1, lcType, dgSerialNumber)
    '    End Sub
    'End Class

    'Public Class BaseArgs
    '    Private myuow As UnitOfWork
    '    Private myGuid As Guid
    '    Private myPlugInFolder As String
    '    Private myCompanyName As String
    '    Private myAddress1 As String
    '    Private myLicenseControlType As LicenseControlType
    '    Private myDongleSerialNumber As Byte()

    '    Public ReadOnly Property UOW() As UnitOfWork
    '        Get
    '            Return Me.myuow
    '        End Get
    '    End Property

    '    Public ReadOnly Property Guid() As Guid
    '        Get
    '            Return Me.myGuid
    '        End Get
    '    End Property

    '    Public ReadOnly Property PlugInFolder() As String
    '        Get
    '            Return Me.myPlugInFolder
    '        End Get
    '    End Property

    '    Public ReadOnly Property CompanyName() As String
    '        Get
    '            Return Me.myCompanyName
    '        End Get
    '    End Property

    '    Public ReadOnly Property Address1() As String
    '        Get
    '            Return Me.myAddress1
    '        End Get
    '    End Property

    '    Public ReadOnly Property LicenseControlType() As LicenseControlType
    '        Get
    '            Return Me.myLicenseControlType
    '        End Get
    '    End Property

    '    Public ReadOnly Property DongleSerialNumber() As Byte()
    '        Get
    '            Return Me.myDongleSerialNumber
    '        End Get
    '    End Property

    '    Public Sub New(uow As UnitOfWork, guid As Guid, plugInFolder As String, companyName As String, address1 As String, lcType As LicenseControlType, dgSerialNumber As Byte())
    '        Me.myuow = uow
    '        Me.myGuid = guid
    '        Me.myPlugInFolder = plugInFolder
    '        Me.myCompanyName = companyName
    '        Me.myAddress1 = address1
    '        Me.myLicenseControlType = lcType
    '        Me.myDongleSerialNumber = dgSerialNumber
    '    End Sub
    'End Class

    'Public Class BeforeLoadArgs
    '    Inherits BaseArgs
    '    Private myAccessRightFilename As String = ""
    '    Private myMainMenuCaption As String = ""
    '    Private mySystemReportFilename As String = ""

    '    <Obsolete("Use BCE.AutoCount.AccessRight.AccessRightMap.AddAccessRightRecord or BCE.AutoCount.AccessRight.AccessRightMap.RemoveAccessRightRecord instead.")> _
    '    Public Property AccessRightFilename() As String
    '        Get
    '            Return Me.myAccessRightFilename
    '        End Get
    '        Set(value As String)
    '            Me.myAccessRightFilename = value
    '        End Set
    '    End Property

    '    Public Property SystemReportFilename() As String
    '        Get
    '            Return Me.mySystemReportFilename
    '        End Get
    '        Set(value As String)
    '            Me.mySystemReportFilename = value
    '        End Set
    '    End Property

    '    Public Property MainMenuCaption() As String
    '        Get
    '            Return Me.myMainMenuCaption
    '        End Get
    '        Set(value As String)
    '            Me.myMainMenuCaption = value
    '        End Set
    '    End Property

    '    Public Sub New(uow As UnitOfWork, guid As Guid, plugInFolder As String, companyName As String, address1 As String, lcType As LicenseControlType, dgSerialNumber As Byte())
    '        MyBase.New(uow, guid, plugInFolder, companyName, address1, lcType, dgSerialNumber)
    '    End Sub
    'End Class

    'Public Class AfterLoginArgs
    '    Inherits BaseArgs
    '    Private myVisible As Boolean = True
    '    Private myMainMenuCaption As String = ""

    '    Public Property Visible() As Boolean
    '        Get
    '            Return Me.myVisible
    '        End Get
    '        Set(value As Boolean)
    '            Me.myVisible = value
    '        End Set
    '    End Property

    '    Public Property MainMenuCaption() As String
    '        Get
    '            Return Me.myMainMenuCaption
    '        End Get
    '        Set(value As String)
    '            Me.myMainMenuCaption = value
    '        End Set
    '    End Property

    '    Public Sub New(uow As UnitOfWork, guid As Guid, plugInFolder As String, companyName As String, address1 As String, lcType As LicenseControlType, dgSerialNumber As Byte())
    '        MyBase.New(uow, guid, plugInFolder, companyName, address1, lcType, dgSerialNumber)
    '    End Sub
    'End Class

End Namespace