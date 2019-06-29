using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetRequest.
    /// The phoneNumberTable contains columns: "Phone Number", "Description"
    /// Replaced by: UserBroadWorksAnywhereGetResponse16sp2
    /// <see cref="UserBroadWorksAnywhereGetRequest"/>
    /// <see cref="UserBroadWorksAnywhereGetResponse16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16878""}]")]
    public class UserBroadWorksAnywhereGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _alertAllLocationsForClickToDialCalls;

        [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16878")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

        [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16878")]
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
