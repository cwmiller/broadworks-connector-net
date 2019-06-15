using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's DNIS Announcements
    /// The response is either a GroupCallCenterGetDNISAnnouncementResponse or an ErrorResponse.
    /// 
    /// Replaced by GroupCallCenterGetDNISAnnouncementRequest17sp4
        /// <see cref="GroupCallCenterGetDNISAnnouncementResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterGetDNISAnnouncementRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetDNISAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
