using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSystemServiceDnGetAvailableListRequest.
    /// Contains a list of available DNs not yet assigned to any instance of system service.
        /// <see cref="SystemSystemServiceDnGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSystemServiceDnGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<string> _availableDn;

        [XmlElement(ElementName = "availableDn", IsNullable = false, Namespace = "")]
        public List<string> AvailableDn {
            get => _availableDn;
            set {
                AvailableDnSpecified = true;
                _availableDn = value;
            }
        }

        [XmlIgnore]
        public bool AvailableDnSpecified { get; set; }
        
    }
}
