using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSimultaneousRingFamilyGetRequest.
    /// Replaced By: UserSimultaneousRingFamilyGetResponse14sp4
    /// <see cref="UserSimultaneousRingFamilyGetRequest"/>
    /// <see cref="UserSimultaneousRingFamilyGetResponse14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47222""}]")]
    public class UserSimultaneousRingFamilyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47222")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:47222")]
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

        protected List<string> _simRingPhoneNumber = new List<string>();

        [XmlElement(ElementName = "simRingPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:47222")]
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
        protected bool SimRingPhoneNumberSpecified { get; set; }

    }
}
