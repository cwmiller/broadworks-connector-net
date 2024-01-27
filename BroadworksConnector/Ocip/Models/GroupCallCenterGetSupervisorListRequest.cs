using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6377""}]")]
    public class GroupCallCenterGetSupervisorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetSupervisorListResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6377")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}
