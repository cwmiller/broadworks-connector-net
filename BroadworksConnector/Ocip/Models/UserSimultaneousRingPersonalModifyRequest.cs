using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's simultaneous ring personal service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: UserSimultaneousRingPersonalModifyRequest14sp4
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserSimultaneousRingPersonalModifyRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47469""}]")]
    public class UserSimultaneousRingPersonalModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47469")]
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
        protected bool UserIdSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47469")]
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
        protected bool IsActiveSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SimultaneousRingSelection _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47469")]
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
        protected bool IncomingCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _simRingPhoneNumberList;

        [XmlElement(ElementName = "simRingPhoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47469")]
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
        protected bool SimRingPhoneNumberListSpecified { get; set; }

    }
}
