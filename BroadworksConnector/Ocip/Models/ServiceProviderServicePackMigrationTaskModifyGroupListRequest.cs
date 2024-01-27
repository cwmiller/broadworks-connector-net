using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replace the list of groups to be migrated for a specified service pack migration task.
    /// Modification is only allowed prior to task execution.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6534"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6537""}]}]")]
    public class ServiceProviderServicePackMigrationTaskModifyGroupListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6534")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:6534")]
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

        protected bool _migrateAllGroups;

        [XmlElement(ElementName = "migrateAllGroups", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6537")]
        public bool MigrateAllGroups
        {
            get => _migrateAllGroups;
            set
            {
                MigrateAllGroupsSpecified = true;
                _migrateAllGroups = value;
            }
        }

        [XmlIgnore]
        protected bool MigrateAllGroupsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList _groupIdList;

        [XmlElement(ElementName = "groupIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6537")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList GroupIdList
        {
            get => _groupIdList;
            set
            {
                GroupIdListSpecified = true;
                _groupIdList = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdListSpecified { get; set; }

    }
}
