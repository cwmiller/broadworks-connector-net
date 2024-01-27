using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group can either use it's service provider/enterprise's preferred carrier or use it's own.
    /// The group carrier name is exposed if it was previously configured.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:594""}]")]
    public class GroupPreferredCarrierName
    {

        protected bool _useServiceProviderPreferredCarrier;

        [XmlElement(ElementName = "useServiceProviderPreferredCarrier", IsNullable = false, Namespace = "")]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:594")]
        public bool UseServiceProviderPreferredCarrier
        {
            get => _useServiceProviderPreferredCarrier;
            set
            {
                UseServiceProviderPreferredCarrierSpecified = true;
                _useServiceProviderPreferredCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool UseServiceProviderPreferredCarrierSpecified { get; set; }

        protected string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:594")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Carrier
        {
            get => _carrier;
            set
            {
                CarrierSpecified = true;
                _carrier = value;
            }
        }

        [XmlIgnore]
        protected bool CarrierSpecified { get; set; }

    }
}
