using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Treatment entry
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseVoiceVPNTreatmentEntry 
    {

        
        private string _id;

        [XmlElement(ElementName = "id", IsNullable = false, Namespace = "")]
        public string Id {
            get => _id;
            set {
                IdSpecified = true;
                _id = value;
            }
        }

        [XmlIgnore]
        public bool IdSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
    }
}
