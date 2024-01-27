using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Directory number range. The minimum and maximum values are inclusive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2942""}]")]
    public class DNRange
    {

        protected string _minPhoneNumber;

        [XmlElement(ElementName = "minPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2942")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2942")]
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

    }
}
