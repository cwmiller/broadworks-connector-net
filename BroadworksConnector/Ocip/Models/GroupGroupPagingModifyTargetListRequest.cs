using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the target list for a paging group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d36df8c109e3ea7324f79031368c661:461""}]")]
    public class GroupGroupPagingModifyTargetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"0d36df8c109e3ea7324f79031368c661:461")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _targetUserIdList;

        [XmlElement(ElementName = "targetUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0d36df8c109e3ea7324f79031368c661:461")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList TargetUserIdList
        {
            get => _targetUserIdList;
            set
            {
                TargetUserIdListSpecified = true;
                _targetUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool TargetUserIdListSpecified { get; set; }

    }
}
