using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseEnterpriseTrunkGetUserListRequest.
    /// The column headings for the enterpriseTrunkUserTable are: "Group Id", "User Id", "Last Name", "First Name", "Phone Number", "Alternate Trunk Identity", "Hiragana Last Name", "Hiragana First Name",
    /// "Extension", "Department", "Email Address" and "Route List Assigned".
    /// <see cref="EnterpriseEnterpriseTrunkGetUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:413""}]")]
    public class EnterpriseEnterpriseTrunkGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _enterpriseTrunkUserTable;

        [XmlElement(ElementName = "enterpriseTrunkUserTable", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:413")]
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
