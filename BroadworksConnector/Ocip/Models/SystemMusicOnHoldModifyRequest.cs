using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Music On Hold.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMusicOnHoldModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _delayMilliseconds;

        [XmlElement(ElementName = "delayMilliseconds", IsNullable = false, Namespace = "")]
        public int DelayMilliseconds {
            get => _delayMilliseconds;
            set {
                DelayMillisecondsSpecified = true;
                _delayMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayMillisecondsSpecified { get; set; }
        
    }
}
