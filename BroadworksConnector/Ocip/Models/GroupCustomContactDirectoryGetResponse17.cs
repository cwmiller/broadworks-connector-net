using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCustomContactDirectoryGetRequest17.
    /// The response contains all the contacts in the group's given custom
    /// contact directory. Contains a table with column headings: "User Id",
    /// "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Virtual On-Net Phone Number", "Group Id",
    /// "Is Virtual On-Net User", "Department", "Phone Number", "Extension",
    /// "Mobile", "Email Address", "Yahoo Id", "Title", "IMP Id", "Receptionist Note".
    /// If the entry represents a Virtual On-Net user then "User Id" is blank,
    /// the "Virtual On-Net Phone Number" contains the phone Number of the
    /// Virtual On-Net user, the "Group Id" contains the Virtual On-Net user's
    /// group and the "Is Virtual On-Net User" contains true.
    /// If the entry represents a BroadWorks user then the "User Id" contains
    /// his BroadWorks userId, the "Virtual On-Net Phone Number" and
    /// "Group Id" fields are field is blank and the "Is Virtual On-Net User"
    /// contains false.  The Receptionist Note column is only populated in AS
    /// Mode, if the user sending the request is the owner of the Receptionist
    /// Note and a Note exists.
    /// <see cref="GroupCustomContactDirectoryGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3679""}]")]
    public class GroupCustomContactDirectoryGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3679")]
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
        protected bool UserTableSpecified { get; set; }

    }
}
