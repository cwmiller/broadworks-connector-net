using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksMobilityGeographicalPoolIMRNGetListRequest.
    /// <see cref="SystemBroadWorksMobilityGeographicalPoolIMRNGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:864""}]")]
    public class SystemBroadWorksMobilityGeographicalPoolIMRNGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:864")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeSpecified { get; set; }

        private List<string> _imrnNumber = new List<string>();

        [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:864")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> ImrnNumber
        {
            get => _imrnNumber;
            set
            {
                ImrnNumberSpecified = true;
                _imrnNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ImrnNumberSpecified { get; set; }

    }
}
