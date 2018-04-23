Public Class MyData
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = Value
        End Set
    End Property
    Private m_Name As String

    Public Property Age() As System.Nullable(Of Integer)
        Get
            Return m_Age
        End Get
        Set(ByVal value As System.Nullable(Of Integer))
            m_Age = Value
        End Set
    End Property
    Private m_Age As System.Nullable(Of Integer)

    Public Property Email() As String
        Get
            Return m_Email
        End Get
        Set(ByVal value As String)
            m_Email = Value
        End Set
    End Property
    Private m_Email As String

    Public Property ArrivalDate() As System.Nullable(Of DateTime)
        Get
            Return m_ArrivalDate
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            m_ArrivalDate = Value
        End Set
    End Property
    Private m_ArrivalDate As System.Nullable(Of DateTime)
End Class
