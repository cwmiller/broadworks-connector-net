using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCountryCodeGetListRequest. Contains the default country code
    /// and a table with one row per country code.  The table columns are
    /// "Country Code", "Country Name", "Off Hook Warning Seconds",
    /// "Ring Period Milliseconds", "National Prefix", "Use Prefix",
    /// "Maximum Call Waiting Tones", "Time Between Call Waiting Tones Milliseconds"
    /// and "Disable National Prefix for OffNet Calls".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Disable National Prefix for OffNet Calls"
    /// <see cref="SystemCountryCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6922""}]")]
    public class SystemCountryCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultCountryCode;

        [XmlElement(ElementName = "defaultCountryCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6922")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string DefaultCountryCode
        {
            get => _defaultCountryCode;
            set
            {
                DefaultCountryCodeSpecified = true;
                _defaultCountryCode = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultCountryCodeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _countryCodeTable;

        [XmlElement(ElementName = "countryCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6922")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CountryCodeTable
        {
            get => _countryCodeTable;
            set
            {
                CountryCodeTableSpecified = true;
                _countryCodeTable = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeTableSpecified { get; set; }

    }
}
