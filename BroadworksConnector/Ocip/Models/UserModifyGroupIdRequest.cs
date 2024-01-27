using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Move the user from one group to another group within the same enterprise.
    /// If evaluateOnly is specified, no actual move will happen. The command only tests the move and reports the impacts or possible conditions preventing the move.
    /// The response is either UserModifyGroupIdResponse or ErrorResponse.
    /// <see cref="UserModifyGroupIdResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2499""}]")]
    public class UserModifyGroupIdRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserModifyGroupIdResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2499")]
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

        protected string _newGroupId;

        [XmlElement(ElementName = "newGroupId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2499")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewGroupId
        {
            get => _newGroupId;
            set
            {
                NewGroupIdSpecified = true;
                _newGroupId = value;
            }
        }

        [XmlIgnore]
        protected bool NewGroupIdSpecified { get; set; }

        protected bool _evaluateOnly;

        [XmlElement(ElementName = "evaluateOnly", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2499")]
        public bool EvaluateOnly
        {
            get => _evaluateOnly;
            set
            {
                EvaluateOnlySpecified = true;
                _evaluateOnly = value;
            }
        }

        [XmlIgnore]
        protected bool EvaluateOnlySpecified { get; set; }

    }
}
