using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSMDIMessageDeskGetServerRouteListRequest.
    /// The SMDI Server route table column headings are: "Destination" and "SMDI Servers".
        /// <see cref="SystemSMDIMessageDeskGetServerRouteListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSMDIMessageDeskGetServerRouteListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _smdiServerRouteTable;

        [XmlElement(ElementName = "smdiServerRouteTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SmdiServerRouteTable {
            get => _smdiServerRouteTable;
            set {
                SmdiServerRouteTableSpecified = true;
                _smdiServerRouteTable = value;
            }
        }

        [XmlIgnore]
        public bool SmdiServerRouteTableSpecified { get; set; }
        
    }
}
