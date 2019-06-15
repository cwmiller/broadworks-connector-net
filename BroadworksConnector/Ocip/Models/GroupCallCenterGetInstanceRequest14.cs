using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Call Center instance.
    /// The response is either GroupCallCenterGetInstanceResponse14 or ErrorResponse.
    /// Replaced By: GroupCallCenterGetInstanceRequest14sp3
        /// <see cref="GroupCallCenterGetInstanceResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterGetInstanceRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetInstanceRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
