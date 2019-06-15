using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackGetDetailListRequest. It contains the service pack details
    /// and the list of services in a table format. The column headings are "Service", "Authorized"
    /// "Allocated" and "Available".
        /// <see cref="ServiceProviderServicePackGetDetailListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderServicePackGetDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        public string ServicePackName {
            get => _servicePackName;
            set {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackNameSpecified { get; set; }
        
        private string _servicePackDescription;

        [XmlElement(ElementName = "servicePackDescription", IsNullable = false, Namespace = "")]
        public string ServicePackDescription {
            get => _servicePackDescription;
            set {
                ServicePackDescriptionSpecified = true;
                _servicePackDescription = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackDescriptionSpecified { get; set; }
        
        private bool _isAvailableForUse;

        [XmlElement(ElementName = "isAvailableForUse", IsNullable = false, Namespace = "")]
        public bool IsAvailableForUse {
            get => _isAvailableForUse;
            set {
                IsAvailableForUseSpecified = true;
                _isAvailableForUse = value;
            }
        }

        [XmlIgnore]
        public bool IsAvailableForUseSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _servicePackQuantity;

        [XmlElement(ElementName = "servicePackQuantity", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt ServicePackQuantity {
            get => _servicePackQuantity;
            set {
                ServicePackQuantitySpecified = true;
                _servicePackQuantity = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackQuantitySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _assignedQuantity;

        [XmlElement(ElementName = "assignedQuantity", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt AssignedQuantity {
            get => _assignedQuantity;
            set {
                AssignedQuantitySpecified = true;
                _assignedQuantity = value;
            }
        }

        [XmlIgnore]
        public bool AssignedQuantitySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _allowedQuantity;

        [XmlElement(ElementName = "allowedQuantity", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AllowedQuantity {
            get => _allowedQuantity;
            set {
                AllowedQuantitySpecified = true;
                _allowedQuantity = value;
            }
        }

        [XmlIgnore]
        public bool AllowedQuantitySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userServiceTable;

        [XmlElement(ElementName = "userServiceTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServiceTable {
            get => _userServiceTable;
            set {
                UserServiceTableSpecified = true;
                _userServiceTable = value;
            }
        }

        [XmlIgnore]
        public bool UserServiceTableSpecified { get; set; }
        
    }
}
