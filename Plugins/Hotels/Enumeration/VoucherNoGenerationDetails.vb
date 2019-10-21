Namespace Salling.HOTELS.ORM
    Public Class VoucherNoGenerationDetails
        'voucher number generation types
        Public Enum GenerationType
            Generate_General_Voucher_No
            Generate_Private_Voucher_No
        End Enum

        'if voucher generation type is private 
        Public Enum PrivateGenerationType
            Manual
            Auto
        End Enum
    End Class
End Namespace
