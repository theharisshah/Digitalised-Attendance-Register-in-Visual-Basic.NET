Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("Barcode Enabled Attendance Record System")> 
<Assembly: AssemblyDescription("Thank You for using this software. This project aims at providing user friendly interface for maintaining Employee Record and Attendance. We hope you like the software and any suggestions will be cordially welcomed.")> 
<Assembly: AssemblyCompany("Developers:: Rohit;Yogesh;Ravi;Manish;Vikas")> 
<Assembly: AssemblyProduct("")> 
<Assembly: AssemblyCopyright("(c) 2007")> 
<Assembly: AssemblyTrademark("B.E.A.R.S")> 
<Assembly: CLSCompliant(True)> 

<Assembly: AssemblyVersion("0.9.*")> 

#Region " Helper Class to Get Information for the About form. "
' This class uses the System.Reflection.Assembly class to
' access assembly meta-data
' This class is not a normal feature of AssemblyInfo.vb
Public Class AssemblyInfo
    ' Used by Helper Functions to access information from Assembly Attributes
    Private myType As Type

   

    Public ReadOnly Property AsmName() As String
        Get
            Return myType.Assembly.GetName.Name.ToString()
        End Get
    End Property
    Public ReadOnly Property AsmFQName() As String
        Get
            Return myType.Assembly.GetName.FullName.ToString()
        End Get
    End Property
    Public ReadOnly Property CodeBase() As String
        Get
            Return myType.Assembly.CodeBase
        End Get
    End Property
    Public ReadOnly Property Copyright() As String
        Get
            Dim at As Type = GetType(AssemblyCopyrightAttribute)
            Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
            Dim ct As AssemblyCopyrightAttribute = CType(r(0), AssemblyCopyrightAttribute)
            Return ct.Copyright
        End Get
    End Property
    Public ReadOnly Property Company() As String
        Get
            Dim at As Type = GetType(AssemblyCompanyAttribute)
            Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
            Dim ct As AssemblyCompanyAttribute = CType(r(0), AssemblyCompanyAttribute)
            Return ct.Company
        End Get
    End Property
    Public ReadOnly Property Description() As String
        Get
            Dim at As Type = GetType(AssemblyDescriptionAttribute)
            Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
            Dim da As AssemblyDescriptionAttribute = CType(r(0), AssemblyDescriptionAttribute)
            Return da.Description
        End Get
    End Property
    Public ReadOnly Property Product() As String
        Get
            Dim at As Type = GetType(AssemblyProductAttribute)
            Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
            Dim pt As AssemblyProductAttribute = CType(r(0), AssemblyProductAttribute)
            Return pt.Product
        End Get
    End Property
    Public ReadOnly Property Title() As String
        Get
            Dim at As Type = GetType(AssemblyTitleAttribute)
            Dim r() As Object = myType.Assembly.GetCustomAttributes(at, False)
            Dim ta As AssemblyTitleAttribute = CType(r(0), AssemblyTitleAttribute)
            Return ta.Title
        End Get
    End Property
    Public ReadOnly Property Version() As String
        Get
            Return myType.Assembly.GetName.Version.ToString()
        End Get
    End Property
End Class

#End Region