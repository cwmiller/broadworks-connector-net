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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:19117""}]")]
    public class AlternateNumberEntry17
    {

        protected string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19117")]
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

        protected string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19117")]
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

        protected BroadWorksConnector.Ocip.Models.RingPattern? _ringPattern;

        [XmlElement(ElementName = "ringPattern", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:19117")]
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
