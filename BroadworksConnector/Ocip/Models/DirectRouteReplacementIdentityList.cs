using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class DirectRouteReplacementIdentityList
    {
        private string _dtgIdentity;

        [XmlElement(ElementName = "dtgIdentity", IsNullable = false, Namespace = "")]
        public string DtgIdentity
        {
            get => _dtgIdentity;
            set
            {
                DtgIdentitySpecified = true;
                _dtgIdentity = value;
            }
        }

        [XmlIgnore]
        public bool DtgIdentitySpecified { get; set; }
        private string _trunkIdentity;

        [XmlElement(ElementName = "trunkIdentity", IsNullable = false, Namespace = "")]
        public string TrunkIdentity
        {
            get => _trunkIdentity;
            set
            {
                TrunkIdentitySpecified = true;
                _trunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool TrunkIdentitySpecified { get; set; }
    }
}
