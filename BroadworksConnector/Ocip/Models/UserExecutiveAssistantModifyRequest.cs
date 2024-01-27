using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the setting for executive assistant.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d531efc7ebfdf83cc344962728505dd5:80""}]")]
    public class UserExecutiveAssistantModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d531efc7ebfdf83cc344962728505dd5:80")]
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

        protected bool _enableDivert;

        [XmlElement(ElementName = "enableDivert", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d531efc7ebfdf83cc344962728505dd5:80")]
        public bool EnableDivert
        {
            get => _enableDivert;
            set
            {
                EnableDivertSpecified = true;
                _enableDivert = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDivertSpecified { get; set; }

        protected string _divertToPhoneNumber;

        [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d531efc7ebfdf83cc344962728505dd5:80")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DivertToPhoneNumber
        {
            get => _divertToPhoneNumber;
            set
            {
                DivertToPhoneNumberSpecified = true;
                _divertToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DivertToPhoneNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.ExecutiveAssistantOptInStatus> _optInStatus = new List<BroadWorksConnector.Ocip.Models.ExecutiveAssistantOptInStatus>();

        [XmlElement(ElementName = "optInStatus", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d531efc7ebfdf83cc344962728505dd5:80")]
        public List<BroadWorksConnector.Ocip.Models.ExecutiveAssistantOptInStatus> OptInStatus
        {
            get => _optInStatus;
            set
            {
                OptInStatusSpecified = true;
                _optInStatus = value;
            }
        }

        [XmlIgnore]
        protected bool OptInStatusSpecified { get; set; }

    }
}
