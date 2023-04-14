namespace exercise_2
{
    public class Program
    {
        public static void Main()
        {
            string[] emails = { "sim ple@example.com", "very..common@example.com",
                "A@b@c@example.com", "davidsemitotskiy(comment)@gmail.com(\\ldawl@@)",
                "other.email-with-hyphen@example.com", "\"john..doe\"@example.org",
                "a\"b(c)d, e:f; g<h> i[j\\k]l @example.com", "just\"not\"right@example.com",
                "1234567890123456789012345678901234567890123456789012345678901234+x@example.com",
                "i_like_underscore@but_its_not_allow_in _this_part.example.com", "rozhik@ziet.zhitomir.ua", "rozhik@ziet.zhitomir.ecaw",
                "\"@@@wda\"@gmail.com", "dwaf@dwaf@gmail.com"
            };

            foreach (string email in emails)
            {
                Console.Write($"{email} is ");
                Console.WriteLine(EmailValidator.ValidateEmail(email) ? "valid" : "not valid");
            }
        }
    }
}
