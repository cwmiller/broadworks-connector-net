using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a route point's announcement settings.
    /// The response is either a GroupRoutePointGetAnnouncementResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupRoutePointGetAnnouncementRequest19.
        /// <see cref="GroupRoutePointGetAnnouncementResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupRoutePointGetAnnouncementRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRoutePointGetAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
