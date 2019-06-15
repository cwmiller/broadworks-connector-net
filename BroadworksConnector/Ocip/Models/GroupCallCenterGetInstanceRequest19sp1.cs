using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a Call Center instance.
    /// The response is either GroupCallCenterGetInstanceResponse19sp1 or ErrorResponse.
    /// Replaced by GroupCallCenterGetInstanceRequest22.
        /// <see cref="GroupCallCenterGetInstanceResponse19sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterGetInstanceRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetInstanceRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
