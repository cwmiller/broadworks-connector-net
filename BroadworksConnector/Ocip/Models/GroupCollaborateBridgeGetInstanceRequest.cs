using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a collaborate bridge.
    /// The response is either GroupCollaborateBridgeGetInstanceResponse or ErrorResponse.
    /// 
    /// Replaced by: GroupCollaborateBridgeGetInstanceRequest20sp1
        /// <see cref="GroupCollaborateBridgeGetInstanceResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCollaborateBridgeGetInstanceRequest20sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCollaborateBridgeGetInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
