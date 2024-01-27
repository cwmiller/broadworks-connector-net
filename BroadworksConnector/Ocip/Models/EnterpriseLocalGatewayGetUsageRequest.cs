using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get usage details of a local gateway under an enterprise.
    /// The response is either EnterpriseLocalGatewayGetUsageResponse or an ErrorResponse.
    /// <see cref="EnterpriseLocalGatewayGetUsageResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:523""}]")]
    public class EnterpriseLocalGatewayGetUsageRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseLocalGatewayGetUsageResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:523")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _trunkGroupName;

        [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:523")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TrunkGroupName
        {
            get => _trunkGroupName;
            set
            {
                TrunkGroupNameSpecified = true;
                _trunkGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupNameSpecified { get; set; }

    }
}
