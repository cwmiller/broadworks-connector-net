using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a GETS Session Priority Map.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGETSSessionPriorityMapModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        public int PriorityLevel {
            get => _priorityLevel;
            set {
                PriorityLevelSpecified = true;
                _priorityLevel = value;
            }
        }

        [XmlIgnore]
        public bool PriorityLevelSpecified { get; set; }
        
        private int _sessionPriority;

        [XmlElement(ElementName = "sessionPriority", IsNullable = false, Namespace = "")]
        public int SessionPriority {
            get => _sessionPriority;
            set {
                SessionPrioritySpecified = true;
                _sessionPriority = value;
            }
        }

        [XmlIgnore]
        public bool SessionPrioritySpecified { get; set; }
        
    }
}
