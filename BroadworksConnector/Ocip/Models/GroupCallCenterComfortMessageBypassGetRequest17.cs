using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's comfort message bypass settings.
    /// The response is either a GroupCallCenterComfortMessageBypassGetResponse17 or an ErrorResponse.
    /// 
    /// Replaced by: GroupCallCenterComfortMessageBypassGetRequest20
        /// <see cref="GroupCallCenterComfortMessageBypassGetResponse17"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterComfortMessageBypassGetRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterComfortMessageBypassGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
