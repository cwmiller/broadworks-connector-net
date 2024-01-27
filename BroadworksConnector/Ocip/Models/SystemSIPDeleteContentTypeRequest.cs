using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a content type for the SIP interface.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16985""}]")]
    public class SystemSIPDeleteContentTypeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _contentType;

        [XmlElement(ElementName = "contentType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16985")]
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

    }
}
