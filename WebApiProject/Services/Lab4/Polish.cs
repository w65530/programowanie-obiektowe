namespace WebApiProject.Services.Lab4
{
    public class Polish : Language, ILanguage
    {
        public Polish(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string GetLanguageName()
        {
            return Name;
        }
        public override string getLang()
        {
            return "pl";
        }
    }
}
