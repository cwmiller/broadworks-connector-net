using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a ServiceProviderPreferredCarrierGetRequest.
    /// Contains the currently configured carriers for a specified country code for a service provider / enterprise.
    /// <see cref="ServiceProviderPreferredCarrierGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:274""}]")]
    public class ServiceProviderPreferredCarrierGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:274")]
        [MinLength(1)]
        [MaxLength(80)]
        public string IntraLataCarrier
        {
            get => _intraLataCarrier;
            set
            {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool IntraLataCarrierSpecified { get; set; }

        protected string _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:274")]
        [MinLength(1)]
        [MaxLength(80)]
        public string InterLataCarrier
        {
            get => _interLataCarrier;
            set
            {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool InterLataCarrierSpecified { get; set; }

        protected string _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:274")]
        [MinLength(1)]
        [MaxLength(80)]
        public string InternationalCarrier
        {
            get => _internationalCarrier;
            set
            {
                InternationalCarrierSpecified = true;
                _internationalCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool InternationalCarrierSpecified { get; set; }

    }
}
