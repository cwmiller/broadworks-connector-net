using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemHPBXMobileTerminationGetRequest.
    /// Contains the hPBX mobile termination related configuration parameters.
    /// <see cref="SystemHPBXMobileTerminationGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11375""}]")]
    public class SystemHPBXMobileTerminationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _routingPrefix;

        [XmlElement(ElementName = "routingPrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11375")]
        [MinLength(1)]
        [MaxLength(80)]
        public string RoutingPrefix
        {
            get => _routingPrefix;
            set
            {
                RoutingPrefixSpecified = true;
                _routingPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool RoutingPrefixSpecified { get; set; }

    }
}
