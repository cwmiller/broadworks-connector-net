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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6466"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6469""}]}]")]
    public class ServiceProviderServicePackMigrationTaskModifyGroupListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6466")]
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

        private string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6466")]
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

        private bool _migrateAllGroups;

        [XmlElement(ElementName = "migrateAllGroups", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6469")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList _groupIdList;

        [XmlElement(ElementName = "groupIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6469")]
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
