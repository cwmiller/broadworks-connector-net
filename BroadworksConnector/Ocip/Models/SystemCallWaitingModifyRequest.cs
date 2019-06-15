using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Waiting.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallWaitingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _playDistinctiveRingback;

        [XmlElement(ElementName = "playDistinctiveRingback", IsNullable = false, Namespace = "")]
        public bool PlayDistinctiveRingback {
            get => _playDistinctiveRingback;
            set {
                PlayDistinctiveRingbackSpecified = true;
                _playDistinctiveRingback = value;
            }
        }

        [XmlIgnore]
        public bool PlayDistinctiveRingbackSpecified { get; set; }
        
    }
}
