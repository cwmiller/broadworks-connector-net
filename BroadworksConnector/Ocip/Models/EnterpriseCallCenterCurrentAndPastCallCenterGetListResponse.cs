using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest.
    /// <see cref="EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:1155""}]")]
    public class EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _serviceUserId = new List<string>();

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1155")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> ServiceUserId
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

        protected List<string> _deletedServiceUserId = new List<string>();

        [XmlElement(ElementName = "deletedServiceUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1155")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> DeletedServiceUserId
        {
            get => _deletedServiceUserId;
            set
            {
                DeletedServiceUserIdSpecified = true;
                _deletedServiceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool DeletedServiceUserIdSpecified { get; set; }

    }
}
