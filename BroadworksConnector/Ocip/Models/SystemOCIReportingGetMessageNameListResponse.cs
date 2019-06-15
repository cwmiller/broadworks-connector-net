using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIReportingGetMessageNameListRequest.
        /// <see cref="SystemOCIReportingGetMessageNameListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemOCIReportingGetMessageNameListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _messageNameStartsWith;

        [XmlElement(ElementName = "messageNameStartsWith", IsNullable = false, Namespace = "")]
        public List<string> MessageNameStartsWith {
            get => _messageNameStartsWith;
            set {
                MessageNameStartsWithSpecified = true;
                _messageNameStartsWith = value;
            }
        }

        [XmlIgnore]
        public bool MessageNameStartsWithSpecified { get; set; }
        
    }
}
