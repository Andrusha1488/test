namespace test1practic
{
    public class Class1
    {
        public static int PasswordVerify(string password)
        {
            int result = 0;
            if (password.Length >= 7)
            {
                result++;

            }

            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    result++;
                    break;
                }
            }

            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    result++;
                    break;
                }
            }

            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    result++;
                    break;
                }
            }

            char[] specialCharacters = "!@#$%^&*()_+-=[]{}|;':\",.<>?/`~".ToCharArray();
            foreach (char c in password)
            {
                if (specialCharacters.Contains(c))
                {
                    result++;
                    break;
                }
            }

            return result;
        }
    }
}
