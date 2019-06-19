using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring Alternate Call Indicator that replaces
    /// a previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3206""}]")]
    public class ReplacementCommunicationBarringAlternateCallIndicatorList
    {

        private List<string> _alternateCallIndicator = new List<string>();

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3206")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> AlternateCallIndicator
        {
            get => _alternateCallIndicator;
            set
            {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCallIndicatorSpecified { get; set; }

    }
}
