using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSimultaneousRingPersonalGetRequest.
    /// Replaced By: UserSimultaneousRingPersonalGetResponse14sp4
    /// <see cref="UserSimultaneousRingPersonalGetRequest"/>
    /// <see cref="UserSimultaneousRingPersonalGetResponse14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7770""}]")]
    public class UserSimultaneousRingPersonalGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7770")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SimultaneousRingSelection _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7770")]
        public BroadWorksConnector.Ocip.Models.SimultaneousRingSelection IncomingCalls
        {
            get => _incomingCalls;
            set
            {
                IncomingCallsSpecified = true;
                _incomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallsSpecified { get; set; }

        private List<string> _simRingPhoneNumber = new List<string>();

        [XmlElement(ElementName = "simRingPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7770")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> SimRingPhoneNumber
        {
            get => _simRingPhoneNumber;
            set
            {
                SimRingPhoneNumberSpecified = true;
                _simRingPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool SimRingPhoneNumberSpecified { get; set; }

    }
}
