using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterGetAgentSupervisorListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "IMP Id",
    /// "Location Code".
    /// <see cref="UserCallCenterGetAgentSupervisorListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6912""}]")]
    public class UserCallCenterGetAgentSupervisorListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

        [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6912")]
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
        public bool SupervisorTableSpecified { get; set; }

    }
}
