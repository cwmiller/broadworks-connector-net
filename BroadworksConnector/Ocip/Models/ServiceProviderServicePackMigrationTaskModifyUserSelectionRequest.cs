using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replace the list of services and packs used to select which users will be migrated.
    /// Modification is only allowed prior to task execution.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6611""}]")]
    public class ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6611")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6611")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TaskName
        {
            get => _taskName;
            set
            {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        protected bool TaskNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType _userSelectionType;

        [XmlElement(ElementName = "userSelectionType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6611")]
        public BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType UserSelectionType
        {
            get => _userSelectionType;
            set
            {
                UserSelectionTypeSpecified = true;
                _userSelectionType = value;
            }
        }

        [XmlIgnore]
        protected bool UserSelectionTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserServiceList _userServiceNameList;

        [XmlElement(ElementName = "userServiceNameList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6611")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserServiceList UserServiceNameList
        {
            get => _userServiceNameList;
            set
            {
                UserServiceNameListSpecified = true;
                _userServiceNameList = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceNameListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementServicePackNameList _servicePackNameList;

        [XmlElement(ElementName = "servicePackNameList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6611")]
        public BroadWorksConnector.Ocip.Models.ReplacementServicePackNameList ServicePackNameList
        {
            get => _servicePackNameList;
            set
            {
                ServicePackNameListSpecified = true;
                _servicePackNameList = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameListSpecified { get; set; }

    }
}
