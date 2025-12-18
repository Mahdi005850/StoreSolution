namespace Store.Helpers;

internal class PhoneNumberHelper
{
    internal static bool IsValidPhoneNumber(string phoneNumber)
    {
        if (!string.IsNullOrEmpty(phoneNumber))
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    public static string FormatToValidPhoneNumber(string phoneNumber)
    {
        return phoneNumber;
    }
}
