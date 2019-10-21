Imports DevExpress
Imports DevExpress.Xpo
Imports Salling.UI

Namespace Salling.Interface
    Public Interface IGraphical
        Inherits [Interface].IPlugin
        ReadOnly Property Dashboard As Dashboard

    End Interface

End Namespace