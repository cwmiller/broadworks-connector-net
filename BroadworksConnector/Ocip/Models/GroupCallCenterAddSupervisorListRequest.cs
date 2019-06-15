using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add supervisor(s) to a call center.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterAddSupervisorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _supervisorUserId;

        [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
        public List<string> SupervisorUserId {
            get => _supervisorUserId;
            set {
                SupervisorUserIdSpecified = true;
                _supervisorUserId = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorUserIdSpecified { get; set; }
        
    }
}
