using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of supervisors assigned to a call center.
    /// Only users in the same group or enterprise as this call center can
    /// successfully execute this request.
    /// The response is either a GroupCallCenterGetSupervisorListResponse
    /// or an ErrorResponse.
    /// Replaced By: GroupCallCenterSupervisorReportingGetRequest
        /// <see cref="GroupCallCenterGetSupervisorListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallCenterSupervisorReportingGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterGetSupervisorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
