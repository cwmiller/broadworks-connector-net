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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4696""}]")]
    public class MWIDeliveryToMobileEndpointTemplateBody
    {

        protected List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine> _line = new List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateLine>();

        [XmlElement(ElementName = "line", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4696")]
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
