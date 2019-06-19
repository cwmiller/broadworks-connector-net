using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Name dialing last and first names.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2906""}]")]
    public class NameDialingName
    {

        private string _nameDialingLastName;

        [XmlElement(ElementName = "nameDialingLastName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2906")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NameDialingLastName
        {
            get => _nameDialingLastName;
            set
            {
                NameDialingLastNameSpecified = true;
                _nameDialingLastName = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingLastNameSpecified { get; set; }

        private string _nameDialingFirstName;

        [XmlElement(ElementName = "nameDialingFirstName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2906")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NameDialingFirstName
        {
            get => _nameDialingFirstName;
            set
            {
                NameDialingFirstNameSpecified = true;
                _nameDialingFirstName = value;
            }
        }

        [XmlIgnore]
        public bool NameDialingFirstNameSpecified { get; set; }

    }
}
