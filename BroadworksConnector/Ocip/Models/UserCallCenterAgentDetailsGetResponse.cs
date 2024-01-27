using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterAgentDetailsGetRequest.
    /// Contains the detail information for a Call Center Agent.
    /// <see cref="UserCallCenterAgentDetailsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6638""}]")]
    public class UserCallCenterAgentDetailsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isCallCenterBasicAssigned;

        [XmlElement(ElementName = "isCallCenterBasicAssigned", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6638")]
        public bool IsCallCenterBasicAssigned
        {
            get => _isCallCenterBasicAssigned;
            set
            {
                IsCallCenterBasicAssignedSpecified = true;
                _isCallCenterBasicAssigned = value;
            }
        }

        [XmlIgnore]
        protected bool IsCallCenterBasicAssignedSpecified { get; set; }

        protected bool _isCallCenterStandardAssigned;

        [XmlElement(ElementName = "isCallCenterStandardAssigned", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6638")]
        public bool IsCallCenterStandardAssigned
        {
            get => _isCallCenterStandardAssigned;
            set
            {
                IsCallCenterStandardAssignedSpecified = true;
                _isCallCenterStandardAssigned = value;
            }
        }

        [XmlIgnore]
        protected bool IsCallCenterStandardAssignedSpecified { get; set; }

        protected bool _isCallCenterPremiumAssigned;

        [XmlElement(ElementName = "isCallCenterPremiumAssigned", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6638")]
        public bool IsCallCenterPremiumAssigned
        {
            get => _isCallCenterPremiumAssigned;
            set
            {
                IsCallCenterPremiumAssignedSpecified = true;
                _isCallCenterPremiumAssigned = value;
            }
        }

        [XmlIgnore]
        protected bool IsCallCenterPremiumAssignedSpecified { get; set; }

    }
}
