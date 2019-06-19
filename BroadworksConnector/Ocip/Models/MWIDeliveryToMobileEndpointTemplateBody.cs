using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint template body.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""958b78cc2a785d78259c1e8a474eb40d:420""}]")]
    public class MWIDeliveryToMobileEndpointTemplateBody
    {

        private List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> _line = new List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine>();

        [XmlElement(ElementName = "line", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:420")]
        public List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> Line
        {
            get => _line;
            set
            {
                LineSpecified = true;
                _line = value;
            }
        }

        [XmlIgnore]
        public bool LineSpecified { get; set; }

    }
}
