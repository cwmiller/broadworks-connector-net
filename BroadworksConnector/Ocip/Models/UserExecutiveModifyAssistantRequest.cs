using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the assistant setting and the list of assistants assigned to an executive user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3a54ac906cb7002cc1a30fbb0efadb0a:357""}]")]
    public class UserExecutiveModifyAssistantRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:357")]
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

        protected bool _allowOptInOut;

        [XmlElement(ElementName = "allowOptInOut", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:357")]
        public bool AllowOptInOut
        {
            get => _allowOptInOut;
            set
            {
                AllowOptInOutSpecified = true;
                _allowOptInOut = value;
            }
        }

        [XmlIgnore]
        protected bool AllowOptInOutSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _assistantUserIdList;

        [XmlElement(ElementName = "assistantUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3a54ac906cb7002cc1a30fbb0efadb0a:357")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AssistantUserIdList
        {
            get => _assistantUserIdList;
            set
            {
                AssistantUserIdListSpecified = true;
                _assistantUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool AssistantUserIdListSpecified { get; set; }

    }
}
