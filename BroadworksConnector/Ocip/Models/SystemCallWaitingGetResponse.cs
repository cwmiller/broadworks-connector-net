using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallWaitingGetRequest.
        /// <see cref="SystemCallWaitingGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallWaitingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
