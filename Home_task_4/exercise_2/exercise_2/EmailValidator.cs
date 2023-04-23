using System.Text;

namespace exercise_2
{
    public static class EmailValidator
    {
        private static char[] _forbiddenSpecialSymbols = { '\"', '(', ')', ',', ':', ';', '<', '>', '[', ']', '\\', ' ' };

        private static string[] _reservedDomains = { "com", "edu", "org", "uk", "de", "ua" };

        public static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            if (!email.Contains('@') || email.StartsWith('@') || email.EndsWith('@'))
            {
                return false;
            }
// Можна б було посплітити по собачці і перевірити, чи довжина результату є 2, а потім вже продовжити
            email = EmailWithoutComments(email);
            int lastIndex = email.LastIndexOf('@');
            string localPart = email[..lastIndex];
            string domainPart = email[(lastIndex + 1)..];
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
                string value = localPart[1..(localPart.Length - 1)];
                if (value.Contains('\"') || value.Contains('\\'))
                {
                    return false;
                }
            }
            else
            {
                if (localPart.Contains('@') || localPart.StartsWith('.') || localPart.EndsWith('.') || ContainsForbiddenSpecialSymbols(localPart) || ContainsDoubleDots(localPart))
                {
                    return false;
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

            if (domainPart.Contains('_') || domainPart.StartsWith('.') || domainPart.EndsWith('.') || ContainsForbiddenSpecialSymbols(domainPart))
            {
                return false;
            }

            string[] dnsMarks = domainPart.Split('.');
            return ValidateDnsMarks(dnsMarks);
        }

        private static bool ValidateDnsMarks(string[] dnsMarks)
        {
            if (dnsMarks.FirstOrDefault(dns => dns == "") != null)
            {
                return false;
            }

            foreach (string dnsMark in dnsMarks)
            {
                if (dnsMark.Length > 63)
                {
                    return false;
                }

                if (dnsMark.StartsWith('-') || dnsMark.EndsWith('-'))
                {
                    return false;
                }
            }

            bool contains = false;
            foreach (var domain in _reservedDomains)
            {
                if (dnsMarks[dnsMarks.Length - 1] == domain)
                {
                    contains = true;
                    break;
                }
            }

            if (!contains)
            {
                return false;
            }

            return true;
        }

        private static bool ContainsForbiddenSpecialSymbols(string part)
        {
            foreach (char specialSymbol in _forbiddenSpecialSymbols)
            {
                if (part.Contains(specialSymbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ContainsDoubleDots(string part)
        {
            int countDots = part.Count(c => c == '.');
            int offset = 0;
            for (int i = 0; i < countDots - 1; i++)
            {
                offset = part.IndexOf('.', offset);
                if (offset == part.Length - 1)
                {
                    break;
                }

                if (part[offset + 1] == '.')
                {
                    return true;
                }
            }

            return false;
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
