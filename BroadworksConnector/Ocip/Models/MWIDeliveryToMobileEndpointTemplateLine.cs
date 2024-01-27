using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint template section associated with a specific tag.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:431""}]")]
    public class MWIDeliveryToMobileEndpointTemplateLine
    {

        protected string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:431")]
        [MinLength(1)]
        [MaxLength(128)]
        public string Prefix
        {
            get => _prefix;
            set
            {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateTag _tag;

        [XmlElement(ElementName = "tag", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:431")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateTag Tag
        {
            get => _tag;
            set
            {
                TagSpecified = true;
                _tag = value;
            }
        }

        [XmlIgnore]
        protected bool TagSpecified { get; set; }

        protected string _postfix;

        [XmlElement(ElementName = "postfix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:431")]
        [MinLength(1)]
        [MaxLength(128)]
        public string Postfix
        {
            get => _postfix;
            set
            {
                PostfixSpecified = true;
                _postfix = value;
            }
        }

        [XmlIgnore]
        protected bool PostfixSpecified { get; set; }

    }
}
