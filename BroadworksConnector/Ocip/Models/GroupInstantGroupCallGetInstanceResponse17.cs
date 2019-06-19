using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupInstantGroupCallGetInstanceRequest17.
    /// Contains the service profile information and a list of phone numbers.
    /// 
    /// Replaced by: GroupInstantGroupCallGetInstanceResponse19sp1
    /// <see cref="GroupInstantGroupCallGetInstanceRequest17"/>
    /// <see cref="GroupInstantGroupCallGetInstanceResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:30209""}]")]
    public class GroupInstantGroupCallGetInstanceResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:30209")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }

        private List<string> _destinationPhoneNumber = new List<string>();

        [XmlElement(ElementName = "destinationPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:30209")]
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
        public bool DestinationPhoneNumberSpecified { get; set; }

        private bool _isAnswerTimeoutEnabled;

        [XmlElement(ElementName = "isAnswerTimeoutEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:30209")]
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
        public bool IsAnswerTimeoutEnabledSpecified { get; set; }

        private int _answerTimeoutMinutes;

        [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:30209")]
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
        public bool AnswerTimeoutMinutesSpecified { get; set; }

    }
}
