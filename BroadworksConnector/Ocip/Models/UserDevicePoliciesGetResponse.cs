using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDevicePoliciesGetRequest. enableDeviceFeatureSynchronization is ignored by the
    /// application server in Multiple User Shared mode.
    /// <see cref="UserDevicePoliciesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32522""}]")]
    public class UserDevicePoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

        [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32522")]
        public BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode
        {
            get => _lineMode;
            set
            {
                LineModeSpecified = true;
                _lineMode = value;
            }
        }

        [XmlIgnore]
        protected bool LineModeSpecified { get; set; }

        private bool _enableDeviceFeatureSynchronization;

        [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32522")]
        public bool EnableDeviceFeatureSynchronization
        {
            get => _enableDeviceFeatureSynchronization;
            set
            {
                EnableDeviceFeatureSynchronizationSpecified = true;
                _enableDeviceFeatureSynchronization = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDeviceFeatureSynchronizationSpecified { get; set; }

    }
}
