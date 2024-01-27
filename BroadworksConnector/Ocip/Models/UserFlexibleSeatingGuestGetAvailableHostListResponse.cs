using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserFlexibleSeatingGuestGetAvailableHostListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "Association Limit Hours", "Enable Association Limit",
    /// <see cref="UserFlexibleSeatingGuestGetAvailableHostListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1d4e390f8cd01ca6f92589024d74dac6:388""}]")]
    public class UserFlexibleSeatingGuestGetAvailableHostListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _hostUserTable;

        [XmlElement(ElementName = "hostUserTable", IsNullable = false, Namespace = "")]
        [Group(@"1d4e390f8cd01ca6f92589024d74dac6:388")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HostUserTable
        {
            get => _hostUserTable;
            set
            {
                HostUserTableSpecified = true;
                _hostUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool HostUserTableSpecified { get; set; }

    }
}
