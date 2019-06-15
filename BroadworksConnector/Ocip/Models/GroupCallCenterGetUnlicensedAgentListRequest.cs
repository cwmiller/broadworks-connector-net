using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of unlicensed users who are preventing the Call Center from upgrading to another type.
    /// The response is either GroupCallCenterGetUnlicensedAgentListResponse or ErrorResponse.
        /// <see cref="GroupCallCenterGetUnlicensedAgentListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetUnlicensedAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.CallCenterType _callCenterType;

        [XmlElement(ElementName = "callCenterType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterType CallCenterType {
            get => _callCenterType;
            set {
                CallCenterTypeSpecified = true;
                _callCenterType = value;
            }
        }

        [XmlIgnore]
        public bool CallCenterTypeSpecified { get; set; }
        
    }
}
