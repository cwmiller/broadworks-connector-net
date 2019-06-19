using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCentersLoginGetListRequest.
    /// Indicates whether the agent is current available (logged in) to each call center in the list.
    /// Contains a table with column headings: "Service User Id", "Phone Number", "Extension", "Available",
    /// "Logoff Allowed".
    /// ***** NOTE: Prior to release 14sp1, the AppServer had a bug that caused it to emit column heading
    /// "Service User ID" with
    /// ***** the ID capitalized. Beginning in release 14sp1, the appserver is compliant with the schema and
    /// emits a
    /// ***** the column heading "Service User Id".
    /// Replaced By: UserCallCenterGetResponse
    /// <see cref="UserCallCentersLoginGetListRequest"/>
    /// <see cref="UserCallCenterGetResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6869""}]")]
    public class UserCallCenterGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:6869")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        public bool UserTableSpecified { get; set; }

    }
}
