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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f39163d0e42e05c4a1692a62f625df9f:501""}]")]
    public class UserBroadWorksAnywhereGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _alertAllLocationsForClickToDialCalls;

        [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:501")]
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
        protected bool AlertAllLocationsForClickToDialCallsSpecified { get; set; }

        protected bool _alertAllLocationsForGroupPagingCalls;

        [XmlElement(ElementName = "alertAllLocationsForGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:501")]
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
        protected bool AlertAllLocationsForGroupPagingCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

        [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:501")]
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
        protected bool PhoneNumberTableSpecified { get; set; }

    }
}
