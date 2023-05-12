namespace Cruxlab_lib.Model
{
    public class PasswordRequirementsModel
    {
        public string RequiredString { get; set; }
        public int MinCountOfRequiredString { get; set; }
        public int MaxCountOfRequiredString { get; set; }
        public string Password { get; set; }
    }
}
