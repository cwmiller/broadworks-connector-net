using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupUserHotelingGuestSettingsGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name",
    /// "Hiragana Last Name", and "Hiragana First Name", "Phone Number",
    /// "Extension", "Department", "In Trunk Group", "Email Address", "Is Active".
    /// "Is Active" is "true" or "false".
    /// "Phone Number" is presented in the E164 format.
    /// <see cref="GroupUserHotelingGuestSettingsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7544""}]")]
    public class GroupUserHotelingGuestSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userHotelingGuestTable;

        [XmlElement(ElementName = "userHotelingGuestTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7544")]
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
