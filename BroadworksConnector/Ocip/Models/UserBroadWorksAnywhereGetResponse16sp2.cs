using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetRequest16sp2.
    /// The phoneNumberTable contains columns: "Phone Number", "Description"
    /// <see cref="UserBroadWorksAnywhereGetRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:490""}]")]
    public class UserBroadWorksAnywhereGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _alertAllLocationsForClickToDialCalls;

        [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:490")]
        public bool AlertAllLocationsForClickToDialCalls
        {
            get => _alertAllLocationsForClickToDialCalls;
            set
            {
                AlertAllLocationsForClickToDialCallsSpecified = true;
                _alertAllLocationsForClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertAllLocationsForClickToDialCallsSpecified { get; set; }

        private bool _alertAllLocationsForGroupPagingCalls;

        [XmlElement(ElementName = "alertAllLocationsForGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:490")]
        public bool AlertAllLocationsForGroupPagingCalls
        {
            get => _alertAllLocationsForGroupPagingCalls;
            set
            {
                AlertAllLocationsForGroupPagingCallsSpecified = true;
                _alertAllLocationsForGroupPagingCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertAllLocationsForGroupPagingCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

        [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:490")]
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
