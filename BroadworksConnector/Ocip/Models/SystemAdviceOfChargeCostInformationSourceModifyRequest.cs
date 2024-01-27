using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a cost information source.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9975efc7f5883a0595f811ee72ba4df5:217""}]")]
    public class SystemAdviceOfChargeCostInformationSourceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _peerIdentity;

        [XmlElement(ElementName = "peerIdentity", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:217")]
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
        protected bool PeerIdentitySpecified { get; set; }

        protected int _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"9975efc7f5883a0595f811ee72ba4df5:217")]
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
        protected bool PrioritySpecified { get; set; }

    }
}
