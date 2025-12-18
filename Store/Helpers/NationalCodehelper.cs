namespace Store.Helpers;

internal class NationalCodehelper
{
    public static bool IsValidNationalCode(string nationalCode)
    {
        if (!string.IsNullOrEmpty(nationalCode))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static string FormatIsValidNatonalCode(string nationalCode)
    {
        return nationalCode;
    }
}
