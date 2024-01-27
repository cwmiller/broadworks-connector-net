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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1eceb69ac1f6f751a3ee0dce729e5cc2:129""}]")]
    public class SystemResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _sendResourcePriorityToNetwork;

        [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:129")]
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
        [Group(@"1eceb69ac1f6f751a3ee0dce729e5cc2:129")]
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
