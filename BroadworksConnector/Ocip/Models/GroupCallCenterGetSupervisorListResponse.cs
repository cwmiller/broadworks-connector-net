using System;
using System.Xml.Serialization;
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
     
    public class GroupCallCenterGetSupervisorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _reportingServerURL;

        [XmlElement(ElementName = "reportingServerURL", IsNullable = false, Namespace = "")]
        public string ReportingServerURL {
            get => _reportingServerURL;
            set {
                ReportingServerURLSpecified = true;
                _reportingServerURL = value;
            }
        }

        [XmlIgnore]
        public bool ReportingServerURLSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

        [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SupervisorTable {
            get => _supervisorTable;
            set {
                SupervisorTableSpecified = true;
                _supervisorTable = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorTableSpecified { get; set; }
        
    }
}
