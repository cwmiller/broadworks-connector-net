using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system level settings for Service Pack Migration.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16405""}]")]
    public class SystemServicePackMigrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _maxSimultaneousMigrationTasks;

        [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16405")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaxSimultaneousMigrationTasks
        {
            get => _maxSimultaneousMigrationTasks;
            set
            {
                MaxSimultaneousMigrationTasksSpecified = true;
                _maxSimultaneousMigrationTasks = value;
            }
        }

        [XmlIgnore]
        protected bool MaxSimultaneousMigrationTasksSpecified { get; set; }

    }
}
