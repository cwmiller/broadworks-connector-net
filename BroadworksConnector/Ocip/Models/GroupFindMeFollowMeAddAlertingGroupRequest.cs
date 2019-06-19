using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an alerting group to a Find-me/Follow-me instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:57"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:64"",""optional"":true}]}]")]
    public class GroupFindMeFollowMeAddAlertingGroupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:57")]
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
        public bool ServiceUserIdSpecified { get; set; }

        private string _alertingGroupName;

        [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:57")]
        [MinLength(1)]
        [MaxLength(40)]
        public string AlertingGroupName
        {
            get => _alertingGroupName;
            set
            {
                AlertingGroupNameSpecified = true;
                _alertingGroupName = value;
            }
        }

        [XmlIgnore]
        public bool AlertingGroupNameSpecified { get; set; }

        private string _alertingGroupDescription;

        [XmlElement(ElementName = "alertingGroupDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:57")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlertingGroupDescription
        {
            get => _alertingGroupDescription;
            set
            {
                AlertingGroupDescriptionSpecified = true;
                _alertingGroupDescription = value;
            }
        }

        [XmlIgnore]
        public bool AlertingGroupDescriptionSpecified { get; set; }

        private bool _useDiversionInhibitor;

        [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:57")]
        public bool UseDiversionInhibitor
        {
            get => _useDiversionInhibitor;
            set
            {
                UseDiversionInhibitorSpecified = true;
                _useDiversionInhibitor = value;
            }
        }

        [XmlIgnore]
        public bool UseDiversionInhibitorSpecified { get; set; }

        private bool _answerConfirmationRequired;

        [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:57")]
        public bool AnswerConfirmationRequired
        {
            get => _answerConfirmationRequired;
            set
            {
                AnswerConfirmationRequiredSpecified = true;
                _answerConfirmationRequired = value;
            }
        }

        [XmlIgnore]
        public bool AnswerConfirmationRequiredSpecified { get; set; }

        private int _numberOfRings;

        [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:57")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int NumberOfRings
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

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:64")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:64")]
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

    }
}
