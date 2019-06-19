using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallPickupGetRequest.
    /// Identifies which Call Pickup group the user belongs to and the list of users in the group.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Department", "Phone Number", "Extension", "Email Address".
    /// <see cref="UserCallPickupGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""045ce951b3e25dec090606af4ad50c63:394""}]")]
    public class UserCallPickupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:394")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"045ce951b3e25dec090606af4ad50c63:394")]
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
