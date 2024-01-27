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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:4817""}]")]
    public class GroupCallCenterGetRoutingPolicyResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterRoutingPolicy _routingPolicy;

        [XmlElement(ElementName = "routingPolicy", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4817")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4817")]
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
