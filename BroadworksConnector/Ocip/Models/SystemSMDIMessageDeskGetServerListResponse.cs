using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaServerGetListRequest. The SMDI Server table column
    /// headings are: "Device Name", "Net Address", "Port" and "Description".
        /// <see cref="SystemMediaServerGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMDIMessageDeskGetServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _smdiServerTable;

        [XmlElement(ElementName = "smdiServerTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SmdiServerTable {
            get => _smdiServerTable;
            set {
                SmdiServerTableSpecified = true;
                _smdiServerTable = value;
            }
        }

        [XmlIgnore]
        public bool SmdiServerTableSpecified { get; set; }
        
    }
}
