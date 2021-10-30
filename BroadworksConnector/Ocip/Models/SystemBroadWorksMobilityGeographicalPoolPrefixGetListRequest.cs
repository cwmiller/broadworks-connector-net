using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a list of geographical prefixes belonging to a geographical pool.
    /// The response is either SystemBroadWorksMobilityGeographicalPoolPrefixGetListResponse or ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityGeographicalPoolPrefixGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:934""}]")]
    public class SystemBroadWorksMobilityGeographicalPoolPrefixGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobilityGeographicalPoolPrefixGetListResponse>
    {

        private string _geographicalPoolName;

        [XmlElement(ElementName = "geographicalPoolName", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:934")]
        [MinLength(1)]
        [MaxLength(80)]
        public string GeographicalPoolName
        {
            get => _geographicalPoolName;
            set
            {
                GeographicalPoolNameSpecified = true;
                _geographicalPoolName = value;
            }
        }

        [XmlIgnore]
        protected bool GeographicalPoolNameSpecified { get; set; }

    }
}
