using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's call notify service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""26f62134ab1693f4bdddc7c70b20d2eb:301""}]")]
    public class UserCallNotifyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:301")]
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

        private string _callNotifyEmailAddress;

        [XmlElement(ElementName = "callNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:301")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CallNotifyEmailAddress
        {
            get => _callNotifyEmailAddress;
            set
            {
                CallNotifyEmailAddressSpecified = true;
                _callNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool CallNotifyEmailAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation = new List<BroadWorksConnector.Ocip.Models.CriteriaActivation>();

        [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:301")]
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
        public bool CriteriaActivationSpecified { get; set; }

    }
}
