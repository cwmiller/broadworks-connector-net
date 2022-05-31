using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Resource Priority service attributes for the reseller.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0c61aa8506194ca714d0fe1c4a0b57ff:82""}]")]
    public class ResellerResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:82")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected bool _useSystemSettings;

        [XmlElement(ElementName = "useSystemSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:82")]
        public bool UseSystemSettings
        {
            get => _useSystemSettings;
            set
            {
                UseSystemSettingsSpecified = true;
                _useSystemSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemSettingsSpecified { get; set; }

        protected bool _sendResourcePriorityToNetwork;

        [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:82")]
        public bool SendResourcePriorityToNetwork
        {
            get => _sendResourcePriorityToNetwork;
            set
            {
                SendResourcePriorityToNetworkSpecified = true;
                _sendResourcePriorityToNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool SendResourcePriorityToNetworkSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResourcePriorityValue _resourcePriority;

        [XmlElement(ElementName = "resourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:82")]
        public BroadWorksConnector.Ocip.Models.ResourcePriorityValue ResourcePriority
        {
            get => _resourcePriority;
            set
            {
                ResourcePrioritySpecified = true;
                _resourcePriority = value;
            }
        }

        [XmlIgnore]
        protected bool ResourcePrioritySpecified { get; set; }

    }
}
