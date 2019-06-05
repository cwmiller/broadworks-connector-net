using BroadworksConnector.Ocip.Models;

namespace BroadworksConnector.Ocip
{
    public class UserDetails
    {
        public LoginType LoginType { get; set; }

        public string Locale { get; set; }

        public string Encoding { get; set; }

        public string GroupId { get; set; }

        public string ServiceProviderId { get; set; }

        public bool IsEnterprise { get; set; }

        public int PasswordExpiresDays { get; set; }

        public string UserDomain { get; set; }

        public string ResellerId { get; set; }
    }
}
