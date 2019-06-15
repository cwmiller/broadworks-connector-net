using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDirectRouteGetRequest.
    /// Contains the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
        /// <see cref="UserDirectRouteGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserDirectRouteGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy _outgoingDTGPolicy;

        [XmlElement(ElementName = "outgoingDTGPolicy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy OutgoingDTGPolicy {
            get => _outgoingDTGPolicy;
            set {
                OutgoingDTGPolicySpecified = true;
                _outgoingDTGPolicy = value;
            }
        }

        [XmlIgnore]
        public bool OutgoingDTGPolicySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy _outgoingTrunkIdentityPolicy;

        [XmlElement(ElementName = "outgoingTrunkIdentityPolicy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy OutgoingTrunkIdentityPolicy {
            get => _outgoingTrunkIdentityPolicy;
            set {
                OutgoingTrunkIdentityPolicySpecified = true;
                _outgoingTrunkIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        public bool OutgoingTrunkIdentityPolicySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DirectRouteIdentifiers _directRouteIdentityList;

        [XmlElement(ElementName = "directRouteIdentityList", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DirectRouteIdentifiers DirectRouteIdentityList {
            get => _directRouteIdentityList;
            set {
                DirectRouteIdentityListSpecified = true;
                _directRouteIdentityList = value;
            }
        }

        [XmlIgnore]
        public bool DirectRouteIdentityListSpecified { get; set; }
        
    }
}
