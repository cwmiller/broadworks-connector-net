using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseVoiceVPNGetPolicyListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _locationList;

        [XmlElement(ElementName = "locationList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable LocationList
        {
            get => _locationList;
            set
            {
                LocationListSpecified = true;
                _locationList = value;
            }
        }

        [XmlIgnore]
        public bool LocationListSpecified { get; set; }
    }
}
