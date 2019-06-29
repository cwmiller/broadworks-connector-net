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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9a6dbade05624033cf7fe782b7c9a9a7:353""}]")]
    public class UserExecutiveModifyAssistantRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:353")]
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

        private bool _allowOptInOut;

        [XmlElement(ElementName = "allowOptInOut", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:353")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _assistantUserIdList;

        [XmlElement(ElementName = "assistantUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:353")]
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
