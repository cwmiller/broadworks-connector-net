using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's simultaneous ring family service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: UserSimultaneousRingFamilyModifyRequest14sp4
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserSimultaneousRingFamilyModifyRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7733""}]")]
    public class UserSimultaneousRingFamilyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7733")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7733")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7733")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _simRingPhoneNumberList;

        [XmlElement(ElementName = "simRingPhoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7733")]
        public BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList SimRingPhoneNumberList
        {
            get => _simRingPhoneNumberList;
            set
            {
                SimRingPhoneNumberListSpecified = true;
                _simRingPhoneNumberList = value;
            }
        }

        [XmlIgnore]
        public bool SimRingPhoneNumberListSpecified { get; set; }

    }
}
