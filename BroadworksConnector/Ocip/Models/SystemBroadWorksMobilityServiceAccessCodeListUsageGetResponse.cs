using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityServiceAccessCodeListUsageGetRequest.
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeListUsageGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1198""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeListUsageGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _mobileNetworkName = new List<string>();

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1198")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> MobileNetworkName
        {
            get => _mobileNetworkName;
            set
            {
                MobileNetworkNameSpecified = true;
                _mobileNetworkName = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNetworkNameSpecified { get; set; }

    }
}
