using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterGetRoutingPolicyRequest.
    /// Contains a table with column headings: "Service User Id", "Name" and
    /// "Priority".
        /// <see cref="GroupCallCenterGetRoutingPolicyRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetRoutingPolicyResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.CallCenterRoutingPolicy _routingPolicy;

        [XmlElement(ElementName = "routingPolicy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterRoutingPolicy RoutingPolicy {
            get => _routingPolicy;
            set {
                RoutingPolicySpecified = true;
                _routingPolicy = value;
            }
        }

        [XmlIgnore]
        public bool RoutingPolicySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallCenterTable {
            get => _callCenterTable;
            set {
                CallCenterTableSpecified = true;
                _callCenterTable = value;
            }
        }

        [XmlIgnore]
        public bool CallCenterTableSpecified { get; set; }
        
    }
}
