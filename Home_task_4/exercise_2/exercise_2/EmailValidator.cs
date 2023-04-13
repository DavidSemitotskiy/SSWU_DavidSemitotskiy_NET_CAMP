using System.Text;

namespace exercise_2
{
    public static class EmailValidator
    {
        private static char[] _forbiddenSpecialSymbols = { '\"', '(', ')', ',', ':', ';', '<', '>', '[', ']', '\\' };

        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (!email.Contains('@'))
            {
                return false;
            }

            if (email.Count(c => c == '@') > 1 || email.StartsWith('@') || email.EndsWith('@'))
            {
                return false;
            }

            email = EmailWithoutComments(email);
            string[] parts = email.Split('@');
            string localPart = parts[0];
            string domainPart = parts[1];
            return ValidateLocalPart(localPart) && ValidateDomainPart(domainPart);
        }

        private static bool ValidateLocalPart(string localPart)
        {
            if (localPart.Length > 64)
            {
                return false;
            }

            if (localPart.StartsWith('\"') && localPart.EndsWith('\"'))
            {
            }
            else
            {
                foreach (char specialSymbol in _forbiddenSpecialSymbols)
                {
                    if (localPart.Contains(specialSymbol))
                    {
                        return false;
                    }
                }

                if (localPart.StartsWith('.') || localPart.EndsWith('.'))
                {
                    return false;
                }

                int countDots = localPart.Count(c => c == '.');
                int offset = 0;
                for (int i = 0; i < countDots; i++)
                {
                    offset = localPart.IndexOf('.', offset);
                    if (offset == localPart.Length - 1)
                    {
                        break;
                    }

                    if (localPart[offset + 1] == '.')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool ValidateDomainPart(string domainPart)
        {
            if (domainPart.Length > 255 || domainPart.Length == 1)
            {
                return false;
            }

            if (domainPart.Contains('_'))
            {
                return false;
            }

            return true;
        }

        private static string EmailWithoutComments(string email)
        {
            StringBuilder builder = new StringBuilder(email);
            int offsetLeftBracket = 0;
            int offsetRightBracket = 0;
            int offsetAfterDeleting = 0;
            int countDeleting = 0;
            while ((offsetLeftBracket = email.IndexOf('(', offsetLeftBracket)) != -1)
            {
                offsetRightBracket = email.IndexOf(')', offsetLeftBracket);
                if (offsetRightBracket == -1 || offsetRightBracket < offsetLeftBracket)
                {
                    continue;
                }

                countDeleting = offsetRightBracket - offsetLeftBracket + 1;
                builder.Remove(offsetLeftBracket - offsetAfterDeleting, countDeleting);
                offsetLeftBracket = offsetRightBracket;
                offsetAfterDeleting += countDeleting;
            }

            return builder.ToString();
        }
    }
}
