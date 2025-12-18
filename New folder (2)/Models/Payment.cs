using Store.BaseBackend.Enums;

namespace Store.BaseBackend.Models;

public class Payment : BaseModel
{
    private Payment()
    {
    }

    public CashPaymentStatus? Status { get; set; }
    public double Amount { get; internal set; }
    public DateTime PaymentDateTime { get; internal set; }
    public PaymentType PaymentType { get; internal set; }
    public bool IsCompleted { get; internal set; }

    public static Payment CreateCashPayment(double amount)
    {
        Payment payment = new()
        {
            Status = CashPaymentStatus.Pending,
            Amount = amount,
            PaymentDateTime = DateTime.UtcNow,
            PaymentType = PaymentType.Cash,
            IsCompleted = true
        };

        return payment;
    }

    public static Payment CreateChequePayment(double amount, DateTime paymentDateTime)
    {
        Payment payment = new()
        {
            Status = null,
            Amount = amount,
            PaymentDateTime = paymentDateTime,
            PaymentType = PaymentType.Cheque,
            IsCompleted = false
        };

        return payment;
    }
}

