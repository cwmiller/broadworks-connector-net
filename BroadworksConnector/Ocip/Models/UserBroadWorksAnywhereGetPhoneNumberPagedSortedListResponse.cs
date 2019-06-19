using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest.
    /// The phoneNumberTable contains columns: "Phone Number", "Description", "Activated"
    /// <see cref="UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:404""}]")]
    public class UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

        [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:404")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PhoneNumberTable
        {
            get => _phoneNumberTable;
            set
            {
                PhoneNumberTableSpecified = true;
                _phoneNumberTable = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberTableSpecified { get; set; }

    }
}
