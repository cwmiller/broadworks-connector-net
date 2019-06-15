using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Call Center instance.
    /// The response is either GroupCallCenterGetInstanceResponse17sp1 or ErrorResponse.
    /// 
    /// Replaced by: GroupCallCenterGetInstanceRequest17sp3
        /// <see cref="GroupCallCenterGetInstanceResponse17sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterGetInstanceRequest17sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetInstanceRequest17sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
