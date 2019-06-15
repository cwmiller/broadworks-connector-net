using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's announcement settings.
    /// The response is either a GroupCallCenterGetAnnouncementResponse14sp6 or an ErrorResponse.
    /// 
    /// Replaced By: GroupCallCenterGetAnnouncementRequest16
        /// <see cref="GroupCallCenterGetAnnouncementResponse14sp6"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterGetAnnouncementRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetAnnouncementRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
    }
}
