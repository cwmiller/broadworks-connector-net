using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Meet-Me Conferencing bridge.
    /// The response is either GroupMeetMeConferencingGetInstanceResponse19 or ErrorResponse.
    /// 
    /// Replaced by: GroupMeetMeConferencingGetInstanceRequest19sp1
        /// <see cref="GroupMeetMeConferencingGetInstanceResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupMeetMeConferencingGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupMeetMeConferencingGetInstanceRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
