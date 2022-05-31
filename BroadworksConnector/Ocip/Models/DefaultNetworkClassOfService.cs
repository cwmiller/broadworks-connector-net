using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The default Network Class of Service to set during assignation/unassignation.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2032""}]")]
    public class DefaultNetworkClassOfService
    {

        protected bool _useExisting;

        [XmlElement(ElementName = "useExisting", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2032")]
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
        protected bool UseExistingSpecified { get; set; }

        protected string _networkClassOfServiceName;

        [XmlElement(ElementName = "networkClassOfServiceName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2032")]
        [MinLength(1)]
        [MaxLength(40)]
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
        protected bool NetworkClassOfServiceNameSpecified { get; set; }

    }
}
