using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of prefixes that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:885""}]")]
    public class EnterpriseTrunkReplacementNumberPrefixList
    {

        protected List<string> _numberPrefix = new List<string>();

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:885")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> NumberPrefix
        {
            get => _numberPrefix;
            set
            {
                NumberPrefixSpecified = true;
                _numberPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPrefixSpecified { get; set; }

    }
}
