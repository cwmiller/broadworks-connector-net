using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CommunicationBarringProfileReplacementList
    {
        private List<string> _profileName;

        [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
        public List<string> ProfileName
        {
            get => _profileName;
            set
            {
                ProfileNameSpecified = true;
                _profileName = value;
            }
        }

        [XmlIgnore]
        public bool ProfileNameSpecified { get; set; }
    }
}
