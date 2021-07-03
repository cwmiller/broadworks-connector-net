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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16516""}]")]
    public class SystemSIPAddContentTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _contentType;

        [XmlElement(ElementName = "contentType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16516")]
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

        private BroadWorksConnector.Ocip.Models.SystemSIPSupportedInterface _interface;

        [XmlElement(ElementName = "interface", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16516")]
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
