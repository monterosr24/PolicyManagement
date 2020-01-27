namespace PolicyManagement.Models.ModelView
{
    public class ClientPolicyViewModel: BaseViewModel<int>
    {
        public int ClientId { get; set; }
        public int PolicyId { get; set; }
    }
}
