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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:420""}]")]
    public class MWIDeliveryToMobileEndpointTemplateBody
    {

        protected List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> _line = new List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine>();

        [XmlElement(ElementName = "line", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:420")]
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
        protected bool LineSpecified { get; set; }

    }
}
