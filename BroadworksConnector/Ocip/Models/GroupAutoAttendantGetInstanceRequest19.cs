using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Auto Attendant instance.
    /// The response is either GroupAutoAttendantGetInstanceResponse19 or ErrorResponse.
    /// 
    /// Replaced by: GroupAutoAttendantGetInstanceRequest19sp1 in AS data mode
        /// <see cref="GroupAutoAttendantGetInstanceResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupAutoAttendantGetInstanceRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAutoAttendantGetInstanceRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
