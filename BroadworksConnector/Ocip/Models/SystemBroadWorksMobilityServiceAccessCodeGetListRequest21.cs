using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of system service access codes.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeGetListResponse21 or ErrorResponse.
        /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListResponse21"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksMobilityServiceAccessCodeGetListRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceAccessCodeListName;

        [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
        public string ServiceAccessCodeListName {
            get => _serviceAccessCodeListName;
            set {
                ServiceAccessCodeListNameSpecified = true;
                _serviceAccessCodeListName = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAccessCodeListNameSpecified { get; set; }
        
    }
}
