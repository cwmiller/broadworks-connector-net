using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSMDIMessageDeskGetServerListRequest.
    /// The SMDI Server table column headings are: "Device Name", "Net Address", "Port".
        /// <see cref="UserSMDIMessageDeskGetServerListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSMDIMessageDeskGetServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
