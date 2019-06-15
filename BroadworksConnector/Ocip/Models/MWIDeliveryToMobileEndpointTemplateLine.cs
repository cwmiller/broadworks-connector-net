using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint template section associated with a specific tag.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MWIDeliveryToMobileEndpointTemplateLine 
    {

        
        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        public string Prefix {
            get => _prefix;
            set {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        public bool PrefixSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateTag _tag;

        [XmlElement(ElementName = "tag", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateTag Tag {
            get => _tag;
            set {
                TagSpecified = true;
                _tag = value;
            }
        }

        [XmlIgnore]
        public bool TagSpecified { get; set; }
        
        private string _postfix;

        [XmlElement(ElementName = "postfix", IsNullable = false, Namespace = "")]
        public string Postfix {
            get => _postfix;
            set {
                PostfixSpecified = true;
                _postfix = value;
            }
        }

        [XmlIgnore]
        public bool PostfixSpecified { get; set; }
        
    }
}
