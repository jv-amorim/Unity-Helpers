namespace UnityHelpers.EmailHelpers
{
    public class EmailMessage
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string SenderEmailAddress { get; set; }
        public string SenderPassword { get; set; }
        public string MessageBody { get; set; }
        public bool IsBodyHtml { get; set; }
        public string Subject { get; set; }
        public string RecepientEmailAddress { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Host) || string.IsNullOrEmpty(SenderPassword))
                return false;
            if (Port < 0 || Port > 65535)
                return false;
            if (!EmailValidator.Validate(SenderEmailAddress))
                return false;
            if (!EmailValidator.Validate(RecepientEmailAddress))
                return false;

            return true;
        }
    }
}