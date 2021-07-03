using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupInstantGroupCallGetInstanceRequest14.
    /// Contains the service profile information and a list of phone numbers.
    /// <see cref="GroupInstantGroupCallGetInstanceRequest14"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:10748""}]")]
    public class GroupInstantGroupCallGetInstanceResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10748")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        private List<string> _destinationPhoneNumber = new List<string>();

        [XmlElement(ElementName = "destinationPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10748")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> DestinationPhoneNumber
        {
            get => _destinationPhoneNumber;
            set
            {
                DestinationPhoneNumberSpecified = true;
                _destinationPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DestinationPhoneNumberSpecified { get; set; }

        private bool _isAnswerTimeoutEnabled;

        [XmlElement(ElementName = "isAnswerTimeoutEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10748")]
        public bool IsAnswerTimeoutEnabled
        {
            get => _isAnswerTimeoutEnabled;
            set
            {
                IsAnswerTimeoutEnabledSpecified = true;
                _isAnswerTimeoutEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool IsAnswerTimeoutEnabledSpecified { get; set; }

        private int _answerTimeoutMinutes;

        [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:10748")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int AnswerTimeoutMinutes
        {
            get => _answerTimeoutMinutes;
            set
            {
                AnswerTimeoutMinutesSpecified = true;
                _answerTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool AnswerTimeoutMinutesSpecified { get; set; }

    }
}
