using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterCurrentAndPastDNISGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private List<string> _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public List<string> Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        private List<string> _deletedName;

        [XmlElement(ElementName = "deletedName", IsNullable = false, Namespace = "")]
        public List<string> DeletedName
        {
            get => _deletedName;
            set
            {
                DeletedNameSpecified = true;
                _deletedName = value;
            }
        }

        [XmlIgnore]
        public bool DeletedNameSpecified { get; set; }
    }
}
