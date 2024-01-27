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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:10945""}]")]
    public class GroupInstantGroupCallGetInstanceResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10945")]
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
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected List<string> _destinationPhoneNumber = new List<string>();

        [XmlElement(ElementName = "destinationPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10945")]
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

        protected bool _isAnswerTimeoutEnabled;

        [XmlElement(ElementName = "isAnswerTimeoutEnabled", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10945")]
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

        protected int _answerTimeoutMinutes;

        [XmlElement(ElementName = "answerTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10945")]
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
