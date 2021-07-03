using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6815""}]")]
    public class GroupCallCenterModifySupervisorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6815")]
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

        private string _reportingServerURL;

        [XmlElement(ElementName = "reportingServerURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6815")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ReportingServerURL
        {
            get => _reportingServerURL;
            set
            {
                ReportingServerURLSpecified = true;
                _reportingServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingServerURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _supervisorUserIdList;

        [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6815")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList
        {
            get => _supervisorUserIdList;
            set
            {
                SupervisorUserIdListSpecified = true;
                _supervisorUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool SupervisorUserIdListSpecified { get; set; }

    }
}
