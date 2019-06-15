using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the data associated with Privacy for a service instance.
    /// The response is either a GroupServiceInstancePrivacyGetResponse17sp4
    /// or an ErrorResponse.
        /// <see cref="GroupServiceInstancePrivacyGetResponse17sp4"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupServiceInstancePrivacyGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
