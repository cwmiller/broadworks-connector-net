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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1160""}]")]
    public class EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _serviceUserId = new List<string>();

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1160")]
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

        private List<string> _deletedServiceUserId = new List<string>();

        [XmlElement(ElementName = "deletedServiceUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1160")]
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
