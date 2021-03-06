using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a list of geographical prefixes from a pool.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:917""}]")]
    public class SystemBroadWorksMobilityGeographicalPoolPrefixDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _geographicalPoolName;

        [XmlElement(ElementName = "geographicalPoolName", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:917")]
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

        private List<string> _prefix = new List<string>();

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:917")]
        [MinLength(2)]
        [MaxLength(5)]
        public List<string> Prefix
        {
            get => _prefix;
            set
            {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixSpecified { get; set; }

    }
}
