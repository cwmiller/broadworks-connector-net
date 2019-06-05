using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class DefaultNetworkClassOfService
    {
        private bool _useExisting;

        [XmlElement(ElementName = "useExisting", IsNullable = false, Namespace = "")]
        public bool UseExisting
        {
            get => _useExisting;
            set
            {
                UseExistingSpecified = true;
                _useExisting = value;
            }
        }

        [XmlIgnore]
        public bool UseExistingSpecified { get; set; }
        private string _networkClassOfServiceName;

        [XmlElement(ElementName = "networkClassOfServiceName", IsNullable = false, Namespace = "")]
        public string NetworkClassOfServiceName
        {
            get => _networkClassOfServiceName;
            set
            {
                NetworkClassOfServiceNameSpecified = true;
                _networkClassOfServiceName = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceNameSpecified { get; set; }
    }
}
