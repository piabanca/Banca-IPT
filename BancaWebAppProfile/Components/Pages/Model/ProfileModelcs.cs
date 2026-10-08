namespace BancaWebAppProfile.Components.Pages.Model
{
    public class ProfileModel
    {
        public string FullName { get; set; } = "";
        public string Program { get; set; } = "";
        public string Bio { get; set; } = "";
        public string Location { get; set; } = "";
        public string Email { get; set; } = "";
        public int Projects { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
    }
}