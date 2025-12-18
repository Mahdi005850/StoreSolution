namespace Store.BaseBackend.Enums;

internal enum OrderStatus
{
    None = 0,
    PreApproval = 5,
    Aproved = 10,
    Payed_Completed = 20, 
    Processing = 30, 
    Canceled = 40,
    Delivered = 50,
}
