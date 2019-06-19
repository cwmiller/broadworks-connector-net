using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderServicePhoneNumberLookupRequest.
    /// The column headings for the userTable are: "Group Id", "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension" and "Department".
    /// <see cref="ServiceProviderServicePhoneNumberLookupRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5791""}]")]
    public class ServiceProviderServicePhoneNumberLookupResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5791")]
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
