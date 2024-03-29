using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add target(s) to a paging group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:106""}]")]
    public class GroupGroupPagingAddTargetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:106")]
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

        protected List<string> _targetUserId = new List<string>();

        [XmlElement(ElementName = "targetUserId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:106")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> TargetUserId
        {
            get => _targetUserId;
            set
            {
                TargetUserIdSpecified = true;
                _targetUserId = value;
            }
        }

        [XmlIgnore]
        protected bool TargetUserIdSpecified { get; set; }

    }
}
