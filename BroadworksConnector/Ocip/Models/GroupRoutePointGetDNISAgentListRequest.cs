using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of agent who selected the DNIS as the outgoing call.
    /// The response is either GroupRoutePointGetDNISAgentListResponse or ErrorResponse.
        /// <see cref="GroupRoutePointGetDNISAgentListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRoutePointGetDNISAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey {
            get => _dnisKey;
            set {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        public bool DnisKeySpecified { get; set; }
        
    }
}
