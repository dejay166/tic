using System.Globalization;
namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string TestType { get; set; }
        public string TestArea { get; set; }
        public string TestFocus { get; set; }
        public string Idea { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/contacts/{0}", this.ContactId);
            }
            set { }
        }
    }
}