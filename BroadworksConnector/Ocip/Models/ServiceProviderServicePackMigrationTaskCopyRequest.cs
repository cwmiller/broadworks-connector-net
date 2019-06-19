using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Makes a copy of one or more existing service pack migration tasks. A copied task
    /// can be edited with other commands and scheduled for future execution. The
    /// name of the new task is chosen automatically. The name will
    /// be "Copy (number) of taskName".
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5445""}]")]
    public class ServiceProviderServicePackMigrationTaskCopyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5445")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private List<string> _taskName = new List<string>();

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5445")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> TaskName
        {
            get => _taskName;
            set
            {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        public bool TaskNameSpecified { get; set; }

    }
}
