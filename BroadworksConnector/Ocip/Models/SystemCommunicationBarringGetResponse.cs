using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCommunicationBarringGetRequest.
    /// 
    /// Replaced by: SystemCommunicationBarringGetResponse21sp1 in AS data mode.
        /// <see cref="SystemCommunicationBarringGetRequest"/>
        /// <see cref="SystemCommunicationBarringGetResponse21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _directTransferScreening;

        [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
        public bool DirectTransferScreening {
            get => _directTransferScreening;
            set {
                DirectTransferScreeningSpecified = true;
                _directTransferScreening = value;
            }
        }

        [XmlIgnore]
        public bool DirectTransferScreeningSpecified { get; set; }
        
    }
}
