namespace PolicyManagement.Models.Model
{
    public class ClientPolicyView: BaseView
    {
        public string NameClient { get; set; }
        public string LastName { get; set; }
        public string NamePolicy { get; set; }
        public int Period { get; set; }
        public string Type { get; set; }
        public string NameCovering { get; set; }
        public int Percentage { get; set; }
    }
}
