using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4821""}]")]
    public class GroupCallCenterGetRoutingPolicyResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CallCenterRoutingPolicy _routingPolicy;

        [XmlElement(ElementName = "routingPolicy", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4821")]
        public BroadWorksConnector.Ocip.Models.CallCenterRoutingPolicy RoutingPolicy
        {
            get => _routingPolicy;
            set
            {
                RoutingPolicySpecified = true;
                _routingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4821")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallCenterTable
        {
            get => _callCenterTable;
            set
            {
                CallCenterTableSpecified = true;
                _callCenterTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterTableSpecified { get; set; }

    }
}
