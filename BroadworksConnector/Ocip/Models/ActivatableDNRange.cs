using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Activatable directory number range. The minimum and maximum values are inclusive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:562""}]")]
    public class ActivatableDNRange
    {

        protected string _minPhoneNumber;

        [XmlElement(ElementName = "minPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:562")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MinPhoneNumber
        {
            get => _minPhoneNumber;
            set
            {
                MinPhoneNumberSpecified = true;
                _minPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MinPhoneNumberSpecified { get; set; }

        protected string _maxPhoneNumber;

        [XmlElement(ElementName = "maxPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:562")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MaxPhoneNumber
        {
            get => _maxPhoneNumber;
            set
            {
                MaxPhoneNumberSpecified = true;
                _maxPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MaxPhoneNumberSpecified { get; set; }

        protected bool _activate;

        [XmlElement(ElementName = "activate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:562")]
        public bool Activate
        {
            get => _activate;
            set
            {
                ActivateSpecified = true;
                _activate = value;
            }
        }

        [XmlIgnore]
        protected bool ActivateSpecified { get; set; }

    }
}
