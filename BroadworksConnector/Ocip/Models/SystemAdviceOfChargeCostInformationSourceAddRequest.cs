using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a cost information source. The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:154""}]")]
    public class SystemAdviceOfChargeCostInformationSourceAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _peerIdentity;

        [XmlElement(ElementName = "peerIdentity", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:154")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PeerIdentity
        {
            get => _peerIdentity;
            set
            {
                PeerIdentitySpecified = true;
                _peerIdentity = value;
            }
        }

        [XmlIgnore]
        public bool PeerIdentitySpecified { get; set; }

        private int _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:154")]
        [MinInclusive(0)]
        [MaxInclusive(9)]
        public int Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }

    }
}
