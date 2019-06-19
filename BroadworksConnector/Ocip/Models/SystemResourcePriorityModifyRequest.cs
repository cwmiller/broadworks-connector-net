using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system Resource Priority service attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0c61aa8506194ca714d0fe1c4a0b57ff:129""}]")]
    public class SystemResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _sendResourcePriorityToNetwork;

        [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:129")]
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
        [Optional]
        [Group(@"0c61aa8506194ca714d0fe1c4a0b57ff:129")]
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
