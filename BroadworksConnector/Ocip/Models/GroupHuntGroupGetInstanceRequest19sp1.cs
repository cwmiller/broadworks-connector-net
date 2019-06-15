using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Hunt Group instance.
    /// The response is either GroupHuntGroupGetInstanceResponse19sp1 or ErrorResponse.
    /// 
    /// Replaced by: GroupHuntGroupGetInstanceRequest20
        /// <see cref="GroupHuntGroupGetInstanceResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupHuntGroupGetInstanceRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupHuntGroupGetInstanceRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
