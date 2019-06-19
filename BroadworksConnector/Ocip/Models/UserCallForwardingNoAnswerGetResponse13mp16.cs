using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallForwardingNoAnswerGetRequest13mp16.
    /// <see cref="UserCallForwardingNoAnswerGetRequest13mp16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9bba36247a6338c8a1cff754a22a6c6b:59""}]")]
    public class UserCallForwardingNoAnswerGetResponse13mp16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"9bba36247a6338c8a1cff754a22a6c6b:59")]
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

        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9bba36247a6338c8a1cff754a22a6c6b:59")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToPhoneNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallForwardingNoAnswerNumberOfRings _numberOfRings;

        [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"9bba36247a6338c8a1cff754a22a6c6b:59")]
        public BroadWorksConnector.Ocip.Models.CallForwardingNoAnswerNumberOfRings NumberOfRings
        {
            get => _numberOfRings;
            set
            {
                NumberOfRingsSpecified = true;
                _numberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfRingsSpecified { get; set; }

    }
}
