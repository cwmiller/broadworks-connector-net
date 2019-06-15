using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of SIP aliases that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementSIPAliasList 
    {

        
        private List<string> _sipAlias;

        [XmlElement(ElementName = "sipAlias", IsNullable = false, Namespace = "")]
        public List<string> SipAlias {
            get => _sipAlias;
            set {
                SipAliasSpecified = true;
                _sipAlias = value;
            }
        }

        [XmlIgnore]
        public bool SipAliasSpecified { get; set; }
        
    }
}
