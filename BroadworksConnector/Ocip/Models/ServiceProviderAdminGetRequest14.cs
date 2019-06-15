using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a service provider administrators profile.
    /// The response is either a ServiceProviderAdminGetResponse14 or an ErrorResponse.
    /// Replaced by ServiceProviderAdminGetRequest21sp1.
        /// <see cref="ServiceProviderAdminGetResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ServiceProviderAdminGetRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdminGetRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
    }
}
