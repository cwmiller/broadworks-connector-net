using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemPreferredCarrierGetUserListRequest.
    /// Contains a table with one row per user.
    /// The table columns are: "User Id", "Service Provider Id", "Group Id", "Last Name", "First Name", "Phone Number", "Email Address",
    /// "Hiragana Last Name", and "Hiragana First Name", "Extension", "Department".
    /// <see cref="SystemPreferredCarrierGetUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:496""}]")]
    public class SystemPreferredCarrierGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _usersUsingCarrierTable;

        [XmlElement(ElementName = "usersUsingCarrierTable", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:496")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsersUsingCarrierTable
        {
            get => _usersUsingCarrierTable;
            set
            {
                UsersUsingCarrierTableSpecified = true;
                _usersUsingCarrierTable = value;
            }
        }

        [XmlIgnore]
        public bool UsersUsingCarrierTableSpecified { get; set; }

    }
}
