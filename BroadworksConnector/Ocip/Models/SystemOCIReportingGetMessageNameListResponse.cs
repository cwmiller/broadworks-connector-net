using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIReportingGetMessageNameListRequest.
    /// <see cref="SystemOCIReportingGetMessageNameListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13943""}]")]
    public class SystemOCIReportingGetMessageNameListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _messageNameStartsWith = new List<string>();

        [XmlElement(ElementName = "messageNameStartsWith", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13943")]
        [MinLength(1)]
        [MaxLength(256)]
        public List<string> MessageNameStartsWith
        {
            get => _messageNameStartsWith;
            set
            {
                MessageNameStartsWithSpecified = true;
                _messageNameStartsWith = value;
            }
        }

        [XmlIgnore]
        protected bool MessageNameStartsWithSpecified { get; set; }

    }
}
