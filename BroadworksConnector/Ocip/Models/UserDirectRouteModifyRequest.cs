using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserDirectRouteModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.DirectRouteReplacementIdentityList _directRouteIdentityList;

        [XmlElement(ElementName = "directRouteIdentityList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DirectRouteReplacementIdentityList DirectRouteIdentityList {
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
