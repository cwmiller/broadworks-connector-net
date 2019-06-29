using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterSupervisorReportingGetRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name".
    /// <see cref="GroupCallCenterSupervisorReportingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:8612""}]")]
    public class GroupCallCenterSupervisorReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _reportingServerName;

        [XmlElement(ElementName = "reportingServerName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8612")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportingServerName
        {
            get => _reportingServerName;
            set
            {
                ReportingServerNameSpecified = true;
                _reportingServerName = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingServerNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

        [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8612")]
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
