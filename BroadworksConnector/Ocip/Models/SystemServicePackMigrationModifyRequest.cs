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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16189""}]")]
    public class SystemServicePackMigrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _maxSimultaneousMigrationTasks;

        [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16189")]
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
