public class RandomPassword
{
    public static string GetRandomPassword(int length)
    {
        char[] chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".ToCharArray();

        string password = string.Empty;
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int x = random.Next(chars.Length);

            if (!password.Contains(chars[x]))
            {
                password += chars[x];
            }
            else
            {
                i--;
            }
        }

        return password;
    }
}