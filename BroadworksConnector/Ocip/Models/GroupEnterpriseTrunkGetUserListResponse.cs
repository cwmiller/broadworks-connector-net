using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEnterpriseTrunkGetUserListRequest.
    /// The column headings for the enterpriseTrunkUserTable are: "User Id", "Last Name", "First Name", "Phone Number", "Alternate Trunk Identity", "Hiragana Last Name", "Hiragana First Name",
    /// "Extension", "Department", "Email Address" and "Route List Assigned".
    /// <see cref="GroupEnterpriseTrunkGetUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:790""}]")]
    public class GroupEnterpriseTrunkGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkUserTable;

        [XmlElement(ElementName = "enterpriseTrunkUserTable", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:790")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EnterpriseTrunkUserTable
        {
            get => _enterpriseTrunkUserTable;
            set
            {
                EnterpriseTrunkUserTableSpecified = true;
                _enterpriseTrunkUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseTrunkUserTableSpecified { get; set; }

    }
}
