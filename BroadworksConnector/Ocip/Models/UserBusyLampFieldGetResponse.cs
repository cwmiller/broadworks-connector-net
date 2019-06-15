using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: UserBusyLampFieldGetResponse16sp2
    /// 
    /// Response to UserBusyLampFieldGetRequest.
    /// The table has column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// <see cref="UserBusyLampFieldGetResponse16sp2"/>
        /// <see cref="UserBusyLampFieldGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserBusyLampFieldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _listURI;

        [XmlElement(ElementName = "listURI", IsNullable = false, Namespace = "")]
        public string ListURI {
            get => _listURI;
            set {
                ListURISpecified = true;
                _listURI = value;
            }
        }

        [XmlIgnore]
        public bool ListURISpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable {
            get => _monitoredUserTable;
            set {
                MonitoredUserTableSpecified = true;
                _monitoredUserTable = value;
            }
        }

        [XmlIgnore]
        public bool MonitoredUserTableSpecified { get; set; }
        
    }
}
