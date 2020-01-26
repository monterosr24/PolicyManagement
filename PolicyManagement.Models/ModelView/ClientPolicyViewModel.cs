namespace PolicyManagement.Models.ModelView
{
    public class ClientPolicyViewModel
    {
        public int ClientId { get; set; }
        public int PolicyId { get; set; }
        public string NameClient { get; set; }
        public string LastName { get; set; }
        public string NamePolicy { get; set; }
        public int Period { get; set; }
        public string Type { get; set; }
        public string NameCovering { get; set; }
        public int Percentage { get; set; }
    }
}
