using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Verification Translation and Routing parameters
    /// for creating a Verify Translation and Routing request from
    /// parameters.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4592""}]")]
    public class VerifyTranslationAndRoutingParameters
    {

        private BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination _origination;

        [XmlElement(ElementName = "origination", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4592")]
        public BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingOrigination Origination
        {
            get => _origination;
            set
            {
                OriginationSpecified = true;
                _origination = value;
            }
        }

        [XmlIgnore]
        protected bool OriginationSpecified { get; set; }

        private string _destination;

        [XmlElement(ElementName = "destination", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4592")]
        [MinLength(1)]
        [MaxLength(500)]
        public string Destination
        {
            get => _destination;
            set
            {
                DestinationSpecified = true;
                _destination = value;
            }
        }

        [XmlIgnore]
        protected bool DestinationSpecified { get; set; }

        private string _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4592")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        protected bool ContactSpecified { get; set; }

        private string _diversion;

        [XmlElement(ElementName = "diversion", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4592")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Diversion
        {
            get => _diversion;
            set
            {
                DiversionSpecified = true;
                _diversion = value;
            }
        }

        [XmlIgnore]
        protected bool DiversionSpecified { get; set; }

    }
}
