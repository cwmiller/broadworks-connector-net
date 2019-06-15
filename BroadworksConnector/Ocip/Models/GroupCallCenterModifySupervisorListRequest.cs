using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaces a list of users as supervisors for a call center.
    /// Also allows the modification of the reporting server URL address.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Element "reportingServerURL"" will always be ignored.
    /// Replaced By: GroupCallCenterSupervisorReportingModifyRequest
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterSupervisorReportingModifyRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterModifySupervisorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _reportingServerURL;

        [XmlElement(ElementName = "reportingServerURL", IsNullable = true, Namespace = "")]
        public string ReportingServerURL {
            get => _reportingServerURL;
            set {
                ReportingServerURLSpecified = true;
                _reportingServerURL = value;
            }
        }

        [XmlIgnore]
        public bool ReportingServerURLSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _supervisorUserIdList;

        [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList {
            get => _supervisorUserIdList;
            set {
                SupervisorUserIdListSpecified = true;
                _supervisorUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorUserIdListSpecified { get; set; }
        
    }
}
