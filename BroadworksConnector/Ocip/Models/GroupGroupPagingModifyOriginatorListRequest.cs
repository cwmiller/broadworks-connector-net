using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the originator list for a paging group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:443""}]")]
    public class GroupGroupPagingModifyOriginatorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:443")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _originatorUserIdList;

        [XmlElement(ElementName = "originatorUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:443")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList OriginatorUserIdList
        {
            get => _originatorUserIdList;
            set
            {
                OriginatorUserIdListSpecified = true;
                _originatorUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatorUserIdListSpecified { get; set; }

    }
}
