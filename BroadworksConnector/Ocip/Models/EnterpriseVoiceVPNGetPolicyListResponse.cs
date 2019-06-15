using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseVoiceVPNGetListResponse.
    /// Returns a 4 column table with column headings:
    /// "Location Code", "Min Extension Length", "Max Extension Length", "Location Selection".
        /// <see cref="EnterpriseVoiceVPNGetListResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseVoiceVPNGetPolicyListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _locationList;

        [XmlElement(ElementName = "locationList", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LocationList {
            get => _locationList;
            set {
                LocationListSpecified = true;
                _locationList = value;
            }
        }

        [XmlIgnore]
        public bool LocationListSpecified { get; set; }
        
    }
}
