using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupUserCallForwardingSettingsGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name",
    /// "Hiragana Last Name", and "Hiragana First Name", "Phone Number",
    /// "Extension", "Department", "In Trunk Group", "Email Address",
    /// "Is Active", "Forwarding Address".
    /// "Is Active" is "true" or "false".
    /// The "Forwarding Address" is the Call Forwarding service's forwarding address.
    /// If the service is Call Forwarding Selective, the default forwarding address is returned.
    /// "Phone Number" is presented in the E164 format.
    /// <see cref="GroupUserCallForwardingSettingsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:8382""}]")]
    public class GroupUserCallForwardingSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userCallForwardingTable;

        [XmlElement(ElementName = "userCallForwardingTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:8382")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserCallForwardingTable
        {
            get => _userCallForwardingTable;
            set
            {
                UserCallForwardingTableSpecified = true;
                _userCallForwardingTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserCallForwardingTableSpecified { get; set; }

    }
}
