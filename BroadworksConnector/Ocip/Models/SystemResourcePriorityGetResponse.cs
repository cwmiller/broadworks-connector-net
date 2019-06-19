using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemResourcePriorityGetRequest.
    /// The response contains the system Resource Priority service attributes.
    /// <see cref="SystemResourcePriorityGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0c61aa8506194ca714d0fe1c4a0b57ff:112""}]")]
    public class SystemResourcePriorityGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _sendResourcePriorityToNetwork;

        [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false, Namespace = "")]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:112")]
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
        public bool SendResourcePriorityToNetworkSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _resourcePriority;

        [XmlElement(ElementName = "resourcePriority", IsNullable = false, Namespace = "")]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:112")]
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
        public bool ResourcePrioritySpecified { get; set; }

    }
}
