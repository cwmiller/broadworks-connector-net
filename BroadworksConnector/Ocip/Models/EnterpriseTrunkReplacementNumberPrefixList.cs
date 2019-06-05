using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseTrunkReplacementNumberPrefixList
    {
        private List<string> _numberPrefix;

        [XmlElement(ElementName = "numberPrefix", IsNullable = false, Namespace = "")]
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
        public bool NumberPrefixSpecified { get; set; }
    }
}
