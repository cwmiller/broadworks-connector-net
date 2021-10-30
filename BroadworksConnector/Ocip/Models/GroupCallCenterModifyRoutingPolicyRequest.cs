using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group call center routing policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5299""}]")]
    public class GroupCallCenterModifyRoutingPolicyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5299")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5299")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterRoutingPolicy _routingPolicy;

        [XmlElement(ElementName = "routingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5299")]
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

        private List<BroadWorksConnector.Ocip.Models.CallCenterRoutingPriorityOrder> _routingPriorityOrder = new List<BroadWorksConnector.Ocip.Models.CallCenterRoutingPriorityOrder>();

        [XmlElement(ElementName = "routingPriorityOrder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5299")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterRoutingPriorityOrder> RoutingPriorityOrder
        {
            get => _routingPriorityOrder;
            set
            {
                RoutingPriorityOrderSpecified = true;
                _routingPriorityOrder = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingPriorityOrderSpecified { get; set; }

    }
}
