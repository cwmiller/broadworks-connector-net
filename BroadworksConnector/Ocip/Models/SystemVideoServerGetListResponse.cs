using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVideoServerGetListRequest. The Video Server table column
    /// headings are: "Net Address", "Port", "Transport", "Description".
    /// Transport types: udp, tcp, unspecified
        /// <see cref="SystemVideoServerGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVideoServerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _videoServerTable;

        [XmlElement(ElementName = "videoServerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable VideoServerTable {
            get => _videoServerTable;
            set {
                VideoServerTableSpecified = true;
                _videoServerTable = value;
            }
        }

        [XmlIgnore]
        public bool VideoServerTableSpecified { get; set; }
        
    }
}
