using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of SIP aliases that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4004""}]")]
    public class ReplacementSIPAliasList
    {

        private List<string> _sipAlias = new List<string>();

        [XmlElement(ElementName = "sipAlias", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4004")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> SipAlias
        {
            get => _sipAlias;
            set
            {
                SipAliasSpecified = true;
                _sipAlias = value;
            }
        }

        [XmlIgnore]
        protected bool SipAliasSpecified { get; set; }

    }
}
