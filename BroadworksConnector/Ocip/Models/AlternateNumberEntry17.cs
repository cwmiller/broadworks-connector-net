using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Alternate Number Entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:14532""}]")]
    public class AlternateNumberEntry17
    {

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14532")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14532")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Extension
        {
            get => _extension;
            set
            {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RingPattern? _ringPattern;

        [XmlElement(ElementName = "ringPattern", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:14532")]
        public BroadWorksConnector.Ocip.Models.RingPattern? RingPattern
        {
            get => _ringPattern;
            set
            {
                RingPatternSpecified = true;
                _ringPattern = value;
            }
        }

        [XmlIgnore]
        protected bool RingPatternSpecified { get; set; }

    }
}
