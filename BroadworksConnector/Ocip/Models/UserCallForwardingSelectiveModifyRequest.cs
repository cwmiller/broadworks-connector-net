using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's call forwarding selective service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a80d284dc33fadcf5b323133519ad1a8:205""}]")]
    public class UserCallForwardingSelectiveModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:205")]
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
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:205")]
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

        protected string _defaultForwardToPhoneNumber;

        [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:205")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DefaultForwardToPhoneNumber
        {
            get => _defaultForwardToPhoneNumber;
            set
            {
                DefaultForwardToPhoneNumberSpecified = true;
                _defaultForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultForwardToPhoneNumberSpecified { get; set; }

        protected bool _playRingReminder;

        [XmlElement(ElementName = "playRingReminder", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:205")]
        public bool PlayRingReminder
        {
            get => _playRingReminder;
            set
            {
                PlayRingReminderSpecified = true;
                _playRingReminder = value;
            }
        }

        [XmlIgnore]
        protected bool PlayRingReminderSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation = new List<BroadWorksConnector.Ocip.Models.CriteriaActivation>();

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a80d284dc33fadcf5b323133519ad1a8:205")]
        public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation
        {
            get => _criteriaActivation;
            set
            {
                CriteriaActivationSpecified = true;
                _criteriaActivation = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaActivationSpecified { get; set; }

    }
}
