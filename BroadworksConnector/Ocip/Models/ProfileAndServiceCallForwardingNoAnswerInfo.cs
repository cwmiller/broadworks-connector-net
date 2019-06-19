using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Call Forwarding No Answer service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4092""}]")]
    public class ProfileAndServiceCallForwardingNoAnswerInfo
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4092")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4092")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4092")]
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
