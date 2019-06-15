using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's DNIS Announcements
    /// The response is either a GroupCallCenterGetDNISAnnouncementResponse19 or an ErrorResponse.
        /// <see cref="GroupCallCenterGetDNISAnnouncementResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetDNISAnnouncementRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey {
            get => _dnisKey;
            set {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        public bool DnisKeySpecified { get; set; }
        
    }
}
