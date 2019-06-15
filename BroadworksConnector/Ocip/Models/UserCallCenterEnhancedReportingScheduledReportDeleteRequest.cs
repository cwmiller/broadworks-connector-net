using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a call center reporting scheduled report created by a supervisor.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterEnhancedReportingScheduledReportDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _supervisorUserId;

        [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
        public string SupervisorUserId {
            get => _supervisorUserId;
            set {
                SupervisorUserIdSpecified = true;
                _supervisorUserId = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorUserIdSpecified { get; set; }
        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
    }
}
