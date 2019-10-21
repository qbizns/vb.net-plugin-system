Namespace Salling.HOTELS.ORM
    Public Class Charges

        'charge types
        Public Enum CahargeTypes
            Always_Charge
            Extra_charge
            Payable
            Receivable
        End Enum

        'Post Types
        Public Enum PostTypes
            Check_In_and_Check_out
            Every_Day
            Every_Day_Except_Check_In
            Every_Day_Except_Check_In_And_Check_Out
            On_Check_In
            On_Check_Out
        End Enum

        'Qty Types
        Public Enum QtyTypes
            Per_Qty
            Per_Adult
            Per_Child
            Per_Person
        End Enum

    End Class
End Namespace
