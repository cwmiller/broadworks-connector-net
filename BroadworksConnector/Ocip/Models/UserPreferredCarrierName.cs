using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User can either use it's group's preferred carrier or use it's own.
    /// The user carrier name is exposed if it was previously configured.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:621""}]")]
    public class UserPreferredCarrierName
    {

        protected bool _useGroupPreferredCarrier;

        [XmlElement(ElementName = "useGroupPreferredCarrier", IsNullable = false, Namespace = "")]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:621")]
        public bool UseGroupPreferredCarrier
        {
            get => _useGroupPreferredCarrier;
            set
            {
                UseGroupPreferredCarrierSpecified = true;
                _useGroupPreferredCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool UseGroupPreferredCarrierSpecified { get; set; }

        protected string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:621")]
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
