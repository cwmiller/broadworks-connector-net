using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the hPBX mobile termination related configuration parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11391""}]")]
    public class SystemHPBXMobileTerminationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _routingPrefix;

        [XmlElement(ElementName = "routingPrefix", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11391")]
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
