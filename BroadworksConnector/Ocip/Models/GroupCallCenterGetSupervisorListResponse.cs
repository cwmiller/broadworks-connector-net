using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetSupervisorListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name".
    /// Element "reportingServerURL"" will always be blank.
    /// Replaced By: GroupCallCenterSupervisorReportingGetResponse
    /// <see cref="GroupCallCenterGetSupervisorListRequest"/>
    /// <see cref="GroupCallCenterSupervisorReportingGetResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6396""}]")]
    public class GroupCallCenterGetSupervisorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _reportingServerURL;

        [XmlElement(ElementName = "reportingServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6396")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

        [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6396")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SupervisorTable
        {
            get => _supervisorTable;
            set
            {
                SupervisorTableSpecified = true;
                _supervisorTable = value;
            }
        }

        [XmlIgnore]
        protected bool SupervisorTableSpecified { get; set; }

    }
}
