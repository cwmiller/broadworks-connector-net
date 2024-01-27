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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1442""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeListUsageGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _mobileNetworkName = new List<string>();

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1442")]
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
