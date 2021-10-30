using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a GETS Session Priority map.  It maps a priority level with a session priority AVP value.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11134""}]")]
    public class SystemGETSSessionPriorityMapAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11134")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int PriorityLevel
        {
            get => _priorityLevel;
            set
            {
                PriorityLevelSpecified = true;
                _priorityLevel = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityLevelSpecified { get; set; }

        private int _sessionPriority;

        [XmlElement(ElementName = "sessionPriority", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11134")]
        [MinInclusive(0)]
        [MaxInclusive(4)]
        public int SessionPriority
        {
            get => _sessionPriority;
            set
            {
                SessionPrioritySpecified = true;
                _sessionPriority = value;
            }
        }

        [XmlIgnore]
        protected bool SessionPrioritySpecified { get; set; }

    }
}
