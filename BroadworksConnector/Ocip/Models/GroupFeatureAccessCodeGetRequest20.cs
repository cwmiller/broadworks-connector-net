using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get group FAC code level and the list of feature access codes for a group.
    /// The response is either a GroupFeatureAccessCodeGetResponse20 or an
    /// ErrorResponse.
    /// Returned Feature Access Codes may be group specific, or Service Provider
    /// Feature Access Codes, depending on FAC code level.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by: GroupFeatureAccessCodeGetRequest21
        /// <see cref="GroupFeatureAccessCodeGetResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupFeatureAccessCodeGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupFeatureAccessCodeGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
    }
}
