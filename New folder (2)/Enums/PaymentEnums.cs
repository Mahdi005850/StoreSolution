namespace Store.BaseBackend.Enums;

public enum PaymentType
{
    Cash = 10, 
    Cheque = 20,
}

public enum CashPaymentStatus
{
    Pending = 10,
    Paid = 20, 
    Returned = 30,
} 
public enum ChequePaymentStatus
{
    Pending = 10,       //waiting 
    Cleared = 20,      //paid
    Bounced = 30,     //returned
    Collected = 40,  //the second option of paid 
}
