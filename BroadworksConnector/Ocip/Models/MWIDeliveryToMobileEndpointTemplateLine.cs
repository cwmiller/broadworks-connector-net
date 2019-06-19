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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""958b78cc2a785d78259c1e8a474eb40d:431""}]")]
    public class MWIDeliveryToMobileEndpointTemplateLine
    {

        private string _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:431")]
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
        public bool PrefixSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateTag _tag;

        [XmlElement(ElementName = "tag", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:431")]
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
        public bool TagSpecified { get; set; }

        private string _postfix;

        [XmlElement(ElementName = "postfix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:431")]
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
        public bool PostfixSpecified { get; set; }

    }
}
