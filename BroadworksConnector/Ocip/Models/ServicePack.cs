using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The common Service Pack elements.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4391""}]")]
    public class ServicePack
    {

        private string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4391")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

        private string _servicePackDescription;

        [XmlElement(ElementName = "servicePackDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4391")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ServicePackDescription
        {
            get => _servicePackDescription;
            set
            {
                ServicePackDescriptionSpecified = true;
                _servicePackDescription = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackDescriptionSpecified { get; set; }

        private bool _isAvailableForUse;

        [XmlElement(ElementName = "isAvailableForUse", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4391")]
        public bool IsAvailableForUse
        {
            get => _isAvailableForUse;
            set
            {
                IsAvailableForUseSpecified = true;
                _isAvailableForUse = value;
            }
        }

        [XmlIgnore]
        protected bool IsAvailableForUseSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _servicePackQuantity;

        [XmlElement(ElementName = "servicePackQuantity", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4391")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt ServicePackQuantity
        {
            get => _servicePackQuantity;
            set
            {
                ServicePackQuantitySpecified = true;
                _servicePackQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackQuantitySpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.UserService> _serviceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4391")]
        public List<BroadWorksConnector.Ocip.Models.UserService> ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceNameSpecified { get; set; }

    }
}
