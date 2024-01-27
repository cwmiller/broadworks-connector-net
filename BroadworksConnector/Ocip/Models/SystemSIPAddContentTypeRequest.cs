using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a content type for the SIP interface.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16736""}]")]
    public class SystemSIPAddContentTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _contentType;

        [XmlElement(ElementName = "contentType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16736")]
        [MinLength(2)]
        [MaxLength(80)]
        public string ContentType
        {
            get => _contentType;
            set
            {
                ContentTypeSpecified = true;
                _contentType = value;
            }
        }

        [XmlIgnore]
        protected bool ContentTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemSIPSupportedInterface _interface;

        [XmlElement(ElementName = "interface", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16736")]
        public BroadWorksConnector.Ocip.Models.SystemSIPSupportedInterface Interface
        {
            get => _interface;
            set
            {
                InterfaceSpecified = true;
                _interface = value;
            }
        }

        [XmlIgnore]
        protected bool InterfaceSpecified { get; set; }

    }
}
