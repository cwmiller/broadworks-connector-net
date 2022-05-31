using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupUserCallWaitingSettingsGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana
    /// Last Name", and "Hiragana First Name", "Phone Number",
    /// "Extension", "Department", "In Trunk Group", "Email Address", "Is Active".
    /// "Is Active" is "true" or "false".
    /// "Phone Number" is presented in the E164 format.
    /// <see cref="GroupUserCallWaitingSettingsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8778""}]")]
    public class GroupUserCallWaitingSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userCallWaitingTable;

        [XmlElement(ElementName = "userCallWaitingTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8778")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserCallWaitingTable
        {
            get => _userCallWaitingTable;
            set
            {
                UserCallWaitingTableSpecified = true;
                _userCallWaitingTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserCallWaitingTableSpecified { get; set; }

    }
}
