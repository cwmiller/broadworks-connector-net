using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseUserHotelingGuestSettingsGetListRequest.
    /// Contains a table with column headings: "Group Id", "User Id", "Last Name", "First
    /// Name", "Hiragana Last Name", and "Hiragana First Name", "Phone
    /// Number", "Extension", "Department", "In Trunk Group", "Email Address",
    /// "Is Active".
    /// "Is Active" is "true" or "false".
    /// "Phone Number" is presented in the E164 format.
    /// <see cref="EnterpriseUserHotelingGuestSettingsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:990""}]")]
    public class EnterpriseUserHotelingGuestSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userHotelingGuestTable;

        [XmlElement(ElementName = "userHotelingGuestTable", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:990")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserHotelingGuestTable
        {
            get => _userHotelingGuestTable;
            set
            {
                UserHotelingGuestTableSpecified = true;
                _userHotelingGuestTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserHotelingGuestTableSpecified { get; set; }

    }
}
