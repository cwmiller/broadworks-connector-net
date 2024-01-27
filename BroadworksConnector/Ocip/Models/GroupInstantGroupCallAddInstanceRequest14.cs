using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add an Instant Group Call service instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6c8b59f80404b6283b25be24c263cb12:46""}]")]
    public class GroupInstantGroupCallAddInstanceRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
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
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
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
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
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
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
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

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6c8b59f80404b6283b25be24c263cb12:46")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
