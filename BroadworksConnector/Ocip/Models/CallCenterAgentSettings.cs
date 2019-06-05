using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterAgentSettings
    {
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        private bool _available;

        [XmlElement(ElementName = "available", IsNullable = false, Namespace = "")]
        public bool Available
        {
            get => _available;
            set
            {
                AvailableSpecified = true;
                _available = value;
            }
        }

        [XmlIgnore]
        public bool AvailableSpecified { get; set; }
        private int _skillLevel;

        [XmlElement(ElementName = "skillLevel", IsNullable = false, Namespace = "")]
        public int SkillLevel
        {
            get => _skillLevel;
            set
            {
                SkillLevelSpecified = true;
                _skillLevel = value;
            }
        }

        [XmlIgnore]
        public bool SkillLevelSpecified { get; set; }
    }
}
