using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest.
    /// Returns a 12 column table with column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Group Id", "Phone Number", "Extension", "Mobile", "Email Address", "Department", "IMP Id", "Title",
    /// "Receptionist Note".  The Receptionist Note column is only populated, if the user sending
    /// the request is the owner of the Receptionist Note and a Note exists.
    /// <see cref="UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""44477d346d2631b033071e12af214ac8:163""}]")]
    public class UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"44477d346d2631b033071e12af214ac8:163")]
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
