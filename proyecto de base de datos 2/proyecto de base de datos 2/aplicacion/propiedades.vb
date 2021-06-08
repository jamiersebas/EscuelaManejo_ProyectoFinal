Public Class propiedades


    Private _id_personal As Integer
    Private _direccion_personal As String
    Private _nombre_personal As String
    Private _apellido_personal As String
    Private _fecha_nacimiento As String
    Private _fecha_contratacion As String
    Private _telefono_personal As String
    Private _email_personal As String
    Private _fecha_baja As String
    Private _estado As String
    Private _puesto As String
    Private _id_catalogo As Integer
    Private _usuario As String
    Private _contraseña As String



    Public Property id_personal As Integer
        Get
            Return _id_personal
        End Get
        Set(value As Integer)
            _id_personal = value

        End Set
    End Property
    Public Property direccion_personal As String
        Get
            Return _direccion_personal
        End Get
        Set(value As String)
            _direccion_personal = value

        End Set
    End Property

    Public Property nombre_personal As String
        Get
            Return _nombre_personal
        End Get
        Set(value As String)
            _nombre_personal = value

        End Set
    End Property
    Public Property apellido_personal As String
        Get
            Return _apellido_personal
        End Get
        Set(value As String)
            _apellido_personal = value

        End Set
    End Property
    Public Property fecha_nacimiento As String
        Get
            Return _fecha_nacimiento
        End Get
        Set(value As String)
            _fecha_nacimiento = value

        End Set
    End Property
    Public Property fecha_contratacion As String
        Get
            Return _fecha_contratacion
        End Get
        Set(value As String)
            _fecha_contratacion = value

        End Set
    End Property
    Public Property telefono_personal As String
        Get
            Return _telefono_personal
        End Get
        Set(value As String)
            _telefono_personal = value

        End Set
    End Property
    Public Property email_personal As String
        Get
            Return _email_personal
        End Get
        Set(value As String)
            _email_personal = value

        End Set
    End Property
    Public Property fecha_baja As String
        Get
            Return _fecha_baja
        End Get
        Set(value As String)
            _fecha_baja = value

        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value

        End Set
    End Property
    Public Property puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value

        End Set
    End Property

    Public Property id_catalogo As Integer
        Get
            Return _id_catalogo
        End Get
        Set(value As Integer)
            _id_catalogo = value

        End Set

    End Property
    Public Property usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value

        End Set

    End Property
    Public Property contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value

        End Set

    End Property


End Class

