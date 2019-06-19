using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group can either use it's service provider/enterprise's preferred carrier or use it's own.
    /// You can use the Service Provider preferred carrier without clearing the group
    /// carrier name -- in this case, the group carrier name is retained.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:608""}]")]
    public class GroupPreferredCarrierNameModify
    {

        private bool _useServiceProviderPreferredCarrier;

        [XmlElement(ElementName = "useServiceProviderPreferredCarrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:608")]
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
        public bool UseServiceProviderPreferredCarrierSpecified { get; set; }

        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:608")]
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
        public bool CarrierSpecified { get; set; }

    }
}
