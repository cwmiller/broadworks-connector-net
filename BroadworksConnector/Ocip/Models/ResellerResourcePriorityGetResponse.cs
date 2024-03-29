using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerResourcePriorityGetRequest.
    /// The response contains the reseller Resource Priority service attributes.
    /// If useSystemSettings is true, the parameters sendResourcePriorityToNetwork and
    /// resourcePriority will not be returned in the response.
    /// <see cref="ResellerResourcePriorityGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1eceb69ac1f6f751a3ee0dce729e5cc2:63""}]")]
    public class ResellerResourcePriorityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useSystemSettings;

        [XmlElement(ElementName = "useSystemSettings", IsNullable = false, Namespace = "")]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:63")]
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
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:63")]
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
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:63")]
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
