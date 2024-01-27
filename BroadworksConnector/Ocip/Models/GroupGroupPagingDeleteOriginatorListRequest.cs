using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete originator(s) from a paging group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8ede928f2a9c1318573ba9c7a105655c:139""}]")]
    public class GroupGroupPagingDeleteOriginatorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:139")]
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

        protected List<string> _originatorUserId = new List<string>();

        [XmlElement(ElementName = "originatorUserId", IsNullable = false, Namespace = "")]
        [Group(@"8ede928f2a9c1318573ba9c7a105655c:139")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> OriginatorUserId
        {
            get => _originatorUserId;
            set
            {
                OriginatorUserIdSpecified = true;
                _originatorUserId = value;
            }
        }

        [XmlIgnore]
        protected bool OriginatorUserIdSpecified { get; set; }

    }
}
