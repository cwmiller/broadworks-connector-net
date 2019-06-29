using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5295""}]")]
    public class ServiceProviderServicePackGetDetailListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _servicePackName;

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
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
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
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

        private BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt _assignedQuantity;

        [XmlElement(ElementName = "assignedQuantity", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
        public BroadWorksConnector.Ocip.Models.UnboundedNonNegativeInt AssignedQuantity
        {
            get => _assignedQuantity;
            set
            {
                AssignedQuantitySpecified = true;
                _assignedQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedQuantitySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _allowedQuantity;

        [XmlElement(ElementName = "allowedQuantity", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AllowedQuantity
        {
            get => _allowedQuantity;
            set
            {
                AllowedQuantitySpecified = true;
                _allowedQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool AllowedQuantitySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _userServiceTable;

        [XmlElement(ElementName = "userServiceTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5295")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServiceTable
        {
            get => _userServiceTable;
            set
            {
                UserServiceTableSpecified = true;
                _userServiceTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceTableSpecified { get; set; }

    }
}
