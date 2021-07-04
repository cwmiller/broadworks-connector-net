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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:58"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""79f226053ee345f2ff4c37c37c8e9114:65"",""optional"":true}]}]")]
    public class GroupFindMeFollowMeAddAlertingGroupRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:58")]
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

        private string _alertingGroupName;

        [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:58")]
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
        protected bool AlertingGroupNameSpecified { get; set; }

        private string _alertingGroupDescription;

        [XmlElement(ElementName = "alertingGroupDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:58")]
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
        protected bool AlertingGroupDescriptionSpecified { get; set; }

        private bool _useDiversionInhibitor;

        [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:58")]
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
        protected bool UseDiversionInhibitorSpecified { get; set; }

        private bool _answerConfirmationRequired;

        [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:58")]
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
        protected bool AnswerConfirmationRequiredSpecified { get; set; }

        private int _numberOfRings;

        [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:58")]
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
        protected bool NumberOfRingsSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:65")]
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
        protected bool PhoneNumberSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"79f226053ee345f2ff4c37c37c8e9114:65")]
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

    }
}
